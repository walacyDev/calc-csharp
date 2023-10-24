using System;

class Program
{
    static void Main(string[] args)
    {
        int operacao;
        int n1, n2;
        double resultado;
        string doOperacao = "sim"; // Initialize doOperacao with "sim" to enter the loop

        Console.WriteLine("Bem vindo ao sistema de cálculo!");

        while (doOperacao.ToLower() == "sim")
        {
            Console.WriteLine("Qual operação matemática você deseja fazer?");
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação");
            operacao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número da operação:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número da operação:");
            n2 = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    resultado = n1 + n2;
                    Console.WriteLine("O resultado da Soma é: " + resultado);
                    break;
                case 2:
                    resultado = n1 - n2;
                    Console.WriteLine("O resultado da Subtração é: " + resultado);
                    break;
                case 3:
                    if (n2 != 0)
                    {
                        resultado = (double)n1 / n2;
                        Console.WriteLine("O resultado da Divisão é: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                case 4:
                    resultado = n1 * n2;
                    Console.WriteLine("O resultado da Multiplicação é: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

            Console.WriteLine("Deseja fazer mais alguma operação? (sim/nao)");
            doOperacao = Console.ReadLine();
        }
    }
}
