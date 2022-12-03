// See https://aka.ms/new-console-template for more information

using AoC_Day_3;
using System.Collections;

int counter = 0;
ArrayList rucksacks = new ArrayList();
ArrayList ruckSackGroups = new ArrayList();
List<string> ruckSackGroupRuckSacks = new List<string>();
Dictionary<string, int> lowercaseValues = new Dictionary<string, int>();
Dictionary<string, int> uppercaseValues = new Dictionary<string, int>();

string lastLine = File.ReadLines(@"D:\Repos\AdventOfCode2022\AoC_Day_3\AoC_Day_3\rucksacks.txt").Last();

foreach (string line in System.IO.File.ReadLines(@"D:\Repos\AdventOfCode2022\AoC_Day_3\AoC_Day_3\rucksacks.txt")) {

    List<string> rucksack = new List<string>();

    int ruckSize = line.Length;
    int ruckHalf = ruckSize / 2;
    ruckSize -= 1;

    rucksack.Add(line.Substring(0, ruckHalf));
    rucksack.Add(line.Substring(ruckHalf));

    rucksacks.Add(rucksack);


    //part 2
    if (counter != 3) {
        ruckSackGroupRuckSacks.Add(line);
    } else {
        counter = 0;
        ruckSackGroups.Add(ruckSackGroupRuckSacks);
        ruckSackGroupRuckSacks = new List<string>();
        ruckSackGroupRuckSacks.Add(line);
    }
    
    if(line == lastLine) {
        ruckSackGroups.Add(ruckSackGroupRuckSacks);
    }
    counter++;
}

Rucksacks rSack = new Rucksacks();
int partOneTotal = 0;
int partTwoTotal = 0;

foreach (List<string> sack in rucksacks) {
    partOneTotal += rSack.doWork(sack);
}

foreach (List<string> sack in ruckSackGroups) {
    partTwoTotal += rSack.doPart2Work(sack);
}
Console.WriteLine("Part 1:  " + partOneTotal.ToString());
Console.WriteLine("Part 2:  " + partTwoTotal.ToString());

Console.ReadKey();