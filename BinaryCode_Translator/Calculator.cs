using System.Reflection.Metadata;

public class Calculator
{
    string input = "";



    List<char> tempNumber = new();

    DecimalConversion decmial = new();

    BinaryConversion binary = new();


    public void Update(string i, bool binaryBool)
    {
        input = i;
        if (binaryBool == true)
        {
            binary.Update(input);
        }
        else
        {
            decmial.Update(input);
        }
        Console.ReadKey();
    }
}