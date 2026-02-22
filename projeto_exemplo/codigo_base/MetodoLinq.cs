using Dumpify;
using Spectre.Console;
using System.Linq;

namespace projeto_exemplo.codigo_base;

public class MetodoLinq
{
    record Pessoa(string nome, int idade);

    IEnumerable<Pessoa> pessoas = [
        new("Fernanda",25),
        new("Lucas",19),
        new("Lucas",19),
        new("Carlos",30),
        new("Eduarda",25),
        new("Eduarda",25),
        new("Eduarda",25),
        ];
    IEnumerable<int> lista1 = [1,2,3,4];
    IEnumerable<int> lista2 = [5,6,7,8];

    public void MetodosImportantes()
    {
        var frutas = new List<string>()
        {
            "Maça",
            "Cereja",
            "Abacate",
            "Banana",
            "Uva",
            "Mirtilo",
            "Coco",
            "Coco"
        };

        Console.WriteLine(frutas.First()); // exibe o primeiro item
        Console.WriteLine(frutas.FirstOrDefault("Sem frutas")); // primeiro, se não achar, default
        Console.WriteLine(frutas.Any(x => x == "Cereja")); //verifica se existe
        Console.WriteLine(frutas.All(x => x == "Uva"));//verifica se todos os elementos são Uva

        Console.WriteLine();

        Console.WriteLine(frutas.Count);////conta quantos itens tem
        Console.WriteLine(frutas.Count(x => x == "Banana"));////conta quantos itens são Banana
        Console.WriteLine(frutas.ElementAt(4));//retorna o elemento no indice 4
        Console.WriteLine(frutas.ElementAtOrDefault(4));//retorna o elemento no indice 4

        Console.WriteLine();

        foreach (var fruta in frutas.Take(3)) // exibe os 3 primeiros elementos
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine();

        foreach (var fruta in frutas.Take(4..6)) // usando range
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine();

        foreach (var item in frutas.Where(x => x == "Uva" || x == "Cereja"))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        //Console.WriteLine(frutas.Single()); //captura somente 1 elemento
        Console.WriteLine(frutas.Single(x => x == "Cereja"));

        Console.WriteLine();

        Console.WriteLine(frutas.Last());//captura o ultimo item

        Console.WriteLine();

        foreach (var item in frutas.Skip(2)) //pula os 2 primeiros itens
        {
            Console.WriteLine(item);
        }
        frutas.Append("opa");
        frutas.Append("opaopa");

        Console.WriteLine();

        frutas.Distinct().Dump();
        pessoas.DistinctBy(x => x.idade).Dump();

        Console.WriteLine();

        pessoas.MaxBy(x => x.idade).Dump();//traz os maiores campos de acordo com uma funcao, dentro de um objeto.
        pessoas.MinBy(x => x.idade).Dump();//traz os menores campos de acordo com uma funcao, dentro de um objeto.
        lista1.Concat(lista2).Dump();

        Console.WriteLine();

        pessoas.GroupBy(x => x.idade).OrderBy(x => x.Key).Dump();
    }


}
