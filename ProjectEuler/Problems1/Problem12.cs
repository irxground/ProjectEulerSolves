using System;
using System.Linq;

namespace ProjectEuler {
	public class Problem12 {
		public static void Run () {
			int num = 0;
			int[] primes = Util.Primes(1000 * 1000);
			while (true) {
				num++;
				long tri = (long)num * (num + 1) / 2;
				int result = 1;
				foreach (var prime in primes) {
					int cnt = 1;
					while (tri % prime == 0) {
						tri /= prime;
						cnt++;
					}
					result *= cnt;
				}
				if (result > 500) {
					tri = (long)num * (num + 1) / 2;
					Console.WriteLine(tri);
					return;
				}
			}
		}
	}
}

