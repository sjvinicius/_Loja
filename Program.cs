using System;

namespace _Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOJINHO DO TADEU\n");

            //Variaveis
            int qtdp = 10;
            string [] nome = new string [qtdp];
            string [] apresent = new string [qtdp];
            string [] retorno = new string [qtdp];
            float [] preco = new float [qtdp];
            bool [] promocao = new bool [qtdp];
            int returncase;
 
            //Funções

            //Mostrar Menu
            void MostrarMenu() {
                
                Console.WriteLine("Selecione uma Opção");
                Console.WriteLine("\n[1] Cadastrar Produtos");
                Console.WriteLine("[2] Listar Produtos");
                Console.WriteLine("[0] Cancelar\n");
                returncase = int.Parse( Console.ReadLine() );

            }

            //Cadastro
            void CadastrarProduto() {
                
                    for (int i = 0; i < qtdp; i++)
                    {
                        
                        Console.Write($"Escreva o nome do {i+1}° produto: ");
                        nome[i] = Console.ReadLine();

                        Console.Write($"Escreva o Preço do {i+1}° produto: R$");
                        preco[i] = float.Parse( Console.ReadLine() );

                        Console.WriteLine($"O produto está em promoção? (s/n)");
                        retorno[i] = Console.ReadLine();

                        if ( retorno[i] == "s" )
                        {

                            promocao[i] = true;
                            apresent [i] = "Sim";
                        
                        } else {

                            promocao[i] = false;
                            apresent [i] = "Não";
                        }

                    }

                    MostrarMenu();

                switch (returncase)
                {
                    case 1:

                        CadastrarProduto();

                        break;

                    case 2:

                        ListarProdutos();

                        break;

                    case 0:

                        Console.WriteLine("Fim");

                        break;

                    default:

                    Console.WriteLine("Inválido");

                    break;

                }
            }

            //Listar Produtos
            void ListarProdutos() {

                    for (var c = 0; c < qtdp; c++)
                    {
                        
                        Console.WriteLine($"Produto N° {c+1} ");
                        Console.WriteLine($"Nome: {nome[c]}");
                        Console.WriteLine($"Preço: {preco[c]}");
                        Console.WriteLine($"Promoção: {apresent[c]}\n");

                    }

                    MostrarMenu();

                switch (returncase)
                {
                    case 1:

                        CadastrarProduto();

                        break;

                    case 2:

                        ListarProdutos();

                        break;

                    case 0:

                        Console.WriteLine("Fim");

                        break;

                    default:

                    Console.WriteLine("Inválido");

                    break;

                }

            }




            //Main
            
            MostrarMenu();

            switch (returncase)
            {
                case 1:

                    CadastrarProduto();

                    break;

                case 2:

                    ListarProdutos();

                    break;

                case 0:

                    Console.WriteLine("Fim");

                    break;

                default:

                Console.WriteLine("Inválido");

                break;

                
            }

            
        
        }
    }
}

 