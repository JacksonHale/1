using System;
using System.IO;
int elfCount = 0;
int currentTotal = 0;
int calorieMax1 = 0;
int calorieMax2 = 0;
int calorieMax3 = 0;
int tempSwap = 0;
// read each line of text file 'input'
// considers a blank line the delimiter of each 'elf'
// counts total calories of each elf and compares to previous highest calorie count
// print at end
foreach (string line in System.IO.File.ReadLines("input.txt"))
{  
    if(line == "")
    {
        if(currentTotal > calorieMax3)
        {
            calorieMax3 = currentTotal;
            if(calorieMax3 > calorieMax2)
            {
                tempSwap = calorieMax2;
                calorieMax2 = calorieMax3;
                calorieMax3 = tempSwap;
                if(calorieMax2 > calorieMax1)
                {
                    tempSwap = calorieMax1;
                    calorieMax1 = calorieMax2;
                    calorieMax2 = tempSwap;
                }
            }
        }
        currentTotal = 0;
        elfCount++;
    } 
    else
    {
        currentTotal += Convert.ToInt32(line);
    }
}  
Console.WriteLine("Elf number 3 has " + Convert.ToString(calorieMax3) + " calories worth of food! that's a lot!"); 
Console.WriteLine("Elf number 2 has " + Convert.ToString(calorieMax2) + " calories worth of food! that's a lot!"); 
Console.WriteLine("Elf number 1 has " + Convert.ToString(calorieMax1) + " calories worth of food! that's a lot!"); 
Console.WriteLine("Together the elves have " + Convert.ToString(calorieMax1 + calorieMax2 + calorieMax3));
// Suspend the screen.  
System.Console.ReadLine();  