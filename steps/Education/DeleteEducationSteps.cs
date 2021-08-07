using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Education
{
    [Binding]
    public class DeleteEducationSteps
    {
        [Given(@"Delete Education on the webpage")]
        public void GivenDeleteEducationOnTheWebpage()
        {
            Start.Setup();
            StartEducation.deleteeducation();
        }
    }
}
