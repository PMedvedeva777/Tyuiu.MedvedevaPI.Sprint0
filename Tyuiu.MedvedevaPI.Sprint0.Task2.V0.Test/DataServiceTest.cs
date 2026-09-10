namespace Tyuiu.MedvedevaPI.Sprint0.Task2.V0.Test;

using Tyuiu.MedvedevaPI.Sprint0.Task2.V0.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Полина";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет,Полина", res);
    }
}
