using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MiniORM.Services
{
    class ConnectionStringBuilder
    {
        private SqlConnectionStringBuilder connectionString;

        public ConnectionStringBuilder(string databaseName)
        {
            this.connectionString = new SqlConnectionStringBuilder();
            this.connectionString["Server"] = ".";
            this.connectionString["Integrated Security"] = true;
            this.connectionString["Trusted_Connection"] = true;
            this.connectionString["Connection Timeout"] = 1000;
            this.connectionString["Databse"] = databaseName;
        }
        public string ConnectionString()
        {
            return connectionString.ToString();
        }
    }
}
