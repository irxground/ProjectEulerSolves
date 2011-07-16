using System;
namespace ProjectEuler {
	public class Problem10 {
		public static void Run () {
			const int size = 2 * 1000 * 1000;
			bool[] table = new bool[size];
			for (int i = 2; i < table.Length; i++)
				table[i] = true;
			int len = (int)Math.Sqrt(size) + 1;
			for (int i = 2; i < len; i++) {
				if (table[i]) {
					for (int j = i * i; j < table.Length; j += i) {
						table[j] = false;
					}
				}
			}
			long sum = 0;
			for (int i = 0; i < table.Length; i++)
				if (table[i])
					sum += i;
			Console.WriteLine(sum);
		}
	}
}

