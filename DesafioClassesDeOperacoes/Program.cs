using DesafioClassesDeOperacoes;

Console.WriteLine("Olá, seja bem vindo à Calculatronic!");
Operacoes operacoes = new Operacoes();
Console.WriteLine("O valor é: " + operacoes.Soma.Somar (10, 10));
Console.WriteLine("O valor é: " + operacoes.Subtracao.Subtrair(30, 15));
Console.WriteLine("O valor é: " + operacoes.Divisao.Dividir(657, 98));
Console.WriteLine("O valor é: " + operacoes.Multiplicacao.Multiplicar(9, 48));

Console.ReadKey();