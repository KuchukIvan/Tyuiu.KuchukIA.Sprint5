using System;
using Tyuiu.KuchukIA.Sprint5.Task2.V18.Lib;
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
        Console.WriteLine("* Задание #2                                                                                  *");
        Console.WriteLine("* Вариант #18                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");

        int[,] matrix = new int[3, 3] { { 3, 8, 4 },
                                        {-5, -4, -3},
                                        {-9, 0, 2} };


        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix.Length / rows;

        Console.WriteLine();
        Console.WriteLine("Матрица:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }






        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        string res = ds.SaveToFileTextData(matrix);


        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан");





        Console.ReadKey();

    }
}
