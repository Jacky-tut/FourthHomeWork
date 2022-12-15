/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()??"");
numberA = Math.Abs(numberA);
string numberOneStr = Convert.ToString(numberA);

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()??"");
numberB = Math.Abs(numberB);
string numberTwoStr = Convert.ToString(numberB);


int tmp = numberA;
for (int i = 1; i <= numberB; i++)
{
    tmp = tmp * numberA;
}

double result = Math.Pow(numberA, numberB);
Console.WriteLine($"{result}");
