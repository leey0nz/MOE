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
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
            verificationErrors = new StringBuilder();

            // Navigate URL
            driver.Navigate().GoToUrl("https://www.development.opal2.conexus.net/app/cam");

            //AutoItX3 autoIt = new AutoItX3();
            //autoIt.WinActivate("Open");

            // Login Page
            LoginRoleHQCAO.Login(driver);

            ApproveUI addingCourse = new ApproveUI(driver);
            // Check Security Log-in
            var isProceedExisted = addingCourse.ClickButton._checkElementExistedByXPath("//button[contains(text(),'Proceed')]");
            if (isProceedExisted == true)
            {
                addingCourse.ClickButton._ClickByFindElement("//button[contains(text(),'Proceed')]");
            }
            try
            {
                // Tab Menu
                addingCourse.ClickMenu.ClickTabMenu("//span[contains(text(),'Course Administration')]");
                Thread.Sleep(2000);

                // Pending Course Approval menu
                addingCourse.ClickButton._ClickButton("//div[contains(text(),'Pending Course Approval')]");

                // Search Course
                addingCourse.EnterTextBox.PasteTexts("//input[@placeholder='Search in Course Administration']", "Basketball Testing 24b1297f224e4c2f");

                // Choose course
                addingCourse.ClickButton._ClickButton("//p[@class='main-title ng-star-inserted']");
                Thread.Sleep(2000);

                // Approve button
                addingCourse.ClickButton._ClickButton("//button[contains(text(),'Approve')]");

                // Input Comment
                addingCourse.EnterTextBox.PasteTexts("//textarea[@placeholder='Please add comment ...']", "Agree");

                // Proceed button
                addingCourse.ClickButton._ClickButton("/html/body/app-root/kendo-dialog/div[2]/div/comment-dialog/div[3]/button[2]");
            }
            catch (Exception e)
            {
                RedMessage("Scenario Approve Course: Can not approve course !!!\n Reason: " + e);
                return;
            }
            GreenMessage("Scenario Approve Course: Appove course success!!!!");
            {

            }
        }
    }
}