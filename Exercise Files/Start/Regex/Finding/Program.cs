// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for using Regex to find patterns
using System.Text.RegularExpressions; // Add this using directive

string teststr1 = "The quick brown Fox jumps over the lazy Dog"; 
string teststr2 = "the quick brown fox jumps over the lazy dog";

// TODO: The IsMatch function is used to determine if the content of a string
// results in a match with the given Regex

var capWords = new Regex(@"\b[A-Z]\w+\b"); // Match capitalized words

System.Console.WriteLine(capWords.IsMatch(teststr1));
System.Console.WriteLine(capWords.IsMatch(teststr2));

foreach(Match item in capWords.Matches(teststr1)){ // Use the Matches method to get all matches
    System.Console.WriteLine(item.Value);
}

foreach(Match item in capWords.Matches(teststr2)){
    System.Console.WriteLine(item.Value);
}
// TODO: The RegexOptions argument can be used to perform
// case-insensitive searches

var noCase = new Regex(@"fox", RegexOptions.IgnoreCase); // Match the word "fox" case-insensitively
System.Console.WriteLine(noCase.IsMatch(teststr1)); 
System.Console.WriteLine(noCase.IsMatch(teststr2)); 

// Use the Match and Matches methods to get information about
// specific Regex matches for a given pattern

// TODO: The Match method returns a single match at a time

var m = capWords.Match(teststr1); // Get the first match
while (m.Success){ // Loop through all matches
    System.Console.WriteLine($"{m.Value} found at index {m.Index}"); // Print the match
    m = m.NextMatch(); // Get the next match
}

// TODO: The Matches method returns a collection of Match objects

MatchCollection mc = capWords.Matches(teststr1); // Get all matches
System.Console.WriteLine($"Found {mc.Count} matches"); // Print the number of matches
foreach(Match match in mc){ // Loop through all matches
    System.Console.WriteLine($"{match.Value} found at index {match.Index}"); // Print the match
}