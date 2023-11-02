using System;

public class TypeConversion
{
	public TypeConversion()
	{

	}

	public void InputString()
	{
		string value;
		Console.WriteLine("Please input any string : ");
		value = Console.ReadLine();
		Console.WriteLine();
		int num = Convert.ToInt32(value);
		Console.WriteLine(num);
	}
}
