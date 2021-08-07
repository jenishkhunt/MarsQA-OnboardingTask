using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Language
    {
        //CLICK language button
        private static IWebElement language => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        //Add new language
        private static IWebElement addlanguage => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        
        public static void languageadd()
        {

            language.Click();
            addlanguage.SendKeys(ExcelLibHelper.ReadData(2, "language"));

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var education = Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            //create select element object 
            var selectElement = new SelectElement(education);
            //select by value
            selectElement.SelectByIndex(2);

            //add lan
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]")).Click();


        }

        public static void languageedit()
        {

            language.Click();
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]")).Clear();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]")).SendKeys("Franch");
            Thread.Sleep(2000);
            //choose level
            var education = Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            //create select element object 
            var selectElement = new SelectElement(education);
            //select by value
            selectElement.SelectByIndex(1);
            Thread.Sleep(2000);
            // update the language
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]")).Click();



        }

        public static void languagedelete()
        {


            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[3]/span[2]/i[1]")).Click();


        }



    }
}
