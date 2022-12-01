/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
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

int x1 = GetNumber("введите x1");
int x2 = GetNumber("введите x2");
int x3 = GetNumber("введите x3");
int y1 = GetNumber("введите y1");
int y2 = GetNumber("введите y2");
int y3 = GetNumber("введите y3");

double sum1 = Math.Pow(((x3 + x2) - x1), 2);
double sum2 = Math.Pow(((y3 + y2) - y1), 2);

double result = Math.Sqrt(sum1 + sum2);

Console.WriteLine($"Расстояние между точек: {result}");