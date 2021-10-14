using System;
using System.Collections.Generic;
using System.Text;
using TestAllurePlusAppium.Helpers;

namespace TestAllurePlusAppium.Pages
{
    public partial class FlashingPage
    {
        public FlashingPage PressFlashButton()
        {
            WaitUntil.WaitElement(_driver, btnFlash);
            btnFlash.Click();
            return this;
        }
    }
}
