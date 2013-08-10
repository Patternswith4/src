using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIUnityDAL;
using DIUnityDAL.Stores;
using DIUnityWeb.Models;
using Microsoft.Practices.Unity;

namespace DIUnityWeb.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ITenantStore tenantStore;

        public ManagementController(ITenantStore tenantStore)
        {
            this.tenantStore = tenantStore;
            var container = new UnityContainer();
            container.RegisterType<ITenantStore, TenantStore>();
        }

        public ActionResult Index()
        {
            var model = new TenantPageViewData<IEnumerable<string>>
                (this.tenantStore.GetTenantNames())
                {
                    Title = "Subscribers"
                };
            return this.View(model);
        }
    }
}
