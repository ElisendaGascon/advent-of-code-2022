using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using advent_of_code_2022.Solutions;

public static class SolutionFactory
{
    public static ISolution GetSolution(int day, int part)
    {
        string className = $"AoC2018.Solutions.Day{day:D2}.Part{part:D2}";
        Type targetType = typeof(ISolution).Assembly.GetType(className);
        var instance = (ISolution)Activator.CreateInstance(targetType);

        return instance;
    }
}
