// See https://aka.ms/new-console-template for more information

using AoC_Day_3;
using System.Collections;

int counter = 0;
ArrayList rucksacks = new ArrayList();
Dictionary<string, int> lowercaseValues = new Dictionary<string, int>();
Dictionary<string, int> uppercaseValues = new Dictionary<string, int>();

foreach (string line in System.IO.File.ReadLines(@"D:\Repos\AdventOfCode2022\AoC_Day_3\AoC_Day_3\rucksacks.txt")) {
    counter++;

    List<string> rucksack = new List<string>();

    int ruckSize = line.Length;
    int ruckHalf = ruckSize / 2;
    ruckSize -= 1;

    rucksack.Add(line.Substring(0, ruckHalf));
    rucksack.Add(line.Substring(ruckHalf));

    rucksacks.Add(rucksack);


    //if (counter % 2 == 0) {
    //    rucksack.Add(line);
    //    rucksacks.Add(rucksack);
    //}else {
    //    rucksack.Clear();
    //    rucksack.Add(line); 
    //}
}

Rucksacks rSack = new Rucksacks();
int runningTotal = 0;

foreach (List<string> sack in rucksacks) {
    runningTotal += rSack.doWork(sack);

}
Console.WriteLine(runningTotal);

Console.ReadKey();