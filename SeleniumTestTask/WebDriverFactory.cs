using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestTask
{
	public static class WebDriverFactory
	{
		public static IWebDriver CreateChromeDriver()
		{
			var options = new ChromeOptions();
			options.AddUserProfilePreference("pageLoadStrategy", "normal");
			var driver = new ChromeDriver(options);
			driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
			return driver;
		}
	}
}