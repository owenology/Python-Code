// this code contains some very basic proof that I can do for loops.


// Code for squaring a number

/*
for (int i = 0; i <= 6; i++)
{
    int sqrNum = i * i;
    Console.WriteLine(sqrNum);
}
*/

// Code for displaying the multiplication table of a number entered by the user

/*
Console.WriteLine("Enter a whole number: ");
string enteredNumPH = Console.ReadLine();
int enteredNum = Convert.ToInt16(enteredNumPH);
for (int i = 1; i <= 12; i++)
{
    int output = enteredNum * i;
    Console.WriteLine(output);
}
*/

// Code for simulating 30 dice throws and keeping a running total of the results

/*
using System.Diagnostics;

Console.WriteLine("Throwing 30 die...");
int dieAmount = 0;
for (int i = 0; i < 30; i++)
{
    Console.WriteLine($"Throw {i}");
    Random rng = new Random();
    int rand1 = rng.Next(1, 7);
    Console.WriteLine($"{rand1}");
    dieAmount = dieAmount + rand1;
    Console.WriteLine($"New Total = {dieAmount}");
}
Console.WriteLine($"Final Total = {dieAmount}"); 
*/

// Code for measuring how long it takes to roll a die a user-specified number of times

/*
using System.Diagnostics; //

Console.WriteLine("Enter how many times you want to roll a die:");
string enteredNumPH2 = Console.ReadLine();
int enteredNum2 = Convert.ToInt32(enteredNumPH2);

var startTime = Stopwatch.GetTimestamp(); //

Console.WriteLine(startTime.ToString());
for (int i = 0; i <= enteredNum2; i++)
{
    Random rng = new Random();
    int rand1 = rng.Next(1, 7);
}

var endTime = Stopwatch.GetTimestamp(); //

var elapsed = TimeSpan.FromTicks(endTime - startTime); //

Console.WriteLine(elapsed.ToString());  //
*/

// Code for simulating dice rolls until the total reaches or exceeds 6000, counting the number of rolls required

/*
int totalRolled = 0;

int dieRolledPH = 0;

for (int i = 0; i <= 6000;)
{
    Random rng = new Random();
    int dieRolled = rng.Next(1, 7);
    i = i + dieRolled;
    totalRolled = totalRolled + 1;
}

Console.WriteLine("Minimum amount of rolls: 1,000");
Console.WriteLine("Maximum amount of rolls: 6,000");
Console.WriteLine("Average Rolls: 3,000");
Console.WriteLine($"Amount rolled: {totalRolled}");
*/
