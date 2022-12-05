string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Solutions\Day04\Day04_Input.txt";
string data = File.ReadAllText(path);

var result = data
    .Split(Environment.NewLine)
    .Select(x => new ValueTuple<string, string>(
        x.Split(",", 2, StringSplitOptions.TrimEntries)[0], x.Split(",", 2, StringSplitOptions.TrimEntries)[1]));

var result1 = result
    .Select((x) => new ValueTuple<ValueTuple<int, int>, ValueTuple<int, int>>(
        (int.Parse(x.Item1.Split("-")[0]), int.Parse(x.Item1.Split("-")[1])),
        (int.Parse(x.Item2.Split("-")[0]), int.Parse(x.Item2.Split("-")[1]))));

var result3 = IsFullyContained(result1) ;

Console.WriteLine(result3);

int IsFullyContained(IEnumerable<((int, int), (int, int))> assignments)
{
    int count = 0;
    int fullyContainedCount = 0;

    foreach (var assignment in assignments)
    {
        count++;
        var a = assignment.Item1.Item1;
        var b = assignment.Item1.Item2;
        var c = assignment.Item2.Item1;
        var d = assignment.Item2.Item2;

        if (a > c & b < d || a < c & b > d || a >= c & b < d || a > c & b <= d || a >= c & b <= d || a <= c & b > d || a < c & b >= d)
        {
            fullyContainedCount++;
        }
    }
    return fullyContainedCount;
}