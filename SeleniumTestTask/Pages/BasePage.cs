using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestTask.Pages
{
	public abstract class BasePage
	{
		protected readonly Navigator Navigator;

		protected BasePage(Navigator navigator)
		{
			Navigator = navigator;
			InitPage();
		}

		private void InitPage()
		{
			PageFactory.InitElements(Navigator.Browse(), this);
		}
	}
}