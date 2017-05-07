Feature: REQ-UI-07
	When I click on the Error button, I should get a 404 HTTP response code

@high
Scenario: ErrorButton - From Home page
	Given I have opened the Home page
	When I clicked on the Error button
	Then Error 404 status should return

@high
Scenario: ErrorButton - From Form page
	Given I have opened the Form page
	When I clicked on the Error button
	Then Error 404 status should return
