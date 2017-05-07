Feature: REQ-UI-03
	When I click on the Home button, I should get navigated to the Home page

@mytag
Scenario: HomeButton - From Home page
	Given I have opened the Home page
	And I clicked on the Home button
	Then I should get navigated to the Home Page

@mytag
Scenario: HomeButton - From Form page
	Given I have opened the Form page
	And I clicked on the Home button
	Then I should get navigated to the Home Page
