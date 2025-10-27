using System;
using Tyuiu.KuchukIA.Sprint5.Task0.V20.Lib;
internal class Program
{
    static void Main(string[] args)
    {

        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                   *");
        Console.WriteLine("* Тема: Обработка файлов                                                                      *");
        Console.WriteLine("* Задание #0                                                                                  *");
        Console.WriteLine("* Вариант #20                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");

        int x = 2;

        Console.WriteLine("x = " + x);
        
     




        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        string res = ds.SaveToFileTextData(x);


        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан");





        Console.ReadKey();

    }
}
