// See https://aka.ms/new-console-template for more information

var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"luhn_numbers.txt");

using (var reader = new StreamReader(filepath))
{
    string cardNumber;
    while ((cardNumber = reader.ReadLine()) != null)
    {
        if (Checker(cardNumber))
        {
            Console.WriteLine($"{cardNumber} is valid ");
        }
        else
        {
            Console.WriteLine($"{cardNumber} is invalid ");
        }
    }
    
}

bool Checker(string cardNumber)
{
    var numberList = new List<int>();
    foreach (var c in cardNumber)
    {
     numberList.Add(int.Parse(c.ToString()));   
    }

    var digits = numberList.ToArray();
    var checkDigit = Luhn(digits);
    return IsCheckDigitValid(digits, checkDigit);
}


int Luhn(int[] digits) // i copied this couse i dont know enough to make it myself...
{
    int checkDigit = 0;
    for (int i = digits.Length - 2; i >= 0; --i)
        checkDigit += ((i & 1) is 0) switch
        {
            true  => digits[i] > 4 ? digits[i] * 2 - 9 : digits[i] * 2,
            false => digits[i]
        };

    return checkDigit;
}

bool IsCheckDigitValid(int[] digits, int checkDigit)
{
    return 10 - (checkDigit % 10) == digits.Last();
}