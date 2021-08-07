using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Education
{
    [Binding]
    public class EditEducationSteps
    {
        [Given(@"Edit Education on the webpage")]
        public void GivenEditEducationOnTheWebpage()
        {
            Start.Setup();
            StartEducation.editeducation();
        }
    }
}
