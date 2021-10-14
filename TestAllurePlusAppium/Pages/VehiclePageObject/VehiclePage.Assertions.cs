using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class VehiclePage
    {

        [AllureStep("Confirm end of check")]
        public VehiclePage ConfirmEndOfCheckId()
        {
            WaitUntil.WaitElement(_driver, btnEditCustomer, 20);
            Assert.IsTrue(btnEditCustomer.Displayed);

            return this;
        }
    }
}
