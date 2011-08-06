using System;
namespace ProjectEuler {
	public class Problem61 {

		int[,] table = new int[100, 100];

		public static void Run () {
			var p = new Problem61();
			Console.WriteLine ("result:");
			Console.WriteLine(p.solve());
		}

		private int solve () {
			this.init();
			for (int i = 0; i < 100; i++) {
				int result = solve(1 << 8, 0, i);
				if (result > 0)
					return result;
			}
			return 0;
		}

		private int solve (int flag, int sum, int state) {
			const int finish = ((1 << 6) - 1) << 3;
			if (flag == finish) return sum;

			for (int i = 0; i < 100; i++) {
				int kind = table[state, i];
				if (kind == 0) continue; // no route
				if ((flag & (1 << kind)) != 0) continue; // visited
				int result = solve(flag | (1 << kind), sum + (state * 100 + i), i);
				if (result != 0) return result;
			}
			return 0;
		}

		private void init () {
			Action<int, int> register = (int kind, int num) => {
				if (1000 <= num && num < 10000) {
					int left = num / 100;
					int right = num % 100;
					if (table[left, right] != 0) throw new Exception("duplicate");
					table[left, right] = kind;
				}
			};
			for (int n = 0;; n++) {
				register(3, n * (n + 1) / 2);
				register(4, n * n);
				register(5, n * (3 * n - 1) / 2);
				register(6, n * (2 * n));
				register(7, n * (5 * n - 3) / 2);
				register(8, n * (3 * n - 2));
			}
		}
	}
}

