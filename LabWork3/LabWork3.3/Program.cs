using System.Diagnostics;

var ts = new TraceSource("Calculator")
{
    Switch = new SourceSwitch("CalculatorSwitch")
    {
        Level = SourceLevels.Information
    }
};

ts.Listeners.Clear();
ts.Listeners.Add(new TextWriterTraceListener("trace.log", "fileListener"));
ts.Listeners.Add(new ConsoleTraceListener());

ts.TraceEvent(TraceEventType.Error, 3, "");
ts.TraceInformation("информация");
ts.TraceEvent(TraceEventType.Warning, 2, "");


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
ts.TraceEvent(TraceEventType.Verbose, 1, $"");
ts.TraceEvent(TraceEventType.Warning, 2, "");
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");