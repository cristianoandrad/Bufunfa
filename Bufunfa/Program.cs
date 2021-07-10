using System;

namespace Bufunfa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(12345678909, "Cristiano Andrade");
            Pessoa p2 = new Pessoa(45467879778, "Igor Aguiar");

            ContaCorrente c1 = new ContaCorrente(123, p1);
            c1.info();
            c1.depositar(250);
            c1.saque(50);
            c1.saque(90);
           
            ContaPoupanca c2 = new ContaPoupanca(777, p2);
            c2.info();
            c2.depositar(300);
            c2.saque(40);
            c2.rendimentos();            

        }
    }
}
