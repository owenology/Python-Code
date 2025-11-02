// This code is made up of many different IF statements, very basic code, but yet again proof I've been over it.


/* ---------------- Checks if you're 18 or older.



Console.WriteLine("Please enter your age...");
int age = Convert.ToInt16(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("You can not vote");
}
else
{
    Console.WriteLine("You cannot vote");
}

*/


/* ----------------  Gives you a grade based on marks

Console.WriteLine("What mark did you get on your test? : ");
string markPlaceHolder = Console.ReadLine();
double mark = Convert.ToDouble(markPlaceHolder); // changing marks into a numerical format


if (mark >= 80 && mark < 101) // anything above 100 is unachieveable, so they cheated, grade D
{
    string grade = ("A");
    Console.WriteLine($"The grade you got from your test is {grade}");
}
else
{
    if (mark >= 60 && mark < 80)
    {
        string grade = ("B");
        Console.WriteLine($"The grade you got from your test is {grade}");
    }
    else
    {
        if (mark >= 50 && mark < 65)
        {
            string grade = ("C");
            Console.WriteLine($"The grade you got from your test is {grade}");
        }
        else
        {
            string grade = ("D");
            Console.WriteLine($"The grade you got from your test is {grade}");
        }
    }
}

/* ---------------- Gives you an average mark based on assignment and test score

using System.Reflection;

Console.WriteLine("What's your student number?");
string studentNumPH = Console.ReadLine();
Console.WriteLine("What's your assignment mark?");
string assignNumPH = Console.ReadLine();
Console.WriteLine("What's your test mark?");
string testNumPH = Console.ReadLine();

double studentNum = Convert.ToDouble(studentNumPH);
double assignNum = Convert.ToDouble(assignNumPH);
double testNum = Convert.ToDouble(testNumPH);

double markAvg = ((assignNum + testNum) / 2);
Console.WriteLine(markAvg);


*/
