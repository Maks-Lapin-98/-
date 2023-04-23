System.Console.WriteLine("Введите первое число "); 
string a = Console.ReadLine(); 
int d = int.Parse(a);

System.Console.WriteLine("Введите второе число "); 
string b = Console.ReadLine();
int e = int.Parse(b);

System.Console.WriteLine("Введите третье число "); 
string c = Console.ReadLine();
int f = int.Parse(c);

int max = 0;

if (max < d)
{
    max = d;
}

if (max < e)
{
    max = e;
}

if (max < f)
{
    max = f;
}

System.Console.WriteLine($"Максимальное число : {max}");