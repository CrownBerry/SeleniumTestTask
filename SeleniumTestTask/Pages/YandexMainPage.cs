using OpenQA.Selenium;

namespace SeleniumTestTask.Pages
{
	[Page("Yandex - main page")]
	public class YandexMainPage
	{
		private static string Uri = "www.ya.ru";
		private readonly IWebDriver _driver;

		public YandexMainPage(IWebDriver driver)
		{
			_driver = driver;
		}

		public void Open()
		{
			_driver.Navigate().GoToUrl(Uri);
		}
	}
}