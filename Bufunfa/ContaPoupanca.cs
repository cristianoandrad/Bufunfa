using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa
{
    class ContaPoupanca : Contas
    {
        private decimal juros = 0.25m; // Informar percentual de juros
        public ContaPoupanca(int nrConta, Pessoa responsavel) : base(nrConta, responsavel)
        {

        }
        public override void saque(decimal valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo = this.saldo - valor;
                Console.WriteLine($"Saque efetuado com sucesso no valor de R$ {valor}, seu saldo atual é R$ {this.saldo}.");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para saque no valor de R$ {valor}, seu saldo atual é R$ {this.saldo}.");
            }
        }

        public void rendimentos()
        {
            decimal rendimentos = (this.saldo * this.juros) / 100;
            this.saldo = this.saldo + rendimentos;
            Console.WriteLine($"Rendimento no valor de R$ {rendimentos} realizado com sucesso, seu saldo atual é R$ {this.saldo}.");
        }
    }
}
