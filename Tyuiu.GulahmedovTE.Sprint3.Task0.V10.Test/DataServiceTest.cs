using Tyuiu.GulahmedovTE.Sprint3.Task0.V10.Lib;
namespace Tyuiu.GulahmedovTE.Sprint3.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0.033;

            Assert.AreEqual(res, wait);

        }
    }
}