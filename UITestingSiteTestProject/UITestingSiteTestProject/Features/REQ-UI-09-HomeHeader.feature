Feature: REQ-UI-09
	The following text should be visible on the Home page in <h1> tag:
	"Welcome to the Docler Holding QA Department"

@mytag
Scenario: HomeHeader - From Home Page by Home and UI Testing button
	Given I have opened the Home page
	Then Header should be visible with "Welcome to the Docler Holding QA Department"
	When I clicked on the Home button
	Then Header should be visible with "Welcome to the Docler Holding QA Department"
	When I clicked on the UI Testing button
	Then Header should be visible with "Welcome to the Docler Holding QA Department"

Scenario: HomeHeader - From Form Page by Home button
	Given I have opened the Form page
	When I clicked on the Home button
	Then Header should be visible with "Welcome to the Docler Holding QA Department"

@mytag
Scenario: HomeHeader - From Form page by UI Testing button
	Given I have opened the Form page
	When I clicked on the UI Testing button
	Then Header should be visible with "Welcome to the Docler Holding QA Department"
