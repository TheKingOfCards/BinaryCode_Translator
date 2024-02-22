Calculator calculator = new();
TakeInput takeInput = new();

while(true)
{
    calculator.Update(takeInput.Input(), takeInput.binary);
}

//Error type 1: Invalid length = "IL"
//Error type 2: Invalid Character = "WC"