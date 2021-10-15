using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassePessoa
{
	class Pessoa
	{
		public string nome;
		public int idade;
		//só define como int quando for fazer calculo com o numero
		public string rg;
		public string cpf;

		public void Acenar(Pessoa pessoa)
		{
			Console.WriteLine("{0} acenou para {1}", this.nome, pessoa.nome);
		}

		public void perguntaIdade(Pessoa pessoaEntrevistada)
		{
			Console.WriteLine("Qual a sua idade, {0}", pessoaEntrevistada.nome);
			pessoaEntrevistada.respostaIdade();
		}

		public void respostaIdade()
		{
			Console.WriteLine("Eu tenho {0} anos!", this.idade);
		}
	}
}