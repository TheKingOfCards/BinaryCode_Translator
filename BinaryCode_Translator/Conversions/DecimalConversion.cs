public class DecimalConversion
{
    private List<char> _inputList = new();


    public void Calculate(string input)
    {
        _inputList = input.ToList();

        ConvertDecimalToBinary();
    }


    void ConvertDecimalToBinary() //Decimal to Binary
    {
        while (IsValidInput(_inputList))
        {
            string userNumberString = ""; //* Must not contain anything

            while (_inputList[0] == ' ') _inputList.RemoveAt(0); // Removes spaces from list


            bool convertedCurrentNumber = false;
            while (!convertedCurrentNumber && _inputList.Count > 0)
            {
                if (_inputList[0] != ' ') // If the first char in the list is a number and adds to string
                {
                    userNumberString += _inputList[0];
                    _inputList.RemoveAt(0);
                }
                else if (_inputList[0] == ' ') // End if user has placed a space 
                {
                    convertedCurrentNumber = true;
                }
            }

            //Changes the temporary number into a int that is sent to the calculate method
            int userNumber = int.Parse(userNumberString);

            CalculateBinaryRepresentation(userNumber);
        }

    }


    void CalculateBinaryRepresentation(int currentNumber)
    {
        int compareNum = 128;

        bool hasPlacedZero = false; // Bool for if a 0 has been places (used to check so that a 1 is not accidentaly placed)


        if (currentNumber <= 255)
        {
            for (int i = 0; i < 8; i++)
            {
                if (compareNum > currentNumber) // Checks if user number is currently bigger than compareNum and if its is places a 0
                {
                    compareNum /= 2;
                    Console.Write('0');
                    hasPlacedZero = true;
                }

                if (compareNum <= currentNumber && hasPlacedZero == false) // Reverese than above and checks if a zero has been placed
                {
                    currentNumber -= compareNum;
                    compareNum /= 2;
                    Console.Write('1');
                }

                hasPlacedZero = false;
            }
            Console.Write(" "); // Space between binary codes
        }
        else // If the user has written a number larger than 255
        {
            Error.PrintError("Range");
            _inputList.Clear();
        }
    }


    static bool IsValidInput(List<char> checkList) // Checks if the input contains anything other than numbers
    {
        bool wrongCharcter = false;

        if (checkList.Count == 0)
        {
            return false;
        }

        foreach (char num in checkList)
        {
            if (num != '0' && num != '1' && num != '2' && num != '3' && num != '4' && num != '5' && num != '6' && num != '7' && num != '8' && num != '9' && num != ' ')
            {
                wrongCharcter = true;
            }
        }

        if (wrongCharcter == true) // return false
        {
            Error.PrintError("WC"); // Wrong character error code
            return false;
        }
        else return true;
    }
}