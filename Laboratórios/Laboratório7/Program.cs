public class Program
{
    static void Tentar(Action a)
    {
        try { a(); } catch (Exception e) { Console.WriteLine(e.Message); }
    }

    public static void Main(string[] args)
    {
        // ---- Parte 1 ----
        Fila f = new Fila();
        Console.WriteLine(f.isVazia());
        f.inserir(3); f.inserir(5); f.inserir(7);
        f.mostrar();
        Console.WriteLine(f.remover());
        f.mostrar();
        Console.WriteLine(f.tamanho());
        f.inserir(10);
        f.mostrar();
        f.remover(); f.remover(); f.remover();
        Console.WriteLine(f.isVazia());
        Tentar(() => f.remover());
        f.inserir(1);
        f.mostrar();

        // ---- Parte 3 ----
        Fila g = new Fila();
        foreach (int x in new[] { 5, 10, 15, 20, 25 }) g.inserir(x);
        Console.WriteLine(g.pesquisar(15));
        Console.WriteLine(g.pesquisar(7));
        Console.WriteLine(g.maior());
        Console.WriteLine(g.somar());
        g.inverter();
        g.mostrar();
        g.inserir(1);
        g.mostrar();

        // ---- Desafio (descomente ao chegar aqui) ----
        // Console.WriteLine(g.removerUltimo());
        // Console.WriteLine(g.removerUltimo());
        // g.mostrar();

        // ---- Parte 5 ----
        foreach (int n in new[] { 1000, 2000 })
        {
            FilaSemUltimo s = new FilaSemUltimo();
            for (int k = 0; k < n; k++) s.inserir(k);
            Console.WriteLine($"n = {n}: passos = {s.passos}");
        }
    }
}