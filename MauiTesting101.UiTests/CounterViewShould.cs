// See https://aka.ms/new-console-template for more information

using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace MauiTesting101.UiTests
{

    public class CounterViewShould : BaseTest
    {
        public CounterViewShould(Platform platform):base(platform){}

        [Test]
        public void WhenCounterClicked_IncrementCount()
        {
            // Arrange: Wait until counter Button is present
            const string countButton = "CounterBtn";
            App.WaitForElement(countButton);

            // Act: Tap the button
            App.Tap(countButton);


            // Assert: check label updated
            var buttonLabelValue = "Clicked 1 time";
            Assert.DoesNotThrow(() => App.WaitForElement(x => x.Marked(buttonLabelValue)), "Button was not clicked");

            // Take a screenshot
            App.Screenshot("Tapped 1 time");
        }
    }
}
