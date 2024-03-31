namespace CalculadoraStirng;

public class Calculadora
{
    private const int VALOR_POR_DEFECTO = 0; //Snake_case se usa solo para las constantes separar con una barra baja
    private const string Separador = ",";
    public int Sumar(string numeros)
    {
        numeros = AjustarEntrada(numeros);
        if (EsSoloUnNumero(numeros) )
        {
            return ConvertirStringAInt(numeros);
        }

        if (SonVariosNumeros(numeros))
        {
            return CalcularSumaDeVariosNumeros(numeros);
        }

        return VALOR_POR_DEFECTO;
    }

    private static int CalcularSumaDeVariosNumeros(string numeros)
    {
        string[] valores = numeros.Split(ConvertirSeparador());
        int suma = 0;
        foreach (string unValor in valores)
        {
            suma += ConvertirStringAInt(unValor);
        }

        return suma;
    }

    private static string AjustarEntrada(string numeros)
    {
        return numeros.Replace('\n', ConvertirSeparador());
    }

    private static char ConvertirSeparador()
    {
        return Separador.ToCharArray().First();
    }

   
    private static bool SonVariosNumeros(string numeros)
    {
        return numeros.Contains(Separador);
    }
    

    private static int ConvertirStringAInt(string numeros)
    {
        return int.Parse(numeros);
    }

    private static bool EsSoloUnNumero(string numeros)
    {
        return numeros.Length == 1;
    }
}