using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class OptionsPage
    {
        [AllureStep("Confirm that Options are displayed")]
        public OptionsPage CheckDisplayItems()
        {
            WaitUntil.WaitElement(_driver, itemOfList);
            Assert.IsTrue(itemOfList.Displayed);

            return this;
        }
    }
}
