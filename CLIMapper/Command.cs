using System;
using System.Collections.Generic;
using System.Linq;

namespace CLIMapper
{
    // filler class so we can have 1 implementation for Execute despite the many generic definitions
    internal class Void : ICommand {
        public string Command => null;

        internal static Action<Void> Action
        {
            get { return v => { }; }
        }
    }

    public static class Command
    {
        /*
         * Since we need access to the actual type at runtime to handle command parsing,
         * this monstrosity is necessary. Without generics for each action we'll just have
         * the ICommand type, which is insufficient to:
         * A) parse the type for options
         * B) instantiate the type to check what its command string is
         */

        public static void Execute<T>(string[] args, Action<T> command1, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T : class, ICommand
        {
            Execute(args, command1, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2>(string[] args, Action<T1> command1, Action<T2> command2, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
        {
            Execute(args, command1, command2, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
        {
            Execute(args, command1, command2, command3, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, command8, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, Action<T9> command9, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
            where T9 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, command8, command9, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, Action<T9> command9, Action<T10> command10, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
            where T9 : class, ICommand
            where T10 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, command8, command9, command10, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, Action<T9> command9, Action<T10> command10, Action<T11> command11, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
            where T9 : class, ICommand
            where T10 : class, ICommand
            where T11 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, command8, command9, command10, command11, Void.Action, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, Action<T9> command9, Action<T10> command10, Action<T11> command11, Action<T12> command12, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
            where T9 : class, ICommand
            where T10 : class, ICommand
            where T11 : class, ICommand
            where T12 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, command8, command9, command10, command11, command12, Void.Action, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, Action<T9> command9, Action<T10> command10, Action<T11> command11, Action<T12> command12, Action<T13> command13, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
            where T9 : class, ICommand
            where T10 : class, ICommand
            where T11 : class, ICommand
            where T12 : class, ICommand
            where T13 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, command8, command9, command10, command11, command12, command13, Void.Action, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, Action<T9> command9, Action<T10> command10, Action<T11> command11, Action<T12> command12, Action<T13> command13, Action<T14> command14, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
            where T9 : class, ICommand
            where T10 : class, ICommand
            where T11 : class, ICommand
            where T12 : class, ICommand
            where T13 : class, ICommand
            where T14 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, command8, command9, command10, command11, command12, command13, command14, Void.Action, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, Action<T9> command9, Action<T10> command10, Action<T11> command11, Action<T12> command12, Action<T13> command13, Action<T14> command14, Action<T15> command15, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
            where T9 : class, ICommand
            where T10 : class, ICommand
            where T11 : class, ICommand
            where T12 : class, ICommand
            where T13 : class, ICommand
            where T14 : class, ICommand
            where T15 : class, ICommand
        {
            Execute(args, command1, command2, command3, command4, command5, command6, command7, command8, command9, command10, command11, command12, command13, command14, command15, Void.Action, flagPrefix, aliases);
        }

        public static void Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string[] args, Action<T1> command1, Action<T2> command2, Action<T3> command3, Action<T4> command4, Action<T5> command5, Action<T6> command6, Action<T7> command7, Action<T8> command8, Action<T9> command9, Action<T10> command10, Action<T11> command11, Action<T12> command12, Action<T13> command13, Action<T14> command14, Action<T15> command15, Action<T16> command16, string flagPrefix = "--", Dictionary<string, string> aliases = null)
            where T1 : class, ICommand
            where T2 : class, ICommand
            where T3 : class, ICommand
            where T4 : class, ICommand
            where T5 : class, ICommand
            where T6 : class, ICommand
            where T7 : class, ICommand
            where T8 : class, ICommand
            where T9 : class, ICommand
            where T10 : class, ICommand
            where T11 : class, ICommand
            where T12 : class, ICommand
            where T13 : class, ICommand
            where T14 : class, ICommand
            where T15 : class, ICommand
            where T16 : class, ICommand
        {
            // can't distill this into a proper structure since we need to maintain the generics
            // so we're doing it the CS 101 way

            if (args.Length == 0)
            {
                // if not given a command, fail out
                throw new ArgumentException("args must have a length greater than 0");
            }

            var commandString = args[0].ToLower();
            // get the arguments not including the command
            var nonCommandArgs = args.Skip(1).ToArray();

            if (commandString == GetCommandString(typeof(T1)))
            {
                command1(Mapper.MapTo<T1>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T2)))
            {
                command2(Mapper.MapTo<T2>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T3)))
            {
                command3(Mapper.MapTo<T3>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T4)))
            {
                command4(Mapper.MapTo<T4>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T5)))
            {
                command5(Mapper.MapTo<T5>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T6)))
            {
                command6(Mapper.MapTo<T6>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T7)))
            {
                command7(Mapper.MapTo<T7>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T8)))
            {
                command8(Mapper.MapTo<T8>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T9)))
            {
                command9(Mapper.MapTo<T9>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T10)))
            {
                command10(Mapper.MapTo<T10>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T11)))
            {
                command11(Mapper.MapTo<T11>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T12)))
            {
                command12(Mapper.MapTo<T12>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T13)))
            {
                command13(Mapper.MapTo<T13>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T14)))
            {
                command14(Mapper.MapTo<T14>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T15)))
            {
                command15(Mapper.MapTo<T15>(nonCommandArgs, flagPrefix, aliases));
            }
            else if (commandString == GetCommandString(typeof(T16)))
            {
                command16(Mapper.MapTo<T16>(nonCommandArgs, flagPrefix, aliases));
            }
            else
            {
                throw new ArgumentException($"no commands matched the given command argument '{commandString}'");
            }
        }

        private static string GetCommandString(Type t)
        {
            return ((ICommand) Activator.CreateInstance(t)).Command.ToLower();
        }
    }
}
