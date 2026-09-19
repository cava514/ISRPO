//5.1.1
//try
//{
//    Console.Write("Введите первое слагаемое: ");
//    double a = Convert.ToDouble(Console.ReadLine()); //Вводиться первое число

//    Console.Write("Введите второе слагаемое: ");
//    double b = Convert.ToDouble(Console.ReadLine()); //Вводиться второе число

//    Console.WriteLine($"{a} + {b} = {a / b}"); //Выводит сумму двух чисел
//}
//catch (FormatException ex) //Исключение если введен текст вместо числа
//{
//    Console.WriteLine(ex.Message);
//}
//catch (DivideByZeroException ex) //Исключение деления на ноль
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex) //Исключение с выводом stack trace
//{
//    Console.WriteLine(ex.StackTrace);
//}

//5.1.2
//using NLog;
//using NLog.Config;
//using NLog.Targets;

//LoggingConfiguration logConfiguration = new();

//FileTarget fileTarget = new()
//{
//    FileName = "errors"
//};

//try
//{
//    Console.Write("Введите первое слагаемое: ");
//    double a = Convert.ToDouble(Console.ReadLine()); //Вводиться первое число

//    Console.Write("Введите второе слагаемое: ");
//    double b = Convert.ToDouble(Console.ReadLine()); //Вводиться второе число

//    Console.WriteLine($"{a} + {b} = {a / b}"); //Выводит сумму двух чисел
//}
//catch (FormatException ex) //Исключение если введен текст вместо числа
//{
//    Console.WriteLine(ex.Message);
//}
//catch (DivideByZeroException ex) //Исключение деления на ноль
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex) //Исключение с выводом stack trace
//{
//    Console.WriteLine(ex.StackTrace);
//}

//5.2.2
//using LabWork2;

//try
//{
//    Console.Write("Введите возраст: ");
//    int age = Convert.ToInt32(Console.ReadLine()); //Вводиться возраст
//    if (age < 0) //Проверка возраста
//        throw new NegativeNumberException("Не существует отрицательного возраста", age); //Генерация исключения
//}
//catch (NegativeNumberException ex) //Исключение если введено отрицательное число, с понятным сообщением
//{
//    Console.WriteLine(ex.Message);
//}

//5.3
using System.Reflection.PortableExecutable;
using System.Text;

FileStream? fileStream = null;

try
{
    fileStream = new("TextFile.txt", FileMode.OpenOrCreate);
    using (var file = new StreamReader(fileStream))
    {
        string? line;
        while ((line = await file.ReadLineAsync()) != null)
        {
            Console.WriteLine(line); //Тут доделать
        }
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    fileStream?.Close();
}

//5.4.1
AppDomain domain = AppDomain.CurrentDomain;
