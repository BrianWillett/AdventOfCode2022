// See https://aka.ms/new-console-template for more information

using AoC_Day_4;

int partOneCount = 0;
int partTwoCount = 0;
Worker worker = new Worker();

foreach (string line in System.IO.File.ReadAllLines(@"D:\Repos\AdventOfCode2022\AoC_Day_4\AoC_Day_4\assignments.txt")) {

    partOneCount += worker.partOneParseLine(line); //part 1
    partTwoCount += worker.partTwoParseLine(); //part 2



}


Console.WriteLine("Part 1:  " + partOneCount.ToString());
Console.WriteLine("Part 2:  " + partTwoCount.ToString());


Console.ReadKey();
