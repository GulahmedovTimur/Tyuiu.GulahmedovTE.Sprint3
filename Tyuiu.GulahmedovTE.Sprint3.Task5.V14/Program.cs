using Tyuiu.GulahmedovTE.Sprint3.Task5.V14.Lib;
namespace Tyuiu.GulahmedovTE.Sprint3.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 14;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Переменная X: {x}");
            Console.WriteLine($"Старт шага первой суммы ряда: {startValue1}");
            Console.WriteLine($"Конец шага первой суммы ряда: {startValue2}");
            Console.WriteLine($"Старт шага второй суммы ряда: {stopValue1}");
            Console.WriteLine($"Конец шага второй суммы ряда: {stopValue2}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write($"Результат = {ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2)}");
            Console.ReadKey();
        }
    }
}