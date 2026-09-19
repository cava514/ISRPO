using System.Diagnostics;
using System.Text;

Stopwatch stopWatch = new();
TimeSpan ts = stopWatch.Elapsed; // получение прошедшего времени
stopWatch.Start();
// длительная операция
string path = @"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3.1\text.txt";   // путь к файлу

// чтение из файла
using (FileStream fstream = File.OpenRead(path))
{
    // выделяем массив для считывания данных из файла
    byte[] buffer = new byte[fstream.Length];
    ts = stopWatch.Elapsed; // получение прошедшего времени
    File.AppendAllText(@"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3.1\timings.txt", $"[{DateTime.Now:u}] Operation=OutputtingAnArrayOperation, Elapsed={ts.Milliseconds} ms\n");
    Debug.WriteLine($"[{DateTime.Now:u}] Operation=OutputtingAnArrayOperation, Elapsed={ts.Milliseconds}");
    // считываем данные
    await fstream.ReadAsync(buffer, 0, buffer.Length);
    ts = stopWatch.Elapsed; // получение прошедшего времени
    File.AppendAllText(@"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3.1\timings.txt", $"[{DateTime.Now:u}] Operation=ReadsDataOperation, Elapsed={ts.Milliseconds} ms\n");
    Debug.WriteLine($"[{DateTime.Now:u}] Operation=ReadsDataOperation, Elapsed={ts.Milliseconds}");
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(buffer);
    ts = stopWatch.Elapsed; // получение прошедшего времени
    File.AppendAllText(@"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3.1\timings.txt", $"[{DateTime.Now:u}] Operation=DecodingOperation, Elapsed={ts.Milliseconds} ms\n");
    Debug.WriteLine($"[{DateTime.Now:u}] Operation=DecodingOperation, Elapsed={ts.Milliseconds}");
    Console.WriteLine($"Текст из файла: {textFromFile}");
    ts = stopWatch.Elapsed; // получение прошедшего времени
    File.AppendAllText(@"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3.1\timings.txt", $"[{DateTime.Now:u}] Operation=OutputDataOperation, Elapsed={ts.Milliseconds} ms\n");
    Debug.WriteLine($"[{DateTime.Now:u}] Operation=OutputDataOperation, Elapsed={ts.Milliseconds}");
}
stopWatch.Stop();
ts = stopWatch.Elapsed; // получение прошедшего времени
File.AppendAllText(@"C:\Temp\ispp45\ИСРПО\LabWork3\LabWork3.1\timings.txt", $"[{DateTime.Now:u}] Operation=EndOperation, Elapsed={ts.Milliseconds} ms\n");
Debug.WriteLine($"[{DateTime.Now:u}] Operation=EndOperation, Elapsed={ts.Milliseconds}");