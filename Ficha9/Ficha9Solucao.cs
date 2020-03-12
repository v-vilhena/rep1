using System;

namespace Ficha9
{
    public class Ficha9Solucao
    {


        #region Exercicio 1
        public static void Exercicio1()
        {
            double a = 0;
            double b = 0;
            double c = 0;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Introduza o " + i + "º número");
                if (i == 1)
                {
                    a = double.Parse(Console.ReadLine());
                }
                else if (i == 2)
                {
                    b = double.Parse(Console.ReadLine());
                }
                else
                {
                    c = double.Parse(Console.ReadLine());
                }
            }
            double d = (a * b * c);
            Console.WriteLine(a + " * " + b + " * " + c + " = " + d);

        }
        #endregion

        #region Exercicio 2
        public static void Exercicio2()
        {
            Console.WriteLine("Introduza o 1º número");
            double i = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o 2º número");
            double j = double.Parse(Console.ReadLine());

            double iPlusj = (i + j);
            double iSbtrktj = (i - j);
            double iMultij = (i * j);
            double iDividj = (i / j);
            double iRemj = (i % j);

            Console.WriteLine(i + " + " + j + " = " + iPlusj);
            Console.WriteLine(i + " - " + j + " = " + iSbtrktj);
            Console.WriteLine(i + " * " + j + " = " + iMultij);
            Console.WriteLine(i + " / " + j + " = " + iDividj);
            Console.WriteLine(i + " % " + j + " = " + iRemj);
        }
        #endregion

        #region Exercicio 3
        public static void Exercicio3()
        {
            double x = 0;
            double y = 0;
            double z = 0;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Introduza o " + i + "º número");
                if (i == 1)
                {
                    x = double.Parse(Console.ReadLine());
                }
                else if (i == 2)
                {
                    y = double.Parse(Console.ReadLine());
                }
                else
                {
                    z = double.Parse(Console.ReadLine());
                }
            }
            double v = (x + y) * z;
            double w = x * y + y * z; 
            
            Console.WriteLine("(" + x + " + " + y + ")" + " * " + z + " = " + v);
            Console.WriteLine(x + " * " + y + " + " + y + " * " + z + " = " + w);


        }
        #endregion

        #region Exercicio 4
        public static void Exercicio4()
        {
            Console.WriteLine("Introduza um número");
            int primeOfAll = int.Parse(Console.ReadLine());
            bool primeBool = true;
            if (primeOfAll == 2)
                {
                Console.WriteLine(primeOfAll);
                }
            else
            {
                for (int i = 2; i <= primeOfAll; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            primeBool = false;
                            break;
                        }
                    }
                    if (primeBool == true)
                    {
                        Console.WriteLine(i);
                    }
                    primeBool = true;
                }
            }
            
        }

        #endregion

        #region Exercicio 5
        public static void Exercicio5()
        {
            Console.WriteLine("Hello?");
            var i = Console.ReadLine();
            if (i == "Is it me you're looking for?")
            {
                Console.WriteLine("I can see it in your eyes");
            }
        }
        #endregion

        #region Exercicio 6
        public static void Exercicio6()
        {
            Console.WriteLine("Escolha um número entre 1 e 100, e responda às seguintes perguntas com S para Sim ou N para Não");
            int divisor = 50;
            int aglomerado = 0;
            var respostaFinal = "N";
            int i = 1;
                  
            while (divisor > 2)
            {
                Console.WriteLine("É maior que " + (aglomerado + divisor) + "?");
                var resposta = Console.ReadLine();
                if (resposta == "S")
                    aglomerado += divisor;
                else if (resposta != "N")
                    Console.WriteLine("Resposta inválida");
                divisor /= 2;
            }

            while (respostaFinal != "S")
            {
                
                Console.WriteLine("O seu número é " + (aglomerado + i) + "?");
                respostaFinal = Console.ReadLine();
                i++;
            }
            Console.WriteLine("O seu número é " + (aglomerado + i - 1) + "!");
            
        }
        #endregion

    }
}
