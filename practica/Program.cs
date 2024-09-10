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
void AllSum(List<int> priList)
{
    int sum = 0;
    foreach (int i in priList)
    {
        sum =+ i;
    }
    Console.WriteLine(sum);
}
List<string> purList = new List<string>();
List<int> priList = new List<int>();
Console.WriteLine("Вводите ваши покупочки и их цену (в рублях)");
Console.WriteLine("\n Чтобы закончить, введите 1");
bool work = true;

    Console.WriteLine("Ваш товар: ");
    string purchase = Console.ReadLine();
    purList.Add(purchase);
    Console.WriteLine("Добавлено: " + purchase);
    Console.WriteLine("Стоимость товара " + purchase);
    int price = int.Parse(Console.ReadLine());
    Console.WriteLine("Стоимость добавлена!");
Console.WriteLine("Ваш товар: ");
 purchase = Console.ReadLine();
purList.Add(purchase);
Console.WriteLine("Добавлено: " + purchase);
Console.WriteLine("Стоимость товара " + purchase);
price = int.Parse(Console.ReadLine());
Console.WriteLine("Стоимость добавлена!");
AllSum(priList);
