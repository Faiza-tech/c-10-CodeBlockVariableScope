﻿/*bool flag = true;
int value = 0;
if (flag){
    
    Console.WriteLine($"Inside the code block: {value}");
}
 value = 10;
Console.WriteLine($"Outside the code block: {value}");*/

int value = 5;
if (value > 0)
{
    int value2 = 6;
    int sum = value + value2;
    Console.WriteLine(sum);
}
Console.WriteLine($"Outside the code block: {value}");

//////////
bool flag = true;
if (flag)
{
    Console.WriteLine($"flag is:{flag}");
}

///////////////
/*string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");*/

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

//////
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        bool fouund = true;

        if (fouund)
        {
            Console.WriteLine("Set contains 42");

        }

        Console.WriteLine($"Total: {total}");
    }

}

/////////////////////
int[] num = { 4, 8, 15, 16, 23, 42 };
int totalSum = 0;
bool found = false;

foreach (int number in num)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {totalSum}");

