// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
if(Directory.Exists(dirname)){
    Directory.Delete(dirname);
} else {
    Directory.CreateDirectory(dirname);
}


// TODO: Get the path for the current directory
System.Console.WriteLine(Directory.GetCurrentDirectory());


// TODO: Just like with files, you can retrieve info about a directory
DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
System.Console.WriteLine(di.Name);
System.Console.WriteLine(di.Parent);
System.Console.WriteLine(di.CreationTime);


// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");

var curPath = Directory.GetCurrentDirectory();
List<string> thedirs = new List<string> (Directory.EnumerateDirectories(curPath));
foreach( string dir in thedirs){
    System.Console.WriteLine(dir);
}

 Console.WriteLine("---------------");

Console.WriteLine("Just files:");
thedirs = new List<string> (Directory.EnumerateFiles(curPath));
foreach( string dir in thedirs){
    System.Console.WriteLine(dir);
}

Console.WriteLine("---------------");

// Console.WriteLine("All directory contents:");

thedirs = new List<string> (Directory.EnumerateFileSystemEntries(curPath));
foreach( string dir in thedirs){
    System.Console.WriteLine(dir);
}
