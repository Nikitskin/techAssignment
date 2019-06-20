Feature: LogInValidations

@SmokeTest
Scenario: Log out functionality
	Given I log in as 'dev' into application
	When I press log in link
	Then I should be navigated to login page
	And I see log in link

@SmokeTest
Scenario Outline: Invalid log in check
	Given I enter <userName> into UserName field
	And I enter <password> into  Password field
	When I press logIn button
	Then I see error with text 'Wrong credentials. You can do it, try again!'
	And I don't see profile link
	And I see log in link

	Examples: 
	| userName                    | password                                  |
	| 1                           | 1                                         |
	| ~!@#$%^&*()_+-=[];'\.,/{}:" | <>?`\| ~!@#$%^&*()_+-=[];'\.,/{}:"  <>?`\ |
	| -1A                         | -1A                                       |
	| SELECT * FROM users         | SELECT * FROM users                       |

@SmokeTest
Scenario Outline: Correct information in profile after log in
	Given I log in as <user> into application
	When I press log in link
	And Click Profile link
	Then I see 'Your super power: Debug a repellent factory storage.' in my profile

@SmokeTest
Scenario Outline: Correct information in Details after log in
	Given I log in as <user> into application
	When I press log in link
	And Click Details link
	Then I see 'Zuper Dooper Dev' as my name in details
	And I see 'zd.dev@wearewaes.com' as email in details