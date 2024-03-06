public static class Error
{
    public static void PrintError(string errorType)
    {
        string error = "";

        if (errorType == "IL") error = "Invalid length of binary code";

        if (errorType == "WC") error = "Invalid character in code";

        if (errorType == "Range") error = "Invalid size of decimal";

        Console.WriteLine($"ERROR: {error} -- Conversion could not be done" );
    }
}