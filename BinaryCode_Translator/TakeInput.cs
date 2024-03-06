public class TakeInput
{
    public bool convertBinary;


    public string GetInput()
    {
        ChooseConversion();


        string input = "";

        while(input == "")
        {
            if (convertBinary)
            {
                Console.WriteLine("Write your binary code");
            }
            else
            {
                Console.WriteLine("Write your decimal number");
                Console.WriteLine("Separate numbers by using space");
            }

            input = Console.ReadLine();
        
            if (input == "")
            {
                Console.WriteLine("Type something");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
        return input;
    }


    void ChooseConversion() //User chooses which converson they want to do
    {
        Console.Clear();

        bool choosing = true;
        while (choosing)
        {
            choosing = false;

            Console.WriteLine("1. Binary => Decimal");
            Console.WriteLine("2. Decimal => Binary");
            Console.WriteLine("E. Exit");

            Console.WriteLine("\nChoose conversion by pressing the number infront of the correct one");
            char input;

            input = Console.ReadKey().KeyChar;

            if (input == '1')
            {
                convertBinary = true;
            }
            else if (input == '2')
            {
                convertBinary = false;
            }
            else if (input.ToString().ToLower() == "e")
            {
                Environment.Exit(0);
            }
            else
            {
                choosing = true;
            }

            Console.Clear();
        }
    }
}