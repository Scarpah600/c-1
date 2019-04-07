using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Motorista
    {
        public String Nome {get; set;}
        public String DtNascimento {get; set;}
        public String Carteira { get; set; }

        public Motorista()
        {
            this.Nome = " ";
            this.DtNascimento = " ";
            this.Carteira = " ";
        }

        public Motorista(String nome, String dtNascimento, String carteira)
        {
            this.Nome = nome;
            this.DtNascimento = dtNascimento;
            this.Carteira = carteira;
        }
        public void imprimirDados()
        {
            System.Console.WriteLine("Nome: {0} DataNascimento: {1} Carteira{2}",Nome,DtNascimento,Carteira);
        }

    }
}
