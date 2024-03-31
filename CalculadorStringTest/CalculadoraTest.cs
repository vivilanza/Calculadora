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
   
    [TestMethod]
    public void SumarStringDosNumerosSeparadosPorComaTest()
    {
        Calculadora unaCalculadora = new Calculadora();
        Assert.AreEqual(3,unaCalculadora.Sumar("1,2"));
    }

    [TestMethod]
    public void SumarStringDosNumerosSeparadosPorBarraNTest()
    {
        Calculadora unaCalculadora = new Calculadora();
        Assert.AreEqual(5,unaCalculadora.Sumar("2\n3"));
    }
        
}