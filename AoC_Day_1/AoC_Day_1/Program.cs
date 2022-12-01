// See https://aka.ms/new-console-template for more information

int runningTotal = 0;
int highestTotal = 0;
int secondHighestTotal = 0;
int thirdHighestTotal = 0;

foreach (string line in System.IO.File.ReadLines(@"D:\Repos\AdventOfCode2022\AoC_Day_1\elves.txt")) {

    try {
        int curr = Int32.Parse(line);
        runningTotal += curr;

    } catch (Exception e) {

        if(e.Message.Contains("Input string was not in a correct format.")){
            //This is a line break
            if (runningTotal > highestTotal) {
                secondHighestTotal = highestTotal;
                thirdHighestTotal = secondHighestTotal;
                highestTotal = runningTotal;
            } else if (runningTotal > secondHighestTotal) {
                thirdHighestTotal = secondHighestTotal;
                secondHighestTotal = runningTotal;
            } else if (runningTotal > thirdHighestTotal) {
                thirdHighestTotal = runningTotal;
            }
            runningTotal = 0;
        }
            
    }
    
}

Console.WriteLine("Highest Calorie Count:  " + highestTotal.ToString());
Console.WriteLine("Second Highest Calorie Count:  " + secondHighestTotal.ToString());
Console.WriteLine("Third Highest Calorie Count:  " + thirdHighestTotal.ToString());

Console.WriteLine();  
Console.WriteLine("Total of all three:  " + (highestTotal + secondHighestTotal + thirdHighestTotal).ToString());

Console.ReadKey();