Feature: REQ-UI-05
	When I click on the Form button, I should get navigated to the Form page

@mytag
Scenario: FormButton - From Home page
	Given I have opened the Home page
	And I clicked on the Form button
	Then I should get navigated to the Form Page

@mytag
Scenario: FormButton - From Form page
	Given I have opened the Form page
	And I clicked on the Form button
	Then I should get navigated to the Form Page
