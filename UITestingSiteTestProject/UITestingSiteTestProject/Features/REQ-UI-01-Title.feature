﻿Feature: REQ-UI-01
	The Title should be "UI Testing Site" on every site

@moderate
Scenario: Title - Home page test
	Given I have opened the Home page
	Then the title should be UI Testing Site

@moderate
Scenario: Title - Form page test
	Given I have opened the Form page
	Then the title should be UI Testing Site

@moderate
Scenario: Title - Hello page test
	Given I have opened the Hello page
	Then the title should be UI Testing Site