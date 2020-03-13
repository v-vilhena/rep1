using System;

namespace Ficha13
{
    public class Ficha13Solucao
    {
        #region Exercicio 1
        public static double ConverterStringParaNumeroDouble(string num)
        {
            var parseOk = double.TryParse(num, out double parsedDoub);
            if (parseOk)
            {
                return parsedDoub;
            }
            else
            {
                return 0;
            }
        }
        public static char ConverterStringParaCharacter(string num)
        {
            var parseOk = char.TryParse(num, out char parsedChar);
            if (parseOk)
            {
                return parsedChar;
            }
            else
            {
                return '0';
            }
        }
        public static void Calculadora()
        {
            
            double result = 0.0;
            //
            //Introdução do primeiro número
            //
            Console.Write("Introduza o 1º número: ");
            double numA = ConverterStringParaNumeroDouble(Console.ReadLine());
            Console.WriteLine();
            string proceed = "S";
             
            while (proceed == "S")
            {
                Console.Write("Introduza o 1º número: ");
                numA = ConverterStringParaNumeroDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Proceder com os valores introduzidos? (S/N)");
                proceed = Console.ReadLine();
                if (proceed != "S")
                    break;

            }
            Console.Clear();


            //
            //Loop para continuar a operar com o resultado dado
            //
            var continuity = "S";
            while (continuity == "S")
            {
                Console.WriteLine("Continuar? (S/N)");
                continuity = Console.ReadLine();
                if (continuity == "S")
                {
                    //
                    //Introdução do operador
                    //
                    Console.WriteLine("prima + para somar" + '\n' +
                                      "prima - para subtrair" + '\n' +
                                      "prima * para multiplicar" + '\n' +
                                      "prima / para dividir" + '\n' +
                                      "prima % para obter o resto inteiro de uma divisão");
                    var operacao = Console.ReadKey();
                    string operador = "";
                    Console.WriteLine();

                    //
                    //Introdução do segundo número
                    //
                    Console.Write("Introduza o 2º número: ");
                    double numB = ConverterStringParaNumeroDouble(Console.ReadLine());
                    Console.WriteLine();

                    //
                    //Atribuição do resultado, consoante o operador
                    //
                    switch (operacao.KeyChar)
                    {
                        case '+': result = (numA + numB); operador = " + "; break;
                        case '-': result = (numA - numB); operador = " - "; break;
                        case '*': result = (numA * numB); operador = " * "; break;
                        case '/': result = (numA / numB); operador = " / "; break;
                        case '%': result = (numA % numB); operador = " % "; break;
                        default: Console.WriteLine("Operador inválido, tente de novo"); break;
                    }
                    //
                    // Excepção para divisão por 0
                    //
                    if (numA > 0 && numB == 0 && operador == " / ")
                        Console.WriteLine(numA + operador + numB + " = " + "positive lazy 8");
                    else if (numA < 0 && numB == 0 && operador == " / ")
                        Console.WriteLine(numA + operador + numB + " = " + "negative lazy 8");
                    else if (numA == 0 && numB == 0 && operador == " / ")
                        Console.WriteLine("A resposta é 42");
                    else
                        Console.WriteLine(numA + operador + numB + " = " + result);
                }
                else
                {
                    Console.WriteLine("Espero que o ajuste de contas tenha sido benéfico");
                }
            }
            return;

        }
    
    #endregion

        #region Exercicio 2
        public static void JogarAoGalo()
        {
            Console.WriteLine("still nothing");
        }
        #endregion

        #region Exercicio 3
        public static void JogarAForca()
        {
            Console.WriteLine("still nothing");
        }
    #endregion
    }
}

                                           //int numA, int numB, string soma,
                                           //string subtracao, string multiplicacao,
                                           //int divisao, int resto
