namespace projeto_exemplo.codigo_base;

public class Dicionario
{
    public void ExibirClasseDicionario()
    {
        Dictionary<int, string> dicionarioTeste = new();
        dicionarioTeste.Add(1, "Matheus");
        dicionarioTeste.Add(2, "Willian");
        string valorChaveDois = dicionarioTeste[1];
        Console.WriteLine(valorChaveDois);

        bool existeChaveUm = dicionarioTeste.ContainsKey(1);
        bool existeValorMatheus = dicionarioTeste.ContainsValue("Matheus");
        Console.WriteLine(existeChaveUm);
        Console.WriteLine(existeValorMatheus);
    }
}
