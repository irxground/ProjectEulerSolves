using System;
namespace ProjectEuler {
	public class Problem7 {
		public static void Run () {
			const int size = 1000 * 1000;
			bool[] table = Util.Eratosthenes(size);
			int cnt = 0;
			int value = 0;
			for (int i = 0; i < table.Length; i++) {
				if (table[i]) {
					cnt++;
					if (cnt == 10001) {
						value = i;
						break;
					}
				}
			}
			Console.WriteLine (value);
		}
	}
}

