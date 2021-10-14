using NUnit.Allure.Steps;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;


namespace TestAllurePlusAppium.Pages
{
    public partial class LoginPage
    { 

        [AllureStep("Enter Email - {0}")]
        public LoginPage EnterEmail(string email)
        {
            inputEmail.Clear();
            inputEmail.SendKeys(email);

            return this;
        }

        [AllureStep("Enter password -  {0}")]
        public LoginPage EnterPassword(string psw)
        {
            inputPassword.Clear();
            inputPassword.SendKeys(psw);

            return this;
        }

        [AllureStep("Press Login button")]
        public ConnectionPage PressLoginButton()
        {
            btnLogin.Click();

            return Pages.Connection;
        }
    }
}
