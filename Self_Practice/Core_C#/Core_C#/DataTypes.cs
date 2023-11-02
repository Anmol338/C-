using System;

public class DataTypes
{
	public DataTypes()
	{
		
	}

	public void Integers()
	{
        // Bytes
        byte num = 1;		// Range from 1 to 255
        Console.WriteLine("Byte :- " + num);

        // sbytes
        sbyte num1 = -128;  // Range from -128 to 127
        Console.WriteLine("Signed Byte :- " + num1);

        // short
        short num2 = -32768;    // Range from -32768 to 32767
        Console.WriteLine("Signed short :- " + num2);

        // unsigned short
        ushort num3 = 65535;        // Range from 0 to 65535
        Console.WriteLine("Unsigned short number :- " + num3);

        // integer
        int num4 = -2147483648;      // Range from -2147483648 to 2147483647
        Console.WriteLine("Signed Integer number :- " + num4);

        // unsigned integer
        uint num5 = 4294967295;      //Range from 0 to 4294967295
        Console.WriteLine("Unsigned Integer number :- " + num5);

        // long
        long num6 = -9223372036845775808;     // Range from -9223372036845775808 to 9223372036845775807
        Console.WriteLine("Long Integer number :- " + num6);

        // unsigned long
        ulong num7 = 18446744073709551615;     // Range from 0 to 18446744073709551615
        Console.WriteLine("Unsigned long number :- " + num7);
    }

    public void Floating()
    {
        float num_float = 12844444444444444444;
        Console.WriteLine("Floationg Point number :- " + num_float);

        decimal num_decimal = 12884545545455555556.6778787M;
        Console.WriteLine("Decimal Number :- " + num_decimal);

        num_float = 100.12365F;
        Console.WriteLine(num_float);
    }

}
