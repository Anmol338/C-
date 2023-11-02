using System;

public class Test
{
	public Test()
	{

	}

	public string ReadString()
	{
		Console.WriteLine("Enter one string : ");
		string tmp = Console.ReadLine();
		return tmp;
	}

	public void WriteString(String str)
	{
		Console.WriteLine(str);
	}
}
