namespace projeto_exemplo.codigo_base;

public class Fatorial
{
    public int Fat(int n)
    {
        int res;
        if (n <= 1)
        {
            res = 1;
        }
        else
        {
            res = n*Fat(n - 1);
        }
        return res;
    }
}
