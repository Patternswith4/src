using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DIUnityDAL.Models;

namespace DIUnityDAL.Stores
{
    public interface ITenantStore
    {
        void Initialize();
        Tenant GetTenant(string tenant);
        IEnumerable<string> GetTenantNames();
        void SaveTenant(Tenant tenant);
    }

    public interface ITenantStoreLogo
    {
        void UploadLogo(string tenant, byte[] logo);
    }
}
