public class TakeInput
{
    public bool binary;


    public string Input()
    {
        string i = "";

        ChooseConversion();

        if (binary)
        {
            Console.WriteLine("Write your binary code");
        }
        else
        {
            Console.WriteLine("Write your decimal number");
            Console.WriteLine("Separate numbers by using space");
        }

        i = Console.ReadLine();

        if (i == "")
        {
            Console.WriteLine("Type something");
            Console.ReadKey();
            Environment.Exit(0);
        }

        return i;
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
                binary = true;
            }
            else if (input == '2')
            {
                binary = false;
            }
            else if (input == 'e')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nThat is not an option");
                Console.ReadKey();
                choosing = true;
            }
            Console.Clear();
        }
    }
}