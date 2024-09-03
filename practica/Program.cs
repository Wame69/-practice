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
//Console.WriteLine("Выберите фигуру которой вы хотите вычислить площадь(круг, треугольник, прямоугольник)");
//string figura = Console.ReadLine();
//double rezult = 0;
//if (figura == "круг")
//{
//    Console.WriteLine("Введите радиус: ");
//    int rad = int.Parse(Console.ReadLine());
//    rezult = 3.14 * rad * rad;
//    Console.WriteLine($"Площадь круга равна {rezult}");
//}
//if (figura == "треугольник")
//{
//    Console.WriteLine("Введите основание: ");
//    int osn = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите высоту: ");
//    int vus = int.Parse(Console.ReadLine());
//    rezult = 0.5 * osn * vus;
//    Console.WriteLine($"Площадь треугольника равна {rezult}");
//}
//if (figura == "прямоугольник")
//{
//    Console.WriteLine("Введите ширину: ");
//    int a = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите длину: ");
//    int b = int.Parse(Console.ReadLine());
//    rezult = a * b;
//    Console.WriteLine($"Площадь прямоугольник равна {rezult}");
//}
//9
//Console.WriteLine("Введите 1 для перевода единиц длины\n2 - для перевода единиц массы");
//int flag = Convert.ToInt16(Console.ReadLine());

//if (flag == 1)
//{
//    Console.WriteLine("Введите количество единиц: ");
//    double count = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine("Введите единицы измерения:\n1 - километры\n2 - метры\n3 - сантиметры\n4 - миллиметры");
//    flag = Convert.ToInt16(Console.ReadLine());

//    if (flag == 1)
//    {
//        Console.WriteLine($"Результат:\n" + count + " километров\n" + count * 1000 + " метров\n" + count * 100000 + " сантиметров\n" + count * 1000000 + " миллметров");
//    }
//    if (flag == 2)
//    {
//        Console.WriteLine($"Результат:\n" + count / 1000 + " километров\n" + count + " метров\n" + count * 100 + " сантиметров\n" + count * 1000 + " миллметров");
//    }

//    if (flag == 3)
//    {
//        Console.WriteLine($"Результат:\n" + count / 100000 + " километров\n" + count / 100 + " метров\n" + count + " сантиметров\n" + count * 10 + " миллметров");
//    }
//    if (flag == 4)
//    {
//        Console.WriteLine($"Результат:\n" + count / 1000000 + " километров\n" + count / 1000 + " метров\n" + count / 10 + " сантиметров\n" + count + " миллметров");
//    }
//}
//else if (flag == 2)
//{
//    Console.WriteLine("Введите кколичество единиц: ");
//    double count = Convert.ToInt16(Console.ReadLine());

//    Console.WriteLine("Введите единицы измерения:\n1 - тонны\n2 - килограммы\n3 - граммы");
//    flag = Convert.ToInt16(Console.ReadLine());

//    if (flag == 1) {
//        Console.WriteLine("Результат:\n" + count + " тонн\n" + count * 1000 + " килограмм\n" + count * 1000000 + " грамм");
//    }
//    if (flag == 2)
//    {
//        Console.WriteLine("Результат:\n" + count / 1000 + " тонн\n" + count  + " килограмм\n" + count * 1000 + " грамм");
//    }
//    if (flag == 3)
//    {
//        Console.WriteLine("Результат:\n" + count / 1000000 + " тонн\n" + count / 1000 + " килограмм\n" + count + " грамм");
//    }
//}
//10
//Console.WriteLine("Введите любое число: ");
//double a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите процент");
//int b = int.Parse(Console.ReadLine());
//double rezult = 0;
//rezult = a * b/100;
//Console.WriteLine(rezult);
//11
//Console.WriteLine("Выберите валюту которую хотите перевести (рубли, доллар, евро, йена)");
//string vall = Console.ReadLine();
//double rezult = 0;
//if (vall == "рубли")
//{
//    Console.WriteLine("Введите сумму: ");
//    double summa = int.Parse(Console.ReadLine());
//    Console.WriteLine("Выберите валюту в которую хотите перевести (доллар, евро, йена)");
//    vall = Console.ReadLine();
//    if(vall == "доллар")
//    {
//        rezult = summa * 0.011;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "евро")
//    {
//        rezult = summa * 0.010074;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "йена")
//    {
//        rezult = summa * 1.62;
//        Console.WriteLine(rezult);
//    }
//}
//if (vall == "доллар")
//{
//    Console.WriteLine("Введите сумму: ");
//    double summa = int.Parse(Console.ReadLine());
//    Console.WriteLine("Выберите валюту в которую хотите перевести (рубли, евро, йена)");
//    vall = Console.ReadLine();
//    if (vall == "рубли")
//    {
//        rezult = summa * 90;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "евро")
//    {
//        rezult = summa * 0.90373;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "йена")
//    {
//        rezult = summa * 146.64;
//        Console.WriteLine(rezult);
//    }

//}
//if (vall == "евро")
//{
//    Console.WriteLine("Введите сумму: ");
//    double summa = int.Parse(Console.ReadLine());
//    Console.WriteLine("Выберите валюту в которую хотите перевести (рубли, доллар, йена)");
//    vall = Console.ReadLine();
//    if (vall == "рубли")
//    {
//        rezult = summa * 99.26;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "доллар")
//    {
//        rezult = summa * 1.11;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "йена")
//    {
//        rezult = summa * 162.26;
//        Console.WriteLine(rezult);
//    }

//}
//if (vall == "йена")
//{
//    Console.WriteLine("Введите сумму: ");
//    double summa = int.Parse(Console.ReadLine());
//    Console.WriteLine("Выберите валюту в которую хотите перевести (рубли, доллар, евро)");
//    vall = Console.ReadLine();
//    if (vall == "рубли")
//    {
//        rezult = summa * 0.615604;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "доллар")
//    {
//        rezult = summa * 0.006819;
//        Console.WriteLine(rezult);
//    }
//    if (vall == "евро")
//    {
//        rezult = summa * 0.006163;
//        Console.WriteLine(rezult);
//    }

//}
//12
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
//int minElement = arr[0];
//int maxElement = arr[0];
//int minIndex = 0;
//int maxIndex = 0;
//for (int i = 1; i < arr.Length; i++)
//{
//  if (arr[i] < minElement)
//  {
//    minElement = arr[i];
//    minIndex = i;
//  }
//  else if (arr[i] > maxElement)
//  {
//     maxElement = arr[i];
//     maxIndex = i;
//  }
//}
//Console.WriteLine($"Минимальный элемент: {minElement} (индекс: {minIndex})");
//Console.WriteLine($"Максимальный элемент: {maxElement} (индекс: {maxIndex})");
