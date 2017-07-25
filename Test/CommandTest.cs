using System;
using CLIMapper;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void Command_Execute_1Action()
        {
            string result = null;

            var args = "foo --i 5".Split(' ');

            Action<Foo> action = f => result = f.i.ToString();
            
            Command.Execute(args, action);

            Assert.AreEqual(result, "5");
        }
    }


    public class Foo : ICommand
    {
        public string Command => "foo";

        public int i;
    }
}
