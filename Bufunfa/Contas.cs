using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa
{
    abstract class Contas
    {
        public int nrAgencia { get; set; }
        private int nrConta { get; set; }
        private Pessoa responsavel { get; set; }
        protected decimal saldo { get; set; }
        private bool aberta { get; set; }

                

        public Contas(int nrAgencia, int nrConta, Pessoa responsavel)
        {
            this.nrAgencia = nrAgencia;
            this.nrConta = nrConta;
            this.responsavel = responsavel;
            this.aberta = true;
            this.saldo = 0;
        }

        public int getNrAgencia()
        {
            return this.nrAgencia;
        }

        public int getNrConta()
        {
            return this.nrConta;
        }

        public Pessoa getPessoa()
        {
            return this.responsavel;

        }

        public bool getAberta()
        {
            return this.aberta;
        }


        public decimal getSaldo()
        {
            return this.saldo;
        }
                

        public void extratoResumido()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"Dados da conta: " +
                $"\nAgencia: {this.nrAgencia}" + 
                $"\nNumero da Conta: {this.nrConta} " +
                $"\nResponsável: {this.responsavel.getNome()}, CPF/CNPJ: {this.responsavel.getCpfCnpj()}" +
                $"\nSaldo Atual: R$ {this.saldo}  ");
            Console.WriteLine("-------------------------------------------------------------------------------");

        }

        public void depositar(decimal valor)
        {
            if (this.aberta == true)
            {
                this.saldo = this.saldo + valor;
                Console.WriteLine($"Deposito no valor de R$ {valor} realizado com sucesso, seu saldo atual é R$ {this.saldo}.");
            }
            else
            {
                Console.WriteLine("Deposito não realizado, conta encerrada.");
            }

        }

        public void fecharConta()
        {
            if (saldo == 0m)
            {
                this.aberta = false;
                Console.WriteLine("Conta fechada com sucesso.");
            }
            else
            {
                Console.WriteLine($"Operação de fechamento de conta não realizado, " +
                    $"conta com saldo de R$ {this.saldo}");
            }

        }

        public void transferencia(decimal valor, Contas conta)
        {
            if(this.saldo >= valor)
            {
                this.saldo = this.saldo - valor;
                Console.WriteLine("-------------Comprovante de Transferencia-------------");
                Console.WriteLine($"Transferencia efetuada com sucesso no valor de R$ {valor}, " +
                    $"\nConta Origem nº: {this.nrConta} \nConta destino nº: {conta.nrConta} " + 
                    $"\nSaldo da conta nº {this.nrConta} é R$ {this.saldo}");
                Console.WriteLine("------------------------------------------------------");

            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para transfência no valor de R$ {valor}, seu saldo atual é R$ {this.saldo}.");
            }
        }

        public abstract void saque(decimal valor);
    }
}
