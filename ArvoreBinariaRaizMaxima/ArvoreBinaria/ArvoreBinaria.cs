using ArvoreBinariaRaizMaxima.Raiz;

namespace ArvoreBinariaRaizMaxima.ArvoreBinaria;

public class ArvoreBinaria : IArvoreBinaria
{
    public IRaiz Raiz { get; private set; }

    public ArvoreBinaria(IRaiz raiz)
    {
        Raiz = raiz;
    }

    public void ConstroiArvore(int[] valoresEsquerda, int[] valoresDireita)
    {
        foreach (var valor in valoresEsquerda.OrderByDescending(v => v))
        {
            Raiz.InsereEsquerda(valor);
        }

        foreach (var valor in valoresDireita.OrderByDescending(v => v))
        {
            Raiz.InsereDireita(valor);
        }
    }
}