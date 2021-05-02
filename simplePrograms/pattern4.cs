using System;
namespace ex1
{
	class ex1
	{
		static void Main(string[] args)
		{
			int i,j,k;
			for(i=1;i<=10;i++)
			{
				for(j=1;j<=10-i;j++)
				
					Console.Write(" ");
					for(k=1;k<=2*i-1;k++)
					Console.Write("*");
				
					Console.WriteLine();
				}
			}
		}
	}

