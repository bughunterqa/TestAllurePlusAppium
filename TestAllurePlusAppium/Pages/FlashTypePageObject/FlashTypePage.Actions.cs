using NUnit.Allure.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class FlashTypePage
    {
        [AllureStep("Press the Next button")]
        public VehiclePage PressNextButton()
        {
            WaitUntil.WaitElement(_driver, btnNext);
            btnNext.Click();

            return Pages.Vehicle;

        }
    }
}
