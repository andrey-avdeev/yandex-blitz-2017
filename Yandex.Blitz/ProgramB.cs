using System;
using System.Collections.Generic;
using System.Linq;

namespace Yandex.Blitz
{
	class ProgramB
	{

		static void MainB(string[] args)
		{
			long n = 0;
			long k = 0;
			var answer = false;
			var exists = false;

			while (!answer && ++n < 100)
			{
				while (!exists && ++k < long.MaxValue)
				{
					if (n == (3 * k / (Math.Pow(S(k), 2)))) exists = true;
				}

				if (!exists)
				{
					answer = true;
				}
				else
				{
					exists = false;
				}
				k = 0;
			}
		}

		static long S(long x)
		{
			long s = 0;

			while (x != 0)
			{
				s += x % 10;
				x /= 10;
			}

			return s;
		}
	}
}
