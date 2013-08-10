using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DIUnityDAL;

namespace DIUnityWeb.Models
{
    public class TenantPageViewData<T>
    {
        public TenantPageViewData()
        {
        }

        public TenantPageViewData(IEnumerable<string> names)
        {

        }
    }
}