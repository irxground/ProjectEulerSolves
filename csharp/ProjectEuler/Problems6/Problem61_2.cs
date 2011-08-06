using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProjectEuler {
	public class Problem61_2 {

		private List<Link>[] table;
		private ISet<int> starts;

		public class Link {
			public readonly int Kind;
			public readonly int Next;
			public Link (int kind, int next) {
				Debug.Assert(3 <= kind && kind <= 8);
				Debug.Assert(10 <= next && next < 100);
				this.Kind = kind;
				this.Next = next;
			}
		}

		public class Node {
			public readonly int Value;
			public readonly Node Next;
			public Node (int value, Node next) {
				Debug.Assert(1000 < value && value <= 10000);
				this.Value = value;
				this.Next = next;
			}

			public override string ToString () {
				var buff = new StringBuilder("[");
				ToString(buff);
				buff.Append("]");
				return buff.ToString();
			}

			private void ToString (StringBuilder buff) {
				if (Next != null) {
					Next.ToString(buff);
					buff.Append(", ");
				}
				buff.Append(this.Value);
			}
		}

		public static void Run () {
			new Problem61_2().solve();
		}

		private void solve () {
			init();
			Node result = null;
			foreach (var s in starts) {
				result = solve(s, 0, null, 0);
				if (result != null)
					break;
			}
			Write(result);
		}

		private void Write (Node node) {
			int sum = 0;
			Node n = node;
			while (n != null) {
				sum += n.Value;
				n = n.Next;
			}
			Console.WriteLine(sum + " : " + node);
		}

		private Node solve (int location, int flags, Node route, int cnt) {
			if (cnt == 6) {
				var lastNode = route.Next.Next.Next.Next.Next;
				Debug.Assert(lastNode != null);
				Debug.Assert(lastNode.Next == null);
				int head = lastNode.Value / 100;
				if (location == head)
					return route;
				else
					return null;
			}
			var links = table[location];
			if (links == null)
				return null;
			foreach (var link in links) {
				if ((flags & (1 << link.Kind)) != 0)
					continue;
				// visited
				var nextFlag = flags | (1 << link.Kind);
				var nextRoute = new Node(location * 100 + link.Next, route);
				var result = solve(link.Next, nextFlag, nextRoute, cnt + 1);
				if (result != null)
					return result;
			}
			return null;
		}

		private void init () {
			table = new List<Link>[100];
			starts = new HashSet<int>();
			Action<int, int> register = (int kind, int num) => {
				if (1000 <= num && num < 10000) {
					int head = num / 100;
					int tail = num % 100;
					var list = table[head];
					if (list == null) {
						list = new List<Link>();
						table[head] = list;
					}
					list.Add(new Link(kind, tail));
				}
			};
			for (int n = 0;; n++) {
				int num3 = n * (1 * n + 1) / 2;
				if (num3 >= 10000)
					break;
				register(3, num3);
				register(4, n * (2 * n + 0) / 2);
				register(5, n * (3 * n - 1) / 2);
				register(6, n * (4 * n - 2) / 2);
				register(7, n * (5 * n - 3) / 2);
				int num8 = n * (6 * n - 4) / 2;
				register(8, num8);
				starts.Add(num8 / 100);
			}
		}
	}
}

