
using System;

public class Pilha
{
    private char[] elementos;
    private int topo;

    public Pilha(int tamanho)
    {
        elementos = new char[tamanho];
        topo = 0;
    }

    public void empilha(char caractere)
    {
        elementos[topo] = caractere;
        topo++;
    }

    public char desempilha()
    {
        topo--;
        return elementos[topo];
    }

    public bool estaVazia()
    {
        return topo == 0;
    }
}

public class Program
{
    public static string inverte(string s)
    {
        Pilha p = new Pilha(s.Length);

        for (int i = 0; i < s.Length; i++)
        {
            p.empilha(s[i]);
        }

        string textoInvertido = "";

        while (!p.estaVazia())
        {
            textoInvertido += p.desempilha();
        }

        return textoInvertido;
    }

    static void Main(string[] args)
    {
        string original = "PUCMINAS";
        string resultado = inverte(original);

        Console.WriteLine(resultado);
    }
}
