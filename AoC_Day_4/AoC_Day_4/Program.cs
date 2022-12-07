// See https://aka.ms/new-console-template for more information

//using AoC_Day_4;

//int partOneCount = 0;
//int partTwoCount = 0;
//Worker worker = new Worker();

//foreach (string line in System.IO.File.ReadAllLines(@"D:\Repos\AdventOfCode2022\AoC_Day_4\AoC_Day_4\assignments.txt")) {

//    partOneCount += worker.partOneParseLine(line); //part 1
//    partTwoCount += worker.partTwoParseLine(); //part 2



//}

//Console.WriteLine("Part 1:  " + partOneCount.ToString());
//Console.WriteLine("Part 2:  " + partTwoCount.ToString());

var theList = File.ReadAllLines(@"D:\Repos\AdventOfCode2022\AoC_Day_4\AoC_Day_4\assignments.txt")
    .Select(x => x.Split(",")
        .Select(x => x.Split("-")
            .Select(x => Convert.ToInt32(x)).ToArray()).ToArray());
//                                   37          36         87         87         37          36         87         87  37-87,36-87
var partOne = theList.Count(x => (x[0][0] <= x[1][0] && x[0][1] >= x[1][1]) || (x[0][0] >= x[1][0] && x[0][1] <= x[1][1]));
var partTwo = theList.Count(x => (x[0][0] >= x[1][0] && x[0][0] <= x[1][1] || x[0][1] >= x[1][0] && x[0][1] <= x[1][1]) || (x[1][0] >= x[0][0] && x[1][0] <= x[0][1] || x[1][1] >= x[0][1] && x[1][1] <= x[0][1]));

Console.ReadKey();
