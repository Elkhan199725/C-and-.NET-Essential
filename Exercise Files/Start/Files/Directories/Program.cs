// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist

// if(!Directory.Exists(dirname)){
//     Directory.CreateDirectory(dirname);
// }
// else{
//     Directory.Delete(dirname);
// }

// TODO: Get the path for the current directory

var curpath = Directory.GetCurrentDirectory();
System.Console.WriteLine(curpath);

// TODO: Just like with files, you can retrieve info about a directory

var di = new DirectoryInfo(curpath);
System.Console.WriteLine($"{di.Name}");
System.Console.WriteLine($"{di.Parent}");
System.Console.WriteLine($"{di.CreationTime}");

// TODO: Enumerate the contents of directories

Console.WriteLine("Just directories:");
var directories = new List<string>(Directory.EnumerateDirectories(curpath));
//or (var directories = Directory.EnumerateDirectories(curpath));
foreach (string dir in directories){
    System.Console.WriteLine(dir);
}

Console.WriteLine("---------------");

System.Console.WriteLine("Just files:");
var files = Directory.EnumerateFiles(curpath);
foreach(string dir in files){
    System.Console.WriteLine(dir);
}

Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
var allEntries = Directory.EnumerateFileSystemEntries(curpath);
foreach(string dir in allEntries){
    System.Console.WriteLine(dir);
}