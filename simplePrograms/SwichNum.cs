using System;

	public class SwitchNum
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a number:");
			int num = Convert.ToInt32(Console.ReadLine());

			switch(num)
			{
				case 10: Console.WriteLine("it is 10");
					 break;
 
				case 20: Console.WriteLine("it is 20");
					 break;

				case 30: Console.WriteLine("it is 30");
					 break;
				default: Console.WriteLine("it is not 10 20 30");
					 break;

			}
		}
	}

