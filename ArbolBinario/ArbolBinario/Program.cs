using System;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número base");
            int numBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un limite de numeros");
            int numLim = int.Parse(Console.ReadLine());
            int[] ArbolBinario = new int[numLim];
            int[] izquierda = new int[numLim];
            int[] derecha = new int[numLim];
        
            for(int i = 0; i < ArbolBinario.Length; i++)
            {
                Console.WriteLine("ingrese un numero");
                ArbolBinario[i] = int.Parse(Console.ReadLine());
                if(ArbolBinario[i] < numBase)
                {
                    for (int j = 0; j < izquierda.Length; j++)
                    {
                        izquierda[j] = ArbolBinario[i];
                    }
                    Console.WriteLine("izquierda");
                    Console.WriteLine(izquierda[i]);
                    numBase = ArbolBinario[i];
                }
                    
                else if(ArbolBinario[i] > numBase)
                {
                    for(int k = 0; k < derecha.Length; k++)
                    {
                        derecha[k] = ArbolBinario[i];                                              
                    }
                    Console.WriteLine("derecha");
                    Console.WriteLine(derecha[i]);
                    numBase = ArbolBinario[i];
                }
            }
        }      
    }
}

