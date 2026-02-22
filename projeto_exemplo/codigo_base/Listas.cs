namespace projeto_exemplo.codigo_base;

public class Listas
{
    public void ExibirListas()
    {
        List<int> listaInteiros = new();
        listaInteiros.Add(1);
        listaInteiros.Add(2);
        listaInteiros.Add(3);
        listaInteiros.Add(4);
        listaInteiros.Remove(1);
        Console.WriteLine(listaInteiros.Count);
        Console.WriteLine(listaInteiros.First());
        Console.WriteLine(listaInteiros.Last());
        Console.WriteLine(listaInteiros.ElementAt(1));

        List<object> listaGenerica = new();
        listaGenerica.Add(1);
        listaGenerica.Add("2");
        Console.WriteLine(listaGenerica);
        

        List<string> listaString = new();
        listaString.Add("1");
        listaString.Add("2");
        string resultado = string.Join(" ", listaString);
        Console.WriteLine(resultado);
    }
    
}
