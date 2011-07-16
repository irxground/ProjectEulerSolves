using System;
using System.Collections.Generic;

namespace ProjectEuler {
	public class Problem3 {

		public static void Run() {
			long problem = 13195;
			int root = (int)Math.Sqrt(problem) + 1;
			int[] primes = Util.Primes(root);
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
	}
}

