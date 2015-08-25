Feature: PrimitiveTypes
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Serializer a String
	Given the string 'test' 
	When it is serialized
	Then the result should be """test"""