using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIUnityDAL.BlobContainers;
using DIUnityDAL.Models;

namespace DIUnityDAL.Stores
{
    public class TenantStore : ITenantStore, ITenantStoreLogo
    {
        private readonly IBlobContainer<Tenant> tenantBlobContainer;
        private readonly IBlobContainer<byte[]> logosBlobContainer;

        public TenantStore(IBlobContainer<Tenant> tenantBlobContainer, IBlobContainer<byte[]> logosBlobContainer)
        {
            Trace.WriteLine(string.Format("Called constructor in TenantStore"), "UNITY");
            this.tenantBlobContainer = tenantBlobContainer;
            this.logosBlobContainer = logosBlobContainer;
        }

        public void Initialize()
        {
            Trace.WriteLine(string.Format("Called Initialize in TenantStore"), "UNITY");
            this.logosBlobContainer.EnsureExist();
            this.tenantBlobContainer.EnsureExist();
            Console.WriteLine("Initialized a TenantStore instance");
        }

        public Tenant GetTenant(string tenant)
        {
            return tenantBlobContainer.Get(tenant);
        }

        public IEnumerable<string> GetTenantNames()
        {
            return this.tenantBlobContainer.GetBlobList().Select(_ => _.Name);
        }

        public void SaveTenant(Tenant tenant)
        {
            throw new NotImplementedException();
        }

        public void UploadLogo(string tenant, byte[] logo)
        {
            throw new NotImplementedException();
        }

    }
}
