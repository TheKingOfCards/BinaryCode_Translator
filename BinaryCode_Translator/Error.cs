public class Error
{
    public void ErrorCode(string errorType)
    {
        string error = "";

        if (errorType == "IL") error = "Invalid length of binary code";

        if (errorType == "WC") error = "Invalid charakter in code";

        if (errorType == "Range") error = "Invalid size of decimal";

        Console.WriteLine($"ERROR: {error} -- Conversion could not be done" );
    }
}