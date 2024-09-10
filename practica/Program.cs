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
//36
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
