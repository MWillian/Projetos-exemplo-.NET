namespace projeto_exemplo.codigo_base;

public class Indexadores
{
    private int[] VelocidadeMaxima = new int[5] { 80, 120, 160, 240, 300 };

    public int this[int i]{
        get
        {
            return VelocidadeMaxima[i];
        }
        set
        {
            VelocidadeMaxima[i] = this.VelocidadeMaxima[i];
        }
    }

}
