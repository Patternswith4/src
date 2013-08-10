using System;
using System.Collections.Generic;
using System.Diagnostics;
using DIUnityDAL.Retries;
using DIUnityDAL.Stores;
using Microsoft.Practices.Unity;

namespace DIUnityDAL
{
    public class ContainerBootStrapper
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            Trace.WriteLine(string.Format("Called RegisterTypes in ContainerBootstrapper"), "UNITY");

            var storageAccountType = typeof(StorageAccount);
            var retryPolicyFactoryType = typeof(IRetryPolicyFactory);

            //Instance Registration
            StorageAccount account = ApplicationConfiguration.GetStorageAccount("DataConnectionString");
            container.RegisterInstance(account);

            //Register Factories
            container.RegisterInstance<IRetryPolicyFactory>(new ConfiguredRetryPolicyFactory())
                     .RegisterType<ISurveyAnswerContainerFactory, SurveyAnswerContainerFactory>(
                         new ContainerControlledLifetimeManager());
        }
    }
}
