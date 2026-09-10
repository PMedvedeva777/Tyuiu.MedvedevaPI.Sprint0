namespace Tyuiu.MedvedevaPI.Sprint0.Task3.V0.Test;
using Tyuiu.MedvedevaPI.Sprint0.Task3.V0.Lib;

    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }

