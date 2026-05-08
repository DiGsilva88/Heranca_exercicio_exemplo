using System.Drawing;
using System.Threading.Channels;

namespace Heranca_exercicio_exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> listaFuncionario = new List<Funcionario>();

            Funcionario f1 = new Funcionario("Luis", 45, "Barcelos");
            Funcionario socio = new Socio("Pedro", 34, "Braga", 100);
            Funcionario tarefeiro = new Outsourcing("maria", 28, "Viana", 15);

            //adiconar lista
            listaFuncionario.Add(f1);
            listaFuncionario.Add(socio);

            listaFuncionario.Add(tarefeiro);

            foreach (Funcionario f in listaFuncionario)

            {
                f.ExibirInformacoes();



            }

            Socio s = new Socio("asd", 34, "brg", 500);
            listaFuncionario.Add(s);

            foreach (Funcionario f in listaFuncionario)

            {
                f.ExibirInformacoes();



            }
            //metodo tostring()
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(socio); //se quiser passar um objecto=socio,gostaria que passase o texto mas não vai acontecer isso
                                      //este objecto pertence a classe socio
            socio.ToString();


            Console.WriteLine("*************Lista funcionarios com Tostring*************");
            {
                foreach (Funcionario f in listaFuncionario)
                {
                    Console.WriteLine(f.ToString());

                    //No teu ciclo foreach, o f.ToString() sozinho não faz nada(ele apenas "gera" a string).
                    //Para veres o resultado, tens de o colocar dentro de um Console.WriteLine


                    //O que está a acontecer no teu código:Polimorfismo: Ao usares foreach (Funcionario f in listaFuncionario), o C# é inteligente: se o objeto for um Socio, ele executa o método do Socio. 
                    //    Se for Outsourcing, executa o dele.ToString: Por defeito, todos os objetos em C# herdam um ToString() que apenas diz o nome da classe. 
                    //    Ao fazeres override, estás a dizer: "Esquece o padrão, usa este formato de texto".



                }

            }
        }






























        //    //implementar a classe base-funcionario-check

        //    Funcionario f1 = new Funcionario("Luís", 45, "Porto");
        //    Funcionario f2 = new Funcionario("Sara", 42, "Braga");


        //    //polimorfismo de referencia
        //    //criar o scoio chamando os construtores
        //    Funcionario socio1 = new Socio("Manuel", 35, "Vila Verde", 100);


        //    //do lado esquerdo o compilador ve o socio como um funcionario
        //    //new socio=> o objecto real é do tipo Socio
        //    //ou seja é um funcionario especializado

        //    Socio socio2 = new Socio("Pedro", 38, "Braga", 200);

        //    f1.ExibirInformacoes();
        //    socio1.ExibirInformacoes();
        //    socio2.MostrarqtAccoes();
        //    socio2.ExibirInformacoes();


        //    //o scoio também é um funcionario só que é especializado

        //    Funcionario socio3 = new Socio("João", 35, "Braga", 300);
        //    //chamo o construtor mas é um funcionario

        //    //polimorfismo vem do grego multiplas formas

        //    //se quero acrescentar algum comportamento a mais vou escrever por exemplo (nAccoes=x)


        //    //criar o  funcionario tarefeiro de Outsourcing

        //    Funcionario tarefeiro = new Outsourcing("Maria", 27, "Braga", 20);
        //    Console.WriteLine("Exibi a informação do tarefeiro");
        //    tarefeiro.ExibirInformacoes();


        //    //com a herança só acresce e pode ser reutilizavel,só cresce as classes ,herdam os metodos
        //}
    }
}
