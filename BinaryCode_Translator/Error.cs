public class Error
{
    public void ErrorCode(string errorType)
    {
        string error = "";

        if (errorType == "IL") error = "Invalid length of binary code: Conversion might be wrong";

        if (errorType == "WC") error = "Invalid charakter in code: Conversion could not be done";

        if (errorType == "Range") error = "Invalid size of decimal: Conversion could not be done";

        Console.WriteLine("ERROR: " + error);
    }
}