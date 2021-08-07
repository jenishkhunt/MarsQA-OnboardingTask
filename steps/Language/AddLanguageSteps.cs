using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Language
{
    [Binding]
    public class AddLanguageSteps
    {
        [Given(@"Add language on the webpage")]
        public void GivenAddLanguageOnTheWebpage()
        {
            Start.Setup();
            StartLanguage.addbutton();
        }
        
    }
}
