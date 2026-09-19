try
{
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.WriteLine($"{a} * {b} = {a * b}");
    Console.WriteLine($"{a} / {b} = {a / b}");
}
catch (FormatException ex)
{
    File.AppendAllText(@"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3\log.txt", $"[{DateTime.Now:u}] FormatException: Input string was not in a correct format\n");
    Console.WriteLine($"Входная строка имела неверный формат {ex.Message}");
}
catch (OverflowException ex)
{
    File.AppendAllText(@"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3\log.txt", $"[{DateTime.Now:u}] OverflowException: Arithmetic, casting, or conversion operation overflow in a checked numeric context\n");
    Console.WriteLine($"Переполнение при выполнении арифметической операции, операции приведения или преобразования в контексте с проверкой переполнения {ex.Message}");
}
catch (Exception ex)
{
    File.AppendAllText(@"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3\log.txt", $"[{DateTime.Now:u}] Exception: Application execution error\n");
    Console.WriteLine($"Ошибка при выполнении приложения {ex.Message}");
}