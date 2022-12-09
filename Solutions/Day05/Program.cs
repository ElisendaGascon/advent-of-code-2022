using System.Numerics;

string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Solutions\Day05\Day05_Input.txt";
string data = File.ReadAllText(path);

var separateStacksInstructions = data.Split(Environment.NewLine + Environment.NewLine);
var stacks = separateStacksInstructions[0];
var instructions = separateStacksInstructions[1];

var separatedInstructions = instructions
    .Split(new[] { Environment.NewLine, "move", "from", "to" }, StringSplitOptions.RemoveEmptyEntries)
    .Chunk(3);

var move = new List<int>();
var from = new List<int>();
var to = new List<int>();

foreach (var line in separatedInstructions)
{
    move.Add(int.Parse(line[0]));
    from.Add(int.Parse(line[1]));
    to.Add(int.Parse(line[2]));
}

// Part 1
// method pop removes and return the object at the top of the stack

Stack<char>[] stacksList = new Stack<char>[]
{ 
    new Stack<char>("RPCDBG".ToCharArray()),
    new Stack<char>("HVG".ToCharArray()),
    new Stack<char>("NSQDJPM".ToCharArray()),
    new Stack<char>("PSLGDCNM".ToCharArray()),
    new Stack<char>("JBNCPFLS".ToCharArray()),
    new Stack<char>("QBDZVGTS".ToCharArray()),
    new Stack<char>("BZMHFTQ".ToCharArray()),
    new Stack<char>("CMDBF".ToCharArray()),
    new Stack<char>("FCQG".ToCharArray())
 };


for (int i = 0; i < move.Count; i++)
{
    int destinationStack = to[i] - 1;
    int originStack = from[i] - 1;
    int numberToMove = move[i];

    for (int j = 0; j < numberToMove; j++)
    {
        if (stacksList[originStack].Count == 0)
        {
            break;
        }
        stacksList[destinationStack].Push(stacksList[originStack].Pop());
    }
}

var resultPart1 = string.Concat(stacksList.Select(x => x.Peek()));
Console.WriteLine(resultPart1);

// Part 2

for (int i = 0; i < move.Count; i++)
{
    int destinationStack = to[i] - 1;
    int originStack = from[i] - 1;
    int numberToMove  = move[i];

    Stack<char> intermediateStack = new Stack<char>();
    //IEnumerable<char> listToMove = new List<char>();

    for (int j = 0; j < numberToMove; j++)
    {
        if (stacksList[originStack].Count == 0)
        {
            break;
        }
        intermediateStack.Push(stacksList[originStack].Pop());
        // listToMove.Append(stacksList[originStack].Pop());
    }

    foreach (char c in intermediateStack)
    {
        stacksList[destinationStack].Push(c);
    }
}

var resultPart2 = string.Concat(stacksList.Select(x => x.Peek()));
Console.WriteLine(resultPart2);