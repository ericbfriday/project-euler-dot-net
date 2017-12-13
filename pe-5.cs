using System;
					
public class Program
{
	public static void Main()
	{
		// brute force method using while loop.
		int i = 1;
 
		while (i %  2 != 0 || i %  3 != 0 || i %  4 != 0 || i %  5 != 0 ||
				 i %  6 != 0 || i %  7 != 0 || i %  8 != 0 || i %  9 != 0 ||
				 i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
				 i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
				 i % 18 != 0 || i % 19 != 0 || i % 20 != 0 ){
			i++;
		}
		Console.WriteLine(i); //  output is 232792560
	}
}

// version with for loop instead of while loop
using System;				
public class Program
{
	public static void Main()
	{
		// brute force with for loop
		bool solved = false; 
 		for (int i = 0; solved != true ; i ++) 
		{
		if (	i %  2 == 0 && i %  3 == 0 && i %  4 == 0 && i %  5 == 0 &&
			i %  6 == 0 && i %  7 == 0 && i %  8 == 0 && i %  9 == 0 &&
			i % 10 == 0 && i % 11 == 0 && i % 12 == 0 && i % 13 == 0 &&
			i % 14 == 0 && i % 15 == 0 && i % 16 == 0 && i % 17 == 0 &&
			i % 18 == 0 && i % 19 == 0 && i % 20 == 0 && i != 0)
		{
		solved = true;
		Console.WriteLine(i); //  output is 232792560	
		}
		}
	}
}
