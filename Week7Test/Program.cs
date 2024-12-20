//Console.WriteLine("Enter your comment:");
//string userInput = Console.ReadLine();

//CountSpaces(userInput);

//static void CountSpaces(string someString)
//{
//    someString = someString.Trim();
//    int wordCounter = 1;

//    foreach (char symbol in someString)
//    {
//        if (char.IsWhiteSpace(symbol))
//        {
//            wordCounter++;
//        }
//    }

//    string word = "word";
//    if (wordCounter > 1)
//    {
//        word = "words";
//    }

//    Console.WriteLine($"Your comment contains {wordCounter} {word}.");
//}

//using System.Security.Cryptography.X509Certificates;

//Console.WriteLine("Enter your name:");
//string userName = Console.ReadLine();

// GreetUser(userName);

//static void GreetUser(string someName)
//{
//    Console.WriteLine($"Hello, {someName}");
//}

Console.WriteLine("How many steps have you walked today?");
int usersSteps = Int32.Parse(Console.ReadLine());

double result = HealthMonitor(usersSteps);

Console.WriteLine(usersSteps);

static double HealthMonitor(int steps)
{
    if (steps < 4000)
    {
        Console.WriteLine("You need to move more.");
    }
    else if (steps >= 4000 && steps < 8000)
    {

        Console.WriteLine("Health goal achieved,");
    }
    else
    {

        Console.WriteLine("Well done!");
    }
}