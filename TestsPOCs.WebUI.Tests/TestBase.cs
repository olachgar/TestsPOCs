using Microsoft.VisualStudio.TestPlatform.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestsPOCs.WebUI.Tests
{
    public class TestBase : IDisposable
    {
        protected readonly IWebDriver webDriver;

        public TestBase()
        {
            webDriver = new ChromeDriver();
        }

        public void Dispose()
        {
            webDriver.Close();
        }
    }
}
