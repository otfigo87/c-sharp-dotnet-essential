// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting string content

float f1 = 123.4f;
int i1 = 2000;

// TODO: Spacing and Alignment: Indexes
//Header using index method
Console.WriteLine("{0, -10} {1, 30}", "Float Value", "Int Value");
//Data
Console.WriteLine("{0, -10} {1, 30}", f1, i1);


// TODO: Spacing and Alignment: Interpolation
Console.WriteLine("{0, -10} {1, 10}", "Float Value", "Int Value");
Console.WriteLine($"{f1, -10} {i1, 10}");

