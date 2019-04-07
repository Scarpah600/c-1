using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Opcao
    {
        public void opcao()
        {
            Onibus on = new Onibus();
            Carro carro = new Carro("Corsa", "ABC-2020", 2008, 4, "PRETO", "100");

       
            //  System.Console.WriteLine("1 - CADASTRAR CLIENTE ");

            int opcao = 0;

            do
            {
                Cliente client = new Cliente();

                System.Console.WriteLine("Digite o seu nome: ");
                string nome = System.Console.ReadLine();
                client.Nome = nome;
                int aluguel;
                System.Console.WriteLine("--- Escolha um veículo para alugar !! ---");
                aluguel = int.Parse(Console.ReadLine());


                switch (aluguel)
                {
                    case 1:
                        System.Console.WriteLine("-- Carros disponiveis para alugar --");
                        carro.ImprimeDados();
                        break;

                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }


            } while (opcao != 0);





        }
    }
}
