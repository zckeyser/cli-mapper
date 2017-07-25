import sys

def get_class_name(index):
    names = ['Alpha', 'Bravo', 'Charlie', 'Delta', 'Echo', 'Foxtrot', 'Golf', 'Hotel', 'India', 'Juliett', 'Kilo', 'Lima', 'Mike', 'November', 'Oscar', 'Papa']

    return names[index]

def gen_class(f, index):
    name = get_class_name[index]

    f.write('public class ' + name + ' : ICommand')
    f.write('\n')
    f.write('{\n')

    f.write('public string Command => ' + name.lower() + ';\n')
    f.write('\n')
    f.write('public int i;\n')
    f.write('\n')

    f.write('}\n')

def gen_classes(filename):
    f = open('../Test/Command/CommandTestClasses.cs')
    
    # namespace and includes
    f.write('using System;\n')
    f.write('using CLIMapper;\n')

    f.write('\n')

    f.write('namespace Test\n')
    f.write('{')

    for i in [0..15]:
        gen_class(f, i)

    f.write('}')

def gen_normal_tests():
    

def gen_alias_tests():


def gen_prefix_tests():


def gen_both_tests():

