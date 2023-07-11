using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Via.TercaGeekBenchmark.Common;

namespace Via.TercaGeekBenchmark.Benchmarks;

[MemoryDiagnoser]
public class ListUtilsBenchmark
{
    private int[] listOfNumbers;
    private int[] listOfNumbersToFind;

    [GlobalSetup]
    public void Setup()
    {
        listOfNumbers = new int[] { 1, 2, 3, 4, 5 };
        listOfNumbersToFind = new int[] { 1, 2, 3 };
    }

    [Benchmark(Baseline = true)]
    public void FindOcorrenciesByList()
    {
        ListUtils.FindOcorrenciesByList(listOfNumbers, listOfNumbersToFind);
    }

    [Benchmark]
    public void FindOcorrenciesByListPedrao()
    {
        ListUtils.FindOcorrenciesByListSimple(listOfNumbers, listOfNumbersToFind);
    }
}
