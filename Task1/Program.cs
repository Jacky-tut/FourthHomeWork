/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число A: ");
string numberOneStr = Console.ReadLine();
Console.WriteLine("Введите число B: ");
string numberTwoStr = Console.ReadLine();

int numberA = Convert.ToInt32(numberOneStr);
int numberB = Convert.ToInt32(numberTwoStr);
int tmp = numberA;
for (int i = 1; i <= numberB; i++)
{
    tmp = tmp * numberA;
}

double result = Math.Pow(numberA, numberB);
Console.WriteLine($"{result}");
