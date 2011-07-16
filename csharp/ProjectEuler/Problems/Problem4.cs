using System;
namespace ProjectEuler {
	public class Problem4 {

		public static void Run () {
			int max = 0;
			for (int i = 999; i >= 100; i--) {
				for (int j = 999; j >= i; j--) {
					int value = i * j;
					if (value > max && IsPalindrome (value)) {
						max = value;
					}
				}
			}
			Console.WriteLine (max);
		}

		private static bool IsPalindrome(int value) {
			var str = value.ToString();
			for (int i = 0; i < str.Length / 2; i++)
				if (str[i] != str[str.Length - 1 - i])
					return false;
			return true;
		}
	}
}

