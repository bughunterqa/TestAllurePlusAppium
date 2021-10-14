using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAllurePlusAppium.Pages
{
    public partial class LoginPage : Browser
    {
        public WindowsElement btnLogin => _driver.FindElementByName("LOGIN");
        public WindowsElement inputEmail => _driver.FindElementByClassName("TextBox");
        public WindowsElement inputPassword => _driver.FindElementByClassName("PasswordBox");


       // public WindowsElement btnLogin => _driver.FindElementByXPath("//button");

    }
}
