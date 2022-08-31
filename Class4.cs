using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassWork
{
    internal class CheckboxDemo
    {
        private static IWebDriver _driver;

        [SetUp]
        public static void SetUp()
        {
            IReadOnlyCollection<IWebElement> checkBoxes = _driver.FindElements(By.ClassName("cb1-element"));
            foreach (IWebElement checkBox in checkBoxes)
            {
                if (checkBox.Selected)
                {
                    checkBox.Click();
                }
            }
        }

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://demo.anhtester.com/basic-checkbox-demo.html";
        }

        [Test]
        public static void TestSingleCheckBox()
        {
            IWebElement singleCheckBox = _driver.FindElement(By.Id("isAgeSelected"));
            singleCheckBox.Click();

            IWebElement singleCheckBoxResult = _driver.FindElement(By.Id("txtAge"));
            Assert.AreEqual("Success - Check box is checked", singleCheckBoxResult.Text, "Message is wrong!");
        }

        public static void TestUnselectAllButton()
        {
            // pasižymim visus
            IReadOnlyCollection<IWebElement> checkBoxes = _driver.FindElements(By.ClassName("cb1-element"));
            foreach (IWebElement checkBox in checkBoxes)
            {
                checkBox.Click();
            }

            IWebElement button = _driver.FindElement(By.Id("check1"));
            button.Click();

            // click on button Unselect All
            Assert.AreEqual("Check All", button.GetAttribute("value").ToString(), "Value is incorrect");
            foreach (IWebElement checkBox in checkBoxes)
            {
                Assert.IsTrue(!checkBox.Selected, "CheckBox Selected.");
            }
            // assert checkbox
        }


        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }
    }
}
