﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Files

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream

// using(StreamWriter sw = File.CreateText(filename)){
//     sw.WriteLine("This is a text file.");
// }

// using(StreamWriter sw = File.AppendText(filename)){
//     sw.WriteLine("This is an additional line.");
// }

// using(StreamReader sr = File.OpenText(filename)){
//     string content = sr.ReadToEnd();
//     Console.WriteLine(content);
// }
// TODO: Determine if a file exists

System.Console.WriteLine(File.Exists(filename));
if(File.Exists(filename)){
    File.Delete(filename);
}
else{
    using(StreamWriter sw = File.CreateText(filename)){
        sw.WriteLine("This is a text file.");
    }
}
System.Console.WriteLine(File.Exists(filename));
