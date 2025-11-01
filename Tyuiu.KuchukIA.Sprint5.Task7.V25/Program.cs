using System;
using Tyuiu.KuchukIA.Sprint5.Task7.V25.Lib;
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
        Console.WriteLine("* Задание #7                                                                                  *");
        Console.WriteLine("* Вариант #25                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");



        string file = "InPutDataFileTask7V25.txt";
        string directory = @"C:\DataSprint5";
        string path = Path.Combine(directory, file);

        Console.WriteLine("Данные находятся в файле: " + path);




        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        string res = ds.LoadDataAndSave(path);

        Console.WriteLine("В файле: " + res);


        Console.ReadKey();

    }
}
