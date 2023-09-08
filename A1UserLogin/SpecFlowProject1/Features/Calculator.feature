Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Valid
Scenario: Login Successfull
	Given the UserName is "Jhon"
	And the Password is "Jhon123"
	When TryLogin
	Then the result should be "Login Successful"
@Invalid
Scenario: Login Unsuccessfull
	Given the UserName is "InvalidUsername"
	And the Password is "InvalidUsername"
	When TryLogin
	Then the result should be "Login Failed"
@NullVal
Scenario: Login Invalid
	Given the UserName is "null"
	And the Password is "null"
	When TryLogin
	Then the result should be "Provide Username and Password"