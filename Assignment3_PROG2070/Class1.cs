﻿//Prince Prajapati


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
public class DefaultSuiteTest
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
        driver.Quit();
    }

    //Test 1 - Validate Accident0
    [Test]
    public void test1validAccident0()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1T6");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("444-333-1478");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("PP@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            //Assert
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$2500"));
        }
    }

    //Test 2 - Validate Accident4
    [Test]
    public void test2validAccident4()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2E 1Y7");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("777-564-7896");
        driver.FindElement(By.Id("email")).SendKeys("pr@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            //Assert
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }

    //Test 3 - Validate Accident2
    [Test]
    public void test3validAccident2()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(788, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("n2w 7y6");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("777-254-9874");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("pr@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            //Assert
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$1350"));
        }
    }

    //Test 4 - Invalid Phone Number
    [Test]
    public void test4invalidphoneNumber()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("Fairview Park");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("147852963");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("pp@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("0");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        var elements = driver.FindElements(By.Id("phone-error"));
        Assert.True(elements.Count > 0);
    }

    //Test 5 - Invalid Email Address
    [Test]
    public void test5invalidemailAddress()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("prajapati");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).SendKeys("111-222-3336");
        driver.FindElement(By.Id("email")).SendKeys("ppgmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
    }

    //Test 6 - Invalid Postal Code
    [Test]
    public void test6invalidpostalCode()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(788, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajaapti");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("n2a1r6");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("111-222-9876");
        driver.FindElement(By.Id("email")).SendKeys("pp@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
    }

    //Test 7 - Age Omit test
    [Test]
    public void test7ageOmit()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("28- Thaler");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).SendKeys("111-555-9875");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("Prince@gmail.com");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
    }

    //Test 8 - Fault Accident Number Omit test
    [Test]
    public void test8faultAccidentOmit()
    {

        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(788, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("789-456-1237");
        driver.FindElement(By.Id("email")).SendKeys("P");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("PRINCYO@GMAIL.COM");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
    }

    //Test 9 - Driving Experience Omit
    [Test]
    public void test9drivingExperienceOmit()
    {

        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(788, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("123-459-7896");
        driver.FindElement(By.Id("email")).SendKeys("Prince29@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
    }

    //Test 10 - First name Omit
    [Test]
    public void test10firstNameOmit()
    {

        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(788, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).SendKeys("789-456-1234");
        driver.FindElement(By.Id("email")).SendKeys("Prince@yahoo.com");
        driver.FindElement(By.Id("age")).SendKeys("20");
        driver.FindElement(By.Id("experience")).SendKeys("1");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("firstName-error")).Text, Is.EqualTo("First Name is required"));
    }

    //test 11 - Last Name Omit
    [Test]
    public void test11lastNameOmit()
    {

        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(788, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).SendKeys("789-456-7891");
        driver.FindElement(By.Id("email")).SendKeys("Prince@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("22");
        driver.FindElement(By.Id("experience")).SendKeys("2");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        var elements = driver.FindElements(By.Id("lastName-error"));
        Assert.True(elements.Count > 0);
    }

    //Test 12 - Address Omit test
    [Test]
    public void test12addressOmit()
    {

        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(788, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N1W 6T5");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("789-456-1234");
        driver.FindElement(By.Id("email")).SendKeys("Prince@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("20");
        driver.FindElement(By.Id("experience")).SendKeys("1");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {

            //Assert
            var elements = driver.FindElements(By.Id("address-errror"));
            Assert.True(elements.Count == 0);
        }
    }

    //Test 13 - Age Exceptions test
    [Test]
    public void test13AgeException()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("280 Thaler");
        driver.FindElement(By.Id("city")).SendKeys("Kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).SendKeys("789-456-7896");
        driver.FindElement(By.Id("email")).SendKeys("Prince@yahoo.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("20");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).SendKeys("10");
        driver.FindElement(By.Id("btnSubmit")).Click();
        driver.FindElement(By.Id("finalQuote")).Click();
        {
            //Assert
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
        }
    }

    //Test 14 - List Quotes
    [Test]
    public void test14listQuotes()
    {

        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Peince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("Kitchener");
        driver.FindElement(By.Id("city")).SendKeys("kitchener");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2A 1R6");
        driver.FindElement(By.Id("phone")).SendKeys("123-456-7896");
        driver.FindElement(By.Id("email")).SendKeys("Princyo@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("20");
        driver.FindElement(By.Id("experience")).SendKeys("1");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        driver.FindElement(By.LinkText("List of Entered Quotes")).Click();
    }
    
    //Test 15 - Phine number omit test
    [Test]
    public void test15phoneNumberOmit()
    {
        //Act
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(792, 816);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Prince");
        driver.FindElement(By.Id("lastName")).SendKeys("Prajapati");
        driver.FindElement(By.Id("address")).SendKeys("Kitchenr");
        driver.FindElement(By.Id("city")).SendKeys("Waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2a 1r6");
        driver.FindElement(By.Id("email")).SendKeys("Pp@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("20");
        driver.FindElement(By.Id("experience")).SendKeys("1");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number is required"));
    }
}
