using System;

public class Calculator
{
    int num1=0, num2=0, num3=0;

	public Calculator()
	{

	}

    public void InputNumber()
    {
        Console.WriteLine("Enter the first number : ");
        string str = Console.ReadLine();
        num1 = int.Parse(str);
        Console.WriteLine("Enter the second number : ");
        str = Console.ReadLine();
        num2 = int.Parse(str);
    }

	public void Add()
	{

	}

    public void Subtract()
    {

    }

    public void Multiplication()
    {

    }

    public void Division()
    {

    }
}
