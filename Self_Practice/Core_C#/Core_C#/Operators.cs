using System;

public class Operators
{
	public Operators()
	{
		
	}

	public void AssignmenrOperator()
	{
        Console.WriteLine("Assignment Operators \n");
		int number = 100;	// int :- Data Type, number :- Variable name, = :- Assignment Operator, 100 :- Value or literals;
		Console.WriteLine(number);
	}

	public void ArithmeticOperator()
	{
        Console.WriteLine("Airthmetic Operators \n");
		int num1 = 0, num2 = 0, num3 = 0;
		num1 = 100;
		num2 = 20;

		// Addition Operator
		Console.WriteLine("Addition ");
		num3 = num1 + num2;
		Console.WriteLine("The addition of " + num1 + " + " + num2 + " = " + num3 + ".\n");

		// Subtraction Opertor
		Console.WriteLine("Subracting");
		num3 = num1 - num2;
        Console.WriteLine("The subtraction of " + num1 + " - " + num2 + " = " + num3 + ".\n");

        // Multiplication Opertor
        Console.WriteLine("Multiplication");
        num3 = num1 * num2;
        Console.WriteLine("The multiplication of " + num1 + " * " + num2 + " = " + num3 + ".\n");

        // Division Opertor
        Console.WriteLine("Division");
        num3 = num1 / num2;
        Console.WriteLine("The division of " + num1 + " / " + num2 + " = " + num3 + ".\n");

        // Modulo Opertor
        Console.WriteLine("Modulo");
        num3 = num1 / num2;
        Console.WriteLine("The remainder of " + num1 + " % " + num2 + " = " + num3 + ".\n");
    }

	public void	RelationalOperator()
	{
        Console.WriteLine("Relational Operators \n");

		bool result;
		int	first_num = 100, second_num = 50;

		Console.WriteLine("Relational Operator : \n");

        Console.WriteLine("Operator : (==)");
        result = (first_num == second_num);
		Console.WriteLine(first_num + " is equals to " + second_num + ".\n" + result + "\n");

        Console.WriteLine("Operator : (>)");
        result = (first_num > second_num);
        Console.WriteLine(first_num + " is greater than " + second_num + ".\n" + result + "\n");

        Console.WriteLine("Operator : (<)");
        result = (first_num < second_num);
        Console.WriteLine(first_num + " is less than " + second_num + ".\n" + result + "\n");

        Console.WriteLine("Operator : (>=)");
        result = (first_num < second_num);
        Console.WriteLine(first_num + " is greater than or equals to " + second_num + ".\n" + result + "\n");

        Console.WriteLine("Operator : (<=)");
        result = (first_num < second_num);
        Console.WriteLine(first_num + " is less than or equals to " + second_num + ".\n" + result + "\n");

        Console.WriteLine("Operator : (!=)");
        result = (first_num < second_num);
        Console.WriteLine(first_num + " is not equals to " + second_num + ".\n" + result);
    }

    public void LogicalOperators()
    {
        Console.WriteLine("Logical Operators \n");

        bool result;
        int first_num = 100, second_num = 200, thid_num = 50;

        result = (first_num < second_num) && (second_num > thid_num);
        Console.WriteLine(result);

        result = (first_num > second_num) || (second_num > thid_num);
        Console.WriteLine(result);
    }

    public void UnaryOperators()
    {

        Console.WriteLine("Uniray Operators \n");

        bool flag = true;
        int number = 50, result;

        result = +number;
        Console.WriteLine("+number :- " + result);

        result = -number;
        Console.WriteLine("-number :- " + result);

        result = ++number;
        Console.WriteLine("++number :- " + result);

        result = ++number;
        Console.WriteLine("++number :- " + result);

        result = --number;
        Console.WriteLine("--number :- " + result);

        Console.WriteLine(!flag);
    }

    public void PostPreOperator()
    {
        Console.WriteLine("Pre and Post Increment and Decrement Operators. \n");

        int num = 999;

        Console.WriteLine("number++ : "+ num++);
        Console.WriteLine("= " + num);

        Console.WriteLine("++number : " + ++num);

        Console.WriteLine("number-- : " + num--);
        Console.WriteLine("= " + num);

        Console.WriteLine("--number : " + --num);
    }

    public void TernaryOperator()
    {
        string day, result;

        Console.WriteLine("Plase input the day : \n");
        day = Console.ReadLine();

        result = (day == "Saturday" ? day + " is a holiday." : day + " is not a holiday.");
        Console.WriteLine(result);
    }



}
