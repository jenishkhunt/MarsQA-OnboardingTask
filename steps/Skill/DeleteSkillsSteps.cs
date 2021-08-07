using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Skill
{
    [Binding]
    public class DeleteSkillsSteps
    {
        [Given(@"Delete skill on the webpage")]
        public void GivenDeleteSkillOnTheWebpage()
        {
            Start.Setup();
            StartSkills.deletebutton();
        }
    }
}
