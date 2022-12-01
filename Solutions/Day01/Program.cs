

string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Solutions\Day01\Day01_Input.txt";
string data = File.ReadAllText(path);

// Part 1
var result = data
    .Split(Environment.NewLine + Environment.NewLine)
    .Select(x => x
        .Split(Environment.NewLine)
        .Select(x => int.Parse(x))
        .Sum());

int maxResult = result.Max();

Console.WriteLine(maxResult);

// Part 2
var topThree = result.OrderByDescending(i => i).Take(3).Sum();
Console.WriteLine(topThree);



