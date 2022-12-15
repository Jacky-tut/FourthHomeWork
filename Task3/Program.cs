Console.WriteLine("Введите размер массива: ");
int numbers =  int.Parse(Console.ReadLine());
int[] arr = new int[numbers];

Console.WriteLine("Введите числа через пробел:");
string[] arrayNumber =  Console.ReadLine().Split(' ');
 
for (int i = 0; i < arrayNumber.Length; i++)
{
    arr[i] = int.Parse(arrayNumber[i]);
    Console.Write($"{arr[i]}");
}




