Feature: ZeroLoginTest
	as a User I can login

@Browser: Chrome
@Browser: Firefox
@Smoketest
@Logintest

Scenario: Correct login
	Given I am at zerobank login page
	When I enter correct login
	And I enter correct password
	And I press Sign in
	Then I am logged in