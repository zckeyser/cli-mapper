/*
 * generated using codegen/command_test.py
 */

using System;
using CLIMapper;
using NUnit.Framework;

namespace Test
{
	[TestFixture]
	public class BasicCommandTest
	{
		[Test]
		public void Execute_1ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_2ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_2ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_3ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_3ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_3ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_4ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_4ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_4ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_4ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_5ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_5ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_5ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_5ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_5ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_6ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_6ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_6ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_6ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_6ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_6ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_7ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_7ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_7ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_7ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_7ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_7ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_7ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_8ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_8ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_8ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_8ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_8ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_8ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_8ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_8ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_9ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_9ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_9ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_9ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_9ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_9ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_9ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_9ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_9ActionArgs_Command9_OnlyActions()
		{
			string[] args = new[] { "india", "--i", "8" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_10ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_10ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_10ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_10ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_10ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_10ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_10ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_10ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_10ActionArgs_Command9_OnlyActions()
		{
			string[] args = new[] { "india", "--i", "8" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_10ActionArgs_Command10_OnlyActions()
		{
			string[] args = new[] { "juliett", "--i", "9" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_11ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_11ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_11ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_11ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_11ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_11ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_11ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_11ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_11ActionArgs_Command9_OnlyActions()
		{
			string[] args = new[] { "india", "--i", "8" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_11ActionArgs_Command10_OnlyActions()
		{
			string[] args = new[] { "juliett", "--i", "9" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_11ActionArgs_Command11_OnlyActions()
		{
			string[] args = new[] { "kilo", "--i", "10" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_12ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_12ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_12ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_12ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_12ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_12ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_12ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_12ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_12ActionArgs_Command9_OnlyActions()
		{
			string[] args = new[] { "india", "--i", "8" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_12ActionArgs_Command10_OnlyActions()
		{
			string[] args = new[] { "juliett", "--i", "9" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_12ActionArgs_Command11_OnlyActions()
		{
			string[] args = new[] { "kilo", "--i", "10" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_12ActionArgs_Command12_OnlyActions()
		{
			string[] args = new[] { "lima", "--i", "11" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_13ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_13ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_13ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_13ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_13ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_13ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_13ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_13ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_13ActionArgs_Command9_OnlyActions()
		{
			string[] args = new[] { "india", "--i", "8" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_13ActionArgs_Command10_OnlyActions()
		{
			string[] args = new[] { "juliett", "--i", "9" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_13ActionArgs_Command11_OnlyActions()
		{
			string[] args = new[] { "kilo", "--i", "10" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_13ActionArgs_Command12_OnlyActions()
		{
			string[] args = new[] { "lima", "--i", "11" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_13ActionArgs_Command13_OnlyActions()
		{
			string[] args = new[] { "mike", "--i", "12" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_14ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_14ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_14ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_14ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_14ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_14ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_14ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_14ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_14ActionArgs_Command9_OnlyActions()
		{
			string[] args = new[] { "india", "--i", "8" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_14ActionArgs_Command10_OnlyActions()
		{
			string[] args = new[] { "juliett", "--i", "9" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_14ActionArgs_Command11_OnlyActions()
		{
			string[] args = new[] { "kilo", "--i", "10" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_14ActionArgs_Command12_OnlyActions()
		{
			string[] args = new[] { "lima", "--i", "11" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_14ActionArgs_Command13_OnlyActions()
		{
			string[] args = new[] { "mike", "--i", "12" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_14ActionArgs_Command14_OnlyActions()
		{
			string[] args = new[] { "november", "--i", "13" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_15ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_15ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_15ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_15ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_15ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_15ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_15ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_15ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_15ActionArgs_Command9_OnlyActions()
		{
			string[] args = new[] { "india", "--i", "8" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_15ActionArgs_Command10_OnlyActions()
		{
			string[] args = new[] { "juliett", "--i", "9" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_15ActionArgs_Command11_OnlyActions()
		{
			string[] args = new[] { "kilo", "--i", "10" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_15ActionArgs_Command12_OnlyActions()
		{
			string[] args = new[] { "lima", "--i", "11" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_15ActionArgs_Command13_OnlyActions()
		{
			string[] args = new[] { "mike", "--i", "12" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_15ActionArgs_Command14_OnlyActions()
		{
			string[] args = new[] { "november", "--i", "13" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_15ActionArgs_Command15_OnlyActions()
		{
			string[] args = new[] { "oscar", "--i", "14" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action);

			Assert.AreEqual(Oscar.Value, 14);
		}

		[Test]
		public void Execute_16ActionArgs_Command1_OnlyActions()
		{
			string[] args = new[] { "alpha", "--i", "0" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Alpha.Value, 0);
		}

		[Test]
		public void Execute_16ActionArgs_Command2_OnlyActions()
		{
			string[] args = new[] { "bravo", "--i", "1" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Bravo.Value, 1);
		}

		[Test]
		public void Execute_16ActionArgs_Command3_OnlyActions()
		{
			string[] args = new[] { "charlie", "--i", "2" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Charlie.Value, 2);
		}

		[Test]
		public void Execute_16ActionArgs_Command4_OnlyActions()
		{
			string[] args = new[] { "delta", "--i", "3" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Delta.Value, 3);
		}

		[Test]
		public void Execute_16ActionArgs_Command5_OnlyActions()
		{
			string[] args = new[] { "echo", "--i", "4" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Echo.Value, 4);
		}

		[Test]
		public void Execute_16ActionArgs_Command6_OnlyActions()
		{
			string[] args = new[] { "foxtrot", "--i", "5" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Foxtrot.Value, 5);
		}

		[Test]
		public void Execute_16ActionArgs_Command7_OnlyActions()
		{
			string[] args = new[] { "golf", "--i", "6" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Golf.Value, 6);
		}

		[Test]
		public void Execute_16ActionArgs_Command8_OnlyActions()
		{
			string[] args = new[] { "hotel", "--i", "7" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Hotel.Value, 7);
		}

		[Test]
		public void Execute_16ActionArgs_Command9_OnlyActions()
		{
			string[] args = new[] { "india", "--i", "8" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(India.Value, 8);
		}

		[Test]
		public void Execute_16ActionArgs_Command10_OnlyActions()
		{
			string[] args = new[] { "juliett", "--i", "9" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Juliett.Value, 9);
		}

		[Test]
		public void Execute_16ActionArgs_Command11_OnlyActions()
		{
			string[] args = new[] { "kilo", "--i", "10" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Kilo.Value, 10);
		}

		[Test]
		public void Execute_16ActionArgs_Command12_OnlyActions()
		{
			string[] args = new[] { "lima", "--i", "11" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Lima.Value, 11);
		}

		[Test]
		public void Execute_16ActionArgs_Command13_OnlyActions()
		{
			string[] args = new[] { "mike", "--i", "12" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Mike.Value, 12);
		}

		[Test]
		public void Execute_16ActionArgs_Command14_OnlyActions()
		{
			string[] args = new[] { "november", "--i", "13" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(November.Value, 13);
		}

		[Test]
		public void Execute_16ActionArgs_Command15_OnlyActions()
		{
			string[] args = new[] { "oscar", "--i", "14" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Oscar.Value, 14);
		}

		[Test]
		public void Execute_16ActionArgs_Command16_OnlyActions()
		{
			string[] args = new[] { "papa", "--i", "15" };

			Command.Execute(args, Alpha.Action, Bravo.Action, Charlie.Action, Delta.Action, Echo.Action, Foxtrot.Action, Golf.Action, Hotel.Action, India.Action, Juliett.Action, Kilo.Action, Lima.Action, Mike.Action, November.Action, Oscar.Action, Papa.Action);

			Assert.AreEqual(Papa.Value, 15);
		}

	}
}
