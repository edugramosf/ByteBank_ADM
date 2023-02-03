using DesafioClassesDeOperacoes.OperacoesBasicas;

namespace DesafioClassesDeOperacoes
{
    public class Operacoes
    {
        public Soma Soma { get; private set; }

        public Subtracao Subtracao { get; private set; }

        public Multiplicacao Multiplicacao { get; private set; }

        public Divisao Divisao { get; set; }

        public Operacoes()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multiplicacao= new Multiplicacao();
            this.Divisao= new Divisao();
        }
    }
}
