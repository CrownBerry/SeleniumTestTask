using System.Threading;
using SeleniumTestTask.Pages;
using TechTalk.SpecFlow;

namespace SeleniumTestTask.Steps
{
	[Binding]
	public class YandexSearchSteps
	{
		private readonly YandexMainPage _yandexMainPage;
		private readonly YandexSearchResultsPage _yandexSearchResultsPage;
		private readonly WikiArticlePage _wikiArticlePage;

		public YandexSearchSteps(YandexMainPage yandexMainPage, YandexSearchResultsPage yandexSearchResultsPage, WikiArticlePage wikiArticlePage)
		{
			_yandexMainPage = yandexMainPage;
			_yandexSearchResultsPage = yandexSearchResultsPage;
			_wikiArticlePage = wikiArticlePage;
		}

		[Given(@"I open yandex main page")]
		public void GivenIOpenYandexMainPage()
		{
			_yandexMainPage.Open();
		}

		[When(@"I enter in search area ""(.*)""")]
		public void WhenIEnterInSearchArea(string searchText)
		{
			_yandexMainPage.EnterInSeacrhField(searchText);
		}

		[When(@"I press search button")]
		public void WhenIPressSearchButton()
		{
			_yandexMainPage.Search();
		}

		[When(@"I click first link with ""(.*)"" in title")]
		public void WhenIClickFirstLinkWithInTitle(string resultTitle)
		{
			_yandexSearchResultsPage.ClickFirstResultWith(resultTitle);
		}

		[Then(@"the result should be on the screen")]
		public void ThenTheResultShouldBeOnTheScreen()
		{
			_yandexSearchResultsPage.AssertResultsIsVisible();
		}

		[Then(@"Open wiki page about ""(.*)""")]
		public void ThenOpenWikiPageAbout(string articleTitle)
		{
			_wikiArticlePage.AssertItsArticleAbout(articleTitle);
		}
	}
}