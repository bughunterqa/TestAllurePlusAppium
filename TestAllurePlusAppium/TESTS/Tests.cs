using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;
using TestAllurePlusAppium.Pages;
using TestAllurePlusAppium.View;
using Assert = NUnit.Framework.Assert;

namespace TestAllurePlusAppium.Pages
{
    [AllureNUnit]
    public class Tests : Browser
    {
        [Test]
        public void Login()
        {
            Pages.Login
                .EnterEmail(Credentials.EmailClientOEM)
                .EnterPassword(Credentials.PasswordClientOEM)
                .PressLoginButton()
                .CheckPageTitle()
                .PressNextButton()
                .CheckSelectedRadioButton()
                .PressNextButton()
                .PressCheckIdButton()
                .ConfirmEndOfCheckId()
                .PressNextButton()
                .CheckDisplayItems()
                .PressNextButton()
                .CheckDisplayItems()
                .PressNextButton()
                .GetModal()
                .CloseModal()
                .PressNextButton()
                .PressFlashButton();






        }


    }
}
