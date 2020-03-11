using System;

namespace Ficha7
{
    public class Ficha7Solucao
    {
        public static int ConverterStringParaNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            if (parseOk)
            {
                return parsedNum;
            }
            else
            {
                return 0;
            }
        }
        public static decimal ConverterStringParaNumeroDecimal(string num)
        {
            var parseOk = decimal.TryParse(num, out decimal parsedDeci);
            if (parseOk)
            {
                return parsedDeci;
            }
            else
            {
                return 0;
            }
        }
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

        #region Exercicio 1.1
        public static void Exercicio101()
        {
            Console.WriteLine("número?");
            double resultado = ConverterStringParaNumeroDouble(Console.ReadLine());
            if (resultado <= 9.44)
            {
                Console.WriteLine("Chumbou");
            }
            else
            {
                Console.WriteLine("Passou");
            }
            
        }
        #endregion

        #region Exercicio 1.2
        public static void Exercicio102()
        {
            Console.WriteLine("Qual o peso?");
            double peso = ConverterStringParaNumeroDouble(Console.ReadLine());
            Console.WriteLine("Qual a altura (separado por vírgula)?");
            double altura = ConverterStringParaNumeroDouble(Console.ReadLine());
            double ibm = (peso / (altura * altura));
            Console.WriteLine("O seu índice de massa corporal é de " + ibm);

            if (ibm < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (ibm >= 18.5 && ibm < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (ibm >= 25 && ibm < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
        }
        #endregion

        #region Exercicio 1.3
        public static void Exercicio103()
        {
            Console.WriteLine("Introduza um número");
            int num = ConverterStringParaNumero(Console.ReadLine());

            if (num % 3 == 0 && num % 7 == 0)
            {
                Console.WriteLine(num + " é multiplo de 3 e de 7");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine(num + " é apenas multiplo de 3");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine(num + " é apenas multiplo de 7");
            }
            else
            {
                Console.WriteLine(num + " não é multiplo de 3 nem de 7");
            }
        }
        #endregion

        #region Exercicio 1.4
        public static void Exercicio104()
        {
            Console.WriteLine("Introduza um número");
            double num = ConverterStringParaNumeroDouble(Console.ReadLine());

            if (num >= 30 && num <= 50)
            {
                Console.WriteLine(num + " encontra-se entre 30 e 50, inclusive");
            }
            else
            {
                Console.WriteLine(num + "não se encontra entre 30 e 50, inclusive");
            }

        }
            #endregion

        #region Exercicio 1.5
        public static void Exercicio105()
        {
            Console.WriteLine("Introduza um número");
            double num = ConverterStringParaNumeroDouble(Console.ReadLine());

            if (num > 10 && num < 20)
            {
               Console.WriteLine(num + " encontra-se entre 10 e 20, exclusive");
            }
            else
            {
               Console.WriteLine(num + " não se encontra entre 10 e 20, exclusive");
            }
        }
        #endregion

        #region Exercicio 1.6
        public static void Exercicio106()
        {
            Console.WriteLine("Para que piso deseja dirigir-se?");
            int piso = ConverterStringParaNumero(Console.ReadLine());

            if (piso < 6 || piso > -2 || piso == 3 || piso == 5)
            {
                Console.WriteLine("Piso indisponível");
            }
            else
            {
                Console.WriteLine("A dirigirmo-nos para o piso " + piso);
            }
        }
        #endregion

        #region Exercicio 1.7
        public static void Exercicio107()
        {
            double total = 0;
            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine("Vamos somar 10 números. Introduza o " + i + "º número.");
                total += ConverterStringParaNumeroDouble(Console.ReadLine());
            }
            Console.WriteLine("A adição dos 10 números introduzidos dá um total de " + total);
        }
        #endregion

        #region Exercicio 1.8
        public static void Exercicio108()
        {
            var i = 1;
            double totalTotal = 0;
            
            while( i < 6) {
                Console.WriteLine("Introduza o " + i + "º artigo");
                var produto = Console.ReadLine();
                Console.WriteLine("Introduza o preço do " + i + "º artigo");
                var preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduza a quantidade do " + i + "º artigo");
                var quant = double.Parse(Console.ReadLine());

                double total = preco * quant;
                Console.WriteLine("O preço total de " + produto + " é " + total + '\n');
                i++;
                totalTotal += total;
                
            }
            Console.WriteLine("O preço total é de " + totalTotal);
        }
            #endregion

        #region Exercicio 1.9
        public static void Exercicio109()
        {
            var acumulador = 0;
            double soma = 0;
            int i;
            do
            {
                Console.WriteLine("Introduza um número (para calcular a média entre os números já introduzidos, introduza 0");
                i = ConverterStringParaNumero(Console.ReadLine());
                if (i != 0)
                {
                    acumulador++;
                    soma += i;
                }
            }
            while (i != 0);
            
            double media = soma / acumulador;

        }
        #endregion

        #region Exercicio 1.10
        public static void Exercicio110()
        {
            Console.WriteLine("Introduza o primeiro número");
            double i = ConverterStringParaNumeroDouble(Console.ReadLine());
            Console.WriteLine("Introduza o segundo número");
            double j = ConverterStringParaNumeroDouble(Console.ReadLine());
            Console.WriteLine("Introduza um operador");
            char k = ConverterStringParaCharacter(Console.ReadLine());

            if (k == '+')
            {
                Console.WriteLine(i + j);
            }
            else if (k == '-')
            {
                Console.WriteLine(i - j);
            }
            else if (k == '*')
            {
                Console.WriteLine(i * j);
            }
            else if (k == '/')
            {
                Console.WriteLine(i / j);
            }
            else if (k == '%')
            {
                Console.WriteLine(i % j);
            }
            else
            {
                Console.WriteLine("Operador Inválido");
            }
        }
        #endregion

        #region Exercicio 1.11
        public static void Exercicio111()
        {
            Console.WriteLine("Introduza um caracter.");
            var c = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Exercicio 1.12
        public static void Exercicio112()
        {
            Console.WriteLine("Introduza um caracter.");
            var c = Console.ReadLine();

            Console.WriteLine("Introduza um número.");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            };

           
        }
        #endregion

        #region Exercicio 1.13
        public static void Exercicio113()
        {
            Console.WriteLine("Introduza um primeiro caracter.");
            var charOne = ConverterStringParaCharacter(Console.ReadLine());

            Console.WriteLine("Introduza um segundo caracter.");
            var charTwo = ConverterStringParaCharacter(Console.ReadLine());
            
            Console.WriteLine("Introduza um primeiro número.");
            int m = ConverterStringParaNumero(Console.ReadLine()); 
            
            Console.WriteLine("Introduza um segundo número.");
            int n = ConverterStringParaNumero(Console.ReadLine());
            
            int countK = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (countK % 2 == 0)
                    {
                        Console.Write(charOne);
                    }
                    else
                    {
                        Console.Write(charTwo);
                    }
                    countK++;
                    
                }
                Console.WriteLine();
            }


        }
        #endregion

        #region Exercicio 2.1
        public static void Exercicio201()
        {
            Console.WriteLine("Introduz a temperatura");
            double temp = ConverterStringParaNumeroDouble(Console.ReadLine());
            var escala = "";
            
            while (escala != "C" && escala != "K" && escala != "F")
            {
                Console.WriteLine("Em que escala? (C, K ou F)");
                escala = Console.ReadLine();
            }

            switch (escala)
            {
                case "C": Console.WriteLine(temp + "ºC é equivalente a " + (temp + 273.15) + "ºK e " + (temp * (9 / 5) + 32) + "ºF");
                    break;
                case "K": Console.WriteLine(temp + "ºK é equivalente a " + (temp - 273.15) + "ºC e " + (temp * (9 / 5) - 459.67) + "ºF");
                    break;
                case "F": Console.WriteLine(temp + "ºF é equivalente a " + ((temp - 32) * (5 / 9)) + "ºC e " + ((temp + 459.67) * (5 / 9)) + "ºK");
                    break;
            }


        }
        #endregion

        #region Exercicio 2.2
        public static void Exercicio202()
        {
            Console.WriteLine("Qual é o número limite?");
            int num = int.Parse(Console.ReadLine());
            for (int cont = 0; cont < num; cont++)
            {
                if (cont % 2 == 1)
                {
                    Console.WriteLine(cont);
                }
            }
        }
        #endregion

        #region Exercicio 2.3
        public static void Exercicio203()
        {
            var caracteres = "";
            var caracter = "";
            do
            {
                Console.WriteLine("Introduz um número, ou enter para terminar");
                caracter = Console.ReadLine();
                caracteres += caracter;
            }
            while (caracter != "");
            Console.WriteLine(caracteres);
        }
        #endregion

        #region Exercicio 3.1
        public static void Exercicio301()
        {
            Console.WriteLine("Introduz um número");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(n * 3);
            }
            else
            {
                Console.WriteLine(n * 2);
            }
        }
        #endregion

        #region Exercicio 3.2
        public static void Exercicio302()
        {
            Console.WriteLine("Qual é a dimensão do triângulo?");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            
            while (n > 0)
            {
                n--;
                int a = 0;
                while (a != n)
                {
                    Console.Write(" ");
                    a++;
                }
                int b = 0;
                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }
                i += 2;
                Console.WriteLine("");
            }
        }
            #endregion
    }
}
