// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Via.TercaGeekBenchmark.Benchmarks;

//var watch = Stopwatch.StartNew();
//Console.WriteLine(ListUtils.FindOcorrenciesByList(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2 }));
//watch.Stop();
//Console.WriteLine($"Tempo de execução: {watch.Elapsed}");

BenchmarkRunner.Run<ListUtilsBenchmark>();

