First, create the application (e.g., Calculator) to be tested. And create the modules (e.g., Add, Divide, etc.) to that project.
Second, create testing modules to test the application.
Steps to test methods (units) in CalculatorController class
	1. Add a separate testing project (e.g., CalculatorTest) using the xUnit template to the solution.
	2. Add the project refernce to Calculator project in the CalculatorTest project (right-click on the Dependencies in CalculatorTest project, then choose the Calculator project to add the ref.)
	3. Add a testing class say CalcTest.cs (this class should be used to test all modules of CalculatorController class in Calculator project.).
	4. For each method in the CalculatorController create one or more corresponding testing method in the CalcTest class.
		For example:
		a) Create the test method AddTest() to test the Add() method in CalculatorController.
			Make sure AddTest() is decorated with [Fact] attribute.
			In the Arrange seciton: 
				(i) Declare and initialize two variables e.g., n1 and n2.
				(ii) Create variable 'expected' and assign the expected result to it. For example, if n1 = 3 and n2 = 5 are assigned, then assign expected = 8. 
				(iii) Create an instance of the model class in Calculator project with auto initialized properties with the values of n1 and n2 for Num1 and Num2, respectively.
			In the Act section:
				(i) Create an instance of the CalculatorController.
				(ii) Invoke the Add() mehtod using the instance, convert the retrun to ViewResult type, and assign it to a local variable, say result.
				(iii) Extract the model from the ViewData of the result and store it in local variable, say model.
				(iv) Assing the Total property of the model to a local variable, say actual.
			In the Assert section:
				(i) Use the Assert.Equal() method to assert the test result through pasing varialbles: expected and actual.
	
		b) Create the test method DivideTest() to test the Divide() method in CalculatorController.
			Create the Arrange, Act and Assert sections (as shown in DivideTest() mehtod.)
		c) Create the test method DivideExceptionTest() to test the Exception handling part of Divide() method in CalculatorController.
			Create the Arrange section to set up the testing environment and Act + Assert section to invoke the Divide() method of the CalculatorController class and assert to check if the exception is thrown.
	5. To run the test:
		a) Open the Test Explorer window (Test -> Test Explorer).
		b) Under the Test column in the window, select the test name that you would like to run (all test methods that are created iin CalculatorTest should be listed here).
		c) Click on thr Run (top left corner) to test the selected test method, or the Run All Tests to test all the test methods.
		d) Interprete the test result displayed in the right-hand side window and fix the code in the origial module (e.g., Add(), Divide() methods in CalculatorController) if needed.