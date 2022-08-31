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
    class WebDriver
    {
        /*[Test]
        public static void TestChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://login.yahoo.com/";
            Thread.Sleep(2000);
            driver.Close();



        }

        [Test]
        public static void TestFullNameInputField()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
            fullNameInputField.SendKeys("Arnas");

            IWebElement submitButton = driver.FindElement(By.CssSelector("#submit"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("name"));
            Assert.AreEqual("Name:", "Name:Arnas", "Name is wrong!");

            driver.Close();

        }

        [Test]
        public static void TestFullNameInputFieldNew()
        {
            string name = "Friday";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
            fullNameInputField.SendKeys(name);

            IWebElement submitButton = driver.FindElement(By.CssSelector("#submit"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("name"));
            Assert.AreEqual($"Name:{name}", result.Text, "Name is wrong!");

            driver.Close();
        }

        [Test]
        public static void TestFullNameAndEmailAddress()
        {

            string name = "Friday";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
            fullNameInputField.SendKeys(name);

            IWebElement emailAddress = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            emailAddress.SendKeys("ratkevicius.arnas@gmail.com");

            IWebElement submitButton = driver.FindElement(By.CssSelector("#submit"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("name"));
            Assert.AreEqual($"Name:{name}", result.Text, "Name is wrong!");

            IWebElement emailResult = driver.FindElement(By.Id("email"));
            Assert.IsTrue(emailResult.Text.Equals("Email:ratkevicius.arnas@gmail.com"), "Email is wrong!");

            driver.Close();
        }*/

        /*[Test]

        public static void TestIfSumTwoPlusTwoIsCorrect()
        {
            string number1 = "2";
            string number2 = "2";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
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

        public static void TestIfSumMinusFivePlusThreeIsCorrect()
        {
            string number1 = "-5";
            string number2 = "3";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
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

        [Test]
        public static void TestIfSumAPlusBGetsError()
        {
            string number1 = "a";
            string number2 = "b";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement Number1InputField = driver.FindElement(By.Id("number1"));
            Number1InputField.SendKeys(number1);

            IWebElement Number2InputField = driver.FindElement(By.Id("number2"));
            Number2InputField.SendKeys(number2);

            IWebElement calculateButton = driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.IsTrue(result.Text.Equals("ERR"), "ERR isn't shown");

            driver.Close();
        }

        /*https://www.w3schools.com/cssref/css_selectors.asp*/

        /* private static IWebDriver _driver;*/

        /*[OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://testpages.herokuapp.com/styled/calculator";
        }



        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "ERR", TestName = "a + b = ERR")]
        public static void TestCalculator(string number1, string number2, string expectedResult)
        {
            IWebElement Number1InputField = _driver.FindElement(By.Id("number1"));
            Number1InputField.Clear();
            Number1InputField.SendKeys(number1);

            IWebElement Number2InputField = _driver.FindElement(By.Id("number2"));
            Number2InputField.Clear();
            Number2InputField.SendKeys(number2);

            IWebElement calculateButton = _driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement result = _driver.FindElement(By.Id("answer"));
            /*Assert.IsTrue(result.Text.Equals("4"), "Sum is incorrect");*/
        /*Assert.AreEqual(expectedResult, result.Text, "Answer is wrong");

    }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }*/



        /*25 + 25.5 = 50.5 
         5 + 25,5 + Integers only = 30
         1.99 + 0.959 = 2.949
         -1 + -9.99 + Integers only = -10*/

        /*private static IWebDriver _driver;*/

        /*[OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://testsheepnz.github.io/BasicCalculator.html#main-body";
        }

        
        [TestCase("25", "25.5", "50.5", false, TestName = "25 + 25.5 = 50.5")]
        [TestCase("5", "25.5", "30", true, TestName = "5 + 25,5 + Integers only = 30")]
        [TestCase("1.99", "0.959", "2.949", false, TestName = "1.99 + 0.959 = 2.949")]
        [TestCase("-1", "-9.99", "-10", true, TestName = "-1 + -9.99 + Integers only = -10")]

        public static void TestCalculator2(string number1Field, string number2Field, string expectedResult, bool isIntegerEnabled)
        {
            IWebElement Number1InputField = _driver.FindElement(By.Id("number1Field"));
            Number1InputField.Clear();
            Number1InputField.SendKeys(number1Field);

            IWebElement Number2InputField = _driver.FindElement(By.Id("number2Field"));
            Number2InputField.Clear();
            Number2InputField.SendKeys(number2Field);

            IWebElement integerCheckBox = _driver.FindElement(By.Id("integerSelect"));
            if (isIntegerEnabled != integerCheckBox.Selected)
            {
                integerCheckBox.Click();
            }

            IWebElement calculateButton = _driver.FindElement(By.Id("calculateButton"));
            calculateButton.Click();

            IWebElement result = _driver.FindElement(By.Id("numberAnswerField"));
            Assert.AreEqual(expectedResult, result.GetAttribute("value").ToString(), "Answer is wrong");
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }*/

        /*[OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://demo.anhtester.com/basic-checkbox-demo.html";
        }

        [Test]
        public static void TestSingleCheckbox()
        {
            IWebElement singleCheckBox = _driver.FindElement(By.Id("isAgeSelected"));
            singleCheckBox.Click();

            IWebElement singleCheckBoxResult = _driver.FindElement(By.Id("txtAge"));
            Assert.AreEqual("Success - Check box is checked", singleCheckBoxResult.Text, "Message is wrong!");
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();*/


        /*IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.ClassName(""));*/

        /*1) Užduotis: Puslapiui https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent
parašyti testus, ar teisingai parodo jūsų naršyklę, jei paleidžiate testus su: chrome, firefox*/

        private static IWebDriver _driver;

        /*[OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/#parse-useragent";
        }


        [TestCase("Chrome 104.0.5112.102", "Chrome 104", TestName = "Chrome 104")]
        [TestCase("Firefox 104.0 (64-bit)", "Firefox 104", TestName = "Firefox 104")]

        public static void TestUserAgentParsing(string userAgnetInputField, string expectedResult)
        {
            IWebElement UserAgentInputField = _driver.FindElement(By.Id("id_user_agent"));
            UserAgentInputField.Clear();
            UserAgentInputField.SendKeys(userAgnetInputField);

            IWebElement parseThisUserAgentButton = _driver.FindElement(By.CssSelector("#parse-controls > input"));
            parseThisUserAgentButton.Click();

            IWebElement result = _driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual(expectedResult, result.Text, "Parsing is wrong");
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }*/

        /*2) Optional: nueiti į https://www.active.com/fitness/calculators/pace patikrinti, ar nubėgus 13km per 1val 5min vieno kilometro
         greitis yra 5min/km*/

       [OneTimeSetUp]
       public static void SetUp()
       {
           _driver = new ChromeDriver();
           _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           _driver.Manage().Window.Maximize();
           _driver.Url = "https://www.active.com/fitness/calculators/pace";
            /*WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Id("close-fixedban")).Displayed);
            IWebElement baner = driver.FindElement(By.Id("close-fixedban"));
            baner.Click();*/
       }

       [TestCase("1", "5", "13", "5", TestName = "1 h 5 min 13 km: pace 5 km/h")]

        public static void TestRunningPace(string hrs, string min, string distance, string expectedResult)
        {
            IWebElement hrsInputField = _driver.FindElement(By.Name("time_hours"));
            hrsInputField.Clear();
            hrsInputField.SendKeys(hrs);

            IWebElement minInputField = _driver.FindElement(By.Name("time_minutes"));
            minInputField.SendKeys(min);

            IWebElement distanceInputField = _driver.FindElement(By.Name("distance"));
            distanceInputField.SendKeys(distance);

            IWebElement distanceTypeSelectorButton = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span"));
            distanceTypeSelectorButton.Click();

            IWebElement distanceTypeSelector = _driver.FindElement(By.CssSelector
            ("#calculator-pace > form > div:nth-child(3) > div > span > ul > li.selectboxit-option.selectboxit-option-first.selectboxit-focus"));
            distanceTypeSelector.Click(); 

            IWebElement paceTypeSelectorButton = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(4) > div > select"));
            paceTypeSelectorButton.Click();

            IWebElement paceTypeSelector = _driver.FindElement(By.CssSelector
                ("#calculator-pace > form > div:nth-child(4) > div > select > option:nth-child(1)"));
            paceTypeSelector.Click();

            IWebElement calculateButton = _driver.FindElement(By.ClassName("btn btn-medium - yellow calculate - btn"));
            calculateButton.Click();

            IWebElement result = _driver.FindElement(By.Name("pace_minutes"));
            Assert.AreEqual(expectedResult, result.Text, "Result is incorrect");
       }

        [OneTimeTearDown]
        public static void TearDown()
        {
            _driver.Close();
        }
    }

}



