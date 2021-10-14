using NUnit.Allure.Steps;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class ConnectionPage
    {
        [AllureStep("Press the Next button")]
        public FlashTypePage PressNextButton()
        {
            WaitUntil.WaitElement(_driver, btnNext);
            btnNext.Click();

            return Pages.FlashType;
        }
    }
}
