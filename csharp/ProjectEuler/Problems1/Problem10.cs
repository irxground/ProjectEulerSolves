using System;
namespace ProjectEuler {
	public class Problem10 {
		public static void Run () {
			const int size = 2 * 1000 * 1000;
			bool[] table = Util.Eratosthenes(size);
			long sum = 0;
			for (int i = 0; i < table.Length; i++)
				if (table[i])
					sum += i;
			Console.WriteLine(sum);
		}
	}
}

