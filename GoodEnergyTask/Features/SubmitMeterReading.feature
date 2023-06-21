Feature: SubmitMeterReading

As a Customer of good energy
I want to be able to submit my meter reading online.


@tag1
Scenario: Valid Submission of Meter Reading
	Given I navigate to good energy website "https://www.goodenergy.co.uk/meter-reading/"
	And I accept all cookies
	And I click on Electricity
	And I tick the box for first meter reading
	When I click on Next
	Then the about you page should be displayed
	And I enter my name "Sam Smith"
	And I enter my email address "demo@test.com"
	And I enter my postcode "SE1 4JL"
	When I click on Next
	Then the electricity page should be displayed 
	And I enter the account number "12345678"
	And I enter meter serial number "rtyhgtfdresdfbh"
	And I enter date of reading
	And I enter meter reading "12345"
	When I click on Submit
	Then the submission should be made successfully

@tag1
	Scenario: Check If User Can Submit reading If Postcode is left blank
	Given I navigate to good energy website "https://www.goodenergy.co.uk/meter-reading/"
	And I accept all cookies
	And I click on Electricity
	And I tick the box for first meter reading
	When I click on Next
	Then the about you page should be displayed
	And I enter my name "Sam Smith"
	And I enter my email address "demo@test.com"
	And I enter my postcode ""
	When I click on Next
	Then a message should appear on the screen to please enter your postcode