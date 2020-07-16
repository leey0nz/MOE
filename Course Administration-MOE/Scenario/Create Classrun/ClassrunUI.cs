using System;
using System.Collections.Generic;
using System.Text;
using Course_Administration_MOE.UI;
using OpenQA.Selenium;

namespace Course_Administration_MOE.Scenario.Approve_Course
{
    public class ClassrunUI
    {
        public SelectTabMenu ClickMenu { get; set; }
        public SelectButton ClickButton { get; set; }
        public SelectSubMenu ClickSubMenu { get; set; }
        public EnterText EnterTextBox { get; set; }
        public EnterText EnterTextBoxByElement { get; set; }
        public ClassrunUI(IWebDriver driver)
        {
            ClickMenu = new SelectTabMenu(driver, "");
            ClickButton = new SelectButton(driver, "");
            ClickSubMenu = new SelectSubMenu(driver, "");
            EnterTextBox = new EnterText(driver, "");
            EnterTextBoxByElement = new EnterText(driver, "");
        }


    }
}
