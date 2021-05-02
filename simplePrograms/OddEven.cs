/* using System;
public class OddEven
{
	public static void Main(string[] args)
	{
		int num=10;
		if(num%2==0)
		{
			Console.WriteLine("it is Even Number");

		}
		else 
		{
			Console.WriteLine("it is Odd NUmber");
		}
	}
} */


using System;
public class OddEven
{

	public static void Main(string[] args)
	{
	Console.WriteLine("Enter a Number");
	int num = Convert.ToInt32(Console.ReadLine());

	if(num%2==0)
	{
		Console.WriteLine("it is even number");
	}

	else
	{ 
		Console.WriteLine("it is Odd Number");
	}
	}
}
