using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestTask.Pages
{
	[Page("Wiki - article page")]
	public class WikiArticlePage : BasePage
	{
		[FindsBy(How = How.CssSelector, Using = "#firstHeading")]
		private IWebElement header;
		
		public WikiArticlePage(Navigator navigator) : base(navigator)
		{
		}

		public void AssertItsArticleAbout(string articleTitle)
		{
			Assert.True(header.Text.Contains(articleTitle));
		}
	}
}