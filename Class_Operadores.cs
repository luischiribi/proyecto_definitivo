using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_definitivo
{
    public class Class_Operadores
    {
        public static void Op_menu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("\n1 - Calcular area del triangulo");
            Console.WriteLine("\n2 - Ingresar dos números por teclado y sumarlos.");
            Console.WriteLine("\n3 - Ingresar un número y visualizar el número elevado al cuadrado. ");
            Console.WriteLine("\n4 - Escribir un algoritmo que convierta de euros a dólares. ");
            Console.WriteLine("\n5 - Escribir un algoritmo que pida el lado de un cuadrado y muestre el valor del área y del perímetro. ");
            Console.WriteLine("\n6 - Escribir un algoritmo que determine el área y el volúmen de un cilindro.");
            Console.WriteLine("\n7 - Realizar un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y el área (pi*r)^2 del círculo inscrito. ");
            Console.WriteLine("\n8 - Calcular el promedio de tres (3) números ingresados por teclado");
            Console.WriteLine("\n9 - salir");
            Console.WriteLine("-----------------");
        }
        public static void Op_1(double num1, double num2)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("lado 1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("lado 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del triangulo es es:");
            Console.WriteLine(num1 * num2 / 2);
            Console.WriteLine("-----------------");
        }
        public static void Op_2(double num1, double num2)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("primer valor:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("la suma es:");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("-----------------");
        }
        public static void Op_3(double num1)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el primer entero a multiplicar:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado es:");
            Console.WriteLine(Math.Pow(num1, 2));
            Console.WriteLine("-----------------");
        }
        public static void Op_4(double num1)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el valor en  euros:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El valor en dolares es:");
            Console.WriteLine(num1 * 1.06);
            Console.WriteLine("-----------------");
        }
        public static void Op_5(double num1)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el lado de un cuadrado:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del cuadrado es : ");
            Console.WriteLine(num1 * num1);
            Console.WriteLine("El perimetro del cuadrado es");
            Console.WriteLine(num1 + num1 + num1 + num1);
            Console.WriteLine("-----------------");
        }
        public static void Op_6(double num1,double num2)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el radio del cilindro:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area del cilindro es  : ");
            Console.WriteLine(2 * Math.PI * num1 * num2);
            Console.WriteLine("El volumen del cilindro es");
            Console.WriteLine(Math.PI * num1 * num1 * num2);
            Console.WriteLine("-----------------");
        }
        public static void Op_7( double num1)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el valor del diametro de la circunferencia:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El radio es : ");
            Console.WriteLine();
            Console.WriteLine("El area del cilindro es  : ");
            Console.WriteLine();
            Console.WriteLine("la longitud de la circunferencia es");
            Console.WriteLine(Math.PI * 2);
            Console.WriteLine("-----------------");
        }
        public static void Op_8(double num1 , double num2 , double num3)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Ingrese el primer valor:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor:");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El promedio de los datos es  : ");
            Console.WriteLine(num1 + num2 + num3 / 3);
        }
        public static void Op_def()
        {
            Console.WriteLine("dato incorrecto saliendo del programa");
        }
       
    }
}
