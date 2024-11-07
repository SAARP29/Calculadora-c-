using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace EjercicioEvaluable  {

    class Calculadora
    {
        public static void Main(String[] args)
        {
            int valor1,valor2;
            Console.WriteLine("Introduzca el primer valor");
             valor1=int.Parse(Console.ReadLine());
             Console.WriteLine("Introduzca el segundo valor");
             valor2=int.Parse(Console.ReadLine());

            while(!IntroduccionDeDatos(valor1,valor2))
            {
                Console.WriteLine("Introduzca el primer valor");
                valor1=int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo valor");
                valor2=int.Parse(Console.ReadLine());
            }
            Menu(valor1,valor2);
        }
    
        public static void Menu(int n1,int n2)
        {
            while(true)
            {
                Console.WriteLine("---MenuCalculadora---");
                Console.WriteLine("1.Suma");
                Console.WriteLine("2.Resta");
                Console.WriteLine("3.Multiplicacion");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Salir");
                Console.WriteLine("\nElija una opcion");
                int opcion=int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                    Suma(n1,n2);
                    break;
                    case 2:
                    Resta(n1,n2);
                    break;
                    case 3:
                    Multiplicacion(n1,n2);
                    break;
                    case 4:
                    Division(n1,n2);
                    break;
                    case 5:
                    Console.WriteLine("Ha salido del programa");
                    return;
                    
                }
            }
        }
    
        public static  Boolean IntroduccionDeDatos (int n1,int n2)
        {
            if (n1 >= 0 && n2 >= 0) 
            {
            return true;
            } else 
            {
            Console.WriteLine("Valores incorrectos");
            return false;
            }
        }

        public static int Suma(int n1,int n2)

        {
            int suma=n1+n2;
            Console.WriteLine("la suma es : "+suma);
            return suma;
        }

        public static int Resta(int n1,int n2)
        {
            int resta=n1-n2;
            Console.WriteLine("la resta de {0} y {1} es {2} ",n1,n2,resta);
            return resta;
        }
        public static int Multiplicacion(int n1,int n2)
        {
            int multiplicacion=n1*n2;
            Console.WriteLine("la multiplicacion de {0} y {1} es {2} ",n1,n2,multiplicacion);
            return multiplicacion;
        }
        public static float Division(int n1,int n2){
            float division=(float)n1/n2;
            Console.WriteLine("la division de {0} y {1} es {2:N2} ",n1,n2,division);
            return division;
        }
    } 


} 
