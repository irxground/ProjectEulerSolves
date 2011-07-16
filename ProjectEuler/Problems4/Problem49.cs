using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectEuler {
	public class Problem49 {
		public static void Run () {
			const int MAX = 10000;
			var table = Util.Eratosthenes(MAX);
			var strTable = new string[table.Length];
			for (int i = 0; i < table.Length; i++) {
				if (table[i]) {
					var chars = i.ToString().ToCharArray();
					Array.Sort(chars);
					strTable[i] = new String(chars);
				}
			}
			Parallel.For(1000, MAX, i => {
				var strA = strTable[i];
				if (strA != null) {
					int maxDiff = (MAX - i - 1) / 2;
					for (int d = 1; d <= maxDiff; d++) {
						var strB = strTable[i + d];
						if (strB == null)
							continue;
						var strC = strTable[i + d * 2];
						if (strC == null)
							continue;
						if (strA == strB && strA == strC) {
							Console.WriteLine("{0}{1}{2}", i, i + d, i + 2 * d);
						}
					}
				}
			});
		}
	}
}

