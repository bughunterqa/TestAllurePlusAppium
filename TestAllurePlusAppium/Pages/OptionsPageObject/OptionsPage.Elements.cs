using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAllurePlusAppium.Pages
{
    public partial class OptionsPage : Browser
    {
        public WindowsElement btnNext => _driver.FindElementByName("NEXT");

        public WindowsElement itemOfList => _driver.FindElementByClassName("ListBoxItem");
    }
}
