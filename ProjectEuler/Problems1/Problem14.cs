using System;
using System.Threading.Tasks;

namespace ProjectEuler {
	public class Problem14 {
		public static void Run () {
			int[] table = new int[10];
			table[0] = 1;
			table[1] = 1;
			int max = 1;
			for (int i = 2; i < table.Length; i++) {
				long num = i;
				int cnt = 0;
				while (num >= i) {
					cnt++;
					if (num % 2 == 0)
						num /= 2;
					else
						num = 3 * num + 1;
				}
				table[i] = table[num] + cnt;
				if (table[i] > max)
					max = table[i];
			}
			//Console.WriteLine(max);
			
		}
	}
}

