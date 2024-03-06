public class BinaryConversion
{
    private List<char> _allBits = new();

    private List<char> _calculateBits = new();

    private int _maxBits = 8;


    public void Calculate(string input)
    {
        input = input.Replace(" ", "");
        _allBits = input.ToList();

        ConvertBinaryToDecimal();
    }


    void ConvertBinaryToDecimal() // Binary => Decimal
    {
        while (_allBits.Count >= _maxBits && IsValidBinary(_allBits) && IsValidLength(_allBits, _maxBits)) // Runs when allBits has a higer count than 8
        {
            _calculateBits.Clear();

            for (int i = 0; i < _maxBits; i++) // Puts 8 elements from bits into calcBits to be printed into strings
            {
                _calculateBits.Add(_allBits[0]);
                _allBits.RemoveAt(0);
            }

            Console.Write(CalculateDecimalRepresentation() + " "); // Writes calculated byte and a space for seperation
        }

        Console.WriteLine(" ");
    }


    string CalculateDecimalRepresentation() //Converts from binary to decimal
    {
        string finishedNumberStr;

        double finishedNumb = 0;

        double exponent = 7;


        foreach (char bit in _calculateBits) // Converts binary to decimal
        {
            double temporaryAddition = 0;

            if (bit == '1') //* if it's a 1 it times it with a 2 to the power of the current exponent and adds it to finishedNumb 
            {
                temporaryAddition = Math.Pow(2, exponent);

                finishedNumb += temporaryAddition;
            }

            exponent--; // Subtracts because the binary code is calculated backwards 
        }

        finishedNumberStr = finishedNumb.ToString();

        return finishedNumberStr;
    }


    static bool IsValidBinary(List<char> checkList) //Checks binary list if it contains anything else than 1 and 0
    {
        bool wrongCharcter = false;

        foreach (char bit in checkList)
        {
            if (bit != '1' && bit != '0')
            {
                wrongCharcter = true;
            }
        }

        if (wrongCharcter)
        {
            Error.PrintError("WC");
            return false;
        }
        else return true;
    }


    static bool IsValidLength(List<char> checkList, int checkMultipleOfMax) // Checks length of binary code to se if it's a mutliple of 8
    {
        int checkNumber = 0;

        bool checkingLength = true;
        while (checkingLength)
        {
            if (checkNumber < checkList.Count) // Adds 8 to the checker if it's lower than bits count
            {
                checkNumber += checkMultipleOfMax;
            }

            if (checkNumber == checkList.Count) // If bits count is a multiple of 8
            {
                return true;
            }

            if (checkNumber > checkList.Count) // If bits count is not an multiple of 8
            {
                Error.PrintError("IL");
                return false;
            }
        }
        return false;
    }
}