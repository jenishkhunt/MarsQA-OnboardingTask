using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Language
{
    [Binding]
    public class DeleteLanguageSteps
    {
        [Given(@"Delete language on the webpage")]
        public void GivenDeleteLanguageOnTheWebpage()
        {
            Start.Setup();
            StartLanguage.deletebutton();
        }
    }
}
