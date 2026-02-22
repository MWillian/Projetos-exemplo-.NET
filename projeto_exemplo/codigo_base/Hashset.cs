namespace projeto_exemplo.codigo_base;

public class Hashset
{
    public void ExibirHashset()
    {
        HashSet<int> set = new();
        set.Add(1);
        set.Add(1);
        set.Add(1);
        Console.WriteLine(set.Count);
    }
}
