using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIUnityDAL
{
    class StorageAccount
    {
        private readonly string connectionString;

        public StorageAccount(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string ConnectionString
        {
            get { return this.connectionString; }
        }
    }
}
