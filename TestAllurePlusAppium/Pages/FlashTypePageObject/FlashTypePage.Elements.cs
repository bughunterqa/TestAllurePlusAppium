using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAllurePlusAppium.Pages
{
    public partial class FlashTypePage : Browser
    {
        public WindowsElement btnNext => _driver.FindElementByName("NEXT");
        public WindowsElement radiobtnEngine => _driver.FindElementByAccessibilityId("EngineRadioButton");
    }
}
