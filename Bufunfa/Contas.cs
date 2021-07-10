using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa
{
    abstract class Contas
    {
        private int nrConta { get; set; }
        private Pessoa responsavel { get; set; }
        protected decimal saldo { get; set; }

                

        public Contas(int nrConta, Pessoa responsavel)
        {
            this.nrConta = nrConta;
            this.responsavel = responsavel;
            this.saldo = 0;
        }

        public decimal getNrConta()
        {
            return this.nrConta;
        }

        public Pessoa getPessoa()
        {
            return this.responsavel;

        }
       
        public decimal getSaldo()
        {
            return this.saldo;
        }
                

        public void info()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Dados da conta \nNumero da Conta {this.nrConta} " +
                $"\nResponsável {this.responsavel.getNome()} CPF/CNPJ {this.responsavel.getCpfCnpj()}" +
                $" \nSaldo Atual R$ {this.saldo}  ");
            Console.WriteLine("--------------------------------------");

        }

        public void depositar(decimal valor)
        {
            this.saldo = this.saldo + valor;
            Console.WriteLine($"Deposito no valor de R$ {valor} realizado com sucesso, seu saldo atual é R$ {this.saldo}.");

        }

        public abstract void saque(decimal valor);
    }
}
