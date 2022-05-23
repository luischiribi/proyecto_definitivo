using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_definitivo
{
    public class Class_Condicionales
    {
        public static void Op_menu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("\n1 - Escribir un algoritmo para saber si el número ingresado por teclado es positivo o negativo.");
            Console.WriteLine("\n2 - Escribir un algoritmo que reciba dos números por teclado y diga cuál es el mayor y cuál el menor. ");
            Console.WriteLine("\n3 - Escriba un programa que lea tres números enteros positivos y que calcule e imprima en pantalla el menor y el mayor de ellos. ");
            Console.WriteLine("\n4 - Dados dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine("\n5 - Dados dos números A y B encontrar el cociente entre A y B. Recordar que la división por cero no está definida, en ese caso debe aparecer una leyenda anunciando que la división no es posible. ");
            Console.WriteLine("\n6 - Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos. ");
            Console.WriteLine("\n7 - Escribir un algoritmo que determine si un año es bisiesto o no.");
            Console.WriteLine("-----------------");

        }
        public static void Op_1(double num1)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese un numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------");
            if (num1 > 0)
            {
                Console.WriteLine("El numero es " + num1 + " positivo");
            }
            else
            {
                Console.WriteLine("El numero es " + num1 + " negativo");
            }
        }
        public static void Op_2(double num1 , double num2)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------");
            if (num1 > num2)
            {
                Console.WriteLine("El numero  " + num1 + "  es mayor que " + num2);
            }
            else
            {
                Console.WriteLine("El numero  " + num1 + " es  menor que " + num2);

            }
        }

        public static void Op_3(double num1, double num2 , double num3)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------");

            if (num1 > num2)
            {
                Console.WriteLine("El numero mayor es " + num1);
            }
            else if (num2 > num3)
            {
                Console.WriteLine("El numero mmayor es " + num2);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + num3);
            }
            if (num1 < num2)
            {
                Console.WriteLine("El numero menor es " + num1);
            }
            else if (num2 < num3)
            {
                Console.WriteLine("El numero menor es " + num2);
            }
            else
            {
                Console.WriteLine("El numero menor es " + num3);
            }
        }
        public static void Op_4(double num1 , double num2)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------");

            if (num1 > num2)
            {
                Console.WriteLine(" la suma es ");
                Console.WriteLine(num1 + num2);
            }
            else
            {
                Console.WriteLine(" la resta es ");
                Console.WriteLine(num1 - num2);
            }
        }

        public static void Op_5(double num1 , double num2)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------");


            if (num1 == 0)
            {
                Console.WriteLine("la division no es posible");
            }
            else if (num2 == 0)
            {
                Console.WriteLine("la division no es posible");
            }
            else
            {
                Console.WriteLine("el resultado es ");
                Console.WriteLine(num1 / num2);
            }
        }

        public static void Op_6(double num1 , double num2)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------");

            if (num1 < 0)
            {
                Console.WriteLine(" la suma es ");
                Console.WriteLine(num1 + num2);
            }
            else if (num2 < 0)
            {
                Console.WriteLine(" la suma es ");
                Console.WriteLine(num1 + num2);
            }
            else
            {
                Console.WriteLine(" la multiplicacion es  ");
                Console.WriteLine(num1 * num2);
            }
        }

        public static void Op_7( double num1)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Calcular bisiestos");
            Console.WriteLine("Año a calcular");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------");

            if (num1 % 4 == 0 && (num1) % 100 != 0 || (num1) % 400 == 0)
            {
                Console.WriteLine("Es bisiesto {0}", num1);
            }
            else
            {
                Console.WriteLine("no es bisiesto {0}", num1);
            }         
        }
        public static void Op_def()
        {
            Console.WriteLine("dato incorrecto saliendo del programa");
        }
    }
}
