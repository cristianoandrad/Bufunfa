using System;

namespace Bufunfa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(12345678909, "Cristiano Andrade");
            Pessoa p2 = new Pessoa(45467879778, "Igor Aguiar");

            ContaCorrente c1 = new ContaCorrente(001,1121223, p1);
            c1.extratoResumido();
            c1.depositar(250);
            c1.saque(50);
            c1.saque(90);
            c1.fecharConta();
            
           
            ContaPoupanca c2 = new ContaPoupanca(002,712177, p2);
            c2.extratoResumido();
            c2.depositar(300);
            c2.saque(40);
            c2.rendimentos();


            c1.transferencia(100, c2);

        }
    }
}
