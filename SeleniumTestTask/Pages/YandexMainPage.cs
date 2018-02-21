using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestTask.Pages
{
	[Page("Yandex - main page")]
	public class YandexMainPage : BasePage
	{
		private const string Url = "http://www.ya.ru/";

		[FindsBy(How = How.CssSelector, Using = "#text")]
		private IWebElement searchField;

		[FindsBy(How = How.CssSelector, Using = "button[role=button]")]
		private IWebElement searchButton;

		public YandexMainPage(Navigator navigator) : base(navigator)
		{
		}

		public void Open()
		{
			Navigator.GoTo(Url);
		}

		public void EnterInSeacrhField(string searchText)
		{
			searchField.SendKeys(searchText);
		}

		public void Search()
		{
			searchButton.Click();
		}
	}
}