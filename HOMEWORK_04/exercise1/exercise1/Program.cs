using System;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int i, even = 0;
			int[] arr = new int[6];

			Console.Write("Enter six numbers:");

			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			for (i = 0; i < 6; i++)
			{
				if (arr[i] % 2 == 0)
				{
					even = even + arr[i];
				}

			}
			Console.WriteLine("Sum of even list is:" + even);

		}
	}
}
