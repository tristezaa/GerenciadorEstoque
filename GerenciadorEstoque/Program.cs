using System;
using System.Text.Json;


namespace GerenciadorEstoque
{
    class Program
    {

        static List<Produto> produtos = new List<Produto>();
        enum Menu
        {
            Listar = 1,
            Adicionar,
            Remover,
            Entrada,
            Saida,
            Sair
        }
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("=== Gerenciador de Estoque ===");
                Console.WriteLine("1. Listar produtos");
                Console.WriteLine("2. Adicionar produto");
                Console.WriteLine("3. Remover produto");
                Console.WriteLine("4. Registrar entrada de produto");
                Console.WriteLine("5. Registrar saída de produto");
                Console.WriteLine("6. Sair");
                int Opcao = int.Parse(Console.ReadLine());
                Menu escolha = (Menu)Opcao;

                switch (escolha)
                {
                    case Menu.Listar:
                        ListarProdutos();
                        break;
                    case Menu.Adicionar:
                        Console.Clear();
                        Cadastro();
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Entrada:
                        break;
                    case Menu.Saida:
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            }
            Console.Clear();

        }

        static void ListarProdutos()
        {
            Console.WriteLine("=== Lista de Produtos ===");
                if (produtos.Count == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                    return;
                }
                foreach (Produto produto in produtos)
                {
                    produto.Exibir();
                    
                }
        }
        enum MenuCadastro
        {
            Curso = 1,
            Ebook,
            ProdutoFisico,
            Voltar
        }

        static void Cadastro()
        {
            bool voltarAoMenu = false;
            while (!voltarAoMenu)
            {
                Console.WriteLine("=== Cadastro de Produto ===");
                Console.WriteLine("1. Curso");
                Console.WriteLine("2. Ebook");
                Console.WriteLine("3. Produto Físico");
                Console.WriteLine("4. Voltar ao menu principal");
                int Opcao = int.Parse(Console.ReadLine());
                MenuCadastro escolha = (MenuCadastro)Opcao;

                switch (escolha)
                {
                    case MenuCadastro.Curso:
                        CadastrarCurso();
                        break;
                    case MenuCadastro.Ebook:
                        CadastrarEbook();
                        break;
                    case MenuCadastro.ProdutoFisico:
                        CadastrarFisico();
                        break;
                    case MenuCadastro.Voltar:
                        voltarAoMenu = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            Console.Clear();
        }

        static void CadastrarFisico()
        {
            Console.WriteLine("=== Cadastro de Produto Físico ===");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.Write("Frete: ");
            float frete = float.Parse(Console.ReadLine());
            ProdutoFisico novoProduto = new ProdutoFisico(nome, preco, frete);
            produtos.Add(novoProduto);
            Salvar();
            Console.WriteLine("Produto físico cadastrado com sucesso!");
        }

        static void CadastrarEbook()
        {
            Console.WriteLine("=== Cadastro de Ebook ===");
            Console.Write("Nome do ebook: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Ebook novoEbook = new Ebook(nome, preco, autor);
            produtos.Add(novoEbook);
            Salvar();
            Console.WriteLine("Ebook cadastrado com sucesso!");
        }

        static void CadastrarCurso()
        {
            Console.WriteLine("=== Cadastro de Curso ===");
            Console.Write("Nome do curso: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Curso novoCurso = new Curso(nome, preco, autor);
            produtos.Add(novoCurso);
            Salvar();
            Console.WriteLine("Curso cadastrado com sucesso!");
        }

        static void Salvar()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(produtos, options);
            File.WriteAllText("Produtos.json", json);
            
        }

        static void Carregar()
        {
            if (!File.Exists("Produtos.json"))
            {
                produtos = new List<Produto>();
                return;
            }

            var options = new JsonSerializerOptions();

            try
            {
                string json = File.ReadAllText("Produtos.json");
                produtos = JsonSerializer.Deserialize<List<Produto>>(json, options)
                           ?? new List<Produto>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar os produtos:");
                Console.WriteLine(ex.Message);
                produtos = new List<Produto>();
            }
        }
    }
}
