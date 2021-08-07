using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Utils
{
    public class StartLanguage
    {
       public static void addbutton()
        {
            Language.languageadd();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Mogli\Desktop\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

        }

        public static void editbutton()
        {
            Language.languageedit();
        }

        public static void deletebutton()
        {
            Language.languagedelete();
        }


    }
}
