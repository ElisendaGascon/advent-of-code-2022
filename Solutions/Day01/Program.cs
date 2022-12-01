

string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Input\Day01.txt";
string data = File.ReadAllText(path);

var result = data
    .Split("\n\n")
    .Select(x => x
        .Split("\n", StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .Aggregate((a, b) => a + b))
    .Max();

Console.WriteLine(result);




string initialString = "1\n2\n3\n4\n\n5\n6";

var maxOfSum = initialString
    .Split("\n\n")
    .Select(x => x
        .Split("\n", StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .Aggregate((a, b) => a + b))
    .Max();

Console.WriteLine(maxOfSum);