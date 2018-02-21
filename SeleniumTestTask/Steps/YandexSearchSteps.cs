using SeleniumTestTask.Pages;
using TechTalk.SpecFlow;

namespace SeleniumTestTask.Steps
{
	[Binding, Scope(Tag = "yandex")]
	public class YandexSearchSteps
	{
		private readonly YandexMainPage _yandexMainPage;

		public YandexSearchSteps(YandexMainPage yandexMainPage)
		{
			_yandexMainPage = yandexMainPage;
		}

		[Given(@"I open yandex main page")]
		public void GivenIOpenYandexMainPage()
		{
			_yandexMainPage.Open();
		}

		[When(@"I enter in search area ""(.*)""")]
		public void WhenIEnterInSearchArea(string selenium0)
		{
		}

		[When(@"I press search button")]
		public void WhenIPressSearchButton()
		{
		}

		[When(@"I click first link with ""(.*)"" in title")]
		public void WhenIClickFirstLinkWithInTitle(string wikipedia0)
		{
		}

		[Then(@"the result should be (.*) on the screen")]
		public void ThenTheResultShouldBeOnTheScreen(int p0)
		{
		}

		[Then(@"Open wiki page about ""(.*)""")]
		public void ThenOpenWikiPageAbout(string selenium0)
		{
		}
	}
}