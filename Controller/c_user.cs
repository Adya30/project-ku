using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaniGrow2.dbconnect;
using TaniGrow2.Model;

namespace TaniGrow2.Controller
{
    // Inheritance + Polymorphism
    public class AdminUser : User { public bool IsAdminUser => true; }
    public class CustomerUser : User { public bool IsAdminUser => false; }

    public class c_user
    {
        private readonly string connString; // Encapsulation

        public c_user()
        {
            connectdata db = new connectdata();
            connString = db.connstring;
        }

        public static User CurrentUser { get; private set; } // Encapsulation

        public string RegisterCustomer(string nama, string username, string telp, string password, string konfirmasi)
        {
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(telp) || string.IsNullOrWhiteSpace(password))
                return "Semua data harus diisi!";

            if (password != konfirmasi)
                return "Konfirmasi password tidak cocok!";

            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string checkQuery = "SELECT 1 FROM users WHERE username=@u LIMIT 1";
            using (var cmd = new NpgsqlCommand(checkQuery, conn)) { cmd.Parameters.AddWithValue("@u", username); if (cmd.ExecuteScalar() != null) return "Username sudah digunakan!"; }

            string insertQuery = @"INSERT INTO users (nama_lengkap, username, no_telp, password, is_admin)
                                   VALUES (@nama, @user, @telp, @pass, false)";
            using (var cmd = new NpgsqlCommand(insertQuery, conn)) { cmd.Parameters.AddWithValue("@nama", nama); cmd.Parameters.AddWithValue("@user", username); cmd.Parameters.AddWithValue("@telp", telp); cmd.Parameters.AddWithValue("@pass", password); cmd.ExecuteNonQuery(); }

            return "Pendaftaran Berhasil";
        }

        public string Login(string username, string password)
        {
            string query = @"SELECT id_user, username, password, nama_lengkap, no_telp, is_admin
                             FROM users 
                             WHERE username=@u AND password=@p 
                             LIMIT 1";

            using var conn = new NpgsqlConnection(connString);
            using var cmd = new NpgsqlCommand(query, conn); cmd.Parameters.AddWithValue("@u", username); cmd.Parameters.AddWithValue("@p", password);
            conn.Open();

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                User akun = Convert.ToBoolean(reader["is_admin"]) ? (User)new AdminUser() : new CustomerUser();
                akun.IdUser = reader.GetInt32(reader.GetOrdinal("id_user"));
                akun.Username = reader["username"].ToString();
                akun.Password = reader["password"].ToString();
                akun.NamaLengkap = reader["nama_lengkap"]?.ToString();
                akun.NoTelp = reader["no_telp"]?.ToString();

                CurrentUser = akun; // Encapsulation
                return akun is AdminUser ? "LOGIN_ADMIN" : "LOGIN_CUSTOMER";
            }

            return "LOGIN_GAGAL";
        }

        public string UpdateProfile(string nama, string username, string telp, string pass, string konfirmasi)
        {
            if (CurrentUser == null) return "Tidak ada user login!";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(pass)) return "Username dan password harus diisi!";
            if (pass != konfirmasi) return "Konfirmasi password tidak cocok!";

            using var conn = new NpgsqlConnection(connString); conn.Open();

            if (username != CurrentUser.Username)
            {
                string checkQuery = "SELECT 1 FROM users WHERE username=@u AND id_user<>@id LIMIT 1";
                using var cmdCheck = new NpgsqlCommand(checkQuery, conn);
                cmdCheck.Parameters.AddWithValue("@u", username);
                cmdCheck.Parameters.AddWithValue("@id", CurrentUser.IdUser);
                if (cmdCheck.ExecuteScalar() != null) return "Username sudah digunakan!";
            }

            string updateQuery = CurrentUser is AdminUser
                ? "UPDATE users SET username=@user, password=@pass WHERE id_user=@id"
                : "UPDATE users SET nama_lengkap=@nama, username=@user, no_telp=@telp, password=@pass WHERE id_user=@id";

            using var cmdUpdate = new NpgsqlCommand(updateQuery, conn);
            cmdUpdate.Parameters.AddWithValue("@user", username);
            cmdUpdate.Parameters.AddWithValue("@pass", pass);
            cmdUpdate.Parameters.AddWithValue("@id", CurrentUser.IdUser);
            if (CurrentUser is CustomerUser) { cmdUpdate.Parameters.AddWithValue("@nama", nama); cmdUpdate.Parameters.AddWithValue("@telp", telp); }
            cmdUpdate.ExecuteNonQuery();

            // Encapsulation
            CurrentUser.Username = username;
            CurrentUser.Password = pass;
            if (CurrentUser is CustomerUser) { CurrentUser.NamaLengkap = nama; CurrentUser.NoTelp = telp; }

            return "Update Profil Berhasil";
        }

        public void Logout() { CurrentUser = null; } // Encapsulation
    }
}