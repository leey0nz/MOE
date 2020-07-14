using Login.Common.Login;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;
using System.Threading;

namespace Course_Administration_MOE.Scenario.Approve_Course
{
    public class ActionApproveCourse
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        [Test]
        public void approveCourse()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            verificationErrors = new StringBuilder();

            // Navigate URL
            driver.Navigate().GoToUrl("https://www.development.opal2.conexus.net/app/cam");

            //AutoItX3 autoIt = new AutoItX3();
            //autoIt.WinActivate("Open");

            // Login Page
            LoginRoleCCC.Login(driver);

            ApproveUI addingCourse = new ApproveUI(driver);
            // Check Security Log-in
            var isProceedExisted = addingCourse.ClickButton._checkElementExistedByXPath("//button[contains(text(),'Proceed')]");
            if (isProceedExisted == true)
            {
                addingCourse.ClickButton._ClickByFindElement("//button[contains(text(),'Proceed')]");
            }

            // Tab Menu
            addingCourse.ClickMenu.ClickTabMenu("//span[contains(text(),'Course Administration')]");
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.XPath(""));
            if (element.Displayed)
            {
                GreenMessage("Yes! I can see the element, it's right there!!!");
            }
            else
            {
                RedMessage("Well, something went wrong, I couldn't see the element!");
            }
        }
    }
}
