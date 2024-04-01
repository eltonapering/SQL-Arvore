namespace ArvoreBinariaRaizMaxima.Raiz;

public class Raiz : IRaiz
{
    public int Valor { get; set; }
    public IRaiz? Esquerda { get; set; }
    public IRaiz? Direita { get; set; }

    public Raiz(int valor)
    {
        Valor = valor;
    }

    public void InsereEsquerda(int valor)
    {
        Raiz atual = this;
        while (atual.Esquerda != null)
        {
            atual = (Raiz)atual.Esquerda;
        }
        atual.Esquerda = new Raiz(valor);
    }

    public void InsereDireita(int valor)
    {
        Raiz atual = this;
        while (atual.Direita != null)
        {
            atual = (Raiz)atual.Direita;
        }
        atual.Direita = new Raiz(valor);
    }
}