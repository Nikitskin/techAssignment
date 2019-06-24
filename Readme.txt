Requirements:
You should have dotnet core 2.2 installed.

To run test:
You can trigger Runbatch.cmd file.
Cmd file will, get nuget packages, build solution with dotnet build command and then will trigger nunit runner which will generate reports.


To get test result:
a) To get results find Test results folder inside TechAssigment\TestResults .trx file
b) To get html result file you should access TechAssigment\WAES.UI.Test.Scenarios\bin\Debug\netcoreapp2.1\extent\index.html

BrowserTypes:
If you want to change chrome to headless chrome then you need to go TechAssigment\WAES.UI.Test.Scenarios\Settings.Designer.cs 
and change value of "browserType" variable
You need to change [global::System.Configuration.DefaultSettingValueAttribute("HeadlessChrome")]

Currently supported variables -
Chrome
HeadlessChrome
