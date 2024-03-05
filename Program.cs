// See https://aka.ms/new-console-template for more information
using AnyVsExists;
using BenchmarkDotNet.Running;

var res = BenchmarkRunner.Run<AnyVsExistsBenchmark>();
Console.WriteLine("Terminou");
