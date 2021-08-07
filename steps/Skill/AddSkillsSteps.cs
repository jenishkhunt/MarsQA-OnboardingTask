using MarsQA_1.SpecflowPages.Utils;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.steps.Skill
{
    [Binding]
    public class AddSkillsSteps
    {
        [Given(@"Add skill on the webpage")]
        public void GivenAddSkillOnTheWebpage()
        {
            Start.Setup();
            StartSkills.addbutton();
        }
    }
}
