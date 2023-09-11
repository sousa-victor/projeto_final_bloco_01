namespace projeto_final_bloco_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = 5;

            int idAnuncio, ano, numLugares;
            string marca, modelo, categoria;
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
                Console.WriteLine("*                   5 - Sair                                   *");
                Console.WriteLine("*                                                              *");
                Console.WriteLine("****************************************************************");
                Console.ResetColor();

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você selecionou: Cadastro de novo veículo!");
                        Console.WriteLine("Por favor informe os seguintes dados:");

                        Console.Write("ID do anúncio: ");
                        idAnuncio = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Marca: ");
                        marca = Console.ReadLine();
                        Console.Write("Modelo: ");
                        modelo = Console.ReadLine();
                        Console.Write("Ano: ");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Categoria: (SUV/Hatch/Sedan/Esportivo) ");
                        categoria = Console.ReadLine();
                        Console.Write("Número de lugares: ");
                        numLugares = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Informe o ID do anúncio");
                        break;

                    case 3:
                        Console.WriteLine("Editar anúncio");
                        break;

                    case 4:
                        Console.WriteLine("Excluir anúncio");
                        break;

                    case 5:
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