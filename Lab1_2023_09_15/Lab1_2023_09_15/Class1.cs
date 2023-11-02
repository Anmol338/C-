using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Hello from Class1");
	}

	public void PrintMessage()
	{
		Console.WriteLine("Hello from PrintMessage");
	}

	// Method Overloading
	public void Sum()			// Creating the non return side function.
	{
		int num1, num2, num3; // Initializing the integer types of variable
		num1 = 34;				// Assigning values into variable
		num2 = 89;              // Assigning values into variable
        num3 = num1 + num2;     // Calculating the sum and assigning the calculated value into variable.
        Console.WriteLine("The Sum of " + num1 + " + "+ num2 + " = "+ num3); // Printing the sum of variable.
	}

	public void Sum(int num1, int num2)
	{
		int num3 = num1 + num2;

		Console.WriteLine("The Sum of " + num1 + " + " + num2 + " = " + num3);
	}

    public void Sum(int num1, int num2, int num3)
    {
        int num4 = num1 + num2 + num3;

        Console.WriteLine("The Sum of " + num1 + " + " + num2 + " + " + num3 + " = " + num4);
    }

	// Method Overloading End
}
