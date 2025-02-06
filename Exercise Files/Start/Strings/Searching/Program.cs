// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
System.Console.WriteLine($"{teststr.Contains("fox")}");
System.Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");//for some foreign albphabets like italian
System.Console.WriteLine($"{teststr.Contains("fox", StringComparison.OrdinalIgnoreCase)}");//most cases

// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
System.Console.WriteLine($"{teststr.StartsWith("the",StringComparison.OrdinalIgnoreCase)}");
System.Console.WriteLine($"{teststr.StartsWith("the")}");
System.Console.WriteLine($"{teststr.EndsWith("dog",StringComparison.OrdinalIgnoreCase)}");
System.Console.WriteLine($"{teststr.EndsWith("dog")}");

// TODO: IndexOf, LastIndexOf finds the index of a substring
System.Console.WriteLine($"{teststr.IndexOf("the")}");
System.Console.WriteLine($"{teststr.IndexOf("the",StringComparison.CurrentCultureIgnoreCase)}");
System.Console.WriteLine($"{teststr.LastIndexOf("the")}");
System.Console.WriteLine($"{teststr.LastIndexOf("dog")}");
System.Console.WriteLine($"{teststr.LastIndexOf("dog",StringComparison.CurrentCultureIgnoreCase)}");

// TODO: Determining empty, null, or whitespace
string? str1 = null;
string str2 = "   ";
string str3 = String.Empty;
System.Console.WriteLine($"{string.IsNullOrEmpty(str1)}");
System.Console.WriteLine($"{string.IsNullOrEmpty(str2)}");
System.Console.WriteLine($"{string.IsNullOrWhiteSpace(str2)}");