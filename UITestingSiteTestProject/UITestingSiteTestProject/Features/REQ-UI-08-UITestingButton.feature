Feature: REQ-UI-08
	When I click on the UI Testing button, I should get navigated to the Home pagepage

@high
Scenario: UITestingButton - From Home page
	Given I have opened the Home page
	And I clicked on the UI Testing button
	Then I should get navigated to the Home Page

@high
Scenario: UITestingButton - From Form page
	Given I have opened the Form page
	And I clicked on the UI Testing button
	Then I should get navigated to the Home Page
