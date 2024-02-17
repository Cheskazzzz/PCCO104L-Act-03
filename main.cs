using System;

class Program {
static void Main(string[] args)
    {
        string output = "";

        Console.WriteLine("Enter Something or type 'exit' to quit:");

        string input = "";
        do
        {
            Console.Write("Enter Something: ");
            input = Console.ReadLine();

            if (input.ToLower() != "exit")
            {
                output += input + " ";
                Console.WriteLine(output);
            }
        } while (input.ToLower() != "exit");
        Console.WriteLine("\nClosing program...");
    }
}
