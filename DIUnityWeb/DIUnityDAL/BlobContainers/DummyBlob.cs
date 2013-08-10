using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUnityDAL.BlobContainers
{
    class DummyBlob: IListBlobItemWithName
    {
        public string Name { get; set; }
    }

    public interface IListBlobItemWithName
    {
        string Name { get; }
    }
}
