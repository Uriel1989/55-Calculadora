using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Calculadora
    {
        public decimal ResultadoSuma (decimal PrimerNumero, decimal SegundoNumero)
        {
            return PrimerNumero + SegundoNumero;
        }

        public decimal ResultadoResta (decimal PrimerNumero, decimal SegundoNumero)
        {
            return PrimerNumero - SegundoNumero;
        }
        public decimal ResultadoMultiplicacion(decimal PrimerNumero, decimal SegundoNumero)
        {
            return PrimerNumero * SegundoNumero;
        }
        public decimal ResultadoDivision(decimal PrimerNumero, decimal SegundoNumero)
        {
            return PrimerNumero / SegundoNumero;
        }

        public decimal Calcular(decimal PrimerNumero, decimal SegundoNumero, string operacion)
        {
            switch (operacion)
            {
                case "sumar":
                    Console.WriteLine("El resultado de la suma es: " + Calculadora.ResultadoSuma(PrimerNumero, SegundoNumero));
                    break;
                case "resta":
                    Console.WriteLine("El resultado de la resta es: " + Calculadora.ResultadoResta(PrimerNumero, SegundoNumero));
                    break;
                case "multiplicacion":
                    Console.WriteLine("El resultado de la multiplicacion es: " + Calculadora.ResultadoMultiplicacion(PrimerNumero, SegundoNumero));
                    break;
                case "division":
                    Console.WriteLine("El resultado de la division es: " + Calculadora.ResultadoDivision(PrimerNumero, SegundoNumero));
                    break;
            }
        }

    }
}
