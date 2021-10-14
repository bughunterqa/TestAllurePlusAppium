using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAllurePlusAppium.Pages
{
    public partial class VehiclePage : Browser
    {
        public WindowsElement btnCheckId => _driver.FindElementByName("CHECK ID");

        public WindowsElement btnNext => _driver.FindElementByName("NEXT");


        public WindowsElement btnEditCustomer => _driver.FindElementByName("EDIT CUSTOMER");
    }
}
