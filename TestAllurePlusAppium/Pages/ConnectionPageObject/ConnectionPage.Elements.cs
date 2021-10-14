using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAllurePlusAppium.Pages
{
    public partial class ConnectionPage : Browser
    {
        public WindowsElement btnNext => _driver.FindElementByName("NEXT");

        public WindowsElement titlePage => _driver.FindElementByName("Connection");
    }
}
