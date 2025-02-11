// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for Replacing content with Regexes 
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";

Regex CapWords = new Regex(@"[A-Z]\w+");

// TODO: Regular expressions can be used to replace content in strings
// in addition to just searching for content

// string result = CapWords.Replace(teststr1, "***"); // Replace all capitalized words with "***"
// System.Console.WriteLine(teststr1);
// System.Console.WriteLine(result);

// TODO: Replacement text can be generated on the fly using MatchEvaluator
// This is a delegate that computes the new value of the replacement

string MakeUpper(Match m){ // Define a function that takes a Match object
    string s = m.ToString(); // Get the matched string

    if(m.Index == 0){ // If the match is at the beginning of the string
        return s; // Return the string as-is
    }

    return s.ToUpper(); // Otherwise, return the string in uppercase
}

string upperstr = CapWords.Replace(teststr1, new MatchEvaluator(MakeUpper)); // Replace capitalized words with uppercase
System.Console.WriteLine(teststr1);
System.Console.WriteLine(upperstr);