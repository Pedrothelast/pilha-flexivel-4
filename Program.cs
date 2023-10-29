using System;

class Program
{
    static void Main(string[] args)
    {
        Fila<int> F1 = new Fila<int>(new int[] { 1, 2, 3 });
        Fila<int> F2 = new Fila<int>(new int[] { 4, 5, 6 });

        ConcatenarFilas(F1, F2);

        Console.WriteLine("Elementos da fila F1 ap�s a concatena��o:");
        foreach (int elemento in F1)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Elementos da fila F2 ap�s a concatena��o:");
        foreach (int elemento in F2)
        {
            Console.Write(elemento + " ");
        }
    }