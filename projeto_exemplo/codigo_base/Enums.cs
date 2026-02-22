namespace projeto_exemplo.codigo_base;

public class Enums
{
    enum NivelDeDificuldade
    {
        Baixo,
        Médio,
        Alto = 10000
    }
    public void ExibirNivelDeDificuldade()
    {
        NivelDeDificuldade nivel1 = NivelDeDificuldade.Baixo;
        int numeroDificuldadeBaixa = (int)nivel1;
        Console.WriteLine(numeroDificuldadeBaixa);

        NivelDeDificuldade nivel2 = NivelDeDificuldade.Médio;
        int numeroDificuldadeMedia = (int)nivel2;
        Console.WriteLine(numeroDificuldadeMedia);

        NivelDeDificuldade nivel3 = NivelDeDificuldade.Alto;
        int numeroDificuldadeAlta = (int)nivel3;
        Console.WriteLine(numeroDificuldadeAlta);
    }
}
