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
		private Navigator _navigator;
		private readonly IObjectContainer objectContainer;

		public SetupSteps(IObjectContainer objectContainer)
		{
			this.objectContainer = objectContainer;
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			_driver = WebDriverFactory.CreateChromeDriver();
			_navigator = new Navigator(_driver);
			objectContainer.RegisterInstanceAs(_navigator);
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
						objectContainer.RegisterInstanceAs(
							Activator.CreateInstance(type, _navigator), pageName);
					}
					else
					{
						objectContainer.RegisterInstanceAs(
							Activator.CreateInstance(type, _navigator));
					}
				}
		}


	}
}