﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistindoDadosComEntityFC.Database
{
    internal class Connection
    {
        private string ConnectionString {  get; set; }
        public Connection()
        {
            ConnectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial " +
                "Catalog=ScreenSoundDB;Integrated Security=True;" +
                "Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False";
        }
        public SqlConnection ObterConexao() => new SqlConnection(ConnectionString);
    }
}
