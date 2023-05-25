// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing numerical data from strings

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
foreach (string str in NumStrs) {
    try {
        testint = int.Parse(str);
        Console.WriteLine($"parsed number is {str}");
    }catch(Exception){
        Console.WriteLine("Could not Parse " + str);
    }

}

// TODO: The TryParse method returns 'true' if the parse is successful

result = int.TryParse(NumStrs[0], out testint);
System.Console.WriteLine($"{result} -- {NumStrs[0]} : {testint}");

result = float.TryParse(NumStrs[1], out testfloat);
System.Console.WriteLine($"{result} -- {NumStrs[1]} : {testfloat}");

result = int.TryParse(NumStrs[3], out testint);
System.Console.WriteLine($"{result} -- {NumStrs[3]} : {testint}");



