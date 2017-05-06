Feature: Navigation
	On every page the title should be UI Testing Site

@mytag
Scenario: UI Test site title
	Given I have opened the home page
	Then the title should be UI Testing Site
