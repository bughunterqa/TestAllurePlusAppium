using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Chrome;
using System;
using TestAllurePlusAppium.Helpers;
using TestAllurePlusAppium.View;

namespace TestAllurePlusAppium
{
    [TestFixture]
    public class Browser 
    {
        public static WindowsDriver<WindowsElement> _driver;

        public static void Initialize()
        {
            AppiumOptions opt = new AppiumOptions();
            opt.AddAdditionalCapability("app", TestData.OEMClientApp);
            opt.AddAdditionalCapability("deviceName", "WindowsPC");
            _driver = new WindowsDriver<WindowsElement>(new Uri(TestData.WindowsApplicationDriverUrl), opt);     
        }

        [SetUp]
        public static void Setup()
        {
            Initialize();
        }


        [OneTimeSetUp]
        public void OneTimeSetup()
        {

        }

        public static ISearchContext Driver
        {
            get { return _driver; }
        }

        public static WindowsDriver<WindowsElement> _Driver
        {
            get { return _driver; }
        }






    }
}