using CalculadoraStirng;

namespace CalculadorStringTest;

[TestClass]
public class CalculadoraTest
{
    [TestMethod]
    public void SumarStirngVacioTest()
    {
        Calculadora unaCalculadora = new Calculadora();
        Assert.AreEqual(0,unaCalculadora.Sumar(""));
    }

    [TestMethod]
    public void SumarStringUnicoNumeroTest()
    {
        Calculadora unaCalculadora = new Calculadora();
        Assert.AreEqual(1,unaCalculadora.Sumar("1"));
    }
    
    
}