using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa
{
    class ContaCorrente : Contas
    {
        private decimal cpmf = 0.38m;
        public ContaCorrente(int nrConta, Pessoa responsavel) : base(nrConta, responsavel)
        {

        }

        public override void saque(decimal valor)
        {
            if (this.saldo >= valor)
            {
                decimal tarifa = this.saldo * this.cpmf;
                this.saldo = this.saldo - valor - tarifa;
                Console.WriteLine($"Saque efetuado com sucesso no valor de R$ {valor}, seu saldo atual é R$ {this.saldo}.");
                Console.WriteLine($"Foi cobrado a tarifa no valor de R$ {tarifa} refente ao saque.");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para saque no valor de R$ {valor},  seu saldo atual é R$ {this.saldo}.");
            }
        }
    }
}
