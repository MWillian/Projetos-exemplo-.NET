namespace projeto_exemplo.codigo_base;

public interface IVeiculo
{
    void ligar();
    void desligar();
    void info();
}
public interface ICombate
{
    void disparar();
}
class Carro: IVeiculo,ICombate {
    public bool ligado;
    private int municao = 0;
    public Carro()
    {

    }
    public void SetMunicao(int qtd)
    {
        this.municao = qtd;
    }
    public void desligar()
    {
        this.ligado = false;
    }

    public void disparar()
    {
        this.municao -= 1; 
    }

    public void info()
    {
        throw new NotImplementedException();
    }

    public void ligar() {
        this.ligado = true;
    }
}

public class Interfaces
{

}
