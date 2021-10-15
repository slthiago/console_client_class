using System;
using ConsoleClassePessoa;

namespace console_cliente_class
{
	class Program
	{
		static void Main(string[] args)
		{
			Pessoa pessoa = new Pessoa();

			Console.Write("Digite o nome: ");
			pessoa.nome = Console.ReadLine();
			Console.Write("Digite a idade: ");
			pessoa.idade = Convert.ToInt32(Console.ReadLine());
			Console.Write("Digite o RG: ");
			pessoa.rg = Console.ReadLine();
			Console.Write("Digite o CPF: ");
			pessoa.cpf = Console.ReadLine();

			Console.WriteLine("Nome: {0}", pessoa.nome);
			Console.WriteLine("Idade: {0}", pessoa.idade);
			Console.WriteLine("RG: {0}", pessoa.rg);
			Console.WriteLine("CPF: {0}", pessoa.cpf);

			Pessoa pessoaSilvia = new Pessoa();

			pessoaSilvia.nome = "Silvia";
			pessoaSilvia.idade = 20;
			pessoaSilvia.rg = "11.111.111";
			pessoaSilvia.cpf = "111.111.111-11";

			Console.WriteLine("Nome: {0}", pessoaSilvia.nome);
			Console.WriteLine("Idade: {0}", pessoaSilvia.idade);
			Console.WriteLine("RG: {0}", pessoaSilvia.rg);
			Console.WriteLine("CPF: {0}", pessoaSilvia.cpf);

			pessoa.Acenar(pessoaSilvia);

			pessoa.perguntaIdade(pessoaSilvia);
		}
	}
}
