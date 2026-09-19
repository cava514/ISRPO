using System.Text;
// Чтение из файла
string filePath = "data.txt";
//Задание #1
ReadFromFile(filePath);
// Нерациональный метод для чтения из файла
static void ReadFromFile(string filePath)
{
    if (!File.Exists(filePath))
    {
        Console.WriteLine("File not found.");
        return;
    }
    // Оптимизация: добавить в конструктор параметр bufferSize: 8192 [Статус:выполненно]
    // для увеличения размера буфера
    using (StreamReader reader = new StreamReader(filePath, Encoding.ASCII, true, bufferSize: 8192))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            // Оптимизация: использовать асинхронные операции
            Console.WriteLine(line);
        }
    }
}
//Задание #2
// Запись в файл
WriteToFile(filePath, "Some data to be written to the file");
// Нерациональный метод для записи в файл
void WriteToFile(string filePath, params string[] data)
{
    // Оптимизация: добавить в конструктор параметры Encoding.UTF8 и bufferSize: 8192 [Статус:выполненно]
    // для увеличения размера буфера
    using (var writer = new StreamWriter(filePath, true, encoding: Encoding.UTF8, bufferSize: 8192))
    {
        // Оптимизация: заменить посимвольную запись записью всей строки в файл [Статус:выполненно]
        foreach (string s in data)
        {
            // Оптимизация: использовать асинхронные операции [Статус:выполненно]
            writer.WriteLineAsync(s);
        }
    }
}
//Задание #3
Dictionary<int, int> _fibonacciCache = new Dictionary<int, int>();
// Вычисление чисел Фибоначчи (сумма двух предыдущих значений: 0,1,1,2,3,5,8,...)
Console.WriteLine("Fibonacci Sequence:");
for (int i = 0; i < 20; i++)
{
    // Оптимизация: избежать повторного вычисления
    Console.WriteLine($"Fib({i}) = {Fibonacci(i)}");
}
// Нерациональный алгоритм для вычисления чисел Фибоначчи
int Fibonacci(int n)
{
    int result;
    if(_fibonacciCache.ContainsKey(n))
        return _fibonacciCache[n];
    if (n <= 1)
        return n;
    if(!_fibonacciCache.ContainsKey(n))
        _fibonacciCache.Add(n, result);
    result = Fibonacci(n - 1) + Fibonacci(n - 2);
    // Оптимизация: кэширование и улучшение алгоритма
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}