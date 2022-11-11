//Fig. 25.3:MetodoGenerico.cs
//Uso de metodos sobrecargados para imprimir arreglos de distintos tipos
using System;
using System.Collections.Generic;

class MetodoSobrecargados
{
    static void Main(string[] args)
    {
        //crea arreglos de tipo int, double and char
        int[] arregloInt = { 1, 2, 3, 4, 5, 6 };
        double[] arregloDouble = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
        char[] arregloChar = { 'H', 'O', 'L', 'A' };

        Console.WriteLine("El arreglo arregloInt contiene:");
        ImprimirArreglo(arregloInt); //Pasa un arreglo int como argumento
        Console.WriteLine("El arreglo arregloDouble contiene:");
        ImprimirArreglo(arregloDouble); //Pasa un arreglo double como argumento
        Console.WriteLine("El arreglo arregloChar contiene:");
        ImprimirArreglo(arregloChar); //Pasa un arreglo char como argumento

    }//Fin del Main

    //Imprime en pantalla el arreglo de todos los tipos
    static void ImprimirArreglo<E>(E[] arregloEntrada)
    {

        foreach (E element in arregloEntrada)
            Console.WriteLine(element + " ");

        Console.WriteLine( "\n" );
    }//Fin del metodo ImprimirArreglo
}//Fin de la clase MetodosSobrecargados