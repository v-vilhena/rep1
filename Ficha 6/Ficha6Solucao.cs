using System;

namespace Ficha6
{
    public class Ficha6Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            Console.WriteLine("Qual é o nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }
        private static void OlaNome(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num 2?");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);
        }

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

        public static void ApresentarSoma(int numA, int numB)
        {
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
        }
        #endregion

        #region Exercicio3
        public static int LerEConverter()
        {
            Console.WriteLine("Número?");
            var num = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(num);
            return numParsed;
        }

        public static void Exercicio3()
        {
            var total = LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            Console.WriteLine(total);
        }

        #endregion

        #region Exercicio4
        public static void Exercicio4()
        {
            Console.WriteLine("Estabeleça A");
            var a = Console.ReadLine();
            Console.WriteLine("Estabeleça B");
            var b = Console.ReadLine();
            var c = a;
            a = b;
            b = c;
            Console.WriteLine("A = " + a + " e B = " + b);
        }
        #endregion

        #region Exercicio5
        public static void Exercicio5()
        {
            #region 5a
            Console.WriteLine("Vamos calcular: a + b * c. Escreva a");
            var an = Console.ReadLine();
            Console.WriteLine("Agora escreva b");
            var bn = Console.ReadLine();
            Console.WriteLine("Agora escreva c");
            var cn = Console.ReadLine();

            var a = ConverterStringParaNumero(an);
            var b = ConverterStringParaNumero(bn);
            var c = ConverterStringParaNumero(cn);

            int abc = a + b * c;
            Console.WriteLine(a + " + " + b + " * " + c + " = " + abc);

            #endregion

            #region 5b
            Console.WriteLine("Vamos calcular: (d + e) % f. Escreva d");
            var dn = Console.ReadLine();
            Console.WriteLine("Agora escreva e");
            var en = Console.ReadLine();
            Console.WriteLine("Agora escreva f");
            var fn = Console.ReadLine();

            var d = ConverterStringParaNumero(dn);
            var e = ConverterStringParaNumero(en);
            var f = ConverterStringParaNumero(fn);
            
            int def = (d + e) % f;
            Console.WriteLine("(" + d + " + " + e + ")" + " * " + f + " = " + def);
            #endregion

            #region 5c
            Console.WriteLine("Vamos calcular: g + h * i / j. Escreva g");
            var gn = Console.ReadLine();
            Console.WriteLine("Agora escreva h");
            var hn = Console.ReadLine();
            Console.WriteLine("Agora escreva i");
            var inn = Console.ReadLine();
            Console.WriteLine("Agora escreva j");
            var jn = Console.ReadLine();

            var g = ConverterStringParaNumero(gn);
            var h = ConverterStringParaNumero(hn);
            var i = ConverterStringParaNumero(inn);
            var j = ConverterStringParaNumero(jn);
            
            int ghij = g + h * i / j;
            Console.WriteLine(g + " + " + h + " * " + i + " / " + j + " = " + ghij);

            #endregion

            #region 5d
            Console.WriteLine("Vamos calcular: k + l / m * n - o % p. Escreva k");
            var kn = Console.ReadLine();
            Console.WriteLine("Agora escreva l");
            var ln = Console.ReadLine();
            Console.WriteLine("Agora escreva m");
            var mn = Console.ReadLine();
            Console.WriteLine("Agora escreva n");
            var nn = Console.ReadLine();
            Console.WriteLine("Agora escreva o");
            var on = Console.ReadLine();
            Console.WriteLine("Agora escreva p");
            var pn = Console.ReadLine();

            var k = ConverterStringParaNumero(kn);
            var l = ConverterStringParaNumero(ln);
            var m = ConverterStringParaNumero(mn);
            var n = ConverterStringParaNumero(nn);
            var o = ConverterStringParaNumero(on);
            var p = ConverterStringParaNumero(pn);

            int klmnop = (k + l / m * n - o % p);
            Console.WriteLine(k + " + " + l + " / " + m + " * " + n + " - " + o + " % " + p + " = " + klmnop);

            #endregion
        }
        #endregion

        #region Exercicio6
        public static void Exercicio6()
        {
            Console.WriteLine("Introduza um número");
            var numTab = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(numTab);

            var numTab2 = numParsed * 2;
            var numTab3 = numParsed * 3;
            var numTab4 = numParsed * 4;
            var numTab5 = numParsed * 5;
            var numTab6 = numParsed * 6;
            var numTab7 = numParsed * 7;
            var numTab8 = numParsed * 8;
            var numTab9 = numParsed * 9;
            var numTab10 = numParsed * 10;

            Console.WriteLine(numTab + " * 1 = " + numTab);
            Console.WriteLine(numTab + " * 2 = " + numTab2);
            Console.WriteLine(numTab + " * 3 = " + numTab3);
            Console.WriteLine(numTab + " * 4 = " + numTab4);
            Console.WriteLine(numTab + " * 5 = " + numTab5);
            Console.WriteLine(numTab + " * 6 = " + numTab6);
            Console.WriteLine(numTab + " * 7 = " + numTab7);
            Console.WriteLine(numTab + " * 8 = " + numTab8);
            Console.WriteLine(numTab + " * 9 = " + numTab9);
            Console.WriteLine(numTab + " * 10 = " + numTab10);
        }

        #endregion

        #region Exercicio7
        public static void Exercicio7()
        {
            Console.WriteLine("Vamos calcular a média entre 2 números. Apresente o 1º");
            var uno = Console.ReadLine();
            Console.WriteLine("Apresente o 2º");
            var dos = Console.ReadLine();

            int one = ConverterStringParaNumero(uno);
            int two = ConverterStringParaNumero(dos);

            int avg = (one + two) / 2;
            Console.WriteLine("A média de " + uno + " e " + dos + " é de " + avg);
        }
        #endregion

        #region Exercicio8
        public static void Exercicio8()
        {
            Console.WriteLine("Vamos calcular a média entre 5 números. Apresente o 1º");
            var uno = Console.ReadLine();
            Console.WriteLine("Apresente o 2º");
            var dos = Console.ReadLine();
            Console.WriteLine("Apresente o 3º");
            var tres = Console.ReadLine();
            Console.WriteLine("Apresente o 4º");
            var cuatro = Console.ReadLine();
            Console.WriteLine("Apresente o 5º");
            var cinco = Console.ReadLine();

            int one = ConverterStringParaNumero(uno);
            int two = ConverterStringParaNumero(dos);
            int three = ConverterStringParaNumero(tres);
            int four = ConverterStringParaNumero(cuatro);
            int five = ConverterStringParaNumero(cinco);

            int avg = (one + two + three + four + five) / 5;
            Console.WriteLine("A média de " + uno + ", " + dos + ", " + tres + ", " + cuatro + " e " + cinco + " é de " + avg);
        }
        #endregion

        #region Exercicio9
        public static void Exercicio9()
        {
            Console.WriteLine("Vamos calcular a média entre 10 números. Apresente o 1º");
            var uno = Console.ReadLine();
            Console.WriteLine("Apresente o 2º");
            var dos = Console.ReadLine();
            Console.WriteLine("Apresente o 3º");
            var tres = Console.ReadLine();
            Console.WriteLine("Apresente o 4º");
            var cuatro = Console.ReadLine();
            Console.WriteLine("Apresente o 5º");
            var cinco = Console.ReadLine();
            Console.WriteLine("Apresente o 6º");
            var seis = Console.ReadLine();
            Console.WriteLine("Apresente o 7º");
            var siete = Console.ReadLine();
            Console.WriteLine("Apresente o 8º");
            var ocho = Console.ReadLine();
            Console.WriteLine("Apresente o 9º");
            var nueve = Console.ReadLine();
            Console.WriteLine("Apresente o 10º");
            var diez = Console.ReadLine();

            int count = 0;
            int total = 0;

            int one = ConverterStringParaNumero(uno);
            count++;
            total += one;
            int two = ConverterStringParaNumero(dos);
            count++;
            total += two;
            int three = ConverterStringParaNumero(tres);
            count++;
            total += three;
            int four = ConverterStringParaNumero(cuatro);
            count++;
            total += four;
            int five = ConverterStringParaNumero(cinco);
            count++;
            total += five;
            int six = ConverterStringParaNumero(seis);
            count++;
            total += six;
            int seven = ConverterStringParaNumero(siete);
            count++;
            total += seven;
            int eight = ConverterStringParaNumero(ocho);
            count++;
            total += eight;
            int nine = ConverterStringParaNumero(nueve);
            count++;
            total += nine;
            int ten = ConverterStringParaNumero(diez);
            count++;
            total += ten;


            int avg = total / count;
            Console.WriteLine("A média é de " + avg);
        }
        #endregion

        #region Exercicio10
        public static void Exercicio10()
        {
            Console.WriteLine("Vamos fazer uma tabela 3x3 com um caracter dado. Introduza o caracter!");
            var c = Console.ReadLine();

            Console.WriteLine(c + " " + c + " " + c + '\n' + c + " " + c + " " + c + '\n' + c + " " + c + " " + c);
        }
        #endregion

        #region Exercicio11
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
        public static void Exercicio11()
        {
            #region produto A
            Console.WriteLine("Introduza o primeiro artigo");
            var produtoA = Console.ReadLine();
            Console.WriteLine("Introduza o preço do primeiro artigo");
            var precoA = Console.ReadLine();
            Console.WriteLine("Introduza a quantidade do primeiro artigo");
            var quantA = Console.ReadLine();

            decimal precoCertoA = ConverterStringParaNumeroDecimal(precoA);
            int quantCertaA = ConverterStringParaNumero(quantA);
            decimal totalA = precoCertoA * quantCertaA;

            Console.WriteLine("O preço total de " + produtoA + " é " + totalA + '\n');
            #endregion

            #region produto B
            Console.WriteLine("Introduza o segundo artigo");
            var produtoB = Console.ReadLine();
            Console.WriteLine("Introduza o preço do segundo artigo");
            var precoB = Console.ReadLine();
            Console.WriteLine("Introduza a quantidade do segundo artigo");
            var quantB = Console.ReadLine();

            decimal precoCertoB = ConverterStringParaNumeroDecimal(precoB);
            int quantCertaB = ConverterStringParaNumero(quantB);
            decimal totalB = precoCertoB * quantCertaB;

            Console.WriteLine("O preço total de " + produtoB + " é " + totalB + '\n');

            #endregion

            #region produto C

            Console.WriteLine("Introduza o terceiro artigo");
            var produtoC = Console.ReadLine();
            Console.WriteLine("Introduza o preço do terceiro artigo");
            var precoC = Console.ReadLine();
            Console.WriteLine("Introduza a quantidade do terceiro artigo");
            var quantC = Console.ReadLine();

            decimal precoCertoC = ConverterStringParaNumeroDecimal(precoC);
            int quantCertaC = ConverterStringParaNumero(quantC);
            decimal totalC = precoCertoC * quantCertaC;

            Console.WriteLine("O preço total de " + produtoC + " é " + totalC + '\n');

            #endregion

            #region produto D

            Console.WriteLine("Introduza o quarto artigo");
            var produtoD = Console.ReadLine();
            Console.WriteLine("Introduza o preço do quarto artigo");
            var precoD = Console.ReadLine();
            Console.WriteLine("Introduza a quantidade do quarto artigo");
            var quantD = Console.ReadLine();

            decimal precoCertoD = ConverterStringParaNumeroDecimal(precoD);
            int quantCertaD = ConverterStringParaNumero(quantD);
            decimal totalD = precoCertoD * quantCertaD;

            Console.WriteLine("O preço total de " + produtoD + " é " + totalD + '\n');

            #endregion

            #region produto E
            Console.WriteLine("Introduza o quinto artigo");
            var produtoE = Console.ReadLine();
            Console.WriteLine("Introduza o preço do quinto artigo");
            var precoE = Console.ReadLine();
            Console.WriteLine("Introduza a quantidade do quinto artigo");
            var quantE = Console.ReadLine();

            decimal precoCertoE = ConverterStringParaNumeroDecimal(precoE);
            int quantCertaE = ConverterStringParaNumero(quantE);
            decimal totalE = precoCertoE * quantCertaE;

            Console.WriteLine("O preço total de " + produtoE + " é " + totalE + '\n');

            #endregion

            decimal totalTotal = totalA + totalB + totalC + totalD + totalE;

            Console.WriteLine("A lista de compras inclui os produtos:" + '\n' + produtoA + '\n' + produtoB + '\n' + produtoC + '\n' + produtoD + '\n' + produtoE);
            Console.WriteLine("O preço total é de " + totalTotal);
        }
        #endregion

        #region Exercicio2.1
        public static void Exercicio21()
        {
            Console.WriteLine("Diz-me algo que eu não saiba");
            var x = Console.ReadLine();
            Console.WriteLine("Eu já sabia que " + x);
        }
        #endregion

        #region Exercicio2.2
        public static void Exercicio22()
        {
            Console.WriteLine("Introduza dois números. Primeiro, o primeiro");
            var fstNum = Console.ReadLine();
            Console.WriteLine("E em segundo, o segundo"); 
            var sndNum = Console.ReadLine();
            Console.WriteLine("O primeiro número é " + fstNum + " e o segundo número é " + sndNum);
        }
        #endregion

        #region Exercicio2.3
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
        public static void Exercicio23()
        {
            Console.WriteLine("Introduz a temperatura");
            double temp = ConverterStringParaNumeroDouble(Console.ReadLine());
            double tempF = temp * (9 / 5) + 32;
            var tempK = temp + 273.15;

            Console.WriteLine("A temperatura " + temp + "ºC é " + tempF + "ºF e " + tempK + "ºK");
        }
        #endregion

        #region Exercicio3.1
        
        public static void Exercicio31()

        {
            Console.WriteLine("Quantas horas?");
            int horas = ConverterStringParaNumero(Console.ReadLine());
            Console.WriteLine("Quantos minutos?");
            int minutos = ConverterStringParaNumero(Console.ReadLine());
            Console.WriteLine("Quantos segundos?");
            int segundos = ConverterStringParaNumero(Console.ReadLine());

            int total = horas * 3600 + minutos * 60 + segundos;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos + " é equivalente a " + total + " segundos" + '\n');
        }
        #endregion

        #region Exercicio3.2
        public static void Exercicio32()
        {
            Console.WriteLine("Qual é o raio?");
            double raio = ConverterStringParaNumeroDouble(Console.ReadLine());

            double perimetro = 2 * 3.14 * raio;
            double area = 3.14 * raio * raio;

            Console.WriteLine("A área do círculo é " + area + " e o perímetro é " + perimetro);

        }
        #endregion
    }
}
