// See https://aka.ms/new-console-template for more information
using CSharpTips.Console;

Console.WriteLine("Hello, World!");

var task = new NonAsyncTask();

var result = await task.GetResult();

if (result == null)
    Console.Write("Result is null");


