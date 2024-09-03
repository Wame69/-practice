//Console.WriteLine("Введите первое любое число: ");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе любое число: ");
//double d = double.Parse(Console.ReadLine());
//Console.WriteLine("Что вы хотите сделать с этими числами(введите +,-,*,/)");
//string oper = Console.ReadLine();
//double rezult = 0;
//if (oper == "+")
//{
//    rezult = a + d;
//    Console.WriteLine($"Сумма чисел равна{rezult}");
//}
//if (oper == "-")
//{
//    rezult = a - d;
//    Console.WriteLine($"Разность чисел равна{rezult}");
//}
//if (oper == "/")
//{
//    if (a == 0 || d == 0)
//    {
//        Console.WriteLine("Делить на ноль нельзя");
//        return;
//    }
//    rezult = a / d;
//    Console.WriteLine($"Деление чисел равна{rezult}");
//}
//if (oper == "*")
//{
//    rezult = a * d;
//    Console.WriteLine($"Умножение чисел равна{rezult}");
//}
//2
//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//int b = 0;
//int c = 0;
//foreach (char i in str)
//{
//    if (i ==  ' ')
//    { 
//        b++; 
//    }
//    if (i == '.' || i == '!' || i == '?')
//    { 
//        c++; 
//    }
//}
//Console.WriteLine($"Символов в строке {str.Length}, слов в строку {b + 1}, предложений в строке {c}");
//3
//Console.WriteLine("Таблица умножения!");
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 11; j++)
//    {
//        Console.WriteLine(i + " * " + j + " = " + i * j);
//    }
//}
//4
//Console.WriteLine("Введите число");
//int num = int.Parse(Console.ReadLine());
//int fac = 1;
//for (int i = 1; i <= num; i++)
//{
//    fac = fac * i;
//}
//Console.WriteLine($"Число фибоначчи{fac}");
//5
//Console.WriteLine("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int j = 1;
//for (int i = 1; i <= n; i += j)
//{
//    Console.Write("{0} ", i);
//    j = i - j;
//}
//6
//class program
//{
//    public static bool IsPrime(int number)
//    {
//        for (int i = 2; i < number; i++)
//        {
//            if (number % i == 0)
//                return false;
//        }
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Простые числа: ");

//        for (int i = 2; i < n; i++)
//        {
//            if (IsPrime(i)) Console.WriteLine(i);
//        }
//    }
//}
//7
//Random random = new Random();
//int rand = random.Next(0, 100);
//int num = 10;
//while (num > 0)
//{
//    Console.WriteLine($"У вас осталось: {num} попыток. Введите число:");
//    int a = Convert.ToInt32(Console.ReadLine());

//    if (a == rand)
//    {
//        Console.WriteLine("Вы угодали число"); break;
//    }
//    else if (a != rand)
//    {
//        Console.WriteLine("Вы не угодали число");
//        num--;
//    }
//}
//8
