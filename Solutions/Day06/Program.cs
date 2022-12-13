string path = @"c:\Users\ElisendaGascon\repos\advent-of-code-2022\Solutions\Day06\Day06_Input.txt";
string data = File.ReadAllText(path);

int FirstMarkerAfterCharacter(int chunks)
{
    for (int i = 0; i < data.Length - chunks; i++)
    {
        List<char> chars = new(data[i..(i + chunks)]);

        if (chars.Distinct().Count() == chunks){
            return i + chunks;
        }
    }

    return 0;
}

Console.WriteLine($"Answer to part 1: {FirstMarkerAfterCharacter(4)}");
Console.WriteLine($"Answer to part 2: {FirstMarkerAfterCharacter(14)}");
