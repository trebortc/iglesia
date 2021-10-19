using System;
using System.Collections.Generic;
using System.Text;

namespace IglesiaData
{
    public class MySqlConfiguration
    {
        public MySqlConfiguration(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string ConnectionString { get; set; }
    }
}
