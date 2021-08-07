using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Utils
{
    class StartEducation
    {
        public static void addeducation()
        {
            Educations.addeducation();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Mogli\Desktop\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

        }

        public static void editeducation()
        {
            Educations.editeducation();
        }

        public static void deleteeducation()
        {
            Educations.deleteeducation();
        }
    }
}
