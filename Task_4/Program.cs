// 4. Показать четные числа от 1 до N

Console.WriteLine("Будем искать все четные числа от 1 до N. Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i=2; i <= N; i++)
    if (i%2==0) Console.WriteLine(i);
