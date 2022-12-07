//// See https://aka.ms/new-console-template for more information

//List<int> amountToMoveList = new List<int>();
//List<int> fromList = new List<int>();
//List<int> toList = new List<int>();

//List<string> cratesDisplay = new List<string>();

//foreach (string line in System.IO.File.ReadAllLines(@"D:\Repos\AdventOfCode2022\AoC_Day_5\AoC_Day_5\input.txt")) {
//    if (line != "") {
//        if (line[0] == 'm') {
//            //move 4 from 2 to 1
//            //always 1, 3, 5
//            string[] splitUp = line.Split(' ');
//            amountToMoveList.Add(Int32.Parse(splitUp[1]));
//            fromList.Add(Int32.Parse(splitUp[3]));
//            toList.Add(Int32.Parse(splitUp[5]));

//        } else {
//            cratesDisplay.Add(line);
//            Console.WriteLine(line);
//        }

//    }
//}


using System.Text.RegularExpressions;


var stacks = Enumerable.Repeat(0, 9).Select(_ => new List<string>()).ToArray();

File.ReadAllLines(@"D:\Repos\AdventOfCode2022\AoC_Day_5\AoC_Day_5\stacks.txt")
    .Reverse()
    .ToList()
    .ForEach(line => Enumerable.Range(0, 9).Where(j => line[1 + j * 4] != ' ')
    .ToList()
    .ForEach(j => stacks[j].Add(line[1 + j * 4].ToString())));

File.ReadAllLines(@"D:\Repos\AdventOfCode2022\AoC_Day_5\AoC_Day_5\input.txt")
    .Select(line => Regex.Replace(line, "[a-zA-Z]", "").Split("  ").Select(int.Parse).ToArray()).ToList()
    .ForEach(rules => {
        stacks[rules[2] - 1].AddRange(stacks[rules[1] - 1].TakeLast(rules[0]));
        stacks[rules[1] - 1].RemoveRange(stacks[rules[1] - 1].Count - rules[0], rules[0]);
    });

stacks.ToList().ForEach(e => Console.Write(e.Last()));

Console.ReadKey();
