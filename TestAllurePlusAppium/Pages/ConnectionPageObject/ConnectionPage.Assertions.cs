using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class ConnectionPage
    {
        [AllureStep("Check that User logged")]
        public ConnectionPage CheckPageTitle()
        {
            WaitUntil.WaitSomeInterval(2);
            string actualTitle = titlePage.Text;

            Assert.AreEqual(actualTitle, "Connection");

            return this;
        }
    }
}
