using System;
using System.Linq;

	public class ArrayFmin
	{
		static void printMin(int[] arr)
		{ 
			int min=arr[0];	
			for(int i=0;i<arr.Length;i++)
			{
				if(min>arr[i])
					{
					min=arr[i];
					}
			}

			Console.WriteLine("Minimum element is:" +min);
		
		}
	
		static void printMax(int[] arr)
		{ 
			int max=arr[0];	
			for(int i=0;i<arr.Length;i++)
			{
				if(max<arr[i])
					{
					max=arr[i];
					}
			}

			Console.WriteLine("Maximum element is:" +max);
			Console.WriteLine("-----------\n\n");
		}



			public static void Main(string[] args)
		{
			int[] arr1= {10,20,15,40,9};
			int[] arr2= {12,23,44,11,10};
			printMin(arr1);
			printMax(arr1);
			printMin(arr2);
			printMax(arr2);

		
		
		
		}
	}

