// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;


[TestFixture]
public class InsuranceQuoteTestsCases
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        if (driver != null)
        {
            driver.Quit();
            driver.Dispose();
        }
    }
    [Test]
    public void InsuranceQuote01_ValidData_Age25_Experience3_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$4500"));
        }
    }

    [Test]
    public void InsuranceQuote02_ValidData_Age25_Experience3_Accidents2()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$4500"));
        }
    }

    [Test]
    public void InsuranceQuote03_ValidData_Age35_Experience10_Accidents4()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }

    [Test]
    public void InsuranceQuote04_InvalidPhoneNumber_Age27_Experience3_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("1234565455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("phone-error")).Text;
            Assert.That(value, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
        }
    }

    [Test]
    public void InsuranceQuote05_InvalidEmailId_Age28_Experience3_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("email-error")).Text;
            Assert.That(value, Is.EqualTo("Must be a valid email address"));
        }
    }

    [Test]
    public void InsuranceQuote06_InvalidPostalCode_Age35_Experience17_Accidents1()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J DY3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("postalCode-error")).Text;
            Assert.That(value, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
        }
    }

    [Test]
    public void InsuranceQuote07_OmittedAge_Experience5_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("9");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age-error")).Text;
            Assert.That(value, Is.EqualTo("Age (>=16) is required"));
        }
    }

    [Test]
    public void InsuranceQuote08_OmittedAccidents_Age37_Experience8()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("accidents-error")).Text;
            Assert.That(value, Is.EqualTo("Number of accidents is required"));
        }
    }

    [Test]
    public void InsuranceQuote09_OmittedExperience_Age45_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("experience-error")).Text;
            Assert.That(value, Is.EqualTo("Years of experience is required"));
        }
    }

    [Test]
    public void InsuranceQuote10_InvalidAge_Experience3_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J DY3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("13");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age-error")).Text;
            Assert.That(value, Is.EqualTo("Please enter a value greater than or equal to 16."));
        }
    }

    [Test]
    public void InsuranceQuote11_OmittedFirstName_Age25_Experience4_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("Waterloo");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 2Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("4");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("firstName-error")).Text;
            Assert.That(value, Is.EqualTo("First Name is required"));
        }
    }

    [Test]
    public void InsuranceQuote12_ValidData_Age16_Experience0_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("16");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("0");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$6000"));
        }
    }

    [Test]
    public void InsuranceQuote13_ValidData_Age60_Experience23_Accidents1()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("60");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("23");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2190"));
        }
    }

    [Test]
    public void InsuranceQuote14_ValidData_Age28_Experience10_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("King street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 4Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$3000"));
        }
    }

    [Test]
    public void InsuranceQuote15_OmittedAddress_Age35_Experience10_Accidents0()
    {
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 877);
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Hitesh");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Kumra");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2J 2Y3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-456-5455");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("hiteshkumra46@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("address-error")).Text;
            Assert.That(value, Is.EqualTo("Address is required"));
        }
    }
}
