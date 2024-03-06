Calculator calculator = new();
TakeInput takeInput = new();

while(true)
{
    calculator.Update(takeInput.GetInput(), takeInput.convertBinary);
}

// Error type 1: Invalid length = "IL"
// Error type 2: Invalid Character = "WC"
// Error type 3: Decimal is to big = "Range"