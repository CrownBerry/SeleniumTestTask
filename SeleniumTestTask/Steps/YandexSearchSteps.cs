using TechTalk.SpecFlow;

namespace SeleniumTestTask.Steps
{
	[Binding, Scope(Tag = "yandex")]
	public class YandexSearchSteps
	{
		[Given(@"I open yandex main page")]
		public void GivenIOpenYandexMainPage()
		{
			ScenarioContext.Current.Pending();
		}

		[When(@"I enter in search area ""(.*)""")]
		public void WhenIEnterInSearchArea(string selenium0)
		{
			ScenarioContext.Current.Pending();
		}

		[When(@"I press search button")]
		public void WhenIPressSearchButton()
		{
			ScenarioContext.Current.Pending();
		}

		[When(@"I click first link with ""(.*)"" in title")]
		public void WhenIClickFirstLinkWithInTitle(string wikipedia0)
		{
			ScenarioContext.Current.Pending();
		}

		[Then(@"the result should be (.*) on the screen")]
		public void ThenTheResultShouldBeOnTheScreen(int p0)
		{
			ScenarioContext.Current.Pending();
		}

		[Then(@"Open wiki page about ""(.*)""")]
		public void ThenOpenWikiPageAbout(string selenium0)
		{
			ScenarioContext.Current.Pending();
		}
	}
}