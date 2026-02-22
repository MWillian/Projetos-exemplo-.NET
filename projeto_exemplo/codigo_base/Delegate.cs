namespace projeto_exemplo.codigo_base;

public class Delegate
{
    delegate int Op(int n1, int n2);
    public static int Soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtracao(int n1, int n2)
    {
        return n1 - n2;
    }

    public void ExibirDados()
    {
        int res;
        Op d1 = new Op(Delegate.Soma);
        res = d1(10, 50);
        Console.WriteLine($"Soma: {res}");
        d1 = new Op(Delegate.Subtracao);
        Console.WriteLine($"Subtração: {res}");
    }
}
