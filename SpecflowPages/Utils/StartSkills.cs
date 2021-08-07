using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Utils
{
    class StartSkills
    {
        public static void addbutton()
        {
            Skills.addskills();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Mogli\Desktop\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

        }

        public static void editbutton()
        {
            Skills.editskills();
        }

        public static void deletebutton()
        {
            Skills.deleteskills();
        }
    }
}
