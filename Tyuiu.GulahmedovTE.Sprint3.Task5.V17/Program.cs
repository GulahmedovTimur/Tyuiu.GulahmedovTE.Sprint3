using Tyuiu.GulahmedovTE.Sprint3.Task5.V17.Lib;
namespace Tyuiu.GulahmedovTE.Sprint3.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая отвечает всем требованиям задания.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(1, 1, 1, 3, 12));

            Console.ReadKey();
        }
    }
}