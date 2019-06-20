Feature: SignUpValidation

@SmokeTest
Scenario: SignUp Validation of Profile
	Given I enter 'Tester' in username field
	And I enter 'Tester' in password field
	And I enter 'Name' in name field
	And I enter 'email@email.com' in email field
	And I select random date of birth
	When I click submit button
	And I click Profile link
	Then I see 'Your super power: You have no super powers yet. =[.' in my profile

@SmokeTest
Scenario: SignUp Validation of Details
	Given I enter 'Tester' in username field
	And I enter 'Tester' in password field
	And I enter 'Name' in name field
	And I enter 'Tester@email.com' in email field
	And I select random date of birth
	When I click submit button
	And Click Details link
	Then I see 'Tester' as my name in details
	And I see 'Tester@email.com' as email in details

@SmokeTest
Scenario: SignUp Validation of log out
	Given I enter 'Tester' in username field
	And I enter 'Tester' in password field
	And I enter 'Name' in name field
	And I enter 'Tester@email.com' in email field
	And I select random date of birth
	When I click submit button
	And Click log out link
	Then I should be navigated to login page
	And I see log in link

@SmokeTest
Scenario Outline: Incorrect input validation on SignUp 
	Given I enter <input> in username field
	And I enter <input> in password field
	And I enter <input> in name field
	And I enter <email> in email field
	And I select random date of birth
	When I click submit button
	And Click Details link
	Then I see 'Tester' as my name in details
	And I see 'Tester@email.com' as email in details

	Examples: 
	| input                       | email                    |
	| 1                           | 1                        |
	| ~!@#$%^&*()_+-=[];'\.,/{}:" | _!@#$%^&*()_~1@email.com |
	| !~111                       | test test@email.com      |
	| SELECT * FROM users         | SELECT * FROM users      |
	|                             | test@emailcom            |

Scenario Outline: Date validation on signup
	Given I enter 'Tester' in username field
	And I enter 'Tester' in password field
	And I enter 'Name' in name field
	And I enter 'email@email.com' in email field
	And I select '31' as day of birth
	And I select 'January' as day of birth
	And i select '2019' as year of birth
	When I click submit button
	And I click Profile link
	Then I see 'Your super power: You have no super powers yet. =[.' in my profile
