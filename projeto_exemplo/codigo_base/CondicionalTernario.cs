namespace projeto_exemplo.codigo_base;

public class CondicionalTernario
{
    public string ExibirTernario()
    {
        int n1 = 3;
        int n2 = 2;

        var resultado = (n1 + n2) % 2 == 0 ? "par" : "impar";
        return resultado;
    }

}
