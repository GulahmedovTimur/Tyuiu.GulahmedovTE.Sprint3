using Tyuiu.GulahmedovTE.Sprint3.Task2.V27.Lib;
namespace Tyuiu.GulahmedovTE.Sprint3.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Начальный шаг = переменная i = 1");
            Console.WriteLine("Конечный шаг = 14");
            Console.WriteLine("Переменная х = 5");

            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            double sumSeries = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + sumSeries);
            Console.ReadKey();
        }
    }
}