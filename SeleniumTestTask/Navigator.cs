using System.Linq.Expressions;
using OpenQA.Selenium;

namespace SeleniumTestTask
{
	public class Navigator
	{
		private IWebDriver _driver;

		public Navigator(IWebDriver driver)
		{
			_driver = driver;
		}

		public void GoTo(string url)
		{
			_driver.Navigate().GoToUrl(url);
		}

		public IWebDriver Browse()
		{
			return _driver;
		}

		public string Title()
		{
			return _driver.Title;
		}

		public void SwitchToSecond()
		{
			_driver.SwitchTo().Window(_driver.WindowHandles[0]).Close();
			_driver.SwitchTo().Window(_driver.WindowHandles[0]);
		}
	}
}