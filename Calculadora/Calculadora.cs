using System;

namespace Calculadora
{
    public class Calculadora
    {
       public static void RequestProduct(ref string output, ref double subtotal)
        {
            var subtotal = 0.0;
            Console.WriteLine("Qual o nome do produto?");
            var name = Console.ReadLine();
            Console.WriteLine($"Qual o preço de {name}?");
            var price = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o quantidade de {name}?");
            var quantity = int.Parse(Console.ReadLine());
            subtotal = price * quantity;
            output = $"{name}({quantity}) - {subtotal}";


        }
        public static string Somadeira(in int num1, in int num2, out int res)
        {
            res = num1 + num2;
            return "Soma";
        }

        public static int Pascaleira(int num1, int num2, out int soma,
                                     out int subtracao, out int multiplicacao,
                                     out int divisao, out int resto)
        {
            soma = num1 + num2;
            subtracao = num1 - num2;
            multiplicacao = num1 * num2;
            divisao = num1 / num2;
            resto = num1 % num2;
        }
        static void Main(string[] args)
        {
            int soma ;
            int;
            var resto;
            Pascaleira(4, 2, out soma, out subtracao, out int multiplicacao, out int divisao, out int resto);
            Console.WriteLine($"A soma de 4 e 2 é {soma} \nA subtralão de 4 e 2 é {subtracao} +
                              $"\nA multiplicação de 4 e 2 é {multiplicacao} \n" +
                              $"\nA divisão de 4 e 2 é {divisao} \nO resto de 4 por 2 é {resto}\n")

        }
        
    }
}
