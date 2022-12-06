// Напишите программу, которая принимает на вход два числа (A и B) и
// метод который возводит число A в натуральную степень B.
// Задание должно быть выполнено в методе.
// В методе не должно быть вывода в консоль. Не использовать Math.Pow()

Console.Clear();

int numberA = IntoInt();
int numberB = IntoInt();

double exponentOfNum = GetExponentOfNumber(numberA, numberB);

if (numberA == 0 && numberA == 0)
{
    Console.WriteLine("Incorrect number");
    return;
}

Console.WriteLine($"Число {numberA} в степени {numberB} = {exponentOfNum}");

double GetExponentOfNumber(int numA, int numB)
{
    double numAb = 1;
    for (int i = 0; i < numB; i++)
    {
        numAb = numA * numAb;
    }
    return numAb;
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


void Test()
{
    int[] introduced = new int[] { 1, 2, 3, 4 };
    int exponent = 3;
    int[] expected = new int[] { 1, 8, 27, 64 };
    for (int i = 0; i < introduced.Length; i++)
    {
        double actual = GetExponentOfNumber(introduced[i], exponent);
    
        if (actual != expected[i])
        {
            Console.WriteLine($"Ожидали получить {expected[i]} а получили {actual}");
        }
        else
        {
            Console.WriteLine("okay");
        }
    }
}

//Test();