using System.Globalization;
using DIUnityDAL.BlobContainers;
using DIUnityDAL.Models;
using Microsoft.Practices.Unity;

namespace DIUnityDAL.Stores
{
    class SurveyAnswerContainerFactory : ISurveyAnswerContainerFactory
    {
        private readonly IUnityContainer unityContainer;

        public SurveyAnswerContainerFactory(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public IBlobContainer<SurveyAnswer> Create(string tenant, string surveySlug)
        {
            var blobContainerName = string.Format(CultureInfo.InvariantCulture, "surveyanswers-{0}-{1}",
                                                  tenant.ToLowerInvariant(), surveySlug.ToLowerInvariant());

            return this.unityContainer.Resolve<IBlobContainer<SurveyAnswer>>(
                new ParameterOverride("blobContainerName", blobContainerName));
        }
    }
}
