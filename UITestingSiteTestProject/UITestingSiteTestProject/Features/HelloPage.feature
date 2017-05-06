Feature: HelloPage
	On the Form page, if you type <value>; 
	the input field and submit the form, 
	you should get redirect to the
	Hello page, and the following text should appear: <result>

@mytag
Scenario Outline: Reach Hello page
	Given I have opened the home page
	And I have navigated to the Form page
	When I enter <Name> to the form
	And I click on the Go button
	Then the Hello page should welcome <Name>
Examples: 
	| Name    |
	| John    |
	| Sophia  |
	| Charlie |
	| Emily   |
