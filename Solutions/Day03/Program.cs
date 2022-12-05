string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Solutions\Day03\Day03_Input.txt";
string data = File.ReadAllText(path);
// Console.WriteLine(data);

// Part 1
// https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.intersect?view=net-7.0

var result = data
    .Split(Environment.NewLine)
    .Select(x => new ValueTuple<string, string>(
        x.Substring(0, x.Length / 2),
        x.Substring(x.Length / 2, x.Length / 2)))
    .Select(x => x.Item1.Intersect(x.Item2))
    .Aggregate(0, (sum, commonItem) => sum + GetPriority(commonItem.First()));
    
Console.WriteLine(result);    
    
// Part 2
        
var result2 = data
    .Split(Environment.NewLine)
    .Chunk(3)
    .Select(x => x[2].Intersect(x[1].Intersect(x[0])))
    .Aggregate(0, (sum, commonItem) => sum + GetPriority(commonItem.First()));

Console.WriteLine(result2);



int GetPriority(char item)
{
    string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    var index = letters.IndexOf(item);
    return index + 1;
}