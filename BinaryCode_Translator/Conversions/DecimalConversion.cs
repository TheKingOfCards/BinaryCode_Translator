public class DecimalConversion
{
    string input = "";

    bool wrongCharcter = false;
    bool decimalDone = false;

    List<char> tempNumber = new();

    readonly Error error = new();

    public void Update(string i)
    {
        input = i;
        
        Conversion();
    }


    void Conversion() //Decimal => Binary
    {
        tempNumber = input.ToList();

        CheckDecimal();

        while (!decimalDone)
        {
            string userNumS = "";

            bool convertedCurrentNum = false;


            while (!convertedCurrentNum && tempNumber.Count > 0) //Puts one number in a temporary string
            {
                if (tempNumber[0] != ' ')
                {
                    userNumS += tempNumber[0];
                }

                if (tempNumber[0] == ' ')
                {
                    convertedCurrentNum = true;
                }

                tempNumber.RemoveAt(0);

            }

            //Changes the temporary number into a int that is sent to the calculate method
            int userNum = int.Parse(userNumS);

            CalculateDecimal(userNum);


            if (tempNumber.Count == 0) //Chekcs if the list with everything is empty
            {
                decimalDone = true;
            }
        }

    }


    void CalculateDecimal(int calcUserNum)
    {
        int compareNum = 128;

        bool hasPlaced0 = false;
        

        if (calcUserNum <= 255)
        {
            for (int i = 0; i < 8; i++)
            {
                if (compareNum > calcUserNum)
                {
                    compareNum /= 2;
                    Console.Write('0');
                    hasPlaced0 = true;
                }

                if (compareNum <= calcUserNum && hasPlaced0 == false)
                {
                    calcUserNum -= compareNum;
                    compareNum /= 2;
                    Console.Write('1');
                }
                hasPlaced0 = false;
            }
            Console.WriteLine(" ");
        }
        else
        {
            error.ErrorCode("Range");
        }
    }


    void CheckDecimal()
    {
        foreach (char num in tempNumber)
        {
            if (num != '0' && num != '1' && num != '2' && num != '3' && num != '4' && num != '5' && num != '6' && num != '7' && num != '8' && num != '9' && num != ' ')
            {
                wrongCharcter = true;
            }
        }

        if (wrongCharcter == true)
        {
            decimalDone = true;
            error.ErrorCode("WC");
        }
        else
        {
            decimalDone = false;
        }
    }
}