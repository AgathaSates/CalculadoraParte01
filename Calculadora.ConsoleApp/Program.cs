namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static int operacoes = 0;    //atributos staticos//para utilizar em toda a classe, o valor ser alterado mesmo dentro do metodo e não morrer la dentro
        static string[] historico = new string[20];

        static void Main(string[] args)
        {            
            while (true)
            {
                string opcao = Menu();

                if (Sair(opcao))
                    break;

                else if (Tabuada(opcao))
                    MostrarTabuada();

                else if (Historico(opcao))
                    MostrarHistorico();

                else               
                    Resultado(Operacoes(opcao));
                    
                Console.Write(" -> Deseja Realizar outra operação? (S/N): "); // ao final de cada operação volta ao menu
                string continuar = Console.ReadLine()!.ToUpper(); // "!" usado para parar o warning
                if (continuar == "N")
                    break;
            }

            static string Menu()
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" Calculadora Tabajara 2025");
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" 1 - Somar");
                Console.WriteLine(" 2 - Subtrair");
                Console.WriteLine(" 3 - Multiplicação");
                Console.WriteLine(" 4 - Divisão");
                Console.WriteLine(" 5 - Tabuada");
                Console.WriteLine(" 6 - Histórico de Operações");
                Console.WriteLine(" S - Sair");
                Console.WriteLine("--------------------------------");
                Console.Write(" -> Digite uma opção: ");

                string opcao = Console.ReadLine()!.ToUpper();

                return opcao;
            }

            static bool Sair(string opcao)
            {
                bool Sair = opcao == "S"; //se ele digitou é verdadeiro então faz a função seguinte aonde ele foi chamado(menu)

                return Sair;
            }

            static bool Tabuada(string opcao) 
            {
                bool Tabuada = opcao == "5";

                return Tabuada;
            }

            static bool Historico(string opcao)
            {
                bool Historico = opcao == "6";

                return Historico;
            }

            static void MostrarTabuada()
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" Tabuada");
                Console.WriteLine("--------------------------------");

                Console.Write(" -> Digite o número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine($" Tabuada do {numero}");             // titulo
                Console.WriteLine("--------------------------------");

                for (int contador = 1; contador <= 10; contador++)
                {
                    int resultadoTabuada = numero * contador;                                    
                    Console.WriteLine($" {numero} x {contador} = {resultadoTabuada}");
                }
                Console.WriteLine("--------------------------------");              
            }

            static void MostrarHistorico() 
            {
                Console.Clear();
                Console.WriteLine("----- Histórico de operações -----");
                if (historico[0] == null)
                {
                    Console.WriteLine(" (X) Não há operações registradas.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("-----------------------");
                    foreach (string operacao in historico)  //foreach
                    {
                        if (operacao != null)   //apenas para arrays com informação
                        {   
                            Console.WriteLine(operacao);          // imprime cada operação              
                        }
                    }
                    Console.WriteLine("-----------------------");

                }
            }

            static string Operacoes(string opcao) //alterado para string
            {
                Console.Clear();
                Console.WriteLine(" --- Digite os valores para realizar a operação ---"); //titulo
                Console.WriteLine();
                Console.Write(" -> Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write(" -> Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("-----------------------------");

                string resultadoInteiro = "";
                double resultado = 0;
                string sinal = "";

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;      // resultado original            
                    sinal = "+";
                    resultadoInteiro = $" {primeiroNumero} {sinal} {segundoNumero} = {resultado.ToString("F2")}"; //reformulei o resultado para mostrar toda a operação
                }

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    sinal = "-";
                    resultadoInteiro = $" {primeiroNumero} {sinal} {segundoNumero} = {resultado.ToString("F2")}";
                }

                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    sinal = "x";
                    resultadoInteiro = $" {primeiroNumero} {sinal} {segundoNumero} = {resultado.ToString("F2")}";
                }

                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.Write(" (X) Não é possivel dividir um número por zero, digite um número novamente:");
                        segundoNumero = Convert.ToDouble(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                    sinal = "÷";
                    resultadoInteiro = $" {primeiroNumero} {sinal} {segundoNumero} = {resultado}";
                }

                historico[operacoes] = $" {primeiroNumero} {sinal} {segundoNumero} = {resultado.ToString("F2")}"; //guarda no array a operação criando o historico
                operacoes++; //pula para preencher o proximo bloco array
                
                return resultadoInteiro;
            }

            static string Resultado(string resultadointeiro) //alterado para string
            {
                Console.WriteLine($" -> Resultado:{resultadointeiro}");
                Console.WriteLine("-----------------------------");

                return resultadointeiro;
            }
        }
    }
}

