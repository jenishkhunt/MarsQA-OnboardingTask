using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Language
{
    [Binding]
    public class EditLanguageSteps
    {
        [Given(@"Edit language on the webpage")]
        public void GivenEditLanguageOnTheWebpage()
        {
            Start.Setup();
            StartLanguage.editbutton();
        }
    }
}
