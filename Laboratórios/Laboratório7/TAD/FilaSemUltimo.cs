using System;

// Parte 5 - fila SEM o ponteiro ultimo: cada inserção percorre a lista inteira

public class FilaSemUltimo
{
    private Celula primeiro = new Celula();
    public long passos = 0;   // quantas células o inserir visitou

    public void inserir(int x)
    {
        Celula i = primeiro;
        while (i.prox != null)
        {
            i = i.prox;
            passos++;
        }
        i.prox = new Celula(x);
    }
}
