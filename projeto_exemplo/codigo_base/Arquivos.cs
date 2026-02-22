namespace projeto_exemplo.codigo_base;
using System.IO;
using System.Runtime.CompilerServices;

public class Arquivos
{
    private string CaminhoArquivo { get; set; } = string.Empty;
    public void CriarArquivo()
    {
        File.WriteAllText("arquivo.txt", "Hello World!");
        Console.WriteLine("Arquivo criado com sucesso.");
    }

    public string CriarArquivoEmLocalEspecifico()
    {
        string path = @"D:\teste\";
        string fileName = "Arquivoteste.txt";
        string filepath = path + fileName;
        string content = "Opa, teste";

        string additionalContent = "Conteudo adicional";
        File.AppendAllText(filepath, additionalContent);
        File.WriteAllText(filepath, content);
        return filepath;
    }
    
    public void LerArquivo()
    {
        string path = @"D:\teste\";
        string fileName = "Arquivoteste.txt";
        string filepath = path + fileName;
        string fileContent = File.ReadAllText(filepath);
        Console.WriteLine(fileContent);
    }

}
