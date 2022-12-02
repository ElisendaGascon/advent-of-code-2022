
string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Solutions\Day02\Day02_Input.txt";
string data = File.ReadAllText(path);
// Console.WriteLine(data);

// Part 1

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



// Part 2

// Opponent's move:
// A = Rock => 1 point
// B = Paper => 2 points
// C = Scissors => 3 points

// How the round needs to end:
// X = Loose => 0 points
// Y = Draw => 3 points
// Z = Win => 6 points

// IF (A, X) => (A, C) 3
// IF (A, Y) => (A, A) 4
// IF (A, Z) => (A, B) 8
// IF (B, X) => (B, A) 1
// IF (B, Y) => (B, B) 5
// IF (B, Z) => (B, C) 9
// IF (C, X) => (C, B) 2
// IF (C, Y) => (C, C) 6
// IF (C, Z) => (C, A) 7

int myScore2 = 0;
int score2 = 0;

foreach ((string, string) pair in listPairs)
{
    if (pair == ("A", "X"))
    {
        myScore2 = 3;
    }
    if (pair == ("C", "Z"))
    {
        myScore2 = 7;
    }
    if (pair == ("B", "Y"))
    {
        myScore2 = 5;
    }
    if (pair == ("C", "X"))
    {
        myScore2 = 2;
    }
    if (pair == ("B", "Z"))
    {
        myScore2 = 9;
    }
    if (pair == ("A", "Y"))
    {
        myScore2 = 4;
    }
    if (pair == ("A", "Z"))
    {
        myScore2 = 8;
    }
    if (pair == ("C", "Y"))
    {
        myScore2 = 6;
    }
    if (pair == ("B", "X"))
    {
        myScore2 = 1;
    }

    score2 += myScore2;
}


Console.WriteLine(score2);