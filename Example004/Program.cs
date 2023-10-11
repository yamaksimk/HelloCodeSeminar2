// int a = 5;
// int b = 10;

// if (a == 5 && b == 10)
//     Console.WriteLine("Yes");

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine("Yes");
else
        Console.WriteLine("No");
