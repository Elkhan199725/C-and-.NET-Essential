// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Working with file information

// Make sure the example file exists
using System.Text.Unicode;

const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file

// System.Console.WriteLine(File.GetCreationTime(filename));
// System.Console.WriteLine(File.GetLastWriteTime(filename));
// System.Console.WriteLine(File.GetLastAccessTime(filename));

// File.SetAttributes(filename, FileAttributes.ReadOnly);
// System.Console.WriteLine(File.GetAttributes(filename));

// TODO: We can also get general information using a FileInfo 
try {
    FileInfo file = new FileInfo(filename);
    System.Console.WriteLine($"{file.Length}");
    System.Console.WriteLine($"{file.Directory}");
    System.Console.WriteLine($"{file.IsReadOnly}");
}
catch(Exception ex){
    System.Console.WriteLine($"Exception: {ex}");
}

// TODO: File information can also be manipulated
DateTime dt = new DateTime(2024,03,23,22,25,30);
File.SetCreationTime(filename,dt);
System.Console.WriteLine(File.GetCreationTime(filename));
