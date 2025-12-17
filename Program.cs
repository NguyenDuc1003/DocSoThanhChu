
Console.Write("Nhập số nguyên không âm (tối đa 3 chữ số): ");
if (!int.TryParse(Console.ReadLine(), out int number) || number < 0 || number > 999)
{
    Console.WriteLine("out of ability");
    return;
}

string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

string result = "";
if (number < 10)
{
    // Đọc số có 1 chữ số
    switch (number)
    {
        case 0: result = ones[0]; break;
        case 1: result = ones[1]; break;
        case 2: result = ones[2]; break;
        case 3: result = ones[3]; break;
        case 4: result = ones[4]; break;
        case 5: result = ones[5]; break;
        case 6: result = ones[6]; break;
        case 7: result = ones[7]; break;
        case 8: result = ones[8]; break;
        case 9: result = ones[9]; break;
    }
}
else if (number < 20)
{
    // Đọc số có 2 chữ số nhỏ hơn 20
    int onesDigit = number % 10;
    switch (onesDigit)
    {
        case 0: result = teens[0]; break;
        case 1: result = teens[1]; break;
        case 2: result = teens[2]; break;
        case 3: result = teens[3]; break;
        case 4: result = teens[4]; break;
        case 5: result = teens[5]; break;
        case 6: result = teens[6]; break;
        case 7: result = teens[7]; break;
        case 8: result = teens[8]; break;
        case 9: result = teens[9]; break;
    }
}
else if (number < 100)
{
    // Đọc số có 2 chữ số lớn hơn hoặc bằng 20
    int tensDigit = number / 10;
    int onesDigit = number % 10;
    result = tens[tensDigit];
    if (onesDigit != 0)
    {
        result += " " + ones[onesDigit];
    }
}
else
{
    // Đọc số có 3 chữ số
    int hundredsDigit = number / 100;
    int remainder = number % 100;
    result = ones[hundredsDigit] + " hundred";
    if (remainder != 0)
    {
        result += " and ";
        if (remainder < 10)
        {
            switch (remainder)
            {
                case 0: result += ones[0]; break;
                case 1: result += ones[1]; break;
                case 2: result += ones[2]; break;
                case 3: result += ones[3]; break;
                case 4: result += ones[4]; break;
                case 5: result += ones[5]; break;
                case 6: result += ones[6]; break;
                case 7: result += ones[7]; break;
                case 8: result += ones[8]; break;
                case 9: result += ones[9]; break;
            }
        }
        else if (remainder < 20)
        {
            int onesDigit = remainder % 10;
            switch (onesDigit)
            {
                case 0: result += teens[0]; break;
                case 1: result += teens[1]; break;
                case 2: result += teens[2]; break;
                case 3: result += teens[3]; break;
                case 4: result += teens[4]; break;
                case 5: result += teens[5]; break;
                case 6: result += teens[6]; break;
                case 7: result += teens[7]; break;
                case 8: result += teens[8]; break;
                case 9: result += teens[9]; break;
            }
        }
        else
        {
            int tensDigit = remainder / 10;
            int onesDigit = remainder % 10;
            result += tens[tensDigit];
            if (onesDigit != 0)
            {
                result += " " + ones[onesDigit];
            }
        }
    }
}

Console.WriteLine(result);
