using System;

namespace Yandex.Blitz
{
	class ProgramA
	{
		static void MainA(string[] args)
		{
			//read input
			var n_text = Console.ReadLine();
			var n = int.Parse(n_text);

			var sequence = Console.ReadLine();
			var sequence_array = sequence.Split(' ');
			var array = new int[sequence_array.Length];
			var i = 0;
			foreach (var item in sequence_array)
			{
				array[i++] = int.Parse(item);
			}

			//initialize
			var isP = true;

			var sumP = 0;
			var sumV = 0;
			var p = 0;
			var v = 0;

			//compute
			i = 0;
			while (i < array.Length)
			{
				if (isP)
				{
					p = array[i];
					sumP += p;
					isP = false;
				}
				else
				{
					v = array[i];
					sumV += v;
					isP = true;
					//end of turn
					i++;
					if (v < p)
					{
						sumV += array[i];
					}
					else
					{
						sumP += array[i];
					}
				}

				i++;
			}

			Console.WriteLine(sumP > sumV ? "Petya" : "Vasya");
		}
	}
}
