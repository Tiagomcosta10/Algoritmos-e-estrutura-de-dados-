using System;

// Célula da fila encadeada (AED 2026/2 - Estudo Dirigido TAD Fila Flexível)


public class Celula
{
    public int elemento;
    public Celula prox;

    public Celula() : this(0) { }

    public Celula(int elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }
}
