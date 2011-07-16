using System;
using System.Collections.Generic;

namespace ProjectEuler {
	public static class Util {

		public static bool[] Eratosthenes(int size) {
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
			return table;
		}

		public static int[] Primes(int max) {
			var table = Eratosthenes(max + 1);
			var lst = new List<int>();
			for (int i = 0 ; i < table.Length; i++)
				if (table[i])
					lst.Add(i);
			return lst.ToArray();
		}
	}
}

