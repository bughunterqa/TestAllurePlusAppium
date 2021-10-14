using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;



namespace TestAllurePlusAppium.Pages
{
    public static class Pages 
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static ConnectionPage Connection
        {
            get { return GetPage<ConnectionPage>(); }
        }

        public static FlashTypePage FlashType
        {
            get { return GetPage<FlashTypePage>(); }
        }

        public static VehiclePage Vehicle
        {
            get { return GetPage<VehiclePage>(); }
        }

        public static CalibrationPage Calibration
        {
            get { return GetPage<CalibrationPage>(); }
        }

        public static OptionsPage Options
        {
            get { return GetPage<OptionsPage>(); }
        }

        public static ConfirmationPage Confirmation
        {
            get { return GetPage<ConfirmationPage>(); }
        }

        public static FlashingPage Flashing
        {
            get { return GetPage<FlashingPage>(); }
        }
    }
}
