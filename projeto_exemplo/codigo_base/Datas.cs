namespace projeto_exemplo.codigo_base;
using System.Globalization;


public class Datas
{
    public void AplicacaoDatas()
    {
        DateOnly dia = new(2023, 12, 1);
        string diaEmTexto = dia.ToLongDateString();
        string diaEmTextoPt = dia.ToString("D", new CultureInfo("pt-BR"));
        Console.WriteLine(diaEmTextoPt);
        Console.WriteLine(diaEmTexto);

        DateTime dia1 = new(2023, 12, 1, 20, 07, 1);
        Console.WriteLine(dia1);

        DateTime hoje = DateTime.Now;
        Console.WriteLine(hoje);

        DateTime horarioGlobal = DateTime.UtcNow;
        Console.WriteLine(horarioGlobal);

        DateTime novaDataAdicionandoAnos = hoje.AddYears(10);
        Console.WriteLine(novaDataAdicionandoAnos);

        DateTime novaDataRemovendoAnos = hoje.AddYears(10);
        Console.WriteLine(novaDataRemovendoAnos);
    }

    public void ExibirDatas()
    {
        DateTime dataEHoraSimples = new();
        dataEHoraSimples = DateTime.Now; //data e hora do computador
        dataEHoraSimples = DateTime.UtcNow; //data e hora global
        string dataNascimentoInvalida = "31/02/2023";

        if (DateTime.TryParse(dataNascimentoInvalida, out DateTime dataResultado))
        {
            Console.WriteLine($"Parseou: {dataResultado.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine("Não parseou");
        }

        DateTimeOffset dataComFusoHorario = new(); //armazena data, hora, e a diferença em relação ao UTC: 10:00 no US e BR

        DateOnly somenteData = new();
        TimeOnly somenteHoraMinutoSegundo = new();

        TimeSpan tempo = new(); //armazena uma duração em tempo

    }
}
