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

        [AllureStep("Check that modal is displayed")]
        public ConfirmationPage GetModal()
        {
            WaitUntil.WaitElement(_driver, btnCalibrate);
            Assert.IsTrue(btnCalibrate.Displayed);

            return this;
        }
    }
}
