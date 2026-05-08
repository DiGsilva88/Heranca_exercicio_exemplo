using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_exercicio_exemplo
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Morada { get; set; }

        //construtor com parametros

        public Funcionario(string nome, int idade, string morada)
        {
            Nome = nome;
            idade = idade;
            Morada = morada;

        }

        //metodo

        public virtual void ExibirInformacoes()

        {
            Console.WriteLine($"Funcionario: {Nome}, idade {Idade}, Morada {Morada}");
        }

        //adaptar o metodo classe base para que possa ser subscrito,adicionar virtual ao metodo para que este possa ser redefinido
        //pelas classes derivadas=         public virtual void ExibirInformacoes()
        //redefinmos o metodo


        //------> criar novo funcionario em regime de outsorcing----> propriedade(valor hora)


        public  void MostrarQtAccoes()
        {
            Console.WriteLine("Este funcionario não tem accoes");
        }




    }
}
