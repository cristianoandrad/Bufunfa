using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bufunfa
{
    class Pessoa
    {
        private long cpfCnjp { get; set; }
        private string nome { get; set; }

        public Pessoa(long cpfCnjp, string nome)
        {
            this.cpfCnjp = cpfCnjp;
            this.nome = nome;
        }

        public long getCpfCnpj()
        {
            return this.cpfCnjp;

        }

        public void setCpfCnpj(long cpfCnpj)
        {
            this.cpfCnjp = cpfCnjp;

        }

        public string getNome()
        {
            return this.nome;

        }

        public void setNome(string nome)
        {
            this.nome = nome;

        }

        public void info()
        {
            Console.WriteLine($"Nome: {this.nome}, CFP/CNPJ: {this.cpfCnjp}");
        }


    }
}
