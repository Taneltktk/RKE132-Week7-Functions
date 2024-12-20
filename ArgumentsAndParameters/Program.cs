
//PrintAnyWord();

Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); //userInput - argument lihtsalt
static void PrintAnyWord(string anyString) //anyString - see on lihtsalt parameter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}
