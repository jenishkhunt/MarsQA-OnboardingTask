using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    public class Start : Driver
    {
        public static void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Mogli\Desktop\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.SigninStep();
        }

       
    }
}
