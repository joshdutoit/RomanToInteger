GetInputAndPrintOutput();

void GetInputAndPrintOutput()
{
    var input = Console.ReadLine();
    if(input == null)
        return;

    var output = RomanToInt(input);
    Console.WriteLine(output);
}

int RomanToInt(string input)
{
    Dictionary<char, int> NumeralToInt = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 100 }
    };

    int sum = 0;

    for (int i = 0; i < input.Length; i++)
    {
        char thisRomanChar = input[i];
        NumeralToInt.TryGetValue(thisRomanChar, out int num);

        if (i + 1 < input.Length && NumeralToInt[input[i + 1]] > NumeralToInt[thisRomanChar])
            sum -= num;
        else
            sum += num;
    }
    return sum;
}