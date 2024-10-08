using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace POS.DataAccess
{
    public class DataService
    {
        private readonly string ConnectionString = "Data Source=DESKTOP-EBPQHUK;Initial Catalog=BusinessDB;Integrated Security=SSPI;TrustServerCertificate=True;";
        public IEnumerable<T> LoadData<T, U>(string sqlCommand, U parameters)
        {
            using (IDbConnection conn = new SqlConnection(ConnectionString))
            {
                CommandType cmd = CommandType.Text;
                var output = conn.Query<T>(sqlCommand, parameters, commandType: cmd);
                return output;
            }
        }

        public int SaveData<T>(string sqlCommand, T parameters)
        {
            using (IDbConnection conn = new SqlConnection(ConnectionString))
            {
                CommandType cmd = CommandType.Text;
                var rows = conn.Execute(sqlCommand, parameters, commandType: cmd);
                return rows;
            }
        }
    }
}
