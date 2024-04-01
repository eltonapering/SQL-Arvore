using ArvoreBinariaRaizMaxima.ArvoreBinaria;
using ArvoreBinariaRaizMaxima.Raiz;

public class Programa
{
    public static void ProcessaCenario(int[] entrada)
    {

        int valorMaximo = entrada.Max();
        int[] valoresEsquerda = entrada.TakeWhile(valor => valor != valorMaximo).ToArray();
        int[] valoresDireita = entrada.SkipWhile(valor => valor != valorMaximo).Skip(1).ToArray();


        IRaiz raiz = new Raiz(valorMaximo);
        ArvoreBinaria arvore = new ArvoreBinaria(raiz);
        arvore.ConstroiArvore(valoresEsquerda, valoresDireita);

        Console.WriteLine("Raiz: " + arvore.Raiz.Valor);
        Console.WriteLine("Galhos da Esquerda: " + string.Join(", ", valoresEsquerda.OrderByDescending(v => v)));
        Console.WriteLine("Galhos da Direita: " + string.Join(", ", valoresDireita.OrderByDescending(v => v)));
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] cenario1 = { 3, 2, 1, 6, 0, 5 };
        int[] cenario2 = { 7, 5, 13, 9, 1, 6, 4 };

        Console.WriteLine("Cenário 1");
        ProcessaCenario(cenario1);

        Console.WriteLine("Cenário 2");
        ProcessaCenario(cenario2);
    }
}