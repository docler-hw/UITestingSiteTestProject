Feature: REQ-UI-10
	The following text should be visible on the Home page in <p> tag:
	"This site is dedicated to perform some exercises and demonstrate automated web testing"

@low
Scenario: HomeParagraph - From Home Page by Home and UI Testing button
	Given I have opened the Home page
	Then Text should be visible with the purpose of the site
	When I clicked on the Home button
	Then Text should be visible with the purpose of the site
	When I clicked on the UI Testing button
	Then Text should be visible with the purpose of the site
	
@low
Scenario: HomeHeader - From Form Page by Home button
	Given I have opened the Form page
	When I clicked on the Home button
	Then Text should be visible with the purpose of the site

@low
Scenario: HomeHeader - From Form page by UI Testing button
	Given I have opened the Form page
	When I clicked on the UI Testing button
	Then Text should be visible with the purpose of the site
