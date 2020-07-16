using Login.Common.Login;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;
using System.Threading;

namespace Course_Administration_MOE.Scenario.Approve_Course
{
    public class CreateClassrun
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
        public void createClassrun()
        {
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
            verificationErrors = new StringBuilder();

            // Navigate URL
            driver.Navigate().GoToUrl("https://www.development.opal2.conexus.net/app/cam");

            //AutoItX3 autoIt = new AutoItX3();
            //autoIt.WinActivate("Open");

            // Login Page
            LoginRoleCA.Login(driver);

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

                // Search Course
                addingCourse.EnterTextBox.PasteTexts("//input[@placeholder='Search in Course Administration']", "Basketball Testing 298876294804421d");

                // Choose course
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-management-page/div/div/kendo-tabstrip/div/list-course-grid/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr/td[2]/p[1]");
                Thread.Sleep(2000);

                // Class Runs tab
                addingCourse.ClickButton._ClickButton("//li[2]//span[1]");

                // Create Class Run button
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/classrun-management-page/div/div/div/div[2]/button");

                // Class Title
                addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[1]/editable/input", "ClassRun 01");

                // Class Start Date
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[2]/editable/kendo-datepicker/span/span/span");
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[2]/editable/kendo-datepicker/span/span/span");
                addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[2]/editable/kendo-datepicker/span/kendo-dateinput/span/input", "18092020");

                // Class End Date
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[3]/editable/kendo-datepicker/span/span/span");
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[3]/editable/kendo-datepicker/span/span/span");
                addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[3]/editable/kendo-datepicker/span/kendo-dateinput/span/input", "01082020");

                // Class Start Time
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[4]/editable/kendo-timepicker/span/span/span");
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[4]/editable/kendo-timepicker/span/span/span");
                addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[4]/editable/kendo-timepicker/span/kendo-dateinput/span/input", "0600AM");

                // Class End Time
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[5]/editable/kendo-timepicker/span/span");
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[5]/editable/kendo-timepicker/span/span");
                addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/classrun-overview-info-tab/form/div/div[5]/editable/kendo-timepicker/span/kendo-dateinput/span/input", "0500PM");

                // Class Run Facilitator
                addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/classrun-planning-tab/form/div/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "urek-cf-01");

                // Minimum Class Size
                addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/classrun-planning-tab/form/div/div[3]/editable/kendo-numerictextbox/span/input", "50");

                // Maximum Class Size 
                addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/classrun-planning-tab/form/div/div[4]/editable/kendo-numerictextbox/span/input", "100");

                // Save button
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/classrun-detail-page/div/div/app-toolbar-fragment/div/div[3]/toolbar-right/div/button");

                // All Class Runs
                addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/classrun-management-page/div/div/kendo-tabstrip/ul/li/span");

            }
            catch (Exception e)
            {
                RedMessage("Scenario Create New Classrun: Can not create classrun!!!\n Reason: " + e);
                return;
            }
            GreenMessage("Scenario Create New Classrun: Create classrun success!!!!");
            {

            }
        }
    }
}