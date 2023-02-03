namespace DesafioClassesDeOperacoes.OperacoesBasicas
{
    public class Divisao
    {
        public double Dividir(double x, double y) 
        {
            if (y == 0) 
            {
                return 0;
            }
            return (x / y);
        }
    }
}
