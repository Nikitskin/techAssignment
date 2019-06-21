Feature: LogInValidations

Scenario: Log out functionality
	Given I log in as 'dev' into application
	When I press log out link
	Then I should be on to login page

Scenario Outline: Invalid log in check
	Given I login as <userName> and <password> on login page
	Then I see error with text 'Wrong credentials. You can do it, try again!'
	And I should be on to login page

	Examples: 
	| userName                    | password                                 |
	| "1"                         | "1"                                      |
	| ~!@#$%^&*()_+-=[];'\.,/{}:  | <>?`\~!@#$%^&*()_+-=[];'\.,/{}:"  <>?`\  |
	| "-1A"                       | "-1A"                                    |
	| "SELECT * FROM users"       | "SELECT * FROM users"                    |

Scenario Outline: Correct information in profile after log in
	Given I log in as '<user>' into application
	When Click Profile link
	Then I see '<profileText>' in my profile

	Examples: 
	| user   | profileText                                          |
	| dev    | Your super power: Debug a repellent factory storage. |
	| admin  | Your super power: Change the course of a waterfall.  |
	| tester | Your super power: Voltage AND Current.               |

Scenario Outline: Correct information in Details after log in
	Given I log in as '<user>' into application
	When Click Details link
	Then I see '<name>' and '<email>' in details page

	Examples: 
	| user   | name                | email                   |
	| dev    | Al Skept-Cal Tester | as.tester@wearewaes.com |
	| admin  | Amazing Admin       | a.admin@wearewaes.com   |
	| tester | Zuper Dooper Dev    | zd.dev@wearewaes.com    |
