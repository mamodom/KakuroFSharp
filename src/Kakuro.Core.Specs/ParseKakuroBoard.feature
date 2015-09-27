Feature: Parse Kakuro Board
	In order to play kakuro
	As a kakuro lover
	I want to be able to open a kakuro board

Scenario: Parse Board
	Given this board named Kakuro exists
		#| A   | B   | C   | D   | E   |
		#| \   | 17\ | 11\ | 30\ | \   |
		#| \19 |     |     |     | \   |
		#| \15 |     |     |     | \17 |
		#| \   | \20 |     |     |     |
		#| \   | \21 |     |     |     |
	#When I parse the board named 'Kakuro1'
	#Then I should be able to see this board
	#	| A   | B   | C   | D   | E   |
	#	| \   | 17\ | 11\ | 30\ | \   |
	#	| \19 |     |     |     | \   |
	#	| \15 |     |     |     | \17 |
	#	| \   | \20 |     |     |     |
	#	| \   | \21 |     |     |     |