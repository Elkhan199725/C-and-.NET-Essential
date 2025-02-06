// See https://aka.ms/new-console-template for more information
using System.Net.WebSockets;

Console.WriteLine("Hello, World!");

string? response;
Console.WriteLine("What's your name?");
response = Console.ReadLine();
Console.WriteLine($"Enjoy the course, {response}");

OperatingSystem thisOS = Environment.OSVersion;
System.Console.WriteLine(thisOS.Platform);
System.Console.WriteLine(thisOS.VersionString);
