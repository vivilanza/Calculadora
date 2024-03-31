﻿namespace CalculadoraStirng;

public class Calculadora
{
    private const int VALOR_POR_DEFECTO = 0; //Snake_case se usa solo para las constantes separar con una barra baja
    private const string Separador = ",";
    public int Sumar(string numeros)
    {
        numeros = numeros.Replace('\n', ConvertirSeparador());
        if (EsSoloUnNumero(numeros) )
        {
            return ConvertirStringAInt(numeros);
        }

        if (SonVariosNumeros(numeros))
        {
            string[] valores = numeros.Split(ConvertirSeparador()); 
            return ConvertirStringAInt(valores[0]) + ConvertirStringAInt(valores[1]);
        }

        return VALOR_POR_DEFECTO;
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