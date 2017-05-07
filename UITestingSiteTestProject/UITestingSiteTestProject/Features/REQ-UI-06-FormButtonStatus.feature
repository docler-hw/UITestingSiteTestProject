Feature: REQ-UI-06
	When I click on the Form button, it should turn to active status

@low
Scenario: FormButtonStatus - From Home page
	Given I have opened the Home page
	Then The status of Form button should be inactive
	When I clicked on the Form button
	Then The status of Form button should be active

@low
Scenario: FormButtonStatus - From Form page
	Given I have opened the Form page
	Then The status of Form button should be active
	When I clicked on the Form button
	Then The status of Form button should be active
