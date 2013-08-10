using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUnityDAL
{
    class ApplicationConfiguration
    {
        public static StorageAccount GetStorageAccount(string connectionString)
        {
            return new StorageAccount(connectionString);
        }
    }
}
