using System;

public class Produtos
{
	public static void MostrarProdutos()
	{
		Console.WriteLine("Seja bem vindo(a)!");
		Console.WriteLine("Temos Novidades, como: Monitor, CPU, Cadeira gamer");
		
		Console.WriteLine("Qual vc deseja comprar?");
		string escolha = Console.ReadLine();
		
		if (escolha.ToLower() == "monitor") // to lower para a pessoa poder digitar tanto minusculo, quantos maiusculo
		{
			Console.WriteLine("R$ 699,99");
			
		}else if (escolha.ToLower() == "cpu")
		{
			Console.WriteLine("R$ 1.399,99");
			
		}else 
		{
			Console.WriteLine("R$ 1.189,90");
		}
		
		Console.WriteLine("Escolha a forma de pagamento");
		Console.WriteLine("1. Cartão de Crédito");
        Console.WriteLine("2. Pagamento Pix");
        Console.WriteLine("3. Pagamento Boleto");
		
		string FormaDePagamento = Console.ReadLine();
		
		if (FormaDePagamento == "1")
		{
			TiposDePagamento.CartaoDeCredito();
		}else if (FormaDePagamento == "2")
		{
			TiposDePagamento.PagamentoPix();
		}else 
		{
			TiposDePagamento.PagamentoBoleto();
		}
	}
}

public class TiposDePagamento
{
	public static void IdentificacaoPessoal()
		{

			Console.WriteLine("Digite seu nome completo:");
			string nome = Console.ReadLine();

			Console.WriteLine("Data de nascimento:");
			string dataNascimento = Console.ReadLine();

			Console.WriteLine("Digite a sua nacionalidade:");
			string nacionalidade = Console.ReadLine();

			Console.WriteLine("Digite o seu estado civil:");
			string civil = Console.ReadLine();

			Console.WriteLine("Digite o seu RG:");
			string rg = Console.ReadLine();

			Console.WriteLine("Digite o seu CPF:");
			string cpf = Console.ReadLine();

			Console.WriteLine("Digite seu email:");
			string email = Console.ReadLine();
		}
	public static void CartaoDeCredito()
	{
		Console.WriteLine("Voce possui op cartão da loja? ");
		string SimOuNao = Console.ReadLine();
		
		if (SimOuNao == "não")
		{
			Console.WriteLine("deseja fazer?");
			string EscolheuFazer = Console.ReadLine();
			
			if (EscolheuFazer == "sim")
			{
				IdentificacaoPessoal();
			}
		}
	}
	public static void PagamentoPix()
	{
		Console.WriteLine("pixxx");
	}
	public static void PagamentoBoleto()
	{
		Console.WriteLine("boletoo");
	}
}
	

public class Program
{
    public static void Main(string[] args)
    {
		Produtos.MostrarProdutos();
	}
}