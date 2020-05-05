using System;

namespace Calculadora_Simples_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //variavel dos numeros a ser calculados
            int num1, num2, soma, subtracao, multiplicacao;
            double divisao;

            //um loop ate 100 operações
            for (int i = 0; i < 100; i++)
            {
                // aqui eu informo qual o primeiro valor a ser calculado
                Console.Write("informe o primeiro valor: ");
                num1 = int.Parse(Console.ReadLine());


                //aqui eu imformo qual o segundo valor a ser calculado
                Console.Write("informe o segundo valor: ");
                'num2 = int.Parse(Console.ReadLine());

                // soma do num 1 com o num 2
                soma = num1 + num2;

                //subtração do num 1 com o num2
                subtracao = num1 - num2;

                // multiplicação do num1 com o num2
                multiplicacao = num1 * num2;

                // divisão do num1 com o num2
                divisao = num1 / num2;

                //ele pega o valor da soma e o valor da multiplicaçao e faz subtraçao entre os dois
                var soma_multiplicacao = soma - multiplicacao;

                //mostra a quantidade de digitos de uma soma 
                var quantidade_de_numeros = soma.ToString().Length;

                //Escreve o resultado na tela
                Console.WriteLine("A soma dos valores é " + soma);
                Console.WriteLine("A subtracao dos valores é " + subtracao);
                Console.WriteLine("A multplicacao dos valores é " + multiplicacao);
                Console.WriteLine("A divisao dos valores é " + divisao);
                Console.WriteLine("A soma - multiplicaçao dos valores é " + soma_multiplicacao);
                Console.WriteLine("quantidade de digitos de uma soma é " + quantidade_de_numeros);
                Console.WriteLine("");
                Console.WriteLine("");

                int q = 0;

                var t = Convert.ToString(q);
                "0"
            }

            Console.ReadKey();
        }
    }
}
