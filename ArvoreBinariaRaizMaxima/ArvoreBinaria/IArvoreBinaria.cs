using ArvoreBinariaRaizMaxima.Raiz;

namespace ArvoreBinariaRaizMaxima.ArvoreBinaria;

public interface IArvoreBinaria
{
    IRaiz Raiz { get; }
    void ConstroiArvore(int[] valoresEsquerda, int[] valoresDireita);
}