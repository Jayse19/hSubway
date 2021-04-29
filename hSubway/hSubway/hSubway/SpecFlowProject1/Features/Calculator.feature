Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Three slices of white are left
	Given There is only 3 slices of white left
	And a PBJ on white is ordered
	Then Sell 1 PBJ on white sandwich 
	And 1 slice of white left

Scenario: One slice of white left
	Given There is only 1 slice of white left
	And a PBJ is ordered
	Then Cannot sell PBJ on white sandwich

Scenario: When a PBJ on white is ordered
	Given white costs 2.00
	And PBJ costs 0.75
	And when a PBJ on white is ordered
	Then the cost should be 2.75

Scenario: When a PBJ on wheat is ordered
	Given white costs 2.25
	And PBJ costs 0.75
	And when a PBJ on wheat is ordered
	Then the cost should be 3.00

Scenario: When a PBJ on rye is ordered
	Given rye costs 2.50
	And PBJ costs 0.75
	And when a PBJ on rye is ordered
	Then the cost should be 3.25

Scenario: When a shredded chicken on white is ordered
	Given white costs 2.00
	And  shredded chicken costs 2.00
	And when a shredded chicken on white is ordered
	Then the cost should be 4.00

Scenario: When a shredded chicken on wheat is ordered
	Given wheat costs 2.25
	And shredded chicken costs 2.00
	And when a shredded chicken on wheat is ordered
	Then the cost should be 4.25

Scenario: When a shredded chicken on rye is ordered
	Given rye costs 2.50
	And shredded chicken costs 2.00
	And when a shredded chicken on rye is ordered
	Then the cost should be 4.50

Scenario: When a shredded chicken on white with cheese, cheese, and cheese is ordered
	Given white costs 2.00
	And shredded chicken costs 2.00
	And cheese costs 0.75
	And cheese costs 0.75
	And cheese costs 0.75
	Then the cost should be 6.25
	
Scenario: When a shredded chicken on rye with cheese, lettuce, lettuce, lettuce, tomato, and bacon is ordered
	Given rye costs 2.50
	And cheese costs 0.75
	And lettuce costs 0.25
	And lettuce costs 0.25
	And lettuce costs 0.25
	And tomato costs 0.25
	And bacon costs 0.75
	Then the cost should be 6.50

Scenario: When a BLT on rye is ordered with cheese, bacon, bacon, bacon, and bacon
	Given rye costs 2.50
	And cheese costs 0.75
	And bacon costs 0.75
	And bacon costs 0.75
	And bacon costs 0.75
	And bacon costs 0.75
	Then the cost should be 8.75