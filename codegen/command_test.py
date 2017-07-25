import sys
import os

def class_names():
    return ['Alpha', 'Bravo', 'Charlie', 'Delta', 'Echo', 'Foxtrot', 'Golf', 'Hotel', 'India', 'Juliett', 'Kilo', 'Lima', 'Mike', 'November', 'Oscar', 'Papa']

def get_class_name(index):
    return class_names()[index]

def gen_class(f, index):
    name = get_class_name(index)

    # lowercase first letter of the type's name
    lambda_name = name.lower()[0]

    f.write('\tpublic class ' + name + ' : ICommand')
    f.write('\n')
    f.write('\t{\n')

    f.write('\t\tpublic static int Value { get; set; }\n')
    f.write('\t\tpublic static Action<' + name + '> Action = ' + lambda_name + ' => Value = ' + lambda_name + '.i;\n')
    f.write('\t\tpublic string Command => "' + name.lower() + '";\n')
    f.write('\n')
    f.write('\t\tpublic int i;\n')
    f.write('\n')

    f.write('\t}\n')
    f.write('\n')

def gen_test_classes():
    f = open('../Test/Command/CommandTestClasses.cs', 'w+')

    f.write('/*\n * generated using codegen/command_test.py\n */\n\n')
    
    # namespace and includes
    f.write('using System;\n')
    f.write('using CLIMapper;\n')

    f.write('\n')

    f.write('namespace Test\n')
    f.write('{\n')

    for i in range(0, 16):
        gen_class(f, i)

    f.write('}')

# gets a comma-delimited list of actions to pass to Command.Execute() up to the given argument index
def action_params(up_to):
    params = ''

    for i in range(0, up_to - 1):
        params += get_class_name(i) + '.Action, '

    params += get_class_name(up_to - 1) + '.Action'

    return params

def gen_normal_test_set(f, index):
    # gen a test to verify each command in the set
    for i in range(0, index):
        class_name = get_class_name(i)

        f.write('\t\t[Test]\n')
        f.write('\t\tpublic void Execute_' + str(index) + 'ActionArgs_Command' + str(i + 1) + '_OnlyActions()\n')
        f.write('\t\t{\n')

        f.write('\t\t\tstring[] args = new[] { "' + class_name.lower() + '", "--i", "' + str(i) + '" };\n')
        f.write('\n')
        f.write('\t\t\tCommand.Execute(args, ' + action_params(index) + ');\n')
        f.write('\n')
        f.write('\t\t\tAssert.AreEqual(' + class_name + '.Value, ' + str(i) + ');\n')

        f.write('\t\t}\n')
        f.write('\n')

def gen_baseline_tests():
    # generate basic tests that use neither aliases nor a prefix override
    f = open('../Test/Command/BasicCommandTest.cs', 'w+')

    f.write('/*\n * generated using codegen/command_test.py\n */\n\n')

    # namespace and includes
    f.write('using System;\n')
    f.write('using CLIMapper;\n')
    f.write('using NUnit.Framework;\n')

    f.write('\n')

    f.write('namespace Test\n')
    f.write('{\n')

    f.write('\t[TestFixture]\n')
    f.write('\tpublic class BasicCommandTest\n')
    f.write('\t{\n')

    for i in range(0, 17):
        gen_normal_test_set(f, i)

    f.write('\t}\n')

    f.write('}\n')

def gen_alias_test_set(f, index):
    # gen a test to verify each command in the set
    for i in range(0, index):
        class_name = get_class_name(i)

        f.write('\t\t[Test]\n')
        f.write('\t\tpublic void Execute_' + str(index) + 'ActionArgs_Command' + str(i + 1) + '_Alias()\n')
        f.write('\t\t{\n')

        f.write('\t\t\tstring[] args = new[] { "' + class_name.lower() + '", "--integer", "' + str(i) + '" };\n')
        f.write('\t\t\tDictionary<string, string> aliases = new Dictionary<string, string>() { { "integer", "i" } };\n')
        f.write('\n')
        f.write('\t\t\tCommand.Execute(args, ' + action_params(index) + ', aliases: aliases);\n')
        f.write('\n')
        f.write('\t\t\tAssert.AreEqual(' + class_name + '.Value, ' + str(i) + ');\n')

        f.write('\t\t}\n')
        f.write('\n')

def gen_alias_tests():
    # generate tests that use aliases
    f = open('../Test/Command/AliasCommandTest.cs', 'w+')

    f.write('/*\n * generated using codegen/command_test.py\n */\n\n')

    # namespace and includes
    f.write('using System.Collections.Generic;\n')
    f.write('using CLIMapper;\n')
    f.write('using NUnit.Framework;\n')

    f.write('\n')

    f.write('namespace Test\n')
    f.write('{\n')

    f.write('\t[TestFixture]\n')
    f.write('\tpublic class AliasCommandTest\n')
    f.write('\t{\n')

    for i in range(0, 17):
        gen_alias_test_set(f, i)

    f.write('\t}\n')

    f.write('}\n')

def gen_prefix_test_set(f, index):
    # gen a test to verify each command in the set
    for i in range(0, index):
        class_name = get_class_name(i)

        f.write('\t\t[Test]\n')
        f.write('\t\tpublic void Execute_' + str(index) + 'ActionArgs_Command' + str(i + 1) + '_Prefix()\n')
        f.write('\t\t{\n')

        f.write('\t\t\tstring[] args = new[] { "' + class_name.lower() + '", "-i", "' + str(i) + '" };\n')
        f.write('\t\t\tstring prefix = "-";\n')
        f.write('\n')
        f.write('\t\t\tCommand.Execute(args, ' + action_params(index) + ', prefix);\n')
        f.write('\n')
        f.write('\t\t\tAssert.AreEqual(' + class_name + '.Value, ' + str(i) + ');\n')

        f.write('\t\t}\n')
        f.write('\n')

def gen_prefix_tests():
    # generate tests that use a prefix override
    f = open('../Test/Command/PrefixCommandTest.cs', 'w+')

    f.write('/*\n * generated using codegen/command_test.py\n */\n\n')

    # namespace and includes
    f.write('using System.Collections.Generic;\n')
    f.write('using CLIMapper;\n')
    f.write('using NUnit.Framework;\n')

    f.write('\n')

    f.write('namespace Test\n')
    f.write('{\n')

    f.write('\t[TestFixture]\n')
    f.write('\tpublic class PrefixCommandTest\n')
    f.write('\t{\n')

    for i in range(0, 17):
        gen_prefix_test_set(f, i)

    f.write('\t}\n')

    f.write('}\n')

def gen_default_command_tests():
    # tests to verify default command naming behavior

def gen_edge_tests():
    # empty args error
    # no matching command error
    # case insensitivity

    print('incomplete step gen_edge_tests')

# main
print('Ensuring command test directory exists...')
directory = '../Test/Command'
if not os.path.exists(directory):
    os.makedirs(directory)

print('Generating test classes...')
gen_test_classes()

print('Generating base tests...')
gen_baseline_tests()

print('Generating alias tests...')
gen_alias_tests()

print('Generating prefix tests...')
gen_prefix_tests()

