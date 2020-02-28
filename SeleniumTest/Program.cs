using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
             kirayemlak();
        }
        public static void kirayemlak()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://kirayemlak.az/");
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://kirayemlak.az/Haqqimizda");
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://kirayemlak.az/Qaydalar");
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://kirayemlak.az/Elaqe");
            Thread.Sleep(5000);


          
            string dString = "Test@mail.com";
            int dnumber = 0555555555;
         
            for (int i = 0; i < 10; i++)
            {

                IWebElement inpFull = driver.FindElement(By.Name("FullName"));
                IWebElement inpFull2 = driver.FindElement(By.Name("Email"));
                IWebElement inpFull3 = driver.FindElement(By.Name("Subject"));
                IWebElement inpFull4 = driver.FindElement(By.Name("PhoneNumber"));
                IWebElement inpFull5 = driver.FindElement(By.Name("MessageText"));
                IWebElement sb = driver.FindElement(By.ClassName("contact-send"));
                inpFull.SendKeys(dString);
                inpFull2.SendKeys(dString);
                inpFull3.SendKeys(dString);
                inpFull4.SendKeys(dnumber.ToString());
                inpFull5.SendKeys(dString);
                sb.Click();
            }
            driver.Close();
        }
    }
}
