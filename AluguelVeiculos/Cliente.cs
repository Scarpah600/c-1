using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Cliente
    {
        public String Nome { get; set; }

        public Cliente()
        {
            this.Nome = "";
        }
        public Cliente(String nome)
        {
            this.Nome = nome;
        }

        public void ImprimeDados()
        {
            System.Console.WriteLine("Nome do Cliente : {0}", Nome);
        }
    }
}
