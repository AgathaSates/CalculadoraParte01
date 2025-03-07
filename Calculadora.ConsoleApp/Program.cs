namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("S - Sair");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Escolha uma opção: ");

            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "S")
            {
                return;
            }
            Console.WriteLine("-----------------------------");
            Console.Write("Digite o primeiro número: ");

            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");

            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            if (opcao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
            }
            else if (opcao == "2") 
            {
                resultado = primeiroNumero - segundoNumero;
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Resultado: " + resultado);

            Console.ReadLine();
        }
    }
}
