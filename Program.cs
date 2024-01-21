class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "0")
            {
                break;
            }

            if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            Console.WriteLine("Digite o primeiro número");
            double num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            double num2 = Double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case "1":
                    resultado = num1 + num2;
                    break;
                case "2":
                    resultado = num1 - num2;
                    break;
                case "3":
                    resultado = num1 * num2;
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        continue;
                    }
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");

        }
    }
}