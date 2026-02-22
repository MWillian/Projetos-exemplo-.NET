namespace projeto_exemplo.codigo_base;

public class ClasseComValores
{
    public string Modelo { get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }

    public ClasseComValores(string modelo)
    {
        Modelo = modelo;
    }
    public void NomeModelo() => Console.WriteLine(Modelo);
}

