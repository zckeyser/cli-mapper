/*
 * generated using codegen/command_test.py
 */

using System;
using CLIMapper;

namespace Test
{
	public class Alpha : ICommand
	{
		public static int Value { get; set; }
		public static Action<Alpha> Action = a => Value = a.i;
		public string Command => "alpha";

		public int i;

	}

	public class Bravo : ICommand
	{
		public static int Value { get; set; }
		public static Action<Bravo> Action = b => Value = b.i;
		public string Command => "bravo";

		public int i;

	}

	public class Charlie : ICommand
	{
		public static int Value { get; set; }
		public static Action<Charlie> Action = c => Value = c.i;
		public string Command => "charlie";

		public int i;

	}

	public class Delta : ICommand
	{
		public static int Value { get; set; }
		public static Action<Delta> Action = d => Value = d.i;
		public string Command => "delta";

		public int i;

	}

	public class Echo : ICommand
	{
		public static int Value { get; set; }
		public static Action<Echo> Action = e => Value = e.i;
		public string Command => "echo";

		public int i;

	}

	public class Foxtrot : ICommand
	{
		public static int Value { get; set; }
		public static Action<Foxtrot> Action = f => Value = f.i;
		public string Command => "foxtrot";

		public int i;

	}

	public class Golf : ICommand
	{
		public static int Value { get; set; }
		public static Action<Golf> Action = g => Value = g.i;
		public string Command => "golf";

		public int i;

	}

	public class Hotel : ICommand
	{
		public static int Value { get; set; }
		public static Action<Hotel> Action = h => Value = h.i;
		public string Command => "hotel";

		public int i;

	}

	public class India : ICommand
	{
		public static int Value { get; set; }
		public static Action<India> Action = i => Value = i.i;
		public string Command => "india";

		public int i;

	}

	public class Juliett : ICommand
	{
		public static int Value { get; set; }
		public static Action<Juliett> Action = j => Value = j.i;
		public string Command => "juliett";

		public int i;

	}

	public class Kilo : ICommand
	{
		public static int Value { get; set; }
		public static Action<Kilo> Action = k => Value = k.i;
		public string Command => "kilo";

		public int i;

	}

	public class Lima : ICommand
	{
		public static int Value { get; set; }
		public static Action<Lima> Action = l => Value = l.i;
		public string Command => "lima";

		public int i;

	}

	public class Mike : ICommand
	{
		public static int Value { get; set; }
		public static Action<Mike> Action = m => Value = m.i;
		public string Command => "mike";

		public int i;

	}

	public class November : ICommand
	{
		public static int Value { get; set; }
		public static Action<November> Action = n => Value = n.i;
		public string Command => "november";

		public int i;

	}

	public class Oscar : ICommand
	{
		public static int Value { get; set; }
		public static Action<Oscar> Action = o => Value = o.i;
		public string Command => "oscar";

		public int i;

	}

	public class Papa : ICommand
	{
		public static int Value { get; set; }
		public static Action<Papa> Action = p => Value = p.i;
		public string Command => "papa";

		public int i;

	}

}