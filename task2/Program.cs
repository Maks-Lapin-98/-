System.Console.WriteLine("Введите первое число "); 
string a = Console.ReadLine(); 
int c = int.Parse(a);

System.Console.WriteLine("Введите Второе число ");
string b = Console.ReadLine();
int d = int.Parse(b);

if (c>d)
{
    System.Console.WriteLine($"Большее число {c}");
    System.Console.WriteLine($"Меньшее число {d}");
}
else if (d>c)
{
    System.Console.WriteLine($"Большее число {d}");
    System.Console.WriteLine($"Меньшее число {c}");
}
else {
    System.Console.WriteLine("Числа равны");
}