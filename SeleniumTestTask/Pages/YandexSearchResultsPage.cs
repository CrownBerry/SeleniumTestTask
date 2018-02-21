using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestTask.Pages
{
	[Page("Yandex - search results")]
	public class YandexSearchResultsPage : BasePage
	{
		[FindsBy(How = How.CssSelector, Using = "li.serp-item h2 a")]
		private IList<IWebElement> searchResultsLinks;

		public YandexSearchResultsPage(Navigator navigator) : base(navigator)
		{
		}

		public void ClickFirstResultWith(string resultTitle)
		{
			searchResultsLinks
				.First(_ => _.Text.ToLowerInvariant().Contains(resultTitle.ToLowerInvariant()))
				.Click();
			Navigator.SwitchToSecond();
		}

		public void AssertResultsIsVisible()
		{
			Assert.True(searchResultsLinks.Any());
		}
	}
}