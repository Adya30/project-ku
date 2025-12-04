using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace TaniGrow2.dbconnect
{
    public class connectdata
    {
        string db_host;
        string db_user;
        string db_pass;
        string db_name;
        public string connstring;

        public connectdata()
        {
            db_host = "localhost";
            db_user = "postgres";
            db_pass = "warungijo";
            db_name = "TaniGrow";

            connstring = $"Host={db_host};Username={db_user};Password={db_pass};Database={db_name};";
        }

        public NpgsqlConnection getConn()
        {
            return new NpgsqlConnection(connstring);
        }
    }
}
