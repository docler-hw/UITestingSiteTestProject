Feature: REQ-UI-02
	The Company Logo should be visible on every site

@mytag
Scenario: Logo - Home page test
	Given I have opened the Home page
	Then the company logo should be displayed

@mytag
Scenario: Logo - Form page test
	Given I have opened the Form page
	Then the company logo should be displayed

@mytag
Scenario: Logo - Hello page test
	Given I have opened the Hello page
	Then the company logo should be displayed
