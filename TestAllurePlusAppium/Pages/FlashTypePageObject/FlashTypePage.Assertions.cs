using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAllurePlusAppium.Pages
{
    public partial class FlashTypePage
    {
        [AllureStep("Check that radio button is selected for Engine Tune")]
        public FlashTypePage CheckSelectedRadioButton()
        {
            bool engineSelected = radiobtnEngine.Selected;

            Assert.IsTrue(engineSelected);

            return this;
        }

    }
}
