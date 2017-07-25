/*
 * generated using codegen/command_test.py
 */

using System.Collections.Generic;
using CLIMapper;
using NUnit.Framework;

namespace Test
{
	[TestFixture]
	public class AliasCommandTest
	{
		[Test]
		public void Execute_1ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_2ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_2ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_3ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_3ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_3ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_4ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_4ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_4ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_4ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_5ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_5ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_5ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_5ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_5ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_6ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_6ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_6ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_6ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_6ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_6ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_7ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_7ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_7ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_7ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_7ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_7ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_7ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_8ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_8ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_8ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_8ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_8ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_8ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_8ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_8ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_9ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_9ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_9ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_9ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_9ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_9ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_9ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_9ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_9ActionArgs_Command9_Alias()
		{
			string[] args = new[] { "india", "--integer", "8" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, aliases: aliases);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_10ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_10ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_10ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_10ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_10ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_10ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_10ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_10ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_10ActionArgs_Command9_Alias()
		{
			string[] args = new[] { "india", "--integer", "8" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_10ActionArgs_Command10_Alias()
		{
			string[] args = new[] { "juliett", "--integer", "9" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, aliases: aliases);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_11ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_11ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_11ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_11ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_11ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_11ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_11ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_11ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_11ActionArgs_Command9_Alias()
		{
			string[] args = new[] { "india", "--integer", "8" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_11ActionArgs_Command10_Alias()
		{
			string[] args = new[] { "juliett", "--integer", "9" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_11ActionArgs_Command11_Alias()
		{
			string[] args = new[] { "kilo", "--integer", "10" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, aliases: aliases);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_12ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_12ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_12ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_12ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_12ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_12ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_12ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_12ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_12ActionArgs_Command9_Alias()
		{
			string[] args = new[] { "india", "--integer", "8" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_12ActionArgs_Command10_Alias()
		{
			string[] args = new[] { "juliett", "--integer", "9" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_12ActionArgs_Command11_Alias()
		{
			string[] args = new[] { "kilo", "--integer", "10" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_12ActionArgs_Command12_Alias()
		{
			string[] args = new[] { "lima", "--integer", "11" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, aliases: aliases);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_13ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_13ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_13ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_13ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_13ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_13ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_13ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_13ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_13ActionArgs_Command9_Alias()
		{
			string[] args = new[] { "india", "--integer", "8" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_13ActionArgs_Command10_Alias()
		{
			string[] args = new[] { "juliett", "--integer", "9" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_13ActionArgs_Command11_Alias()
		{
			string[] args = new[] { "kilo", "--integer", "10" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_13ActionArgs_Command12_Alias()
		{
			string[] args = new[] { "lima", "--integer", "11" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_13ActionArgs_Command13_Alias()
		{
			string[] args = new[] { "mike", "--integer", "12" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, aliases: aliases);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_14ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_14ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_14ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_14ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_14ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_14ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_14ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_14ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_14ActionArgs_Command9_Alias()
		{
			string[] args = new[] { "india", "--integer", "8" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_14ActionArgs_Command10_Alias()
		{
			string[] args = new[] { "juliett", "--integer", "9" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_14ActionArgs_Command11_Alias()
		{
			string[] args = new[] { "kilo", "--integer", "10" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_14ActionArgs_Command12_Alias()
		{
			string[] args = new[] { "lima", "--integer", "11" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_14ActionArgs_Command13_Alias()
		{
			string[] args = new[] { "mike", "--integer", "12" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_14ActionArgs_Command14_Alias()
		{
			string[] args = new[] { "november", "--integer", "13" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, aliases: aliases);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_15ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_15ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_15ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_15ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_15ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_15ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_15ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_15ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_15ActionArgs_Command9_Alias()
		{
			string[] args = new[] { "india", "--integer", "8" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_15ActionArgs_Command10_Alias()
		{
			string[] args = new[] { "juliett", "--integer", "9" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_15ActionArgs_Command11_Alias()
		{
			string[] args = new[] { "kilo", "--integer", "10" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_15ActionArgs_Command12_Alias()
		{
			string[] args = new[] { "lima", "--integer", "11" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_15ActionArgs_Command13_Alias()
		{
			string[] args = new[] { "mike", "--integer", "12" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_15ActionArgs_Command14_Alias()
		{
			string[] args = new[] { "november", "--integer", "13" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_15ActionArgs_Command15_Alias()
		{
			string[] args = new[] { "oscar", "--integer", "14" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, aliases: aliases);

			Assert.AreEqual(Oscar.Value, 14);
		}

		[Test]
		public void Execute_16ActionArgs_Command1_Alias()
		{
			string[] args = new[] { "alpha", "--integer", "0" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_16ActionArgs_Command2_Alias()
		{
			string[] args = new[] { "bravo", "--integer", "1" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_16ActionArgs_Command3_Alias()
		{
			string[] args = new[] { "charlie", "--integer", "2" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_16ActionArgs_Command4_Alias()
		{
			string[] args = new[] { "delta", "--integer", "3" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_16ActionArgs_Command5_Alias()
		{
			string[] args = new[] { "echo", "--integer", "4" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_16ActionArgs_Command6_Alias()
		{
			string[] args = new[] { "foxtrot", "--integer", "5" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_16ActionArgs_Command7_Alias()
		{
			string[] args = new[] { "golf", "--integer", "6" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_16ActionArgs_Command8_Alias()
		{
			string[] args = new[] { "hotel", "--integer", "7" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_16ActionArgs_Command9_Alias()
		{
			string[] args = new[] { "india", "--integer", "8" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_16ActionArgs_Command10_Alias()
		{
			string[] args = new[] { "juliett", "--integer", "9" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_16ActionArgs_Command11_Alias()
		{
			string[] args = new[] { "kilo", "--integer", "10" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_16ActionArgs_Command12_Alias()
		{
			string[] args = new[] { "lima", "--integer", "11" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_16ActionArgs_Command13_Alias()
		{
			string[] args = new[] { "mike", "--integer", "12" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_16ActionArgs_Command14_Alias()
		{
			string[] args = new[] { "november", "--integer", "13" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_16ActionArgs_Command15_Alias()
		{
			string[] args = new[] { "oscar", "--integer", "14" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Oscar.Value, 14);
		}

		[Test]
		public void Execute_16ActionArgs_Command16_Alias()
		{
			string[] args = new[] { "papa", "--integer", "15" };
			Dictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, aliases: aliases);

			Assert.AreEqual(Papa.Value, 15);
		}

	}
}
