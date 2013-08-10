using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIUnityDAL.BlobContainers
{
    public interface IBlobContainer<T>
    {
        void EnsureExist();
        T Get(string objId);
        IEnumerable<IListBlobItemWithName> GetBlobList();
        
    }
}
