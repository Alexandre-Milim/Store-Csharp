using System;

public class Produtos
{
    public static void MostrarProdutos()
    {
        Console.WriteLine("Seja bem vindo(a)!");
        Console.WriteLine("Temos Novidades, como: Monitor, CPU, Cadeira gamer");

        Console.WriteLine("Qual produto você deseja comprar?");
        string escolha = Console.ReadLine();

        if (escolha.ToLower() == "monitor")
        {
            Console.WriteLine("R$ 699,99");
        }
        else if (escolha.ToLower() == "cpu")
        {
            Console.WriteLine("R$ 1.399,99");
        }
        else
        {
            Console.WriteLine("R$ 1.189,90");
        }

        Console.WriteLine("Escolha a forma de pagamento:");
        Console.WriteLine("1. Cartão de Crédito");
        Console.WriteLine("2. Pagamento Pix");
        Console.WriteLine("3. Pagamento Boleto");

        string formaDePagamento = Console.ReadLine();

        if (formaDePagamento == "1")
        {
            TiposDePagamento.CartaoDeCredito();
        }
        else if (formaDePagamento == "2")
        {
            TiposDePagamento.PagamentoPix();
        }
        else
        {
            TiposDePagamento.PagamentoBoleto();
        }
    }
}

public class TiposDePagamento
{
    public static void PreencherDadosDoUsuario()
    {
        Console.WriteLine("Digite seu CPF:");
        string cpf = Console.ReadLine();

        Console.WriteLine("Digite sua senha:");
        string senha = Console.ReadLine();

        if (ValidarCredenciais(cpf, senha)) 
        {
            Console.WriteLine("Dados corretos. Efetuar compra...");
            // Implemente aqui a lógica para efetuar a compra
        }
        else
        {
            Console.WriteLine("Dados incorretos. Compra não realizada.");
        }
    }

    public static void IdentificacaoPessoal()
    {
        Console.WriteLine("Digite seu nome completo:");
        string nome = Console.ReadLine();

        Console.WriteLine("Data de nascimento:");
        string dataNascimento = Console.ReadLine();

        Console.WriteLine("Digite a sua nacionalidade:");
        string nacionalidade = Console.ReadLine();

        Console.WriteLine("Digite o seu estado civil:");
        string estadoCivil = Console.ReadLine();

        Console.WriteLine("Digite o seu RG:");
        string rg = Console.ReadLine();

        Console.WriteLine("Digite o seu CPF:");
        string cpf = Console.ReadLine();

        Console.WriteLine("Digite seu email:");
        string email = Console.ReadLine();
    }

    public static void CartaoDeCredito()
    {
        Console.WriteLine("Você possui o cartão da loja? (sim/não)");
        string possuiCartao = Console.ReadLine();

        if (possuiCartao.ToLower() == "nao")
        {
            Console.WriteLine("Deseja fazer um cartão da loja? (sim/não)");
            string escolha = Console.ReadLine();

            if (escolha.ToLower() == "sim")
            {
                IdentificacaoPessoal();
            }
            else
            {
                Console.WriteLine("Agradecemos a sua visita!");
            }
        }
        else
        {
            PreencherDadosDoUsuario();
        }
    }

    public static void PagamentoPix()
    {
        Console.WriteLine("Digite o numero do telefone");
		float Telefone = Console.ReadLine();
    }

    public static void PagamentoBoleto()
    {
        Console.WriteLine("Pagamento via Boleto selecionado.");
    }

    private static bool ValidarCredenciais(string cpf, string senha) //aqui ele passa duas variaveis como string
    {
        string cpfValido = "12"; //aqui ele marca os valores do cpf e senha
        string senhaValida = "12";

        return cpf == cpfValido && senha == senhaValida; // e fala que as variaveis escrita nos parametro são iguais, e assim usar na função PreencherDadosDoUsuario
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Produtos.MostrarProdutos();
    }
}