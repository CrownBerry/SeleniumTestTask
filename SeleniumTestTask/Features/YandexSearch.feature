Feature: Search Selenium in Yandex

@yandex
Scenario: Search Sleenium and open Wiki page
	Given I open yandex main page
	When I enter in search area "Selenium"
	And I press search button
	Then the result should be 120 on the screen
	When I click first link with "Wikipedia" in title
	Then Open wiki page about "Selenium"
