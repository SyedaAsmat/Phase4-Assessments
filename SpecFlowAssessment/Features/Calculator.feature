Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowAssessment/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 10
	When the two numbers are substracted
	Then the result should be 40

Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 10
	When the two numbers are multiplied
	Then the result should be 500

Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 10
	When the two numbers are divided
	Then the result should be 5