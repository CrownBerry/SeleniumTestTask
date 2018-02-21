using System;
using System.Linq;
using System.Reflection;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestTask.Pages;
using TechTalk.SpecFlow;

namespace SeleniumTestTask
{
	[Binding]
	public class SetupSteps
	{
		private IWebDriver _driver;
		private readonly IObjectContainer _objectContainer;

		public SetupSteps(IObjectContainer objectContainer)
		{
			_objectContainer = objectContainer;
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			InitializeDriver();
			_objectContainer.RegisterInstanceAs(_driver);
			RegisterPages();
		}

		[AfterScenario]
		public void AfterScenario()
		{
			_driver.Dispose();
		}

		private void RegisterPages()
		{
			var pagesAssembly = Assembly.GetAssembly(typeof(YandexMainPage));
			foreach (var type in pagesAssembly.GetTypes())
				if (type.GetCustomAttributes(true).Any(_ => _.GetType() == typeof(Page)))
				{
					var pageName = type.GetCustomAttributes(true).First(_ => _.GetType() == typeof(Page)).ToString().Trim()
					                   .ToLowerInvariant();

					if (!string.IsNullOrEmpty(pageName))
					{
						_objectContainer.RegisterInstanceAs(
							Activator.CreateInstance(type, _driver), pageName);
					}
					else
					{
						_objectContainer.RegisterInstanceAs(
							Activator.CreateInstance(type, _driver));
					}
				}
		}

		private void InitializeDriver()
		{
			var options = new ChromeOptions();
			options.AddUserProfilePreference("pageLoadStrategy", "normal");
			options.AddUserProfilePreference("disable-popup-blocking", "true");
			options.AddUserProfilePreference("intl.accept_languages", "ru");
			_driver = new ChromeDriver(options);
			_driver.Manage().Window.Maximize();
		}
	}
}