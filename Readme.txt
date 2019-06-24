Requirements:
You should have dotnet core 2.2 installed.

To run test:
You can trigger Runbatch.cmd file.
Cmd file will, get nuget packages, build solution with dotnet build command and then will trigger nunit runner which will generate reports.


To get test result:
To get results find Test results folder inside TechAssigment\TestResults

BrowserTypes:
If you want to change chrome to headless chrome then you need to go TechAssigment\WAES.UI.Test.Scenarios\Settings.settings and change value of "browserType" variable

Currently supported variables -
Chrome
HeadlessChrome
