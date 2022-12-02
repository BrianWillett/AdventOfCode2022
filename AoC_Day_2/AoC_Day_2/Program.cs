// See https://aka.ms/new-console-template for more information


using AoC_Day_2;

RockPaperScissors rockPaperScissors = new RockPaperScissors();
int myPointTotal = 0;

foreach (string line in System.IO.File.ReadLines(@"D:\Repos\AdventOfCode2022\AoC_Day_2\AoC_Day_2\strategy.txt")) {
    myPointTotal += rockPaperScissors.doRound(line);
}

Console.WriteLine(myPointTotal);
Console.ReadKey();