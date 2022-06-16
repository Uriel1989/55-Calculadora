using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Calculadora OperacionesMatematicas = new Calculadora();

            Console.WriteLine("Ingrese 2 numeros:");
            decimal PrimerNumero = Convert.ToInt32(Console.ReadLine());
            decimal SegundoNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba la operacion que desea realizar: sumar, resta, multiplicacion o division:");
            string operacion = Convert.ToString(Console.ReadLine());

            switch (operacion)
            {
                case "sumar":
                    Console.WriteLine("El resultado de la suma es: " + OperacionesMatematicas.ResultadoSuma(PrimerNumero, SegundoNumero));
                    break;
                case "resta":
                    Console.WriteLine("El resultado de la resta es: " + OperacionesMatematicas.ResultadoResta(PrimerNumero, SegundoNumero));
                    break;
                case "multiplicacion":
                    Console.WriteLine("El resultado de la multiplicacion es: " + OperacionesMatematicas.ResultadoMultiplicacion(PrimerNumero, SegundoNumero));
                    break;
                case "division":
                    Console.WriteLine("El resultado de la division es: " + OperacionesMatematicas.ResultadoDivision(PrimerNumero, SegundoNumero));
                    break;
            }

            Console.ReadKey();


        }
    }
}
