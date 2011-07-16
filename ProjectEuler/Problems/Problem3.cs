using System;
using System.Collections.Generic;

namespace ProjectEuler {
	public class Problem3 {

		public static void Run() {
			long problem = 13195;
			int root = (int)Math.Sqrt(problem) + 1;
			int[] primes = CreateTable(root);
			long max = MaxPrimeFactor(problem, primes);
			Console.WriteLine (max);
		}

		private static long MaxPrimeFactor(long value, int[] primes) {
			long max = 0;
			for (int i = 0; i < primes.Length; i++) {
				if (value % primes[i] == 0) {
					long another = MaxPrimeFactor(value / primes[i], primes);
					if (another > max) {
						max = another;
					}
				}
			}
			return max;
		}

		private static int[] CreateTable(int size) {
			bool[] table = new bool[size];
			for (int i = 2; i< table.Length; i++)
				table[i] = true;
			int len = (int)Math.Sqrt(size) + 1;
			for (int i = 2; i < len; i++) {
				if (table[i]) {
					for (int j = i * i; j < table.Length; j += i) {
						table[j] = false;
					}
				}
			}
			var primes = new List<int>(size / 4);
			for (int i = 2; i < table.Length; i++)
				if (table[i])
					primes.Add(i);
			return primes.ToArray();
		}
	}
}

