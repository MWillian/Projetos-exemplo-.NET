namespace projeto_exemplo.codigo_base;

public class Switch
{
    public void ExibirSwitch()
    {
        var escolha = "1";
        switch (escolha)
        {
            case "1":
                Console.WriteLine("A opção escolhida foi 1");
                break;
            case "2":
                Console.WriteLine("A opção escolhida foi 1");
                break;
        }

        string resultado = escolha switch
        {
            "1" => "a escolha foi 1",
            "2" => "a escolha foi 2",
            _ => "a escolha não foi nem 1 e nem 2"
        };
    }
}
