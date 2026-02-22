namespace projeto_exemplo.codigo_base;

public class Galinha
{
    private int QuantidadeOvos { get; set; }
    private string Nome { get; set; }
    public Galinha(string nome)
    {
        Nome = nome;
        QuantidadeOvos = 0;
    }

    public Ovo BotarOvo()
    {
        QuantidadeOvos++;
        return new Ovo(QuantidadeOvos, Nome);
    }

    public class Ovo
    {
        private int numOvo;
        private string nomeGalinha = string.Empty;
        public Ovo(int qtd, string nomeGalinha)
        {
            numOvo = qtd;
            Console.WriteLine("Ovo criado.");
            this.nomeGalinha = nomeGalinha;
        }
    }
}

