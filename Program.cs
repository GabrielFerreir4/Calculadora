using System;

namespace calculadora;
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        System.Console.WriteLine("--------- Olá seja bem vindo(a)!!----------");
        System.Console.WriteLine("Qual operação matemática você deseja fazer?");
        System.Console.WriteLine("Digite [1] Para Somar! ");
        System.Console.WriteLine("Digite [2] Para Subtrair! ");
        System.Console.WriteLine("Digite [3] Para Multiplicar! ");
        System.Console.WriteLine("Digite [4] Para Dividir! ");
        System.Console.WriteLine("Digite [5] Para Sair! ");
        System.Console.Write("Digite a opção desejada: ");
        int opcaoCliente = int.Parse(System.Console.ReadLine());
        switch (opcaoCliente)
        {
            case 1:
                {
                    Soma();
                    break;
                }
            case 2:
                {
                    Subtracao();
                    break;
                }


            case 3:
                {
                    Multiplicacao();
                    break;
                }


            case 4:
                {
                    Divisao();
                    break;
                }


            case 5:
                {
                    FormClosing();
                    break;
                }

            default:
                System.Console.WriteLine("Você digitou uma opção inválida, tente novamente!");
                Thread.Sleep(3000);
                Menu();

                break;

        }
        //Thread.Sleep(2500);


    }
    static void Soma()
    {
        Console.Clear();
        Console.Write("Digite o Primeiro Número: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.Write("Digite o Segundo Número: ");

        float v2 = float.Parse(Console.ReadLine());

        double resultado = v1 + v2;

        System.Console.WriteLine("O Resultado da soma de " + v1 + " e " + v2 + " é de: " + resultado);
    }

    static void Subtracao()
    {
        Console.Clear();
        System.Console.Write("Digite o Primeiro Número: ");
        float v1 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");

        System.Console.Write("Digite o Segundo Número: ");

        float v2 = float.Parse(System.Console.ReadLine());

        double resultado = v1 - v2;

        System.Console.WriteLine("O Resultado da Subtração de " + v1 + " e " + v2 + " é de: " + resultado);
    }

    static void Multiplicacao()
    {
        Console.Clear();
        System.Console.Write("Digite o Primeiro Número: ");
        float v1 = float.Parse(System.Console.ReadLine());

        System.Console.WriteLine("");

        System.Console.Write("Digite o Segundo Número: ");
        float v2 = float.Parse(System.Console.ReadLine());

        double resultado = v1 * v2;

        System.Console.WriteLine("O Resultado da Multiplicação de " + v1 + " e " + v2 + " é de: " + resultado);
    }

    static void Divisao()
    {
        Console.Clear();
        System.Console.Write("Digite o Primeiro Número: ");
        float v1 = float.Parse(System.Console.ReadLine());

        System.Console.WriteLine("");

        System.Console.Write("Digite o Segundo Número: ");
        float v2 = float.Parse(System.Console.ReadLine());

        double resultado = v1 / v2;

        System.Console.WriteLine("O Resultado da Divisão de " + v1 + " e " + v2 + " é de: " + resultado);
    }


    static void FormClosing()
    {
        Console.Clear();
        System.Console.WriteLine("Tem certeza que deseja fechar o programa?");
        System.Console.WriteLine("Digite [1] para SIM");
        System.Console.WriteLine("Digite [2] para NAO");
        System.Console.Write("Digite o número referente a opção desejada: ");
        int result = int.Parse(System.Console.ReadLine());
        if (result == 1)
        {
            Console.Clear();
            Environment.Exit(0);
        }
        else if (result <= 0 || result > 2)
        {
            System.Console.WriteLine("Você digitou uma opção errada, tente novamente");
            Thread.Sleep(3000);
            Console.Clear();
            FormClosing();
        }
        else
        {
            System.Console.WriteLine("Okay você irá voltar para o menu principal.");
            Thread.Sleep(3000);
            Console.Clear();
            Menu();
        }
    }


}
