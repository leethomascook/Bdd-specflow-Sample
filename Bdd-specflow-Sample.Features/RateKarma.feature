Feature: Rate Karma
	In order Rate some ones karma
	As a user
	I want to let them know if they have been good or bad


Scenario: Rate the karma of someones action
	Given They have not been rated by me before
	When I submit a rating
	Then the result should be stored in the database
