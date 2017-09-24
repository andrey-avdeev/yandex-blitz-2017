using System;
using System.Collections.Generic;
using System.Linq;

namespace Yandex.Blitz
{
	class ProgramD
	{
		static int[] Money;
		static int[] RealAmount;
		static int[] Parents;
		static bool[] Visited;
		static int Diff;

		static void MainD(string[] args)
		{
			//read input
			var n = ReadNumber();
			var Money = ReadNumberArray();
			Array.Sort(Money);
			var m = ReadNumber();
			var sum = Money.Sum();
			Diff = sum - m;

			//initialize
			RealAmount = Money.ToArray();
			Parents = new int[Money.Length];
			for (int t = 0; t < Money.Length; t++)
			{
				Parents[t] = t;
				Visited[t] = false;
			}

			if (Diff < 0)
			{
				Console.WriteLine("No");
			}
			else
			{
				if (Diff == 0)
				{
					Console.WriteLine("Yes");
				}
				else
				{
					if (GraphExist(ref n, ref Money, ref m, ref sum))
					{
						Console.WriteLine("Yes");
					}
					else
					{
						Console.WriteLine("No");
					}
				}
			}
		}

		static int ReadNumber() => int.Parse(Console.ReadLine());

		static int[] ReadNumberArray() =>
			Console.ReadLine().Split(' ')
							.Select(s => int.Parse(s))
							.ToArray();

		static bool GraphExist(ref int n, ref int[] array, ref int m, ref int sum)
		{
			//array sum here is greater than m

			var i = -1;
			var k = 0;
			var diff = sum - m;
			var length = array.Length;
			var exists = false;

			while (Diff != 0)
			{

			}

			while (!exists && ++i < length)
			{
				k = i;
				while (!exists && diff > 0 && ++k < length)
				{
					if (array[i] > array[k] && diff >= array[k])
					{
						//parents[k] = i;
						array[i] -= array[k];
						diff -= array[k];
						if (diff == 0) exists = true;
					}
				}
			}

			return exists;
		}

		static void NextBag()
		{

		}

		static void PlaceIn(int i, int k)
		{
			Parents[k] = i;
			Diff -= Money[k];
			RealAmount[i] -= RealAmount[k];
		}

		static void PlaceOut(int k, int from)
		{
			Parents[k] = Parents[from] == from ? k : Parents[from];
			Diff += Money[k];
			RealAmount[from] += RealAmount[k];
		}
	}
}
