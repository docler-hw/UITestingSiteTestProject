Feature: REQ-UI-04
	When I click on the Home button, it should turn to active status

@low
Scenario: HomeButtonStatus - From Home page
	Given I have opened the Home page
	Then The status of Home button should be active
	When I clicked on the Home button
	Then The status of Home button should be active

@low
Scenario: HomeButtonStatus - From Form page
	Given I have opened the Form page
	Then The status of Home button should be inactive
	When I clicked on the Home button
	Then The status of Home button should be active
