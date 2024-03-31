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

    [TestMethod]
    public void SumarMasDeDosNumerosSeparadosPorBarraNTest()
    {
        Calculadora unaCalculadora = new Calculadora () ;
        Assert.AreEqual (12,unaCalculadora.Sumar ("1\n3\n7\n1"));
    }
    
    [ TestMethod ]
    public void SumarMasDeDosNumerosSeparadosPorComaTest ()
    {
        Calculadora unaCalculadora = new Calculadora () ;
        Assert . AreEqual (18 , unaCalculadora . Sumar ("3 ,4 ,2 ,5 ,1 ,1 ,1 ,1") ) ;
    }
    [ TestMethod ]
    [ ExpectedException ( typeof ( ExcepcionNumeroNegativo ) ) ]
    public void SumarConNegativosTest ()
    {
        Calculadora unaCalculadora = new Calculadora () ;
        unaCalculadora . Sumar ("1 ,2 ,3 , -1 ,2 ,3") ;
    }

        
}