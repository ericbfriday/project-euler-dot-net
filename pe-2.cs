using System;
					
public class Program
{
	public static int Main()
	{
	int a = 1;
	int b = 1;
	int c = 0;
	int evens = 0;
	
	for (int i = 1; c < 4000000; i++)
	{
		if (c % 2 == 0) 
		{
			evens = evens + c;
		}
		c = a + b;
		a = b;
		b = c;
	}
	Console.WriteLine(evens);
	return evens;
	}
}
// 4613732
