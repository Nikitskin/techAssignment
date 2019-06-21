Feature: SignUpValidation

@SmokeTest
Scenario: SignUp Validation of Profile
	Given I create new user with 'Tester', 'Password', 'Name', 'email@email.com' and random date
	When I click Profile link
	Then I see 'Your super power: You have no super powers yet. =[.' in my profile

@SmokeTest
Scenario Outline: SignUp Validation of Details
	Given I create new user with 'Tester', 'Password', 'Name', 'email@email.com' and random date
	When Click Details link
	Then I see '<name>' and '<email>' in details page

	Examples: 
	| name   | email            |
	| Name   | email@email.com  |

@SmokeTest
Scenario: SignUp Validation of log out
	Given I create new user with 'Tester', 'Password', 'Name', 'email@email.com' and random date
	When I press log out link
	Then I should be on to login page

@SmokeTest
Scenario Outline: Incorrect input validation on SignUp 
	Given I create new user with '<input>', '<input>', '<input>', '<email>' and random date
	Then I see invalidity state of input fields for <input> and <email>

	Examples: 
	| input                      | email                                           |
	| ~!@#$%^&*()_+-=[];'\.,/{}: | <>?`\~!@#$%^&*()_+-=[];'\.,/{}:"<>?`\@email.com |
	| !~aaa                      | test test@email.com                             |
	| SELECT * FROM users        | SELECT * FROM users                             |
	|                            | test@emailcom                                   |

@SmokeTest
Scenario: Date validation on signup
	Given I create user with configured 'Tester', 'Password', 'Name', 'email@email.com' and '01/31/2019'
	Then I should be on signup page
