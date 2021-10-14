using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class CalibrationPage 
    {
        [AllureStep("Confirm that Calibrations are displayed")]
        public CalibrationPage CheckDisplayItems()
        {
            WaitUntil.WaitElement(_driver, itemOfList);
            Assert.IsTrue(itemOfList.Displayed);

            return this;
        }
    }
}
