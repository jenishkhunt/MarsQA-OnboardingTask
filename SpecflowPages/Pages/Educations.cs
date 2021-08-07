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
    class Educations
    {
        public static void addeducation()
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.Sleep(1000);
            // click to the Education Button
            Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]")).Click();
            Thread.Sleep(1000);
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add new Education
            Driver.driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]")).Click();
            Thread.Sleep(1000);
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add College
            Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")).SendKeys(ExcelLibHelper.ReadData(2, "college"));
            Thread.Sleep(1000);
            //choose College......
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var college = Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
            //create select element object 
            var selectElement = new SelectElement(college);
            //select by value
            selectElement.SelectByIndex(3);

            //choose Title......
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var title = Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
            //create select element object 
            var selectElement1 = new SelectElement(title);
            //select by value
            selectElement1.SelectByIndex(1);

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add Degree
            Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]")).SendKeys(ExcelLibHelper.ReadData(2, "degree"));

            //choose Year......
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var year = Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
            //create select element object 
            var selectElement2 = new SelectElement(year);
            //select by value
            selectElement2.SelectByIndex(3);



            //add Education
            Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]")).Click();

        }

        public static void editeducation()
        {
            Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]")).Click();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Edit button
            Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[1]/i[1]")).Click();
            Thread.Sleep(1000);
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add College
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).Clear();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).SendKeys("Unitec");

            //choose College......
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var college = Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            //create select element object 
            var selectElement = new SelectElement(college);
            //select by value
            selectElement.SelectByIndex(5);

            //choose Title......
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var title = Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[1]/select[1]"));
            //create select element object 
            var selectElement1 = new SelectElement(title);
            //select by value
            selectElement1.SelectByIndex(3);

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add Degree
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[2]/input[1]")).Clear();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[2]/input[1]")).SendKeys("Commerce");

            //choose Year......
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var year = Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[3]/select[1]"));
            //create select element object 
            var selectElement2 = new SelectElement(year);
            //select by value
            selectElement2.SelectByIndex(1);



            //add Education
            Driver.driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[3]/input[1]")).Click();


        }

        public static void deleteeducation()
        {
            Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]")).Click();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[6]/span[2]/i[1]")).Click();


        }
    }
}
