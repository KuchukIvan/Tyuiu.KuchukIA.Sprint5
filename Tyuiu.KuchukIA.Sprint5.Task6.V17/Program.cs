using System;
using Tyuiu.KuchukIA.Sprint5.Task6.V17.Lib;
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
        Console.WriteLine("* Задание #6                                                                                  *");
        Console.WriteLine("* Вариант #17                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        
        string file = "InPutDataFileTask6V17.txt";
        string directory = @"C:\DataSprint5";
        string path = Path.Combine(directory, file);

        Console.WriteLine("Данные находятся в файле: " + path);




        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        int res = ds.LoadFromDataFile(path);


        Console.WriteLine(res);


        Console.ReadKey();

    }
}
