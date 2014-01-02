Feature: CreateAGame
	In order to play a game
	As the organiser
	I want to be able to create a game

@mytag
Scenario: Create a game
Given I have entered 31/1/14 into the date field
	And I have entered 5pm into the time field 
	When I press Create
	Then a game of basketball should be created on 31/1/14 at 5pm
