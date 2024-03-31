namespace CalculadoraStirng;

public class Calculadora
{
    private const int VALOR_POR_DEFECTO = 0; //Snake_case se usa solo para las constantes separar con una barra baja
    public int Sumar(string numeros)
    {
        if (EsSoloUnNumero(numeros) )
        {
            return ConvertirStringAInt(numeros);
        }
        
        return VALOR_POR_DEFECTO;
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