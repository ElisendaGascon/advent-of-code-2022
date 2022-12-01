

string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Solutions\Day01\Day01_Input.txt";
string data = File.ReadAllText(path);

// Console.WriteLine(data);

/*int result = data
    .Split("\n\n")
    .Select(x => x
        .Split("\n", StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .Aggregate((a, b) => a + b))
    .Max();

Console.WriteLine(result);*/

int result = data
    .Split(Environment.NewLine + Environment.NewLine)
    .Select(x => x
        .Split(Environment.NewLine)
        .Select(x => int.Parse(x))
        .Aggregate((a, b) => a + b))
    .Max();

Console.WriteLine(result);

/*
string initialString = "1\n2\n3\n4\n\n5\n6";

var maxOfSum = initialString
    .Split("\n\n")
    .Select(x => x
        .Split("\n", StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x))
        .Aggregate((a, b) => a + b))
    .Max();

Console.WriteLine(maxOfSum);*/