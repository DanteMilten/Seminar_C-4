//24 Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A
// a = 5
// sum = 1 + 2 + 3 + 4 + 5


Console.Clear();
Console.Write ("Введите число: ");
int n = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Сумма чисел от 1 до {n} равна {GetSum (n)}");
int GetSum (int limit) {
    int sum = 0;
    for (int i = 1; i <= limit; i++){
        sum += i;
    }
    //Console.WriteLine($"Сумма от 1 до {limit} равна {sum}");
    return sum;
}

// Console.Clear();
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= A; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine($"Результат выполнения программы = {sum}");