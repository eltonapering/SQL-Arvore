namespace ArvoreBinariaRaizMaxima.Raiz;

public interface IRaiz
{
    int Valor { get; set; }
    IRaiz Esquerda { get; set; }
    IRaiz Direita { get; set; }

    void InsereEsquerda(int valor);
    void InsereDireita(int valor);
}