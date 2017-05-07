Feature: REQ-UI-11
	On the Form page, a form should be visible with one input box and one submit button
	
@high
Scenario: HomeHeader - From Form Page by Home button
	Given I have opened the Form page
	Then I should see one input box
	And I should see one submit button

@high
Scenario: HomeParagraph - From Home Page by Home and UI Testing button
	Given I have opened the Home page
	And I clicked on the Form button
	Then I should see one input box
	And I should see one submit button
	When I clicked on the Form button
	Then I should see one input box
	And I should see one submit button
	