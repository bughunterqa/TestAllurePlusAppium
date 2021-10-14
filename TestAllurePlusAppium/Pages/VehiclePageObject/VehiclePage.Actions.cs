using NUnit.Allure.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class VehiclePage
    {
        [AllureStep("Press Check ID button")]
        public VehiclePage PressCheckIdButton()
        {
            WaitUntil.WaitElement(_driver, btnCheckId);
            btnCheckId.Click();

            return this;
        }

        [AllureStep("Press the Next button")]
        public CalibrationPage PressNextButton()
        {
            WaitUntil.WaitElement(_driver, btnNext);
            btnNext.Click();

            return Pages.Calibration;
        }
    }
}
