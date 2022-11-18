namespace CsharpOrJavaDecisionmaker;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Weet je nog niet of je voor Java of C# moet kiezen?\nPress enter to toss a coin...");
        Console.ReadKey();
        while (true)
        {
            Console.WriteLine(MakeDecision());
            Console.Write("Nog een keer gooien (n/Y): ");
            if (Console.ReadLine() == "n")
            {
                Console.WriteLine("Bedankt voor het spelen!");
                return;
            }
        }
    }

    static string MakeDecision()
    {
        string s;
        Random rand = new Random();

        if (rand.NextDouble() < 0.9)
        {
            s = "C#";
        }
        else
        {
            s = "Java";
        }
        return s;
    }
}

