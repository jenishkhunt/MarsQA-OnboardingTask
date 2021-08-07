using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Skill
{
    [Binding]
    public class EditSkillsSteps
    {
        [Given(@"Edit skill on the webpage")]
        public void GivenEditSkillOnTheWebpage()
        {
            Start.Setup();
            StartSkills.editbutton();
        }
    }
}
