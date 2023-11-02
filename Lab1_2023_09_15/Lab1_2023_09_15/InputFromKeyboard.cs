using System;

public class BasicIO
{
	string val;
	int num1=0, num2=0, num3=0;

	public BasicIO()
	{

	}

	public void ReadString()
	{
		Console.WriteLine("Input the first number : ");

		val = Console.ReadLine();

		num1 = Convert.ToInt32(val);

		Console.WriteLine("Input the second number : ");

		val = Console.ReadLine();

		num2 = Convert.ToInt32(val);
	}

	public void DisplayString()
	{
        num3 = num1 + num2;

        Console.WriteLine("The sum of " + num1 + " + " + num2 + " = " + num3);
    }
}
