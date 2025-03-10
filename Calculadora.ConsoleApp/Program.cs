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
                Console.WriteLine("S - Sair");
                Console.WriteLine("-----------------------------");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                Console.WriteLine("-----------------------------");
                Console.Write("Digite o primeiro número: ");

                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");

                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                if (opcao == "1")

                    resultado = primeiroNumero + segundoNumero;

                else if (opcao == "2")

                    resultado = primeiroNumero - segundoNumero;

                else if (opcao == "3")

                    resultado = primeiroNumero * segundoNumero;

                else if (opcao == "4")

                    resultado = primeiroNumero / segundoNumero;


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
