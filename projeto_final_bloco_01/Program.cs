using projeto_final_bloco_01.Controller;
using projeto_final_bloco_01.Model;

namespace projeto_final_bloco_01
    
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = 6;

            int idAnuncio, ano, numLugares;
            string marca, modelo, categoria, entrada;
            bool exotico;

            AnuncioController anuncio = new();



            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                                                              *");
                Console.WriteLine("*                     BEM-VINDO A VS CARS!                     *");
                Console.WriteLine("*                                                              *");
                Console.WriteLine("****************************************************************");
                Console.WriteLine("*                    Informe a opção desejada:                 *");
                Console.WriteLine("*                                                              *");
                Console.WriteLine("*                   1 - Cadastrar novos carros                 *");
                Console.WriteLine("*                   2 - Consultar carros cadastrados           *");
                Console.WriteLine("*                   3 - Editar informações                     *");
                Console.WriteLine("*                   4 - Excluír carros do banco de dados.      *");
                Console.WriteLine("*                   5 - Pesquisar por ID do anúncio            *");
                Console.WriteLine("*                   6 - Sair                                   *");
                Console.WriteLine("*                                                              *");
                Console.WriteLine("****************************************************************");
                Console.ResetColor();

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException){
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Digite valores inteiros!");
                    Console.ResetColor();
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você selecionou: Cadastro de novo veículo!");
                        Console.WriteLine("Por favor informe os seguintes dados:");

                        Console.Write("Marca: ");
                        marca = Console.ReadLine();
                        Console.Write("Modelo: ");
                        modelo = Console.ReadLine();
                        Console.Write("Ano: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Categoria: (SUV/Hatch/Sedan/Esportivo)\n");
                        categoria = Console.ReadLine();
                        Console.Write("Número de lugares: ");
                        numLugares = Convert.ToInt32(Console.ReadLine());
                        Console.Write("É um carro exótico? S/N");
                        entrada = Console.ReadLine();
                        entrada.ToUpper();
                        if (entrada == "S")
                        {
                            exotico = true;
                        }
                        else
                        {
                            exotico = false;
                        }

                        anuncio.AddAnuncio(new Estendida(anuncio.GerarNumero(), ano, numLugares, marca, modelo, categoria, exotico));
                        break;

                    case 2:
                        Console.WriteLine("Carros cadastrados: ");
                        anuncio.ListarTudo();
                        break;

                    case 3:
                        Console.WriteLine("Editar anúncio");
                        break;

                    case 4:
                        Console.WriteLine("Digite o ID do anúncio");
                        idAnuncio = Convert.ToInt32(Console.ReadLine());
                        anuncio.Deletar(idAnuncio);
                        break;

                    case 5:
                        Console.WriteLine("Digite o ID");
                        idAnuncio = Convert.ToInt32(Console.ReadLine());
                        anuncio.ProcuraId(idAnuncio);
                        break;

                    case 6:
                        Console.WriteLine("Programa encerrado");
                        break;

                    default:
                        Console.WriteLine("Informe um número válido de 1 a 5");
                        break;
                }
            }
            while (opcao != 5);





        }
    }
}