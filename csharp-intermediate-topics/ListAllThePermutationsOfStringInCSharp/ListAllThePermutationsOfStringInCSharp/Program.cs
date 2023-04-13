using BenchmarkDotNet.Running;
using ListAllThePermutationsOfStringInCSharp;

Console.WriteLine("Welcome to the permutation generator\n\n");

Console.WriteLine("Select option: \n");
Console.WriteLine("     I   : Interactive permutations");
Console.WriteLine("     B   : Benchmarks");
Console.WriteLine("     1   : From the article - all possible positions");
Console.WriteLine("     2   : From the article - permutations");
Console.WriteLine("     3   : From the article - improved permutations");
Console.WriteLine("     4   : From the article - recursive algorithm");
Console.WriteLine("  <other>: Exit");

var keyToAction = new Dictionary<ConsoleKey, Action>
{
    { ConsoleKey.I, InteractivePermutations.Run },
    { ConsoleKey.B, () => BenchmarkRunner.Run<MemoryAlgorithmsBenchmark>() },
    { ConsoleKey.D1, ExamplesFromTheArticle.PrintAllPossiblePositions },
    { ConsoleKey.D2, ExamplesFromTheArticle.PrintPermutations },
    { ConsoleKey.D3, ExamplesFromTheArticle.PrintPermutationsImproved },
    { ConsoleKey.D4, ExamplesFromTheArticle.PrintPermutationsRecursively },
};

Console.Write("\n Your selection ... ");
var key = Console.ReadKey();
Console.Clear();

if (keyToAction.TryGetValue(key.Key, out var action))
    action();

string a = "test";
var b = a.ToUpper();