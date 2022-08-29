Console.Write("Введите колличество чисел: ");
int numbers = int.Parse(Console.ReadLine()!);
int count = 0;
for (int i = 0; i < numbers; i++)
{
    Console.Write($"Число {i + 1}: ");
     int number = int.Parse(Console.ReadLine()!);
     if (number > 0)
         count++;
 }
Console.WriteLine($"Количество чисел больше 0: {count}");