using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args) //Основной метод программы
    {
        Console.WriteLine("Задание 3"); 
        AllInfoProcess(); //Вызываем метод, который будет выводить информацию о процессах
    }
    static void AllInfoProcess() //Метод, который выводит информацию о всех текущих процессах
    {
        var myProcess = from proc in Process.GetProcesses(".") //Получаем все текущие процессы и сортируем их по приоритету
                        orderby proc.BasePriority
                        select proc;
        Console.WriteLine("\n*** Текущие процессы ***\n"); //Выводим заголовок для списка процессов
        foreach (var p in myProcess) //Выводим информацию о каждрм процессе
            Console.WriteLine("-> PID: {0}\tName: {1}", p.Id, p.ProcessName);

    }
}