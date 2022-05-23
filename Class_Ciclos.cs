using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_definitivo
{
    public class Class_Ciclos
    {
        public static void Op_menu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("\n1 - Imprimir todos los múltiplos de 3 que hay entre 1 y 100.");
            Console.WriteLine("\n2 - Imprimir los números impares entre 0 y 100. ");
            Console.WriteLine("\n3 - Imprimir los números pares del 1 al 100");
            Console.WriteLine("\n4 - Escribir un programa que imprima por pantalla los cuadrados de los números del 1 al 30.");
            Console.WriteLine("\n5 - Escribir un programa que sume los cuadrados de los cien primeros números naturales, mostrando el resultado en pantalla.");
            Console.WriteLine("\n6 - Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente.");
            Console.WriteLine("\n7 - Sumar todos los números que se digitan por teclado mientras no sea cero.");
            Console.WriteLine("-----------------");
        }
        public static void Op_1( double num1)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Los multiplos de 3 del numero 1 al 100 son");
            Console.WriteLine("------------------------------------------");

            for (num1 = 3; num1 <= 100; num1 += 3)
            {
                Console.WriteLine("-" + num1);
            }
        }
        public static void Op_2( double num1)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Los numeros impares del numero 0 al 100 son");
            Console.WriteLine("--------------------------------------------");

            for (num1 = 1; num1 <= 100; num1 += 2)
            {
                Console.WriteLine("-" + num1);
            }
        }
        public static void Op_3( double num1)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Los numeros pares del numero 0 al 100 son");
            Console.WriteLine("------------------------------------------");

            for (num1 = 2; num1 <= 100; num1 += 2)
            {
                Console.WriteLine("-" + num1);
            }
        }
        public static void Op_4( double num1)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Los cuadrados del numero 1 al 30 son");
            Console.WriteLine("-------------------------------------");

            for (num1 = 1; num1 <= 30; num1++)
            {
                Console.WriteLine(" El numero " + num1 + " al cuadrado es = " + Math.Pow(num1, 2));
            }
        }
        public static void Op_5( double num1 , double num2 , double num3)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Los cuadrados del numero 1 al 100 son");
            Console.WriteLine("----------------------------------------");

            num3 = 0;

            for (num1 = 1; num1 <= 100; num1++)
            {
                Console.WriteLine(" El numero " + num1 + " al cuadrado es = " + Math.Pow(num1, 2));
                num3 = num3 + (Math.Pow(num1, 2));
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("la suma de los cuadrados es " + num3);
            Console.WriteLine("--------------------------------------");
        }
        public static void Op_6 ( double num1,double num2, double num3)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            num3 = 0;

            for (num3 = num1; num3 <= num2; num3++)
            {
                Console.WriteLine(" Los numeros es " + num3);
            }
        }
        public static void Op_7( double num1, double num2)
        {
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("-------------------------------------");

            num2 = 0;

            do

            {
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = num2 + num1;
            }
            while (num1 != 0);
        }
        public static void Op_def()
        {
            Console.WriteLine("dato incorrecto saliendo del programa");
        }
    }
}
