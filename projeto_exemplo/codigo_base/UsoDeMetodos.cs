namespace projeto_exemplo.codigo_base;

public class UsoDeMetodos
{
    public int Adicionar(int n1, int n2) => n1 + n2;
    public (int, string) Adicionar2(int n1, int n2)
    {
        int resultado = n1 + n2;
        return (resultado,"matheus");
    }

    public int ExibirSoma(int n1, int n2 = 10)
    {
        return n1 + n2;
    }
}
