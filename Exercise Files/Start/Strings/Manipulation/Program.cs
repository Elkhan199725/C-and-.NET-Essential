﻿// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

using System.Runtime.Intrinsics.Arm;

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string 
System.Console.WriteLine(str1.Length);

// TODO: Access individual characters
System.Console.WriteLine(str1[14]);

// TODO: Iterate over a string like any other sequence of values
foreach (char ch in str1) {
    System.Console.Write(ch);
    if(ch == 'b'){
        System.Console.WriteLine(ch);
        break;
    }
}

// TODO: String Concatenation         
string outstr;
outstr = string.Concat(strs);
System.Console.WriteLine(outstr);

// TODO: Joining strings together with Join
outstr = string.Join(".",strs);
System.Console.WriteLine(outstr);
outstr = string.Join("---",strs);
System.Console.WriteLine(outstr);

// TODO: String Comparison

// Equals just returns a regular Boolean
bool isEqual = str2.ToUpper().Equals(str3.ToUpper());
Console.WriteLine($"{isEqual}");

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
int result = String.Compare(str2, "ThiS is a String", StringComparison.OrdinalIgnoreCase);//ignore case sensitivity
System.Console.WriteLine(result);

// TODO: Replacing content
string outStr = str1.Replace("fox", "cat", StringComparison.OrdinalIgnoreCase);
System.Console.WriteLine(outStr);