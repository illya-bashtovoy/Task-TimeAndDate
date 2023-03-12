/* Створіть додаток, який використовує клас «Task». Додаток має відображати  поточний  час  і  дату.
Запустіть завдання  трьома способами:Через метод «Start» класу «Task».
Через метод «Task.Factory.StartNew».Через метод «Task.Run». */
using System;

namespace Sistem_Programe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Виведення поточного часу та дати
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Час: {currentTime:HH:mm:ss}");
            Console.WriteLine($"Дата: {currentTime:D}\n");

            // Створення трьох завдань для виведення поточного часу
            var task1 = Task.Run(() => Console.WriteLine($"{DateTime.Now:HH:mm:ss}"));
            var task2 = Task.Run(() => Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}"));
            var task3 = Task.Run(() => Console.WriteLine($"{DateTimeOffset.Now:HH:mm:ss}"));

            // Очікування завершення всіх завдань
            Task.WaitAll(task1, task2, task3);
        }
    }
}
