using System;
namespace ProjectEuler {
	public class Problem7 {

		public static void Run () {
			const int size = 1000 * 1000;
			bool[] table = new bool[size];
			for (int i = 2; i < table.Length; i++)
				table[i] = true;
			int len = (int)Math.Sqrt (size) + 1;
			for (int i = 2; i < len; i++) {
				if (table[i]) {
					for (int j = i * i; j < table.Length; j += i) {
						table[j] = false;
					}
				}
			}
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

