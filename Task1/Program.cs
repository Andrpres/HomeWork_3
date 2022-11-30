/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    int result = 0;
    bool inCorrect = false;

    while(!inCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 10000 && result < 99999)
        {
            inCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите именно пятизначное число");
        }
    }

    return result;
}

int numberMy = GetNumber("Введите пятизначное число");

int numberSecond = numberMy / 1000;
int numberSecondConversely = ((numberSecond % 10) * 10) + (numberSecond / 10);

if((numberMy % 100) == numberSecondConversely){
    Console.WriteLine($"-> да");
}else
    Console.WriteLine($"-> нет");