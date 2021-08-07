using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Education
{
    [Binding]
    public class AddEducationSteps
    {
        [Given(@"Add Education on the webpage")]
        public void GivenAddEducationOnTheWebpage()
        {
            Start.Setup();
            StartEducation.addeducation();
        }
    }
}
