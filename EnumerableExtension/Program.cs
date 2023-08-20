// See https://aka.ms/new-console-template for more information
using EnumerableExtension;

Console.WriteLine("Hello, World!");

List<string> list = null;


if(!(list is not null && list.Count > 0))
    Console.WriteLine("Normal way");

if ((bool)!list?.Any())
    Console.WriteLine("Safe way");

if (!list.Safe().Any())
    Console.WriteLine("Safe way");

//the above if checks will give the same result.