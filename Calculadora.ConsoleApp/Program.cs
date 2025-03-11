namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacoes = 0;
            string[] historico = new string[20];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico de operações");
                Console.WriteLine("S - Sair");
                Console.WriteLine("-----------------------------");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                else if (opcao == "5")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-----------Tabuada-----------");
                    Console.Write("Digite um número: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("-----------------------------");
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadoTabuada = numeroTabuada * contador;
                        Console.WriteLine($"{numeroTabuada} X {contador} = {resultadoTabuada}");
                    }
                    Console.WriteLine("-----------------------------");
                    Console.Write("Pressione qualquer tecla para sair: ");
                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("-----Histórico de operações-----");
                    Console.WriteLine();
                    if (historico[0] == null)
                    {                      
                        Console.WriteLine("Não há operações registradas.");
                    }
                    else
                    {
                        foreach (string operacao in historico)
                        {
                            if (operacao != null)
                            {
                                Console.WriteLine(operacao);
                            }
                        }                       
                    }
                    Console.WriteLine();
                    Console.Write("Pressione qualquer tecla para sair: ");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("-----------------------------");
                Console.Write("Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("-----------------------------");

                double resultado = 0;
                string sinal = "";

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    sinal = "+";
                }

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    sinal = "-";
                }

                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    sinal = "x";
                }

                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.Write("Não é possivel dividir um número por zero, digite um número novamente:");
                        segundoNumero = Convert.ToDouble(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                    sinal = "÷";
                }

                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("-----------------------------");
                historico[operacoes] = $"{primeiroNumero} {sinal} {segundoNumero} = {resultado.ToString("F2")}";
                operacoes++;
                Console.Write("Deseja continuar? (S/N): ");
                string continuar = Console.ReadLine().ToUpper();
                if (continuar == "N")
                    break;
            }
        }
    }
}

