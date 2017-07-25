/*
 * generated using codegen/command_test.py
 */

using System.Collections.Generic;
using CLIMapper;
using NUnit.Framework;

namespace Test
{
	[TestFixture]
	public class PrefixCommandTest
	{
		[Test]
		public void Execute_1ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_2ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_2ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_3ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_3ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_3ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_4ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_4ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_4ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_4ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_5ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_5ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_5ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_5ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_5ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_6ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_6ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_6ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_6ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_6ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_6ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_7ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_7ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_7ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_7ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_7ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_7ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_7ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_8ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_8ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_8ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_8ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_8ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_8ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_8ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_8ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_9ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_9ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_9ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_9ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_9ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_9ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_9ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_9ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_9ActionArgs_Command9_Prefix()
		{
			string[] args = new[] { "india", "-i", "8" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, prefix);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_10ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_10ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_10ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_10ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_10ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_10ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_10ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_10ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_10ActionArgs_Command9_Prefix()
		{
			string[] args = new[] { "india", "-i", "8" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_10ActionArgs_Command10_Prefix()
		{
			string[] args = new[] { "juliett", "-i", "9" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, prefix);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_11ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_11ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_11ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_11ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_11ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_11ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_11ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_11ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_11ActionArgs_Command9_Prefix()
		{
			string[] args = new[] { "india", "-i", "8" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_11ActionArgs_Command10_Prefix()
		{
			string[] args = new[] { "juliett", "-i", "9" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_11ActionArgs_Command11_Prefix()
		{
			string[] args = new[] { "kilo", "-i", "10" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, prefix);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_12ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_12ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_12ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_12ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_12ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_12ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_12ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_12ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_12ActionArgs_Command9_Prefix()
		{
			string[] args = new[] { "india", "-i", "8" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_12ActionArgs_Command10_Prefix()
		{
			string[] args = new[] { "juliett", "-i", "9" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_12ActionArgs_Command11_Prefix()
		{
			string[] args = new[] { "kilo", "-i", "10" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_12ActionArgs_Command12_Prefix()
		{
			string[] args = new[] { "lima", "-i", "11" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, prefix);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_13ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_13ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_13ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_13ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_13ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_13ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_13ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_13ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_13ActionArgs_Command9_Prefix()
		{
			string[] args = new[] { "india", "-i", "8" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_13ActionArgs_Command10_Prefix()
		{
			string[] args = new[] { "juliett", "-i", "9" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_13ActionArgs_Command11_Prefix()
		{
			string[] args = new[] { "kilo", "-i", "10" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_13ActionArgs_Command12_Prefix()
		{
			string[] args = new[] { "lima", "-i", "11" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_13ActionArgs_Command13_Prefix()
		{
			string[] args = new[] { "mike", "-i", "12" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, prefix);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_14ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_14ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_14ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_14ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_14ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_14ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_14ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_14ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_14ActionArgs_Command9_Prefix()
		{
			string[] args = new[] { "india", "-i", "8" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_14ActionArgs_Command10_Prefix()
		{
			string[] args = new[] { "juliett", "-i", "9" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_14ActionArgs_Command11_Prefix()
		{
			string[] args = new[] { "kilo", "-i", "10" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_14ActionArgs_Command12_Prefix()
		{
			string[] args = new[] { "lima", "-i", "11" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_14ActionArgs_Command13_Prefix()
		{
			string[] args = new[] { "mike", "-i", "12" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_14ActionArgs_Command14_Prefix()
		{
			string[] args = new[] { "november", "-i", "13" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, prefix);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_15ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_15ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_15ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_15ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_15ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_15ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_15ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_15ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_15ActionArgs_Command9_Prefix()
		{
			string[] args = new[] { "india", "-i", "8" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_15ActionArgs_Command10_Prefix()
		{
			string[] args = new[] { "juliett", "-i", "9" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_15ActionArgs_Command11_Prefix()
		{
			string[] args = new[] { "kilo", "-i", "10" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_15ActionArgs_Command12_Prefix()
		{
			string[] args = new[] { "lima", "-i", "11" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_15ActionArgs_Command13_Prefix()
		{
			string[] args = new[] { "mike", "-i", "12" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_15ActionArgs_Command14_Prefix()
		{
			string[] args = new[] { "november", "-i", "13" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_15ActionArgs_Command15_Prefix()
		{
			string[] args = new[] { "oscar", "-i", "14" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, prefix);

			Assert.AreEqual(Oscar.Value, 14);
		}

		[Test]
		public void Execute_16ActionArgs_Command1_Prefix()
		{
			string[] args = new[] { "alpha", "-i", "0" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_16ActionArgs_Command2_Prefix()
		{
			string[] args = new[] { "bravo", "-i", "1" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_16ActionArgs_Command3_Prefix()
		{
			string[] args = new[] { "charlie", "-i", "2" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_16ActionArgs_Command4_Prefix()
		{
			string[] args = new[] { "delta", "-i", "3" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_16ActionArgs_Command5_Prefix()
		{
			string[] args = new[] { "echo", "-i", "4" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_16ActionArgs_Command6_Prefix()
		{
			string[] args = new[] { "foxtrot", "-i", "5" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_16ActionArgs_Command7_Prefix()
		{
			string[] args = new[] { "golf", "-i", "6" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_16ActionArgs_Command8_Prefix()
		{
			string[] args = new[] { "hotel", "-i", "7" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_16ActionArgs_Command9_Prefix()
		{
			string[] args = new[] { "india", "-i", "8" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_16ActionArgs_Command10_Prefix()
		{
			string[] args = new[] { "juliett", "-i", "9" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_16ActionArgs_Command11_Prefix()
		{
			string[] args = new[] { "kilo", "-i", "10" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_16ActionArgs_Command12_Prefix()
		{
			string[] args = new[] { "lima", "-i", "11" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_16ActionArgs_Command13_Prefix()
		{
			string[] args = new[] { "mike", "-i", "12" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_16ActionArgs_Command14_Prefix()
		{
			string[] args = new[] { "november", "-i", "13" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_16ActionArgs_Command15_Prefix()
		{
			string[] args = new[] { "oscar", "-i", "14" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Oscar.Value, 14);
		}

		[Test]
		public void Execute_16ActionArgs_Command16_Prefix()
		{
			string[] args = new[] { "papa", "-i", "15" };
			string prefix = "-";

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action, prefix);

			Assert.AreEqual(Papa.Value, 15);
		}

	}
}
