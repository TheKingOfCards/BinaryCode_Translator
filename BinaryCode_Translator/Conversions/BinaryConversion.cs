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


    void Conversion() // Binary => Decimal
    {
        input = input.Replace(" ", "");
        bits = input.ToList();

        CheckBinaryCode();

        CheckLength();

        while (bits.Count >= 8) // Runs when bits has higer count than 8
        {
            calcBits.Clear();

            for (int i = 0; i < 8; i++) // Puts 8 elements from bits into calcBits to be printed into strings
            {
                calcBits.Add(bits[0]);
                bits.RemoveAt(0);
            }

            Console.Write(CalculateBinary() + " "); // Writes calculated byte and a space for seperation
        }

        Console.WriteLine(" ");
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

            if (bit == '1') //* if it's a 1 it times it with a 2 to the power of the current exponent and adds it to finishedNumb 
            {
                tempAddition = Math.Pow(2, exponent);

                finishedNumb += tempAddition;
            }

            exponent--; // It's -- because the binary code is calculated backwards 
        }

        finish = finishedNumb.ToString();

        return finish;
    }


    void CheckBinaryCode() //Checks binary list if it contains anything else than 1 and 0
    {
        foreach (char bit in bits)
        {
            if (bit != '1' && bit != '0')
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


    void CheckLength() // Checks length of binary code to se if it's a mutliple of 8
    {
        bool checkingLength = true;

        int checkNum = 0;

        while (checkingLength)
        {
            checkingLength = true;

            if (checkNum < bits.Count) // Adds 8 to the checker if it's lower than bits count
            {
                checkNum += 8;
            }

            if (checkNum == bits.Count) // If bits count is a multiple of 8
            {
                checkingLength = false;
            }

            if (checkNum > bits.Count) // If bits count is not an multiple of 8
            {
                bits.Clear();
                error.ErrorCode("IL");
                checkingLength = false;
            }
        }
    }
}