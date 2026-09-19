//5.1.1
//Console.Write("Введите первое слагаемое: ");
//double a = Convert.ToDouble(Console.ReadLine()); //Вводиться первое число

//Console.Write("Введите второе слагаемое: ");
//double b = Convert.ToDouble(Console.ReadLine()); //Вводиться второе число

//Console.WriteLine($"{a} + {b} = {a+b}"); //Выводит сумму двух чисел

//5.1.3
//string a = ""; //Первое число
//string b = ""; //Второе число
//double sum = 0; //Сумма чисел

//while (a != "exit" && b != "exit") //Цикл с условием пока пользователь не введёт exit
//{
//    Console.Write("Введите первое слагаемое: ");
//    a = Console.ReadLine(); //Вводиться первое число

//    Console.Write("Введите второе слагаемое: ");
//    b = Console.ReadLine(); //Вводиться второе число

//    Console.WriteLine($"{a} + {b} = {Convert.ToDouble(a+b)}"); //Выводит сумму двух чисел
//    sum = Convert.ToDouble(a + b);
//}

//5.2.1
//using System.Diagnostics;

//string a = ""; //Первое число
//string b = ""; //Второе число
//double sum = 0; //Сумма чисел

//while (a != "exit" && b != "exit") //Цикл с условием пока пользователь не введёт exit
//{
//    Console.Write("Введите первое слагаемое: ");
//    Debug.WriteLine("Вводиться первое число"); //Дополнительное сообщение перед ввода первого значения
//    a = Console.ReadLine(); //Вводиться первое число

//    Console.Write("Введите второе слагаемое: ");
//    Debug.WriteLine("Вводиться второе число"); //Дополнительное сообщение перед ввода первого значения
//    b = Console.ReadLine(); //Вводиться второе число

//    Debug.WriteLine("Вывод суммы двух чисел"); //Дополнительное сообщение перед выводом результата
//    Console.WriteLine($"{a} + {b} = {Convert.ToDouble(a + b)}"); //Выводит сумму двух чисел
//    Debug.WriteLine("Сложение двух чисел в сумму"); //Дополнительное сообщение перед сложением
//    sum = Convert.ToDouble(a + b);
//}

//5.2.2
//using System.Diagnostics;

//string a = ""; //Первое число
//string b = ""; //Второе число
//double sum = 0; //Сумма чисел

//while (a != "exit" && b != "exit") //Цикл с условием пока пользователь не введёт exit
//{
//    Console.Write("Введите первое слагаемое: ");
//#if DEBUG
//    Debug.WriteLine("Вводиться первое число"); //Дополнительное сообщение перед ввода первого значения
//#endif
//    a = Console.ReadLine(); //Вводиться первое число

//    Console.Write("Введите второе слагаемое: ");
//#if DEBUG
//    Debug.WriteLine("Вводиться второе число"); //Дополнительное сообщение перед ввода первого значения
//#endif
//    b = Console.ReadLine(); //Вводиться второе число
//#if TRACE
//    Trace.WriteLine("Вывод суммы двух чисел"); //Дополнительное сообщение перед выводом результата
//#endif
//    Console.WriteLine($"{a} + {b} = {Convert.ToDouble(a + b)}"); //Выводит сумму двух чисел
//#if TRACE
//    Trace.WriteLine("Сложение двух чисел в сумму"); //Дополнительное сообщение перед сложением
//#endif
//    sum = Convert.ToDouble(a + b);
//}

//5.3.1
//static double CalculateDiscount(double price, double discountRate) //Метод для расчёта скидки в процентах
//{
//    return price - price / ((discountRate + 100) / 100); //Возвращает итоговую сумму
//}

//5.3.2
//С некорректными параметрами
using System.Diagnostics;

static double CalculateDiscount(double price, double discountRate) //Метод для расчёта скидки в процентах
{
    Debug.Assert(price > 0.00);
    Debug.Assert(discountRate >= 0.00 && discountRate <= 1.00);
    Debug.Assert(price - price / ((discountRate + 100) / 100) <= price);
    return price - price / ((discountRate + 100) / 100); //Возвращает итоговую сумму
}

//5.3.2
//С корректными параметрами
//using System.Diagnostics;

//static double CalculateDiscount(double price, double discountRate) //Метод для расчёта скидки в процентах
//{
//    Debug.Assert(price > 0.00);
//    Debug.Assert(discountRate >= 0.00 && discountRate <= 1.00);
//    Debug.Assert(price - price / ((discountRate + 100) / 100) <= price);
//    return price - price / ((discountRate + 100) / 100); //Возвращает итоговую сумму
//}