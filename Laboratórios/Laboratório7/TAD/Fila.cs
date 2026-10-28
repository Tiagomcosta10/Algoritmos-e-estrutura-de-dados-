using System;
using System.Collections.Generic;

// TAD Fila Flexível com células encadeadas e nó cabeça

public class Fila
{
    private Celula primeiro, ultimo;   // primeiro é o nó cabeça

    public Fila()
    {
        primeiro = new Celula();
        ultimo = primeiro;
    }

    public bool isVazia() { return primeiro == ultimo; }

    public int tamanho()
    {
        int cont = 0;
        for (Celula i = primeiro.prox; i != null; i = i.prox) cont++;
        return cont;
    }

    public void inserir(int x)
    {
        ultimo.prox = new Celula(x);
ultimo = ultimo.prox;
    }

    public int remover()
    {
     if (primeiro == ultimo)
throw new Exception("Erro!");
Celula tmp = primeiro;
primeiro = primeiro.prox;
int elemento = primeiro.elemento;
tmp.prox = null;
tmp = null;
return elemento;
    }

    public void mostrar()
    {
       Console.Write("[ ");
for (Celula i = primeiro.prox; i != null; i = i.prox)
Console.Write(i.elemento + " ");
Console.WriteLine("]");
    }

    // ---------- Parte 3 ----------
    public bool pesquisar(int x)
    {
        for (Celula i = primeiro.prox; i != null; i = i.prox)
            if (i.elemento == x) return true;
        return false;
    }

    public int maior()
    {
        if (isVazia()) throw new Exception("Erro: fila vazia");
        int m = primeiro.prox.elemento;
        for (Celula i = primeiro.prox; i != null; i = i.prox)
            if (i.elemento > m) m = i.elemento;
        return m;
    }

    public int somar()
    {
      int resp = 0;
for (Celula i = primeiro.prox; i != null; i = i.prox) {
resp += i.elemento;
}
return resp;
    }

    public void inverter()
    {
       if (primeiro == ultimo) return; // fila vazia
Celula fim = ultimo;
bool terminou = false;
while (!terminou) {
terminou = (primeiro.prox == fim); // fim é a última célula a ser movida
Celula nova = new Celula(primeiro.prox.elemento);
nova.prox = fim.prox; // copia o primeiro depois do fim
fim.prox = nova;
Celula tmp = primeiro.prox; // descarta o primeiro
primeiro.prox = tmp.prox;
tmp.prox = null;
if (ultimo == fim) ultimo = nova;
}
    }

   
}
