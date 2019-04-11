using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Opcao op = new Opcao();
        

            System.Console.WriteLine("----------------Auto Acesso Locadora de Veiculos------------------------------");
            op.opcao();
            

            //Falta o Aluguel 
            //Motorista que vai Dirigir o Veiculo
            //Data da class verificar 
            //Relatorio 

            Aluguel aluga = new Aluguel();

            



            System.Console.WriteLine("----------------Auto Acesso Locadora de Veiculos Volte Sempre!------------------------------");

            System.Console.ReadKey();
        }
    }
}
