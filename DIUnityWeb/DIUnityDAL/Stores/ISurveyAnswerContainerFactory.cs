using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIUnityDAL.BlobContainers;
using DIUnityDAL.Models;

namespace DIUnityDAL.Stores
{
    interface ISurveyAnswerContainerFactory
    {
        IBlobContainer<SurveyAnswer> Create(string tenant, string surveySlug);
    }
}
