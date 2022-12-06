// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int number = IntoInt();
int sumNumber = SumOfDigitsInNumber(number);

if (sumNumber == 0)
{
    Console.WriteLine("Incorrect number");
    return;
}

Console.WriteLine($"Сумма цифр числа {number} равна {sumNumber}");


int SumOfDigitsInNumber(int num)
{
    int sum = 0;
    for(int i = 0; num % 10 != 0 | num != 0;i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}


int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (!isParsed || num < 1)
    {
        return 0;
    }
    else
    {
        return num;
    }
}
