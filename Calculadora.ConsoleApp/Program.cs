namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("S - Sair");
                Console.WriteLine("-----------------------------");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                else if (opcao == "5")
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("-----------------------------");

                    Console.Write("Digite um número: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++) 
                    {
                        int resultadoTabuada = numeroTabuada * contador;
                        Console.WriteLine($"{numeroTabuada} X {contador} = {resultadoTabuada}");
                    }
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

                if (opcao == "1")

                    resultado = primeiroNumero + segundoNumero;

                else if (opcao == "2")

                    resultado = primeiroNumero - segundoNumero;

                else if (opcao == "3")

                    resultado = primeiroNumero * segundoNumero;

                else if (opcao == "4")
                {
                    while(segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possivel dividir um número por zero");
                        segundoNumero = Convert.ToDouble(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                }

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("-----------------------------");

                Console.Write("Deseja continuar? (S/N): ");
                string continuar = Console.ReadLine().ToUpper();
                if (continuar == "N")
                    break;
            }
        }
    }
}
