using System;
					
public class Program
{
	public static int Main()
	{
		int count = 0;
		for (int i = 0; i <= 1000; i++)
		{
			if (i % 3 == 0 || i % 5 == 0)
			{
				count = count + i;
			}
		}
//		Console.WriteLine(count);
		return count;
	}
}
