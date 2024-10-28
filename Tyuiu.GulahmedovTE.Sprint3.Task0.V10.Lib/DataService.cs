using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GulahmedovTE.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double P = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                P *= Math.Pow(300 / (i + (Math.Pow(value, i))), i);
            }
            return Math.Round(P, 3);
        }
    }
}
