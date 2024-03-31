namespace CalculadoraStirng;

public class Calculadora
{
    private const int VALOR_POR_DEFECTO = 0; //Snake_case se usa solo para las constantes separar con una barra baja
    public int Sumar(string numeros)
    {
        if (numeros.Length == 1)
        {
            return int.Parse(numeros);
        }
        
            
        
        return VALOR_POR_DEFECTO;
    }
}