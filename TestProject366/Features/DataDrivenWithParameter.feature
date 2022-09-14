Feature: DataDrivenWithParameter
In order to benefit from the website, I need to register first	

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "http://demo.automationtesting.in/Register.html"
	And I enter my first name"Owusu"
	And I enter my last name "Siaw"
	And I enter my email address"owusu.siaw@gmail.com"
	And I enter my phone number"0233556677"
	And I click on my gender
	And I select country from dropdown
	When I click on submit button
	#Then I can register successfully