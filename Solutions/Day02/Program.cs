
using Microsoft.VisualBasic;
using System.Net.WebSockets;

string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Solutions\Day02\Day02_Input.txt";
string data = File.ReadAllText(path);
// Console.WriteLine(data);

IEnumerable<(string elf, string me)> listPairs = data
    .Split(Environment.NewLine)
    .Select(x => x.Split(" "))
    .Select(x => (x[0], x[1]))
    .ToList();


int myScore = 0;
int score = 0;

foreach((string, string) pair in listPairs)
{
    if (pair == ("A", "X"))
    { 
        myScore = 4;
    }
    if (pair == ("C", "Z"))
    {
        myScore = 6;
    }
    if (pair == ("B", "Y"))
    {
        myScore = 5;
    }
    if (pair == ("C", "X"))
    {
        myScore = 7;
    }
    if (pair == ("B", "Z"))
    {
        myScore = 9;
    }
    if (pair == ("A", "Y"))
    {
        myScore = 8;
    }
    if (pair == ("A", "Z"))
    {
        myScore = 3;
    }
    if (pair == ("C", "Y"))
    {
        myScore = 2;
    }
    if (pair == ("B", "X"))
    {
        myScore = 1;
    }

    score += myScore;
}


Console.WriteLine(score);

// Rules
// If for move in second row =>
//  move = X, then 1,
//  move = Y, then 2,
//  move = Z, then 3

// Rock (A, X) defeats Scissors (C, Z)
// Scissors (C, Z) defeats Paper (B, Y)
// Paper (B, Y) defeats Rock (A, X)

// DRAW: (A, X), (C, Z), (B, Y) = 3
// WIN: (C, X), (B, Z), (A, Y) = 6
// LOSS: (A, Z), (C, Y), (B, X) = 0

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples
