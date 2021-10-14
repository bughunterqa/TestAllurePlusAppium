using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class ConfirmationPage
    {

        [AllureStep("Close modal window")]
        public ConfirmationPage CloseModal()
        {
            btnCalibrate.Click();

            return this;
        }

        [AllureStep("Press the Next button")]
        public FlashingPage PressNextButton()
        {
            WaitUntil.WaitElement(_driver, btnNext);
            btnNext.Click();

            return Pages.Flashing;
        }
    }
}
