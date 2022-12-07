// See https://aka.ms/new-console-template for more information



string data = File.ReadAllText(@"D:\Repos\AdventOfCode2022\AoC_Day_6\AoC_Day_6\packet.txt");

int start = 0;
int windowLength = 14; //part 1 = 4 part 2 = 14

bool foundAnswer = false;

do {
    foundAnswer = checkRepeats(data.Substring(start, windowLength));
    start += 1;

} while (!foundAnswer);

Console.WriteLine("Part 1: " + (start + 13).ToString());

bool checkRepeats(string window) {

    return window.Distinct().Count() == window.Length;

}

Console.ReadKey();
