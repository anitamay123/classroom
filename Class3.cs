using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassWork
{
    class Homework1
    {

        /*Patikrinti, ar teisingai suskaičiuotos sumos, jei įvesti tokie duomenys:
             2+2
             -5+3
             a + b*/

        [Test]

        public static void TestIfSumTwoPlusTwoIsCorrect()
        {
            string number1 = "2";
            string number2 = "2";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";            

            IWebElement Number1InputField = driver.FindElement(By.Id("number1"));
            Number1InputField.SendKeys(number1);

            IWebElement Number2InputField = driver.FindElement(By.Id("number2"));
            Number2InputField.SendKeys(number2);

            IWebElement calculateButton = driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.IsTrue(result.Text.Equals("4"), "Sum is incorrect");

            driver.Close();
        }

        [Test]

        public static void TestIfSumMinusFiveandThreeIsCorrect()
        {
            string number1 = "-5";
            string number2 = "3";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement Number1InputField = driver.FindElement(By.Id("number1"));
            Number1InputField.SendKeys(number1);

            IWebElement Number2InputField = driver.FindElement(By.Id("number2"));
            Number2InputField.SendKeys(number2);

            IWebElement calculateButton = driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.IsTrue(result.Text.Equals("-2"), "Sum is incorrect");

            driver.Close();
        }
    }
}
