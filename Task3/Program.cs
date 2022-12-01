/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    int result = 0;
    bool inCorrect = false;

    while(!inCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            inCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите корректное число");
        }
    }

    return result;
}

int numberMy = GetNumber("Введите любое число");

for (int i = 1; i <= numberMy; i++)
{
    int numberResult = i * i * i;
    Console.Write($"{numberResult}, ");
}