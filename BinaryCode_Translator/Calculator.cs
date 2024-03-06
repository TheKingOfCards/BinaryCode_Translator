using System.Reflection.Metadata;

public class Calculator
{
    DecimalConversion decmial = new();

    BinaryConversion binary = new();


    public void Update(string input, bool binaryBool)
    {
        if (binaryBool == true) binary.Calculate(input);

        else decmial.Calculate(input);

        Console.ReadKey();
    }
}