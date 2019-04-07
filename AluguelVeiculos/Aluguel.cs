using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Aluguel
    {
        public String Data { get; set; }
        public Cliente cliente {get;set;}
        public Veiculo veiculo { get; set; }

        public Aluguel()
        {
            this.Data = "";
            
        }
        public Aluguel(String data) 
        {
            this.Data = data;

        }
        public void Imprimir()
        {
            System.Console.WriteLine("--------------ALUGUEL DE VEICULOS------");
        }
        public void ImprimeDados()
        {
            Imprimir();
            System.Console.WriteLine("Data do Aluguel: {0} Veiculo: {1} Placa: {2}",this.Data,this.veiculo.Modelo,this.veiculo.Placa);
        }
    }
}
