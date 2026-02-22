namespace projeto_exemplo.codigo_base;

public class ClasseNula
{
    public void ExibirClasseNula()
    {
        int? idade = null;

        bool temIdade = idade.HasValue;
        Console.WriteLine(temIdade);
    }
}
