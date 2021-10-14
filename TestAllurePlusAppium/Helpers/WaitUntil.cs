using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestAllurePlusAppium.Helpers
{
    class WaitUntil
    {
        public static void WaitSomeInterval(int seconds = 2)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }

        public static void WaitElement(WindowsDriver<WindowsElement> webDriver, WindowsElement windowsElement, int seconds = 10)
        {
            //new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(webElement));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(windowsElement));
        }



    }
}
