using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Passo 1
        List<int> lista = new List<int>();
        lista.Add(1);
        lista.Add(2);
        lista.Add(3);
        lista.Add(4);
        lista.Add(5);

        // Passo 2
        Stack<int> pilha = new Stack<int>();
        foreach (int num in lista)
        {
            pilha.Push(num);
        }
        lista.Clear();

        // Passo 3
        Queue<int> fila = new Queue<int>();
        while (pilha.Count > 0)
        {
            fila.Enqueue(pilha.Pop());
        }

        // Passo 4
        lista.Add(6);
        lista.Add(7);
        lista.Add(8);
        lista.Add(9);
        lista.Add(10);

        // Passo 5
        foreach (int num in lista)
        {
            pilha.Push(num);
        }
        lista.Clear();

        while (pilha.Count > 0)
        {
            fila.Enqueue(pilha.Pop());
        }

        // Passo 6
        foreach (int num in fila)
        {
            Console.WriteLine(num);
        }
    }
}