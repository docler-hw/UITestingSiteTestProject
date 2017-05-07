# UITestingSiteTestProject
This repository contains a UI test project to test UITestingSite

Technologies used for the project:

 * Windows 10 Operation System
 * Visual Studio 2017 Community Edition with the latest .NET versions
 * The test cases written in Gherkin, C#, Specflow, NUnit, Selenium (Chrome WebDriver)

### Steps to execute the test cases:

1. Checkout the content of this repository
2. Open the solution file in Visual Studio: `UITestingSiteTestProject/UITestingSiteTestProject.sln`
3. Build the project by `Ctrl+Shift+B`
4. Click on 'Run all' button in the Test Explorer view

If you would like to execute the test cases from Power Shell command line please execute the following steps:
1. Go into the main folder of the repository
2. Build the solution file
3. Execute the test cases by the following command: `C:\Development\Projects\UITestingSiteTestProject\UITestingSiteTestProject\packages\NUnit.ConsoleRunner.3.6.1\tools\nunit3-console.exe C:\Development\Projects\UITestingSiteTestProject\UITestingSiteTestProject\UITestingSiteTestProject\bin\Debug\UITestingSiteTestProject.dll`

### Parallel test execution:
Note that the test cases can be executed parallel. The default number of threads is equal to the number of processors or 2, whichever is greater. (Tested by 4 threads.)

### Execute the test cases by priority tags:
Note that the test cases tagged by their priority. Therefore the different group of test cases can be executed by using the following tags:
* high
* moderate
* low

You can use them by extending the test case execution command with the `--where "cat=high"` arguments