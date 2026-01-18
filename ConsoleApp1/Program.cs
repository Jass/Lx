// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Business.Services;
using ConsoleApp1.Presentation;

Console.WriteLine("Hello, World!");
FindMissing fm = new FindMissing( new ConsoleInput(), new ArrayLibrary(), new ConsoleOutput());
fm.Execute();