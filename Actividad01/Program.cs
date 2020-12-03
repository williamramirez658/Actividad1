using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, mayor,menor, aux,Opcion = 0;
            double num;
            string cadena;
            int[] edad = new int[10];
            string[] nombres = new string[10];
            edad[0] = 12;
            edad[1] = 50;
            edad[2] = 23;
            edad[3] = 10;
            edad[4] = 18;
            edad[5] = 35;
            edad[6] = 41;
            edad[7] = 85;
            edad[8] = 16;
            edad[9] = 45;
            nombres[0] = "juan";
            nombres[1] = "maria";
            nombres[2] = "tereza";
            nombres[3] = "pedro";
            nombres[4] = "javier";
            nombres[5] = "ana";
            nombres[6] = "diana";
            nombres[7] = "jorge";
            nombres[8] = "dayana";
            nombres[9] = "lady";

            while (Opcion != 9)
            {
                Console.WriteLine(" |-------------------------------------------------|\n" + 
                                  " |                  MENU PRINCIPAL                 |\n" +
                                  " |-------------------------------------------------|\n" +
                                  " | 1.  Número Par y Impar                          |\n" +
                                  " | 2.  Tabla de Multiplicar de Número (1 - 10)     |\n" +
                                  " | 3.  Tablas de multiplicar del 2 al 9            |\n" +
                                  " | 4.  Número primo                                |\n" +
                                  " | 5.  Ordenar Vector                              |\n" +
                                  " | 6.  Buscar Nombre en Vector                     |\n" +
                                  " | 7.  Buscar el numero mayor y menor en Vector    |\n" +
                                  " | 8.  Palabra palíndromo                          |\n" +
                                  " | 9.  Salir                                       |\n" +
                                  " |-------------------------------------------------|\n" +
                                  " | Digite la opcion que desea...........           |");
                Opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (Opcion)
                {
                    case 1: //1. Leer un número por teclado y definir si es par o impar 
                        Console.WriteLine(" |-------------------------------------------------|\n" +
                                          " | 1. Número Par y Impar                           |\n" +
                                          " |-------------------------------------------------|\n");
                        Console.WriteLine(" | Digite un numero...........");
                        num = Convert.ToDouble(Console.ReadLine());
                        if(num % 2 == 0)
                        {
                            Console.WriteLine(" El numero " + num + " es Par ");
                        }
                        else
                        {
                            Console.WriteLine(" El numero " + num + " es Impar ");
                        }
                        break;
                    case 2: //2.Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10
                        Console.WriteLine(" |-------------------------------------------------|\n" +
                                          " | 2.  Tabla de Multiplicar de Número (1 - 10)     |\n" +
                                          " |-------------------------------------------------|\n");
                        Console.WriteLine(" | Digite un numero...........");
                        num = Convert.ToDouble(Console.ReadLine());
                        for (i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i + " X " + num + " = " + (i* num));
                        }
                        break;
                    case 3: //3.Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10
                        Console.WriteLine(" |-------------------------------------------------|\n" +
                                          " | 3.  Tablas de multiplicar del 2 al 9            |\n" +
                                          " |-------------------------------------------------|\n");
                        for (i = 2; i < 10; i++)
                        {
                            Console.WriteLine(" -- Tabla de multiplicar del " + i + " -- ");
                            for (j = 1; j <= 10; j++)
                            {
                                Console.WriteLine(i + " X " + j + " = " + (i * j));
                            }
                        }
                        break;
                    case 4: //4.Leer un número por teclado y definir si es primo o no
                        Console.WriteLine(" |-------------------------------------------------|\n" +
                                          " | 4.  Número primo                                |\n" +
                                          " |-------------------------------------------------|\n");
                        Console.WriteLine(" | Digite un numero...........");
                        num = Convert.ToDouble(Console.ReadLine());
                        j = 0;
                        for (i = 1; i <= num; i++)
                        {
                            if(num % i == 0)
                            {
                                j++;
                            }
                        }
                        if (j > 2)
                        {
                            Console.WriteLine(" El numero " + num + " no es primo ");
                        }
                        else
                        {
                            Console.WriteLine(" El numero " + num + " es primo ");
                        }
                        break;
                    case 5: //5.Dado el vector edad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45], ordenarlos en forma ascendiente
                        Console.WriteLine(" |-------------------------------------------------|\n" +
                                          " | 5.  Ordenar Vector                              |\n" +
                                          " |-------------------------------------------------|\n");
                        for (i = 0; i < edad.Length; i++)
                        {
                            for (j = i; j < edad.Length; j++)
                            {
                                if(edad[i]> edad[j])
                                {
                                    aux = edad[i];
                                    edad[i] = edad[j];
                                    edad[j] = aux;
                                }
                            }
                        }
                        Console.WriteLine(" | Vector edad ordenado de menor a mayor");
                        for (j = 0; j < edad.Length ; j++)
                        {
                            Console.WriteLine(edad[j]);
                        }
                        break;
                    case 6: //6.Datos los vectores edad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45] nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"] Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje que el nombre no existe
                        Console.WriteLine(" |-------------------------------------------------|\n" +
                                          " | 6.  Buscar Nombre en Vector                     |\n" +
                                          " |-------------------------------------------------|\n");
                        Console.WriteLine(" | Digite el nombre a buscar...........");
                        cadena = Console.ReadLine();
                        j = 0;
                        for (i = 0; i < nombres.Length; i++)
                        {
                            if (nombres[i]==(cadena))
                            {
                                j=i;
                            }
                        }
                        if (j > 0)
                        {
                            Console.WriteLine(" Resultados de busqueda \n " + nombres[j] + " con edad  " + edad[j]);
                        }
                        break;
                    case 7: //7.Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres con su edad.
                        Console.WriteLine(" |-------------------------------------------------|\n" +
                                          " | 7.  Buscar el numero mayor y menor en Vector    |\n" +
                                          " |-------------------------------------------------|\n");
                        mayor = 0;
                        menor = 0;
                        for (j = 0; j < edad.Length; j++)
                        {
                            if(edad[j]<edad[menor])
                            {
                                menor = j;
                            }
                            if (edad[j] > edad[mayor])
                            {
                                mayor = j;
                            }
                        }
                        Console.WriteLine(" La persona menor es. " + nombres[menor] + " con la edad: " + edad[menor] );
                        Console.WriteLine(" La persona mayor es. " + nombres[mayor] + " con la edad: " + edad[mayor]);
                        break;
                    case 8:  //8.Dado una palabra definir si es palíndromo o no.
                        Console.WriteLine(" |-------------------------------------------------|\n" +
                                          " | 8.  Palabra palíndromo                          |\n" +
                                          " |-------------------------------------------------|\n");
                        Console.WriteLine(" | Digite el palabra...........");
                        cadena = Console.ReadLine();
                        string palindromo = "";
                        foreach(char letra in cadena){
                            palindromo= letra + palindromo;
                        }
                        if(cadena== palindromo)
                        {
                            Console.WriteLine(" La palabra " + palindromo + " SI es una palabra palindromo");
                        }
                        else
                        {
                            Console.WriteLine(" La palabra " + palindromo + " NO es una palabra palindromo");
                        }
                        break;
                    case 9:
                        
                        break;
               
                }
            }
            Console.ReadKey();    
            
            
            
           
           
        }
    }
}
