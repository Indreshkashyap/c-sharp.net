using System;
using System.Linq;

	public class ArrayFunction
	{
		static void printArray(int[] arr)
		{	
			Console.WriteLine("Printing array elements:");
			for(int i=0;i<arr.Length;i++)
			{
			Console.WriteLine(arr[i]);
			}
		}

			public static void Main(string[] args)
		{
			int[] arr1= {10,20,15,40,50};
			int[] arr2= {12,23,44,11,54};
			printArray(arr1);
			printArray(arr2);

		
		
		
		}
	}

