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
//13   

//int[] arr = {1, 324, 23, 358, 2, 5, 3, 6, 7, 3, 45, 23, 642, 35, 543};
//Array.Sort(arr);
//Console.WriteLine("Отсортированный по возрастанию массив:");
//foreach (int element in arr)
//{
//    Console.Write($"{element} ");
//}
//Console.WriteLine();
//// Сортировка по убыванию
//Array.Sort(arr, new Comparison<int>((a, b) => b.CompareTo(a)));
//Console.WriteLine("Отсортированный по убыванию массив:");
//foreach (int element in arr)
//{
//    Console.Write($"{element} ");
//}
//Console.WriteLine();

//14
//int[] arr = { 1, 324, 23, 358, 2, 5, 3, 6, 7, 3, 45, 23, 642, 35, 543 };
//// Ввод искомого элемента
//Console.Write("Введите искомый элемент: ");
//int element = int.Parse(Console.ReadLine());
//// Поиск элемента
//int index = Array.IndexOf(arr, element);
//// Вывод результата
//if (index >= 0)
//{
//   Console.WriteLine($"Элемент найден на индексе {index + 1}.");
//}
//else
//{
//   Console.WriteLine("Элемент не найден.");
//}

//15
//Console.Write("Введите элементы массива, разделённые пробелами: ");
//int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//Console.WriteLine("Элементы массива в обратном порядке:");
//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    Console.Write($"{arr[i]} ");
//}
//Console.WriteLine();
//16
/*Console.WriteLine("Введите размер матрицы AxB");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int[,] matr = new int[a,b];
int[,] matr1 = new int[a, b];
Console.WriteLine("Введите первую матрицу");
for (int i = 0; i < a; i++)
{
    for(int j = 0; j < b; j++)
    {
        matr[i,j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Введите 2 матрицу");
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        matr1[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Введите операцию * + - транспорирование");
switch (Console.ReadLine())
{
    case "+":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] + matr1[i, j];
            }
        }
        break;
    case "-":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] - matr1[i, j];
            }
        }
        break;
    case "*":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr[i, j] = matr[i, j] * matr1[i, j];
            }
        }
        break;
    case "транспорирование":
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                matr1[j, i] = matr[i, j];
            }
        }
        matr = matr1;
        break;
}
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        Console.Write(matr[i,j] + " ");
    }
    Console.WriteLine(" ");
}*/
//17
/*Console.WriteLine("Введите ваше 10-ное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите систему счисления для перевода (2, 8, 16)");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 2:
        string result = Convert.ToString(num, 2);
        Console.WriteLine(result);
        break;
    case 8:
        string result1 = Convert.ToString(num, 8);
        Console.WriteLine(result1);
        break;
    case 16:
        string result2 = Convert.ToString(num, 16);
        Console.WriteLine(result2);
        break;
}*/
//18
/*Console.WriteLine("Числовая пирамида");
int l = 1 + 2 * (10 - 1);
int n = 1;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(new string(' ', (int)(l - n / 2)) + new string('1', n));
    n += 2;
}*/
/*//19
Console.WriteLine("Введите строку");
string str = Console.ReadLine();
Console.WriteLine("Введите подстроку для поиска");
string substr = Console.ReadLine();
int index = str.IndexOf(substr);
if (index == -1)
{
    Console.WriteLine("Вхождения не найдено");
}
else
{
    Console.WriteLine(index);
}*/
//task 20
Console.WriteLine("Удаление пробелов");
Console.WriteLine("Ваша строка");
string str = Console.ReadLine();
while (str.Contains("  ")) 
{
    str = str.Replace("  ", " ");
}
Console.WriteLine(str);
//21
/*Console.WriteLine("Введите первую дату (ДД.ММ.ГГГГ):");
string firstDateInput = Console.ReadLine();
Console.WriteLine("Введите вторую дату (ДД.ММ.ГГГГ):");
string secondDateInput = Console.ReadLine();
DateTime firstDate;
DateTime secondDate;
if (DateTime.TryParseExact(firstDateInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out firstDate) &&
    DateTime.TryParseExact(secondDateInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out secondDate))
{
    TimeSpan difference = secondDate - firstDate;
    int daysDifference = (int)difference.TotalDays;
    Console.WriteLine($"Количество дней между датами: {daysDifference}");
}
else
{
    Console.WriteLine("Некорректный формат даты. Используйте формат ДД.ММ.ГГГГ.");
}*/
//22
/*using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
static void CheckPhoneNum()
{
    Console.WriteLine("Введите номер телефона (проверка работает только на номера России):");
    string phoneNumber = Console.ReadLine();
    if (phoneNumber.Length > 11)
    {
        Console.WriteLine("Номер телефона должен состоять из 11 цифр.");
    }
    if (phoneNumber.Length == 11 && phoneNumber[0] == '8' && phoneNumber[1] == '9')
    {
        bool isNumeric = true;
        foreach (char c in phoneNumber)
        {
            if (!char.IsDigit(c))
            {
                isNumeric = false;
                break;
            }
        }

        if (isNumeric)
        {
            Console.WriteLine("Номер телефона введен корректно!");
        }
        else
        {
            Console.WriteLine("Номер телефона должен состоять только из цифр.");
        }
    }

}
static void CheckEmail()
{
    Console.WriteLine("Введите вашу эл.почту");
    string email = Console.ReadLine();
    if (email.Contains("@") && email.Contains(".") && email.IndexOf('@') > 0 && email.IndexOf('.') > email.IndexOf('@'))
    {
        Console.WriteLine("Ваша почта верна");
    }
    else
    {
        Console.WriteLine("Ваша почта не верна");
    }

}
Console.WriteLine("\nВыберите, что вы хотите проверить: ");
Console.WriteLine("1. Номер телефона");
Console.WriteLine("2. email");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        CheckPhoneNum();
        break;
    case 2:
        CheckEmail();
        break;
}
    */
    /*//23
public class PasswordGenerator
{
    public static string GeneratePassword(int length, bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial)
    {
        Random random = new Random();
        if (length <= 0)
            throw new ArgumentException("Длина пароля должна быть положительным числом");

        char[] password = new char[length];
        string charsToUse = "";

        if (useLowercase) charsToUse += "abcdefghijklmnopqrstuvwxyz";
        if (useUppercase) charsToUse += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (useNumbers) charsToUse += "0123456789";
        if (useSpecial) charsToUse += "!@#$%^&*()-_=+";

        for (int i = 0; i < length; i++)
        {
            password[i] = charsToUse[random.Next(charsToUse.Length)];
        }

        return new string(password);
    }
    static void Main()
    {
        Console.WriteLine("Введите желаемую длину пароля");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Далее выбирайте true/false");
        Console.WriteLine("Использовать маленькие буквы?");
        bool useLowercase = bool.Parse(Console.ReadLine());
        Console.WriteLine("Использовать большие буквы?");
        bool useUppercase = bool.Parse(Console.ReadLine());
        Console.WriteLine("Использовать цифры?");
        bool useNumbers = bool.Parse(Console.ReadLine());
        Console.WriteLine("Использовать специальные символы");
        bool useSpecial = bool.Parse(Console.ReadLine());
        string password = PasswordGenerator.GeneratePassword(length, useLowercase, useUppercase, useNumbers, useSpecial);
        Console.WriteLine("Вот ваш пароль " + password);
    }
}
*/
//24
//24
/*class magazine
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество покупок: ");
        int count = Convert.ToInt32(Console.ReadLine());

        List<Purchase> purchases = new List<Purchase>();

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите название {i + 1} покупки: ");
            string name = Console.ReadLine();

            Console.Write($"Введите стоимость {i + 1} покупки: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            purchases.Add(new Purchase(name, price));
        }

        decimal total = 0;
        decimal vat = 0;

        Console.WriteLine("Чек:");
        foreach (var purchase in purchases)
        {
            Console.WriteLine($"{purchase.Name} - {purchase.Price} руб.");

            total += purchase.Price;
            vat += purchase.Price * 0.2m; // 20% НДС
        }

        Console.WriteLine($"Общая сумма: {total} руб.");
        Console.WriteLine($"НДС: {vat} руб.");
        Console.WriteLine($"Итого: {total + vat} руб.");
    }
}
class Purchase
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Purchase(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}*/
//25
/*using System;
using System.Collections.Generic;
using System.Linq;

namespace WordAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var wordFrequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (wordFrequency.ContainsKey(lowerWord))
                {
                    wordFrequency[lowerWord]++;
                }
                else
                {
                    wordFrequency.Add(lowerWord, 1);
                }
            }

            var sortedWords = wordFrequency.OrderByDescending(pair => pair.Value);
            Console.WriteLine("Статистика частоты слов:");
            foreach (var pair in sortedWords)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}*/
////26 
/*using System;

class TimeCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое время (часы и минуты через пробел): ");
        string[] time1 = Console.ReadLine().Split(' ');
        int hours1 = Convert.ToInt32(time1[0]);
        int minutes1 = Convert.ToInt32(time1[1]);

        Console.Write("Введите второе время (часы и минуты через пробел): ");
        string[] time2 = Console.ReadLine().Split(' ');
        int hours2 = Convert.ToInt32(time2[0]);
        int minutes2 = Convert.ToInt32(time2[1]);

        Console.Write("Выберите операцию (+ или -): ");
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            AddTime(hours1, minutes1, hours2, minutes2);
        }
        else if (operation == "-")
        {
            SubtractTime(hours1, minutes1, hours2, minutes2);
        }
        else
        {
            Console.WriteLine("Неправильная операция");
        }
    }

    static void AddTime(int hours1, int minutes1, int hours2, int minutes2)
    {
        int totalMinutes = minutes1 + minutes2;
        int totalHours = hours1 + hours2 + totalMinutes / 60;
        totalMinutes %= 60;

        Console.WriteLine($"Результат: {totalHours} часов {totalMinutes} минут");
    }

    static void SubtractTime(int hours1, int minutes1, int hours2, int minutes2)
    {
        int totalMinutes = minutes1 - minutes2;
        int totalHours = hours1 - hours2;

        if (totalMinutes < 0)
        {
            totalMinutes += 60;
            totalHours--;
        }

        Console.WriteLine($"Результат: {totalHours} часов {totalMinutes} минут");
    }
}*/
////27
/*using System;
class QuadraticEquationSolver
{
    static void Main(string[] args)
    {
        Console.Write("Введите коэффициент a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Solve(a, b, c);
    }

    static void Solve(double a, double b, double c)
    {
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконечно много решений");
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решений");
                }
            }
            else
            {
                double root = -c / b;

                Console.WriteLine($"Корень уравнения: x = {root}");
            }
        }
        else
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"Корни уравнения: x1 = {root1}, x2 = {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);

                Console.WriteLine($"Корень уравнения: x = {root}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет вещественных корней");
            }
        }
    }
}*/
/*////28
using System;

class LinearSystemSolver
{
    static void Main(string[] args)
    {
        Console.Write("Введите коэффициент a1: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c1: ");
        double c1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент a2: ");
        double a2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c2: ");
        double c2 = Convert.ToDouble(Console.ReadLine());

        SolveSystem(a1, b1, c1, a2, b2, c2);
    }

    static void SolveSystem(double a1, double b1, double c1, double a2, double b2, double c2)
    {
        double determinant = a1 * b2 - a2 * b1;

        if (determinant == 0)
        {
            if (a1 * c2 - a2 * c1 == 0 && b1 * c2 - b2 * c1 == 0)
            {
                Console.WriteLine("Система имеет бесконечно много решений");
            }
            else
            {
                Console.WriteLine("Система не имеет решений");
            }
        }
        else
        {
            double x = (b2 * c1 - b1 * c2) / determinant;
            double y = (a1 * c2 - a2 * c1) / determinant;

            Console.WriteLine($"Решение системы: x = {x}, y = {y}");
        }
    }
}*/
////29
/*using System;
using System.IO;

class DiskMonitoring
{
    static void Main(string[] args)
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            if (drive.IsReady)
            {
                Console.WriteLine($"Диск: {drive.Name}");
                Console.WriteLine($"Тип диска: {drive.DriveType}");
                Console.WriteLine($"Общий размер: {GetFileSize(drive.TotalSize)}");
                Console.WriteLine($"Свободное место: {GetFileSize(drive.AvailableFreeSpace)}");
                Console.WriteLine($"Занятое место: {GetFileSize(drive.TotalSize - drive.AvailableFreeSpace)}");
                Console.WriteLine();
            }
        }
    }

    static string GetFileSize(long size)
    {
        if (size < 1024)
        {
            return $"{size} байт";
        }
        else if (size < 1024 * 1024)
        {
            return $"{size / 1024} КБ";
        }
        else if (size < 1024 * 1024 * 1024)
        {
            return $"{size / (1024 * 1024)} МБ";
        }
        else
        {
            return $"{size / (1024 * 1024 * 1024)} ГБ";
        }
    }
}*/
//30
/*using System;
using System.IO;

class FileManager
{
    static void Main(string[] args)
    {
        Console.WriteLine("Файловый менеджер");
        Console.WriteLine("------------------");

        while (true)
        {
            Console.WriteLine("1. Создать файл");
            Console.WriteLine("2. Удалить файл");
            Console.WriteLine("3. Копировать файл");
            Console.WriteLine("4. Переместить файл");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите операцию: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    CreateFile();
                    break;
                case 2:
                    DeleteFile();
                    break;
                case 3:
                    CopyFile();
                    break;
                case 4:
                    MoveFile();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неправильный выбор. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static void CreateFile()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();

        try
        {
            using (FileStream file = File.Create(fileName))
            {
                Console.WriteLine("Файл создан успешно.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка создания файла: " + ex.Message);
        }
    }

    static void DeleteFile()
    {
        Console.Write("Введите имя файла: ");
        string fileName = Console.ReadLine();

        try
        {
            File.Delete(fileName);
            Console.WriteLine("Файл удален успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка удаления файла: " + ex.Message);
        }
    }

    static void CopyFile()
    {
        Console.Write("Введите имя исходного файла: ");
        string sourceFileName = Console.ReadLine();

        Console.Write("Введите имя целевого файла: ");
        string targetFileName = Console.ReadLine();

        try
        {
            File.Copy(sourceFileName, targetFileName);
            Console.WriteLine("Файл скопирован успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка копирования файла: " + ex.Message);
        }
    }

    static void MoveFile()
    {
        Console.Write("Введите имя исходного файла: ");
        string sourceFileName = Console.ReadLine();

        Console.Write("Введите имя целевого файла: ");
        string targetFileName = Console.ReadLine();

        try
        {
            File.Move(sourceFileName, targetFileName);
            Console.WriteLine("Файл перемещен успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка перемещения файла: " + ex.Message);
        }
    }
}*/
//31
/*using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class JsonProcessor
{
    static void Main(string[] args)
    {
        string jsonFilePath = "data.json";

        try
        {
            string json = File.ReadAllText(jsonFilePath);
            List<Data> data = JsonConvert.DeserializeObject<List<Data>>(json);

            Console.WriteLine("Данные из JSON-файла:");
            Console.WriteLine("------------------------");

            Console.WriteLine("| Имя | Возраст | Город |");
            Console.WriteLine("| --- | --- | --- |");

            foreach (Data item in data)
            {
                Console.WriteLine($"| {item.Name} | {item.Age} | {item.City} |");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка чтения JSON-файла: " + ex.Message);
        }
    }
}

public class Data
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}
*/
////32
/*using System;
using System.Data;

class Xml
{
    static void Main(string[] args)
    {
        string xmlFilePath = "data.xml";

        try
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlFilePath);

            Console.WriteLine("Данные из XML-файла:");
            Console.WriteLine("------------------------");

            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine($"Таблица: {table.TableName}");

                foreach (DataColumn column in table.Columns)
                {
                    Console.Write($"| {column.ColumnName} |");
                }

                Console.WriteLine();

                foreach (DataRow row in table.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        Console.Write($"| {value} |");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка чтения XML-файла: " + ex.Message);
        }
    }
}
*/
////33
/*using System;
using System.Collections.Generic;

class TodoList
{
    private List<TodoItem> _todoItems = new List<TodoItem>();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Ведение списка дел:");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Отметить задачу как выполненную");
            Console.WriteLine("4. Показать список задач");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите действие: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTodoItem();
                    break;
                case 2:
                    RemoveTodoItem();
                    break;
                case 3:
                    MarkTodoItemAsDone();
                    break;
                case 4:
                    ShowTodoList();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    private void AddTodoItem()
    {
        Console.Write("Введите описание задачи: ");
        string description = Console.ReadLine();

        TodoItem todoItem = new TodoItem { Description = description, IsDone = false };
        _todoItems.Add(todoItem);

        Console.WriteLine("Задача добавлена.");
    }

    private void RemoveTodoItem()
    {
        Console.Write("Введите номер задачи для удаления: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        if (index >= 0 && index < _todoItems.Count)
        {
            _todoItems.RemoveAt(index);
            Console.WriteLine("Задача удалена.");
        }
        else
        {
            Console.WriteLine("Неверный номер задачи.");
        }
    }

    private void MarkTodoItemAsDone()
    {
        Console.Write("Введите номер задачи для отметки как выполненной: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        if (index >= 0 && index < _todoItems.Count)
        {
            _todoItems[index].IsDone = true;
            Console.WriteLine("Задача отмечена как выполненная.");
        }
        else
        {
            Console.WriteLine("Неверный номер задачи.");
        }
    }

    private void ShowTodoList()
    {
        Console.WriteLine("Список задач:");
        Console.WriteLine("------------------------");

        for (int i = 0; i < _todoItems.Count; i++)
        {
            TodoItem todoItem = _todoItems[i];
            string status = todoItem.IsDone ? "Выполнена" : "Не выполнена";

            Console.WriteLine($"{i + 1}. {todoItem.Description} - {status}");
        }
    }
}

public class TodoItem
{
    public string Description { get; set; }
    public bool IsDone { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        TodoList todoList = new TodoList();
        todoList.Run();
    }
}*/
//34
//using System;
//using System.IO;

//class FileProcessor
//{
//    public void Run()
//    {
//        Console.Write("Введите имя файла для чтения: ");
//        string inputFileName = Console.ReadLine();

//        Console.Write("Введите имя файла для записи: ");
//        string outputFileName = Console.ReadLine();

//        try
//        {
//            string text = File.ReadAllText(inputFileName);
//            string modifiedText = ModifyText(text);

//            File.WriteAllText(outputFileName, modifiedText);

//            Console.WriteLine("Текст записан в файл.");
//        }
//        catch (FileNotFoundException)
//        {
//            Console.WriteLine("Файл для чтения не найден.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Ошибка: " + ex.Message);
//        }
//    }

//    private string ModifyText(string text)
//    {
//        char[] chars = text.ToCharArray();

//        for (int i = 0; i < chars.Length; i++)
//        {
//            if (char.IsLower(chars[i]))
//            {
//                chars[i] = char.ToUpper(chars[i]);
//            }
//            else if (char.IsUpper(chars[i]))
//            {
//                chars[i] = char.ToLower(chars[i]);
//            }
//        }

//        return new string(chars);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        FileProcessor fileProcessor = new FileProcessor();
//        fileProcessor.Run();
//    }
//}

////35
/*using System;
using System.Collections.Generic;

class Calendar
{
    private Dictionary<DateTime, string> _notes = new Dictionary<DateTime, string>();
    private int _year;
    private int _month;

    public Calendar(int year, int month)
    {
        _year = year;
        _month = month;
    }

    public void Run()
    {
        Console.WriteLine($"Календарь на {_month} {_year} год");

        int daysInMonth = DateTime.DaysInMonth(_year, _month);
        int firstDayOfWeek = (int)new DateTime(_year, _month, 1).DayOfWeek;

        Console.WriteLine(" Пн  Вт  Ср  Чт   Пт  Сб  Вс");

        for (int i = 0; i < firstDayOfWeek; i++)
        {
            Console.Write("  ");
        }

       
        for (int i = 1; i <= daysInMonth; i++)
        {
            Console.Write($"{i,3} ");

           
            if ((i + firstDayOfWeek) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();

        for (int i = 1; i <= daysInMonth; i++)
        {
            DateTime date = new DateTime(_year, _month, i);
            Console.Write($"Введите заметку для {i} числа {(_notes.ContainsKey(date) ? "y/n" : "")}: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                Console.Write("Введите заметку: ");
                string note = Console.ReadLine();
                _notes[date] = note; 
            }
            else if (input.ToLower() == "n" && _notes.ContainsKey(date))
            {
                _notes.Remove(date);
            }
        }

        Console.WriteLine("Заметки:");
   
        foreach (var note in _notes)
        {
            Console.WriteLine($"{note.Key.Day} число: {note.Value}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int year = DateTime.Now.Year;
        int month = DateTime.Now.Month;

        Calendar calendar = new Calendar(year, month);
        calendar.Run();
    }
}*/
//task 36
/*using System;
using System.Collections.Generic;

namespace StudentGradeSystem
{
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public Dictionary<string, List<int>> Grades { get; set; } = new Dictionary<string, List<int>>();

        public Student(string name, string group)
        {
            Name = name;
            Group = group;
        }

        public void AddGrade(string subject, int grade)
        {
            if (Grades.ContainsKey(subject))
            {
                Grades[subject].Add(grade);
            }
            else
            {
                Grades.Add(subject, new List<int>() { grade });
            }
        }

        public double GetAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }

            int totalGrades = 0;
            foreach (var subjectGrades in Grades.Values)
            {
                totalGrades += subjectGrades.Sum();
            }

            return (double)totalGrades / Grades.Count;
        }
    }

    class GradeSystem
    {
        private Dictionary<string, Student> Students { get; set; } = new Dictionary<string, Student>();

        public void AddStudent()
        {
            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите группу студента:");
            string group = Console.ReadLine();

            if (!Students.ContainsKey(name))
            {
                Students.Add(name, new Student(name, group));
                Console.WriteLine($"Студент {name} добавлен в систему.");
            }
            else
            {
                Console.WriteLine($"Студент {name} уже существует в системе.");
            }
        }

        public void AddGrade()
        {
            Console.WriteLine("Введите имя студента:");
            string studentName = Console.ReadLine();

            if (Students.ContainsKey(studentName))
            {
                Console.WriteLine("Введите предмет:");
                string subject = Console.ReadLine();

                Console.WriteLine("Введите оценку:");
                if (int.TryParse(Console.ReadLine(), out int grade))
                {
                    Students[studentName].AddGrade(subject, grade);
                    Console.WriteLine($"Оценка {grade} по предмету {subject} добавлена для {studentName}.");
                }
                else
                {
                    Console.WriteLine("Некорректный ввод оценки.");
                }
            }
            else
            {
                Console.WriteLine($"Студент {studentName} не найден в системе.");
            }
        }

        public void GetStudentInfo()
        {
            Console.WriteLine("Введите имя студента:");
            string studentName = Console.ReadLine();
            GetStudentInfo(studentName);
        }

        public void GetStudentInfo(string studentName)
        {
            if (Students.ContainsKey(studentName))
            {
                Student student = Students[studentName];
                Console.WriteLine($"Студент: {student.Name}, Группа: {student.Group}");
                Console.WriteLine("Оценки:");
                foreach (var subject in student.Grades)
                {
                    Console.WriteLine($"{subject.Key}: {string.Join(", ", subject.Value)}");
                }
                Console.WriteLine($"Средний балл: {student.GetAverageGrade():F2}");
            }
            else
            {
                Console.WriteLine($"Студент {studentName} не найден в системе.");
            }
        }

        public void GetAllStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("В системе нет студентов.");
            }
            else
            {
                foreach (var student in Students.Values)
                {
                    Console.WriteLine($"Студент: {student.Name}, Группа: {student.Group}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GradeSystem system = new GradeSystem();

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Добавить оценку");
                Console.WriteLine("3. Вывести информацию о студенте");
                Console.WriteLine("4. Вывести всех студентов");
                Console.WriteLine("5. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        system.AddStudent();
                        break;
                    case "2":
                        system.AddGrade();
                        break;
                    case "3":
                        system.GetStudentInfo();
                        break;
                    case "4":
                        system.GetAllStudents();
                        break;
                    case "5":
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
    }
}*/
//37
//using System;
//using System.Collections.Generic;

//namespace ContactBook
//{
//    class Contact
//    {
//        public string Name { get; set; }
//        public string Phone { get; set; }
//        public string Email { get; set; }

//        public Contact(string name, string phone, string email)
//        {
//            Name = name;
//            Phone = phone;
//            Email = email;
//        }
//    }

//    class ContactBook
//    {
//        private List<Contact> contacts = new List<Contact>();

//        public void AddContact()
//        {
//            Console.WriteLine("Введите имя контакта:");
//            string name = Console.ReadLine();

//            Console.WriteLine("Введите телефон контакта:");
//            string phone = Console.ReadLine();

//            Console.WriteLine("Введите email контакта:");
//            string email = Console.ReadLine();

//            contacts.Add(new Contact(name, phone, email));
//            Console.WriteLine("Контакт добавлен.");
//        }

//        public void DeleteContact()
//        {
//            Console.WriteLine("Введите имя контакта для удаления:");
//            string name = Console.ReadLine();

//            Contact contactToDelete = contacts.Find(c => c.Name == name);

//            if (contactToDelete != null)
//            {
//                contacts.Remove(contactToDelete);
//                Console.WriteLine("Контакт удален.");
//            }
//            else
//            {
//                Console.WriteLine("Контакт не найден.");
//            }
//        }

//        public void EditContact()
//        {
//            Console.WriteLine("Введите имя контакта для редактирования:");
//            string name = Console.ReadLine();

//            Contact contactToEdit = contacts.Find(c => c.Name == name);

//            if (contactToEdit != null)
//            {
//                Console.WriteLine("Введите новое имя (пустое поле для пропуска):");
//                string newName = Console.ReadLine();
//                if (!string.IsNullOrEmpty(newName))
//                {
//                    contactToEdit.Name = newName;
//                }

//                Console.WriteLine("Введите новый телефон (пустое поле для пропуска):");
//                string newPhone = Console.ReadLine();
//                if (!string.IsNullOrEmpty(newPhone))
//                {
//                    contactToEdit.Phone = newPhone;
//                }

//                Console.WriteLine("Введите новый email (пустое поле для пропуска):");
//                string newEmail = Console.ReadLine();
//                if (!string.IsNullOrEmpty(newEmail))
//                {
//                    contactToEdit.Email = newEmail;
//                }

//                Console.WriteLine("Контакт изменен.");
//            }
//            else
//            {
//                Console.WriteLine("Контакт не найден.");
//            }
//        }

//        public void SearchContact()
//        {
//            Console.WriteLine("Введите имя контакта для поиска:");
//            string name = Console.ReadLine();

//            Contact foundContact = contacts.Find(c => c.Name == name);

//            if (foundContact != null)
//            {
//                Console.WriteLine($"Имя: {foundContact.Name}");
//                Console.WriteLine($"Телефон: {foundContact.Phone}");
//                Console.WriteLine($"Email: {foundContact.Email}");
//            }
//            else
//            {
//                Console.WriteLine("Контакт не найден.");
//            }
//        }

//        public void ShowAllContacts()
//        {
//            if (contacts.Count == 0)
//            {
//                Console.WriteLine("В телефонной книге нет контактов.");
//                return;
//            }

//            Console.WriteLine("Список контактов:");
//            foreach (Contact contact in contacts)
//            {
//                Console.WriteLine($"Имя: {contact.Name}, Телефон: {contact.Phone}, Email: {contact.Email}");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ContactBook contactBook = new ContactBook();

//            while (true)
//            {
//                Console.WriteLine("Выберите действие:");
//                Console.WriteLine("1. Добавить контакт");
//                Console.WriteLine("2. Удалить контакт");
//                Console.WriteLine("3. Редактировать контакт");
//                Console.WriteLine("4. Найти контакт");
//                Console.WriteLine("5. Показать все контакты");
//                Console.WriteLine("6. Выход");

//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        contactBook.AddContact();
//                        break;
//                    case "2":
//                        contactBook.DeleteContact();
//                        break;
//                    case "3":
//                        contactBook.EditContact();
//                        break;
//                    case "4":
//                        contactBook.SearchContact();
//                        break;
//                    case "5":
//                        contactBook.ShowAllContacts();
//                        break;
//                    case "6":
//                        Console.WriteLine("До свидания!");
//                        return;
//                    default:
//                        Console.WriteLine("Некорректный выбор.");
//                        break;
//                }
//            }
//        }
//    }
//}

//38
//using System;

//namespace TicTacToe
//{
//    class Program
//    {
//        static char[,] board = new char[3, 3];
//        static char currentPlayer = 'X';

//        static void Main(string[] args)
//        {
//            InitializeBoard();

//            while (true)
//            {
//                DisplayBoard();

//                Console.WriteLine($"Ход игрока {currentPlayer}:");
//                Console.WriteLine("Введите номер строки (1-3):");
//                int row = int.Parse(Console.ReadLine()) - 1;
//                Console.WriteLine("Введите номер столбца (1-3):");
//                int col = int.Parse(Console.ReadLine()) - 1;

//                if (IsValidMove(row, col))
//                {
//                    MakeMove(row, col);
//                    if (CheckWin())
//                    {
//                        DisplayBoard();
//                        Console.WriteLine($"Игрок {currentPlayer} победил!");
//                        break;
//                    }
//                    else if (CheckDraw())
//                    {
//                        DisplayBoard();
//                        Console.WriteLine("Ничья!");
//                        break;
//                    }

//                    SwitchPlayer();
//                }
//                else
//                {
//                    Console.WriteLine("Неверный ход. Попробуйте снова.");
//                }
//            }

//            Console.ReadKey();
//        }

//        static void InitializeBoard()
//        {
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    board[i, j] = ' ';
//                }
//            }
//        }

//        static void DisplayBoard()
//        {
//            Console.WriteLine("  1 2 3");
//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write($"{i + 1} ");
//                for (int j = 0; j < 3; j++)
//                {
//                    Console.Write($"{board[i, j]} ");
//                }
//                Console.WriteLine();
//            }
//        }

//        static bool IsValidMove(int row, int col)
//        {
//            return row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ';
//        }

//        static void MakeMove(int row, int col)
//        {
//            board[row, col] = currentPlayer;
//        }

//        static void SwitchPlayer()
//        {
//            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
//        }

//        static bool CheckWin()
//        {
//            Проверка строк
//            for (int i = 0; i < 3; i++)
//            {
//                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
//                {
//                    return true;
//                }
//            }

//            Проверка столбцов
//            for (int j = 0; j < 3; j++)
//            {
//                if (board[0, j] == currentPlayer && board[1, j] == currentPlayer && board[2, j] == currentPlayer)
//                {
//                    return true;
//                }
//            }

//            Проверка диагоналей
//            if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
//                (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
//            {
//                return true;
//            }

//            return false;
//        }

//        static bool CheckDraw()
//        {
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    if (board[i, j] == ' ')
//                    {
//                        return false;
//                    }
//                }
//            }

//            return true;
//        }
//    }
//}
//39
//using System;

//namespace BullsAndCows
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Добро пожаловать в игру 'Быки и коровы'!");

//            // Загадываем случайное четырехзначное число с уникальными цифрами
//            int secretNumber = GenerateSecretNumber();

//            while (true)
//            {
//                Console.Write("Введите ваше предположение (четыре цифры): ");
//                string guess = Console.ReadLine();

//                if (guess.Length != 4 || !int.TryParse(guess, out int guessNumber))
//                {
//                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите четырехзначное число.");
//                    continue;
//                }

//                int bulls = CountBulls(secretNumber, guessNumber);
//                int cows = CountCows(secretNumber, guessNumber, bulls);

//                Console.WriteLine($"Быки: {bulls}, Коровы: {cows}");

//                if (bulls == 4)
//                {
//                    Console.WriteLine("Поздравляем! Вы угадали!");
//                    break;
//                }
//            }
//        }

//        static int GenerateSecretNumber()
//        {
//            Random random = new Random();
//            int number;
//            do
//            {
//                number = random.Next(1000, 10000);
//            } while (HasDuplicateDigits(number));
//            return number;
//        }

//        static bool HasDuplicateDigits(int number)
//        {
//            int[] digits = new int[10];
//            while (number > 0)
//            {
//                int digit = number % 10;
//                if (digits[digit] > 0)
//                {
//                    return true;
//                }
//                digits[digit]++;
//                number /= 10;
//            }
//            return false;
//        }

//        static int CountBulls(int secretNumber, int guessNumber)
//        {
//            int bulls = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                if ((secretNumber % 10) == (guessNumber % 10))
//                {
//                    bulls++;
//                }
//                secretNumber /= 10;
//                guessNumber /= 10;
//            }
//            return bulls;
//        }

//        static int CountCows(int secretNumber, int guessNumber, int bulls)
//        {
//            int cows = 0;
//            int[] secretDigits = new int[10];
//            int[] guessDigits = new int[10];
//            for (int i = 0; i < 4; i++)
//            {
//                int secretDigit = secretNumber % 10;
//                int guessDigit = guessNumber % 10;
//                secretDigits[secretDigit]++;
//                guessDigits[guessDigit]++;
//                secretNumber /= 10;
//                guessNumber /= 10;
//            }
//            for (int i = 0; i < 10; i++)
//            {
//                cows += Math.Min(secretDigits[i], guessDigits[i]);
//            }
//            return cows - bulls;
//        }
//    }
//}
//40
//using System;

//namespace BankomatSimulation
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double balance = 0;

//            while (true)
//            {
//                Console.WriteLine("Выберите действие:");
//                Console.WriteLine("1. Внести средства");
//                Console.WriteLine("2. Снять средства");
//                Console.WriteLine("3. Просмотреть баланс");
//                Console.WriteLine("4. Выход");

//                Console.Write("Введите номер действия: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        Console.Write("Введите сумму для внесения: ");
//                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
//                        {
//                            balance += depositAmount;
//                            Console.WriteLine($"Внесено {depositAmount:C}. Новый баланс: {balance:C}");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Некорректный ввод суммы.");
//                        }
//                        break;

//                    case "2":
//                        Console.Write("Введите сумму для снятия: ");
//                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
//                        {
//                            if (withdrawAmount <= balance)
//                            {
//                                balance -= withdrawAmount;
//                                Console.WriteLine($"Снято {withdrawAmount:C}. Новый баланс: {balance:C}");
//                            }
//                            else
//                            {
//                                Console.WriteLine("Недостаточно средств.");
//                            }
//                        }
//                        else
//                        {
//                            Console.WriteLine("Некорректный ввод суммы.");
//                        }
//                        break;

//                    case "3":
//                        Console.WriteLine($"Текущий баланс: {balance:C}");
//                        break;

//                    case "4":
//                        Console.WriteLine("До свидания!");
//                        return;

//                    default:
//                        Console.WriteLine("Некорректный выбор действия.");
//                        break;
//                }
//            }
//        }
//    }
//}
//41
//using System;
//using System.IO;

//namespace CSVReader
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string filePath = "file.csv"; 

//            try
//            {
//                using (StreamReader reader = new StreamReader(filePath))
//                {
//                    string line;
//                    while ((line = reader.ReadLine()) != null)
//                    {
//                        string[] values = line.Split(','); 
                     
//                        foreach (string value in values)
//                        {
//                            Console.Write($"{value,-20}"); 
//                        }
//                        Console.WriteLine();
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
//            }
//        }
//    }
//}
//42
//using System;
//namespace AverageTemperatureCalculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] temperatures = new double[7];

//            Console.WriteLine("Введите температуру для каждого дня недели:");

//            for (int i = 0; i < 7; i++)
//            {
//                Console.Write($"День {i + 1}: ");
//                if (double.TryParse(Console.ReadLine(), out double temperature))
//                {
//                    temperatures[i] = temperature;
//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
//                    i--;
//                }
//            }

//            double sum = 0;
//            foreach (double temperature in temperatures)
//            {
//                sum += temperature;
//            }

//            double averageTemperature = sum / 7;

//            Console.WriteLine($"Средняя температура за неделю: {averageTemperature:F2} градусов.");
//        }
//    }
//}
//44
//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;

//namespace VersionControl
//{
//    class Program
//    {
//        static string directoryPath = @"C:\Users\Student406-11\Desktop\Практика ИСП 122";

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Наблюдение за изменениями файлов в директории: " + directoryPath);
//            List<string> trackedFiles = new List<string>();

//            string[] files = Directory.GetFiles(directoryPath);
//            foreach (string file in files)
//            {
//                trackedFiles.Add(file);
//            }

//            while (true)
//            {

//                foreach (string file in trackedFiles)
//                {
//                    if (File.Exists(file))
//                    {
//                        DateTime lastModifiedTime = File.GetLastWriteTime(file);
//                        if (lastModifiedTime != GetLastCheckedTime(file))
//                        {

//                            string backupFileName = Path.Combine(directoryPath, Path.GetFileNameWithoutExtension(file) + "_" + lastModifiedTime.ToString("yyyyMMddHHmmss") + Path.GetExtension(file));
//                            File.Copy(file, backupFileName);


//                            SetLastCheckedTime(file, lastModifiedTime);

//                            Console.WriteLine($"Файл '{file}' изменен. Сохранена резервная копия: '{backupFileName}'");
//                        }
//                    }
//                    else
//                    {

//                        trackedFiles.Remove(file);
//                        Console.WriteLine($"Файл '{file}' удален.");
//                    }
//                }

//                Thread.Sleep(5000);
//            }
//        }

//        static DateTime GetLastCheckedTime(string file)
//        {
//            string lastCheckedTimeFile = Path.Combine(directoryPath, Path.GetFileNameWithoutExtension(file) + ".checked");

//            if (File.Exists(lastCheckedTimeFile))
//            {
//                return DateTime.Parse(File.ReadAllText(lastCheckedTimeFile));
//            }
//            else
//            {
//                return DateTime.MinValue;
//            }
//        }


//        static void SetLastCheckedTime(string file, DateTime lastModifiedTime)
//        {
//            string lastCheckedTimeFile = Path.Combine(directoryPath, Path.GetFileNameWithoutExtension(file) + ".checked");
//            File.WriteAllText(lastCheckedTimeFile, lastModifiedTime.ToString());
//        }
//    }
//}


//45
//using System;
//using System.IO;
//using System.Collections.Generic;

//namespace ReportGenerator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Генератор отчетов");
//            Console.WriteLine("----------------");

//            List<Sale> sales = new List<Sale>();
//            while (true)
//            {
//                Console.WriteLine("\nВведите данные о продаже (или введите 'exit' для завершения):");
//                Console.Write("Товар: ");
//                string product = Console.ReadLine();
//                if (product.ToLower() == "exit")
//                {
//                    break;
//                }

//                Console.Write("Количество: ");
//                if (int.TryParse(Console.ReadLine(), out int quantity))
//                {
//                    Console.Write("Цена: ");
//                    if (double.TryParse(Console.ReadLine(), out double price))
//                    {
//                        sales.Add(new Sale(product, quantity, price));
//                    }
//                    else
//                    {
//                        Console.WriteLine("Некорректный ввод цены.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод количества.");
//                }
//            }
//            string report = GenerateSalesReport(sales);

//            Console.Write("Введите имя файла для сохранения отчета: ");
//            string fileName = Console.ReadLine();
//            File.WriteAllText(fileName + ".txt", report);

//            Console.WriteLine($"Отчет сохранен в файл '{fileName}.txt'");
//        }

//        class Sale
//        {
//            public string Product { get; set; }
//            public int Quantity { get; set; }
//            public double Price { get; set; }

//            public Sale(string product, int quantity, double price)
//            {
//                Product = product;
//                Quantity = quantity;
//                Price = price;
//            }
//        }
//        static string GenerateSalesReport(List<Sale> sales)
//        {
//            string report = "Отчет о продажах\n\n";
//            report += "Товар | Количество | Цена | Сумма\n";
//            report += "------- | -------- | -------- | --------\n";

//            double totalAmount = 0;
//            foreach (Sale sale in sales)
//            {
//                double amount = sale.Quantity * sale.Price;
//                report += $"{sale.Product} | {sale.Quantity} | {sale.Price:C} | {amount:C}\n";
//                totalAmount += amount;
//            }

//            report += "\nИтоговая сумма: " + totalAmount.ToString("C");

//            return report;
//        }
//    }
//}
////46
//using System;
//using System.Collections.Generic;

//namespace VisitorTracker
//{
//    class Program
//    {
//        static List<Visitor> visitors = new List<Visitor>();

//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Выберите действие:");
//                Console.WriteLine("1. Добавить посетителя");
//                Console.WriteLine("2. Отметить присутствие посетителя");
//                Console.WriteLine("3. Вывести список всех посетителей");
//                Console.WriteLine("4. Выход");

//                Console.Write("Введите номер действия: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        AddVisitor();
//                        break;
//                    case "2":
//                        MarkPresence();
//                        break;
//                    case "3":
//                        PrintVisitorList();
//                        break;
//                    case "4":
//                        Console.WriteLine("До свидания!");
//                        return;
//                    default:
//                        Console.WriteLine("Некорректный выбор действия.");
//                        break;
//                }
//            }
//        }

//        static void AddVisitor()
//        {
//            Console.Write("Введите имя посетителя: ");
//            string name = Console.ReadLine();

//            Console.Write("Введите email посетителя: ");
//            string email = Console.ReadLine();

//            visitors.Add(new Visitor(name, email));
//            Console.WriteLine("Посетитель добавлен.");
//        }

//        static void MarkPresence()
//        {
//            Console.Write("Введите имя посетителя, которого нужно отметить: ");
//            string name = Console.ReadLine();

//            Visitor visitor = visitors.Find(v => v.Name == name);

//            if (visitor != null)
//            {
//                visitor.IsPresent = true;
//                Console.WriteLine($"Присутствие {visitor.Name} отмечено.");
//            }
//            else
//            {
//                Console.WriteLine("Посетитель не найден.");
//            }
//        }

//        static void PrintVisitorList()
//        {
//            if (visitors.Count == 0)
//            {
//                Console.WriteLine("Список посетителей пуст.");
//                return;
//            }

//            Console.WriteLine("\nСписок всех посетителей:");
//            foreach (Visitor visitor in visitors)
//            {
//                Console.WriteLine($"Имя: {visitor.Name}, Email: {visitor.Email}, Присутствие: {visitor.IsPresent}");
//            }
//        }
//    }

//    class Visitor
//    {
//        public string Name { get; set; }
//        public string Email { get; set; }
//        public bool IsPresent { get; set; }

//        public Visitor(string name, string email)
//        {
//            Name = name;
//            Email = email;
//            IsPresent = false;
//        }
//    }
//}
////47
//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;

//namespace TaskScheduler
//{
//    class Program
//    {
//        static List<TaskItem> tasks = new List<TaskItem>();

//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Выберите действие:");
//                Console.WriteLine("1. Добавить задачу");
//                Console.WriteLine("2. Вывести список задач");
//                Console.WriteLine("3. Выход");

//                Console.Write("Введите номер действия: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        AddTask();
//                        break;
//                    case "2":
//                        PrintTaskList();
//                        break;
//                    case "3":
//                        Console.WriteLine("До свидания!");
//                        return;
//                    default:
//                        Console.WriteLine("Некорректный выбор действия.");
//                        break;
//                }
//            }
//        }

//        static void AddTask()
//        {
//            Console.Write("Введите описание задачи: ");
//            string description = Console.ReadLine();

//            Console.Write("Введите время выполнения (чч:мм): ");
//            if (DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime executionTime))
//            {
//                tasks.Add(new TaskItem(description, executionTime));
//                Console.WriteLine("Задача добавлена.");
//            }
//            else
//            {
//                Console.WriteLine("Некорректный формат времени.");
//            }
//        }

//        static void PrintTaskList()
//        {
//            if (tasks.Count == 0)
//            {
//                Console.WriteLine("Список задач пуст.");
//                return;
//            }

//            Console.WriteLine("\nСписок задач:");
//            foreach (TaskItem task in tasks)
//            {
//                Console.WriteLine($"Описание: {task.Description}, Время выполнения: {task.ExecutionTime.ToString("HH:mm")}");
//            }
//        }
//        static async Task CheckTasksAsync()
//        {
//            while (true)
//            {
//                foreach (TaskItem task in tasks)
//                {
//                    if (DateTime.Now >= task.ExecutionTime)
//                    {
//                        Console.WriteLine($"Время выполнения задачи: {task.Description}!");
//                        Console.WriteLine($"Время выполнения: {task.ExecutionTime.ToString("HH:mm")}");
//                        tasks.Remove(task);
//                    }
//                }

//                await Task.Delay(60000);
//            }
//        }

//        class TaskItem
//        {
//            public string Description { get; set; }
//            public DateTime ExecutionTime { get; set; }

//            public TaskItem(string description, DateTime executionTime)
//            {
//                Description = description;
//                ExecutionTime = executionTime;
//            }
//        }
//    }
//}
////48
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace SalesAnalysis
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Sale> sales = new List<Sale>()
//            {
//                new Sale("Товар 1", 5, 200),
//                new Sale("Товар 2", 3, 350),
//                new Sale("Товар 1", 2, 400),
//                new Sale("Товар 3", 1, 600)
//            };

//            Dictionary<string, SaleStatistics> salesStatistics = AnalyzeSales(sales);

//            Console.WriteLine("Статистика продаж:");
//            Console.WriteLine("------------------");
       
//            double totalSales = salesStatistics.Values.Sum(s => s.TotalAmount);
//            Console.WriteLine($"Общая сумма продаж: {totalSales:C}");
      
//            foreach (KeyValuePair<string, SaleStatistics> stat in salesStatistics)
//            {
//                Console.WriteLine($"\nТовар: {stat.Key}");
//                Console.WriteLine($"Количество проданных единиц: {stat.Value.QuantitySold}");
//                Console.WriteLine($"Общая сумма продаж: {stat.Value.TotalAmount:C}");
//            }
//        }
//        class Sale
//        {
//            public string Product { get; set; }
//            public int Quantity { get; set; }
//            public double Price { get; set; }

//            public Sale(string product, int quantity, double price)
//            {
//                Product = product;
//                Quantity = quantity;
//                Price = price;
//            }
//        }

//        class SaleStatistics
//        {
//            public int QuantitySold { get; set; }
//            public double TotalAmount { get; set; }
//        }
//        static Dictionary<string, SaleStatistics> AnalyzeSales(List<Sale> sales)
//        {
//            Dictionary<string, SaleStatistics> salesStatistics = new Dictionary<string, SaleStatistics>();

//            foreach (Sale sale in sales)
//            {
//                if (salesStatistics.ContainsKey(sale.Product))
//                {
//                    salesStatistics[sale.Product].QuantitySold += sale.Quantity;
//                    salesStatistics[sale.Product].TotalAmount += sale.Quantity * sale.Price;
//                }
//                else
//                {
//                    salesStatistics.Add(sale.Product, new SaleStatistics()
//                    {
//                        QuantitySold = sale.Quantity,
//                        TotalAmount = sale.Quantity * sale.Price
//                    });
//                }
//            }

//            return salesStatistics;
//        }
//    }
//}
////49
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Hangman
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] words = { "кошка", "собака", "птица", "рыба", "дерево", "дом", "солнце", "луна" };

//            Random random = new Random();
//            string secretWord = words[random.Next(words.Length)];
//            char[] guessedWord = new char[secretWord.Length];
//            for (int i = 0; i < secretWord.Length; i++)
//            {
//                guessedWord[i] = '_';
//            }

//            int attempts = 6;

//            List<char> usedLetters = new List<char>();

//            while (attempts > 0 && !guessedWord.SequenceEqual(secretWord.ToCharArray()))
//            {
//                Console.WriteLine("\n\nВиселица:");
//                DrawHangman(attempts);

//                Console.WriteLine("\nСлово:");
//                PrintGuessedWord(guessedWord);

//                Console.WriteLine("\nИспользованные буквы:");
//                PrintUsedLetters(usedLetters);

//                Console.Write("\nВведите букву: ");
//                string letterInput = Console.ReadLine().ToLower();

//                if (letterInput.Length != 1 || !char.IsLetter(letterInput[0]))
//                {
//                    Console.WriteLine("Некорректный ввод. Введите одну букву.");
//                    continue;
//                }

//                char letter = letterInput[0];

//                if (usedLetters.Contains(letter))
//                {
//                    Console.WriteLine("Эта буква уже использовалась.");
//                    continue;
//                }

//                usedLetters.Add(letter);

//                bool found = false;
//                for (int i = 0; i < secretWord.Length; i++)
//                {
//                    if (secretWord[i] == letter)
//                    {
//                        guessedWord[i] = letter;
//                        found = true;
//                    }
//                }
//                if (!found)
//                {
//                    attempts--;
//                    Console.WriteLine("Буквы нет в слове.");
//                }
//            }
//            if (guessedWord.SequenceEqual(secretWord.ToCharArray()))
//            {
//                Console.WriteLine("\n\nПоздравляем! Вы угадали слово: " + secretWord);
//            }
//            else
//            {
//                Console.WriteLine("\n\nК сожалению, вы проиграли. Загаданное слово: " + secretWord);
//            }

//            Console.WriteLine("\nНажмите любую клавишу, чтобы выйти.");
//            Console.ReadKey();
//        }

//        static void DrawHangman(int attempts)
//        {
//            Console.WriteLine("   --------");
//            Console.WriteLine("   |      |");
//            Console.WriteLine("   |      " + (attempts < 6 ? 'O' : ' '));
//            Console.WriteLine("   |     " + (attempts < 4 ? '\\' : ' ') + (attempts < 5 ? '|' : ' ') + (attempts < 3 ? '/' : ' '));
//            Console.WriteLine("   |      " + (attempts < 2 ? '|' : ' '));
//            Console.WriteLine("   |     " + (attempts < 1 ? '/' : ' ') + (attempts < 0 ? '\\' : ' '));
//            Console.WriteLine("   |");
//            Console.WriteLine("   -");
//        }

//        static void PrintGuessedWord(char[] guessedWord)
//        {
//            foreach (char letter in guessedWord)
//            {
//                Console.Write(letter + " ");
//            }
//        }

//        static void PrintUsedLetters(List<char> usedLetters)
//        {
//            Console.Write(" ");
//            foreach (char letter in usedLetters)
//            {
//                Console.Write(letter + " ");
//            }
//        }
//    }
//}
////50
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace SurveySystem
//{
//    class Program
//    {
//        static List<Survey> surveys = new List<Survey>();

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Система опросов");
//            Console.WriteLine("----------------");

//            while (true)
//            {
//                Console.WriteLine("\nВыберите действие:");
//                Console.WriteLine("1. Создать опрос");
//                Console.WriteLine("2. Ответить на опрос");
//                Console.WriteLine("3. Вывести результаты опроса");
//                Console.WriteLine("4. Выход");

//                Console.Write("Введите номер действия: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        CreateSurvey();
//                        break;
//                    case "2":
//                        AnswerSurvey();
//                        break;
//                    case "3":
//                        ShowResults();
//                        break;
//                    case "4":
//                        Console.WriteLine("До свидания!");
//                        return;
//                    default:
//                        Console.WriteLine("Некорректный выбор действия.");
//                        break;
//                }
//            }
//        }

//        static void CreateSurvey()
//        {
//            Console.Write("Введите название опроса: ");
//            string title = Console.ReadLine();

//            Survey survey = new Survey(title);
//            surveys.Add(survey);

//            while (true)
//            {
//                Console.WriteLine("\nДобавить вопрос (или введите 'exit' для завершения):");
//                Console.Write("Вопрос: ");
//                string question = Console.ReadLine();
//                if (question.ToLower() == "exit")
//                {
//                    break;
//                }

//                List<string> options = new List<string>();
//                while (true)
//                {
//                    Console.WriteLine("\nДобавить вариант ответа (или введите 'exit' для завершения):");
//                    Console.Write("Вариант ответа: ");
//                    string option = Console.ReadLine();
//                    if (option.ToLower() == "exit")
//                    {
//                        break;
//                    }
//                    options.Add(option);
//                }

//                survey.AddQuestion(new Question(question, options));
//                Console.WriteLine("Вопрос добавлен.");
//            }
//        }

//        static void AnswerSurvey()
//        {
//            if (surveys.Count == 0)
//            {
//                Console.WriteLine("Нет доступных опросов.");
//                return;
//            }

//            Console.WriteLine("\nДоступные опросы:");
//            for (int i = 0; i < surveys.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. {surveys[i].Title}");
//            }

//            Console.Write("Выберите номер опроса: ");
//            if (int.TryParse(Console.ReadLine(), out int surveyIndex) && surveyIndex > 0 && surveyIndex <= surveys.Count)
//            {
//                Survey survey = surveys[surveyIndex - 1];

//                Dictionary<int, int> answers = new Dictionary<int, int>();

//                foreach (Question question in survey.Questions)
//                {
//                    Console.WriteLine($"\n{question.Text}");
//                    for (int j = 0; j < question.Options.Count; j++)
//                    {
//                        Console.WriteLine($"{j + 1}. {question.Options[j]}");
//                    }

//                    Console.Write("Выберите вариант ответа: ");
//                    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= question.Options.Count)
//                    {
//                        if (!answers.ContainsKey(question.Id))
//                        {
//                            answers.Add(question.Id, 0);
//                        }
//                        answers[question.Id] = choice;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Некорректный выбор варианта ответа.");
//                    }
//                }

//                survey.RecordAnswers(answers);
//                Console.WriteLine("\nСпасибо за участие в опросе!");
//            }
//            else
//            {
//                Console.WriteLine("Некорректный выбор опроса.");
//            }
//        }

//        static void ShowResults()
//        {
//            if (surveys.Count == 0)
//            {
//                Console.WriteLine("Нет доступных опросов.");
//                return;
//            }

//            Console.WriteLine("\nДоступные опросы:");
//            for (int i = 0; i < surveys.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. {surveys[i].Title}");
//            }

//            Console.Write("Выберите номер опроса: ");
//            if (int.TryParse(Console.ReadLine(), out int surveyIndex) && surveyIndex > 0 && surveyIndex <= surveys.Count)
//            {
//                Survey survey = surveys[surveyIndex - 1];
//                Console.WriteLine($"\nРезультаты опроса: {survey.Title}");

//                foreach (Question question in survey.Questions)
//                {
//                    Console.WriteLine($"\n{question.Text}");

//                    Dictionary<string, int> optionCounts = new Dictionary<string, int>();

//                    foreach (int answer in survey.Answers.Keys)
//                    {
//                        if (answer == question.Id)
//                        {
//                            if (!optionCounts.ContainsKey(question.Options[survey.Answers[answer] - 1]))
//                            {
//                                optionCounts.Add(question.Options[survey.Answers[answer] - 1], 0);
//                            }
//                            optionCounts[question.Options[survey.Answers[answer] - 1]]++;
//                        }
//                    }

//                    foreach (KeyValuePair<string, int> optionCount in optionCounts)
//                    {
//                        Console.WriteLine($"{optionCount.Key}: {optionCount.Value} голосов");
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("Некорректный выбор опроса.");
//            }
//        }

//        class Survey
//        {
//            public string Title { get; set; }
//            public List<Question> Questions { get; set; }
//            public Dictionary<int, int> Answers { get; set; }

//            public Survey(string title)
//            {
//                Title = title;
//                Questions = new List<Question>();
//                Answers = new Dictionary<int, int>();
//            }

//            public void AddQuestion(Question question)
//            {
//                question.Id = Questions.Count + 1;
//                Questions.Add(question);
//            }

//            public void RecordAnswers(Dictionary<int, int> answers)
//            {
//                Answers = answers;
//            }
//        }

//        class Question
//        {
//            public int Id { get; set; }
//            public string Text { get; set; }
//            public List<string> Options { get; set; }

//            public Question(string text, List<string> options)
//            {
//                Text = text;
//                Options = options;
//            }
//        }
//    }
//}
//51
/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WeatherAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<WeatherData> weatherData = LoadWeatherData("weather_data.csv");

            Dictionary<int, WeatherStatistics> monthlyStatistics = AnalyzeWeatherData(weatherData);

            Console.WriteLine("Статистика погодных данных:");
            Console.WriteLine("--------------------------");

            foreach (KeyValuePair<int, WeatherStatistics> monthStat in monthlyStatistics)
            {
                Console.WriteLine($"\nМесяц: {monthStat.Key}");
                Console.WriteLine($"Средняя температура: {monthStat.Value.AverageTemperature:F2}°C");
                Console.WriteLine($"Количество осадков: {monthStat.Value.TotalPrecipitation:F2} мм");
            }
        }
        class WeatherData
        {
            public DateTime Date { get; set; }
            public double Temperature { get; set; }
            public double Precipitation { get; set; }

            public WeatherData(DateTime date, double temperature, double precipitation)
            {
                Date = date;
                Temperature = temperature;
                Precipitation = precipitation;
            }
        }

        class WeatherStatistics
        {
            public double AverageTemperature { get; set; }
            public double TotalPrecipitation { get; set; }
        }
        static List<WeatherData> LoadWeatherData(string filePath)
        {
            List<WeatherData> weatherData = new List<WeatherData>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        DateTime date = DateTime.Parse(parts[0]);
                        double temperature = double.Parse(parts[1]);
                        double precipitation = double.Parse(parts[2]);

                        weatherData.Add(new WeatherData(date, temperature, precipitation));
                    }
                }
            }

            return weatherData;
        }

        static Dictionary<int, WeatherStatistics> AnalyzeWeatherData(List<WeatherData> weatherData)
        {
            Dictionary<int, WeatherStatistics> monthlyStatistics = new Dictionary<int, WeatherStatistics>();

            foreach (WeatherData data in weatherData)
            {
                int month = data.Date.Month;

                if (monthlyStatistics.ContainsKey(month))
                {
                    monthlyStatistics[month].AverageTemperature += data.Temperature;
                    monthlyStatistics[month].TotalPrecipitation += data.Precipitation;
                }
                else
                {
                    monthlyStatistics.Add(month, new WeatherStatistics()
                    {
                        AverageTemperature = data.Temperature,
                        TotalPrecipitation = data.Precipitation
                    });
                }
            }

            foreach (KeyValuePair<int, WeatherStatistics> monthStat in monthlyStatistics)
            {
                monthStat.Value.AverageTemperature /= weatherData.Where(d => d.Date.Month == monthStat.Key).Count();
            }

            return monthlyStatistics;
        }
    }
}
*/
////52
//using System;
//using System.Collections.Generic;

//namespace LibraryBookTracker
//{
//    class Program
//    {
//        static List<Book> books = new List<Book>();

//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Выберите действие:");
//                Console.WriteLine("1. Добавить книгу");
//                Console.WriteLine("2. Удалить книгу");
//                Console.WriteLine("3. Редактировать книгу");
//                Console.WriteLine("4. Найти книгу");
//                Console.WriteLine("5. Вывести список книг");
//                Console.WriteLine("6. Выход");

//                Console.Write("Введите номер действия: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        AddBook();
//                        break;
//                    case "2":
//                        RemoveBook();
//                        break;
//                    case "3":
//                        EditBook();
//                        break;
//                    case "4":
//                        FindBook();
//                        break;
//                    case "5":
//                        PrintBookList();
//                        break;
//                    case "6":
//                        Console.WriteLine("До свидания!");
//                        return;
//                    default:
//                        Console.WriteLine("Некорректный выбор действия.");
//                        break;
//                }
//            }
//        }

//        static void AddBook()
//        {
//            Console.Write("Введите название книги: ");
//            string title = Console.ReadLine();

//            Console.Write("Введите автора книги: ");
//            string author = Console.ReadLine();

//            Console.Write("Введите жанр книги: ");
//            string genre = Console.ReadLine();

//            books.Add(new Book(title, author, genre));
//            Console.WriteLine("Книга добавлена.");
//        }

//        static void RemoveBook()
//        {
//            Console.Write("Введите название книги для удаления: ");
//            string title = Console.ReadLine();

//            Book bookToRemove = books.Find(b => b.Title == title);

//            if (bookToRemove != null)
//            {
//                books.Remove(bookToRemove);
//                Console.WriteLine("Книга удалена.");
//            }
//            else
//            {
//                Console.WriteLine("Книга не найдена.");
//            }
//        }

//        static void EditBook()
//        {
//            Console.Write("Введите название книги для редактирования: ");
//            string title = Console.ReadLine();

//            Book bookToEdit = books.Find(b => b.Title == title);

//            if (bookToEdit != null)
//            {
//                Console.WriteLine("\nВыберите поле для редактирования:");
//                Console.WriteLine("1. Название");
//                Console.WriteLine("2. Автор");
//                Console.WriteLine("3. Жанр");

//                Console.Write("Введите номер поля: ");
//                string fieldChoice = Console.ReadLine();

//                switch (fieldChoice)
//                {
//                    case "1":
//                        Console.Write("Введите новое название: ");
//                        bookToEdit.Title = Console.ReadLine();
//                        break;
//                    case "2":
//                        Console.Write("Введите нового автора: ");
//                        bookToEdit.Author = Console.ReadLine();
//                        break;
//                    case "3":
//                        Console.Write("Введите новый жанр: ");
//                        bookToEdit.Genre = Console.ReadLine();
//                        break;
//                    default:
//                        Console.WriteLine("Некорректный выбор поля.");
//                        break;
//                }

//                Console.WriteLine("Книга отредактирована.");
//            }
//            else
//            {
//                Console.WriteLine("Книга не найдена.");
//            }
//        }

//        static void FindBook()
//        {
//            Console.Write("Введите текст для поиска: ");
//            string searchText = Console.ReadLine();

//            List<Book> foundBooks = books.FindAll(b =>
//                b.Title.Contains(searchText) ||
//                b.Author.Contains(searchText) ||
//                b.Genre.Contains(searchText));

//            if (foundBooks.Count > 0)
//            {
//                Console.WriteLine("\nНайденные книги:");
//                foreach (Book book in foundBooks)
//                {
//                    Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Жанр: {book.Genre}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Книги не найдены.");
//            }
//        }

//        static void PrintBookList()
//        {
//            if (books.Count == 0)
//            {
//                Console.WriteLine("Список книг пуст.");
//                return;
//            }

//            Console.WriteLine("\nСписок всех книг:");
//            foreach (Book book in books)
//            {
//                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Жанр: {book.Genre}");
//            }
//        }
//    }

//    class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public string Genre { get; set; }

//        public Book(string title, string author, string genre)
//        {
//            Title = title;
//            Author = author;
//            Genre = genre;
//        }
//    }
//}
