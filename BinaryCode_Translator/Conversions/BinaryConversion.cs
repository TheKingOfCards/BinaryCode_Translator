public class BinaryConversion
{
    string input = "";

    List<char> bits = new();

    List<char> calcBits = new();

    bool wrongCharcter = false;

    double exponent = 0;

    readonly Error error = new();


    public void Update(string i)
    {
        input = i;

        Conversion();
    }


    void Conversion() //When user wants to convert binary to decimal
    {
        input = input.Replace(" ", "");
        bits = input.ToList();

        CheckBinaryCode();

        while (bits.Count >= 8) //* Runs when bits has higer count than 8
        {
            calcBits.Clear();

            for (int i = 0; i < 8; i++) //Puts 8 elements from bits into calcBits to be converted
            {
                calcBits.Add(bits[0]);
                bits.RemoveAt(0);
            }

            Console.Write(CalculateBinary() + " "); //Writes calculated byte and a space for seperation
        }

        Console.WriteLine(" ");


        if (bits.Count != 0) //Error checking
        {
            error.ErrorCode("IL");
        }
    }


    string CalculateBinary() //Converts from binary to decimal
    {
        string finish;

        double finishedNumb = 0;

        exponent = 0;
        exponent = 7;



        foreach (char bit in calcBits) // Converts binary to decimal
        {
            double tempAddition = 0;

            if (bit == '1') //* if it's a 1 times it with a 2 to the power of the current exponent and and it to finishedNumb 
            {
                tempAddition = Math.Pow(2, exponent);

                finishedNumb += tempAddition;
            }

            exponent--;
        }

        finish = finishedNumb.ToString();

        return finish;
    }


    void CheckBinaryCode() //Checks binary list if it contains anything else than 1 and 0
    {
        foreach (char bit in bits)
        {
            if (bit != '1' && bit != '0' && bit != ' ')
            {
                wrongCharcter = true;
            }
        }

        if (wrongCharcter) 
        {
            bits.Clear();

            error.ErrorCode("WC");
        }
    }
}