using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioAula09_Casa
{
    internal class Program
    {
        public static List<string> vagas = new List<string> { "______", "______", "______", "______", "______" };


        static void Main(string[] args)
        {
            Console.WriteLine("----------- Estacionamento -----------");
            Console.WriteLine("Opções:");
            Console.WriteLine("1. Estacionar");
            Console.WriteLine("2. Retirar veículo");
            Console.WriteLine("3. Listar veiculos");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 1 && opcao != 2 && opcao != 3)
            {
                Console.WriteLine("Digite uma opção válida!");
                opcao = int.Parse(Console.ReadLine());
            }

            if (opcao == 1)
            {
                for (int i = 0; i < vagas.Count; i++)
                {
                    if (vagas[i] == "______")
                    {
                        Console.WriteLine("Digite a placa do seu veículo (exemplo: xxx600)");
                        string novoCarro = Console.ReadLine();


                        int contaPlaca = novoCarro.Count();

                        if (contaPlaca == 6)
                        {
                            vagas[i] = novoCarro.ToUpper();
                            Console.WriteLine($"O veículo de placa {vagas[i]} foi adicionado a vaga de {i}!");
                            Console.ReadKey();
                            Console.Clear();
                            Main(null);
                            return;
                        }
                        Console.WriteLine("Digite uma placa válida !!");
                        Console.ReadKey();
                        Console.Clear();
                        Main(null);
                        return;

                    }
                }
                Console.WriteLine("Não há vagas disponíveis!");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            if (opcao == 2)
            {
                Console.WriteLine("Qual a placa do seu veículo (exemplo: xxx600)");
                string retirada = Console.ReadLine();

                for (int i = 0; i < vagas.Count; i++)
                {
                    if (vagas[i] == retirada.ToUpper())
                    {
                        Console.WriteLine("O seu veículo foi retirado com sucesso! ");
                        vagas[i] = "______";
                        Console.ReadKey();
                        Console.Clear();
                        Main(null);
                        return;
                    }


                }
                Console.WriteLine("Não existe nenhum carro com essa placa aqui irmão!");

            }
            if (opcao == 3)
            {
                string texto = "";
                for (int i = 0; i < vagas.Count; i++)
                {
                    string placa = vagas[i];
                    string nome_tratado = $" [{placa}] ";

                    texto += nome_tratado;
                }
                Console.WriteLine($"{texto}");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            Console.ReadKey();
        }
    }
}
