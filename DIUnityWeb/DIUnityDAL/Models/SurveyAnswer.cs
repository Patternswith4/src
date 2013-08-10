using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIUnityDAL.Models
{
    public class SurveyAnswer
    {
        public SurveyAnswer()
        {
            this.QuestionAnswers = new List<QuestionAnswer>();
        }

        public string SlugName { get; set; }
        public string Tenant { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public IList<QuestionAnswer> QuestionAnswers { get; set; }
    }

    public enum QuestionType
    {
        SimpleText,
        MultipleChoice,
        FiveStars
    }

    public class QuestionAnswer
    {
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public string Answer { get; set; }
        public string PossibleAnswers { get; set; }
    }
}
