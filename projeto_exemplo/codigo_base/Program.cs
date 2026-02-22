namespace projeto_exemplo.codigo_base;
using Dumpify;
class Program
{
    //Delegates
    //public class Produto
    //{
    //    public string Nome { get; set; } = string.Empty;
    //    public decimal Preco { get; set; }
    //    public string Categoria { get; set; } = string.Empty;

    //}
    //static List<Produto> Filtrar(List<Produto> lista, Predicate<Produto> condicao)
    //{
    //    var resultado = new List<Produto>();
    //    foreach (var item in lista)
    //    {
    //        if (condicao(item) is true)
    //        {
    //            resultado.Add(item);
    //        }
    //    }
    //    return resultado;
    //}

    //static void CalcularPrecoFinal(List<Produto> lista, Func<decimal, decimal> regraCalculo)"
    //{
    //    foreach (var item in lista)
    //    {
    //        decimal precoFinal = regraCalculo(item.Preco);
    //        Console.WriteLine($"O produto {item.Nome}, ficou com o preço de {precoFinal}.");
    //    }
    //}

    //static void GerarRelatorio(List<Produto> lista, Action<Produto> acao)
    //{
    //    foreach (var item in lista)
    //    {
    //        acao(item);
    //    }
    //}

    //static void Main(string[] args)
    //{
    //Datas datas = new();
    //datas.AplicacaoDatas();

    //Enums enumeradores = new();
    //enumeradores.ExibirNivelDeDificuldade();

    //ClasseNula classeNula = new();
    //classeNula.ExibirClasseNula();

    //UsoDeMetodos metodo = new();
    //Console.WriteLine(metodo.Adicionar(n2: 1, n1: 2));
    //Console.WriteLine(metodo.Adicionar2(3,7));

    //ClasseComValores carro = new("Supra");
    //carro.Modelo = "Supra";
    //carro.LancadoEm = new DateOnly(2021, 1, 1);
    //carro.NomeModelo();

    //ClasseComValores carro2 = new("Uno")
    //{
    //    LancadoEm = new DateOnly(2021, 1, 2),
    //    Cor = Cor.Vermelho
    //};
    //carro2.NomeModelo();

    //Arquivos arquivo = new Arquivos();
    //arquivo.CriarArquivo();
    //arquivo.CriarArquivoEmLocalEspecifico();
    //arquivo.LerArquivo();

    //Galinha galinha1 = new("Francisca");
    //galinha1.BotarOvo();


    //Delegates
    //List<Produto> estoque = new List<Produto>
    //{
    //     new Produto { Nome = "Laptop Gamer", Preco = 5000, Categoria = "Eletronicos" },
    //     new Produto { Nome = "Mouse Sem Fio", Preco = 150, Categoria = "Acessorios" },
    //     new Produto { Nome = "Monitor 4K", Preco = 2500, Categoria = "Eletronicos" },
    //     new Produto { Nome = "Teclado Mecanico", Preco = 450, Categoria = "Acessorios" }
    //};

    //Console.WriteLine("Filtrando apenas eletrônicos.");
    //var eletronicos = Filtrar(estoque, x => x.Categoria == "Eletronicos");
    //foreach (var item in eletronicos)
    //{
    //    Console.WriteLine(item.Nome);
    //}

    //Console.WriteLine("Calcular preço final.");
    //CalcularPrecoFinal(estoque,precoOriginal => precoOriginal*0.9m);

    //Console.WriteLine("Gerando relatório.");
    //GerarRelatorio(estoque, p => Console.WriteLine($"Dados do produto {p.Nome}, {p.Preco}, {p.Categoria}."));
    //    }
    static void Main(string[] args)
    {
        MetodoLinq metodos = new();
        metodos.MetodosImportantes();
    }
}
