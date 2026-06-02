using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Trabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();

                Menu();
                Console.Write("\nQual conversão você deseja fazer : ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("\n======== CONVERSÃO DECIMAL -> BINÁRIO ========\n\n");
                        DecimalToBinário();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\n======== CONVERSÃO BINÁRIO -> DECIMAL ========\n\n");
                        BinárioToDecimal();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\n======== CONVERSÃO DECIMAL -> OCTAL ========\n\n");
                        DecimalToOctal();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("\n======== CONVERSÃO OCTAL -> DECIMAL ========\n\n");
                        OctalToDecimal();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("\n======== CONVERSÃO DECIMAL -> HEXADECIMAL ========\n\n");
                        DecimalToHex();
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write("\n======== CONVERSÃO HEXADECIMAL -> DECIMAL ========\n\n");
                        HexToDecimal();
                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case 10:

                        break;
                    case 11:

                        break;
                    case 12:

                        break;
                    default:

                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);

        }

        static void Menu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("MENU DE CONVERSÃO DE BASE");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n1.  Decimal       -->    Binário");
            Console.WriteLine("2.  Binário       -->    Decimal");
            Console.WriteLine("3.  Decimal       -->    Octal");
            Console.WriteLine("4.  Octal         -->    Decimal");
            Console.WriteLine("5.  Decimal       -->    Hexadecimal");
            Console.WriteLine("6.  Hexadecimal   -->    Decimal");
            Console.WriteLine("7.  Binário       -->    Octal");
            Console.WriteLine("8.  Octal         -->    Binário");
            Console.WriteLine("9.  Binário       -->    Hexadecimal");
            Console.WriteLine("10. Hexadecimal   -->    Binário");
            Console.WriteLine("11. Octal         -->    Hexadecimal");
            Console.WriteLine("12. Hexadecimal   -->    Octal\n");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("0.  SAIR");
            Console.WriteLine("----------------------------------------");
        }

        static void DecimalToBinário()
        {
            long[] resto = new long[64];
            long N1;
            long contIndex = 0;
            long cont2 = 0;

            Console.Write("\nInforme um número decimal para ser convertido para binário: ");
            N1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("----------------------------------------------------------------\n");

            if(N1 == 0) { Console.WriteLine("Passo 1: O número é 0, então o resultado é 0.");
            Console.Write("\n----------------------------------------------------------------\n");
            Console.Write("Resultado: 0");
            Console.Write("\n----------------------------------------------------------------\n");
            Console.ReadLine();
            return;}

            else if(N1 < 0) { Console.WriteLine("Error: O número é negativo, então o resultado é inválido para conversão.");
            Console.Write("\n----------------------------------------------------------------\n");
            Console.ReadLine();
            return;
            }


            while (N1 > 0)
            {
                cont2++;

                long resultado = N1 / 2;
                resto[contIndex] = N1 % 2;
                Console.WriteLine($"\nPasso {cont2}: {N1} / 2 -> Quociente: {resultado}, Resto: {resto[contIndex]}");

                N1 = resultado;
                contIndex++;
            }

            Console.Write($"\nPasso {cont2 + 1}: Junte os valores dos restos dos passos ");

            for (long i = cont2; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine($"{i}.");
                }
                else
                {
                    Console.Write($"{i} ,");
                }
            }

            Console.Write("\n----------------------------------------------------------------\n");
            Console.Write("Resultado: ");
            for (long i = contIndex - 1; i >= 0; i--)
            {
                Console.Write(resto[i]);
            }
            Console.Write("\n----------------------------------------------------------------\n");

            Console.ReadLine();

        }
        static void BinárioToDecimal()
        {
            string binario;
            long resultado,resultadototal = 0;
            int BaseN = 2;
            long cont2 = 0, digito, ExpoN;

            Console.Write("Informe um número binário para ser convertido para decimal: ");
            binario = Console.ReadLine();
            long tamanho = binario.Length;
            ExpoN = tamanho;
            
            Console.Write("----------------------------------------------------------------\n");
            for (int i = 0; i < binario.Length; i++)
            {
                ExpoN--;
                cont2++;

                long potencia = CalculoPotencia(BaseN, ExpoN);
                digito = Convert.ToInt32(binario[i].ToString());
                resultado = digito * potencia;
                resultadototal = resultadototal + resultado;
                Console.WriteLine($"\nPasso {cont2}: {digito} * {BaseN}^{ExpoN} -> Resultado do Calculo: {resultado} ");

                
            }
            Console.Write($"\nPasso {cont2 + 1}: Some o resultado dos passos  ");
            for (int i = 1; i <= cont2; i++)
            {
                if (i == cont2)
                {
                    Console.WriteLine($"{i}.");
                }
                else
                {
                    Console.Write($"{i},");
                }
            }
            Console.Write("\n----------------------------------------------------------------\n");
            Console.Write($"Resultado: {resultadototal}");
            Console.Write("\n----------------------------------------------------------------\n");
            Console.ReadLine();
        }
        static void DecimalToOctal() {
            long[] resto = new long[64];
            long N1;
            long contIndex = 0;
            long cont2 = 0;

            Console.Write("\nInforme um número decimal para ser convertido para octal: ");
            N1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("----------------------------------------------------------------\n");

            if (N1 == 0)
            {
                Console.WriteLine("Passo 1: O número é 0, então o resultado é 0.");
                Console.Write("\n----------------------------------------------------------------\n");
                Console.Write("Resultado: 0");
                Console.Write("\n----------------------------------------------------------------\n");
                Console.ReadLine();
                return;
            }

            while (N1 > 0)
            {
                cont2++;

                long resultado = N1 / 8;
                resto[contIndex] = N1 % 8;
                Console.WriteLine($"\nPasso {cont2}: {N1} / 8 -> Quociente: {resultado}, Resto: {resto[contIndex]}");

                N1 = resultado;
                contIndex++;
            }

            Console.Write($"\nPasso {cont2 + 1}: Junte os valores dos restos dos passos ");

            for (long i = cont2; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine($"{i}.");
                }
                else
                {
                    Console.Write($"{i} ,");
                }
            }

            Console.Write("\n----------------------------------------------------------------\n");
            Console.Write("Resultado: ");
            for (long i = contIndex - 1; i >= 0; i--)
            {
                Console.Write(resto[i]);
            }
            Console.Write("\n----------------------------------------------------------------\n");

            Console.ReadLine();


        }

        static void OctalToDecimal()
        {
            string octal;
            long resultado, resultadototal = 0;

            long cont2 = 0, digito, ExpoN;
            int BaseN = 8;

            Console.Write("Informe um número binário para ser convertido para decimal: ");
            octal = Console.ReadLine();
            int tamanho = octal.Length;
            ExpoN = tamanho;

            Console.Write("----------------------------------------------------------------\n");
            for (int i = 0; i < octal.Length; i++)
            {
                ExpoN--;
                cont2++;

                long potencia = CalculoPotencia(BaseN, ExpoN);
                digito = Convert.ToInt32(octal[i].ToString());
                resultado = digito * potencia;
                resultadototal = resultadototal + resultado;
                Console.WriteLine($"\nPasso {cont2}: {digito} * {BaseN}^{ExpoN} -> Resultado do Calculo: {resultado} ");


            }
            Console.Write($"\nPasso {cont2 + 1}: Some o resultado dos passos  ");
            for (int i = 1; i <= cont2; i++)
            {
                if (i == cont2)
                {
                    Console.WriteLine($"{i}.");
                }
                else
                {
                    Console.Write($"{i},");
                }
            }
            Console.Write("\n----------------------------------------------------------------\n");
            Console.Write($"Resultado: {resultadototal}");
            Console.Write("\n----------------------------------------------------------------\n");
            Console.ReadLine();

        }

        static void DecimalToHex()
        {
            string[] hexLetras = { "A", "B", "C", "D", "E", "F" };
            char[] restoC = new char[16];
            long N1;
            long contIndex;
            long cont2 = 0;
            

            Console.Write("\nInforme um número decimal para ser convertido para hexadecimal: ");
            N1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("----------------------------------------------------------------\n");

            if (N1 == 0)
            {
                Console.WriteLine("Passo 1: O número é 0, então o resultado é 0.");
                Console.Write("\n----------------------------------------------------------------\n");
                Console.Write("Resultado: 0");
                Console.Write("\n----------------------------------------------------------------\n");
                Console.ReadLine();
                return;
            }

            while (N1 > 0)
            {
                cont2++;

                if (N1 % 16 >= 10 & N1 % 16 <= 15)
                {
                    contIndex = (N1 % 16) - 10;

                    long resultado = N1 / 16;
                    Console.WriteLine($"\nPasso {cont2}: {N1} / 16 -> Quociente: {resultado}, Resto: {hexLetras[contIndex]}");
                    restoC[cont2 - 1] = Convert.ToChar(hexLetras[contIndex]); 
                    N1 = resultado;
                }
                else
                {
                    long resultado = N1 / 16;
                    long resto = N1 % 16;

                    Console.WriteLine($"\nPasso {cont2}: {N1} / 16 -> Quociente: {resultado}, Resto: {resto}");
                    restoC[cont2 - 1] = Convert.ToChar(resto.ToString());
                    N1 = resultado;
                }

            }
            

            Console.Write($"\nPasso {cont2 + 1}: Junte os valores dos restos dos passos ");

            for (long i = cont2; i > 0; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine($"{i}.");
                }
                else
                {
                    Console.Write($"{i} ,");
                }
            }

            Console.Write("\n----------------------------------------------------------------\n");
            Console.Write("Resultado: ");
            for (long i = cont2 - 1; i >= 0; i--)
            {
                Console.Write(restoC[i]);
            }
            Console.Write("\n----------------------------------------------------------------\n");



            Console.ReadLine();


        }

        static void HexToDecimal()
        {
            char[] hexLetras = { 'A',  'B', 'C', 'D', 'E', 'F'};

            int BaseN = 16;
            long ExpoN;
            long cont2 = 0;
            long resultadoT = 0;

            Console.Write("\nInforme um número hexadecimal para ser convertido para decimal: ");
            string hexN = Convert.ToString(Console.ReadLine());
            string hexNUpper = hexN.ToUpper();
            Console.Write("----------------------------------------------------------------\n");

            char[] caracteres = hexNUpper.ToCharArray();

            for(int i = 0; i < caracteres.Length; i++)
            {
                cont2++;
                ExpoN = caracteres.Length - cont2;

                if (caracteres[i] >= 'A' && caracteres[i] <= 'F')
                {
                    int Index = Array.IndexOf(hexLetras, caracteres[i]);
                    int conversao = Index + 10;
                    long potencia = CalculoPotencia(BaseN, ExpoN);
                    long resultado = conversao * potencia;
                    
                    Console.Write($"\nPasso {cont2}: {caracteres[i]} -> Valor Decimal: {conversao} * {BaseN}^{ExpoN} -> Resultado do Calculo: {resultado}");
                    resultadoT = resultadoT + resultado;
                }

                else if (caracteres[i] >= '0' && caracteres[i] <= '9')
                {
                    int conversao = Convert.ToInt32(caracteres[i].ToString());
                    long potencia = CalculoPotencia(BaseN, ExpoN);
                    long resultado = conversao * potencia;

                    Console.Write($"\nPasso {cont2}: {caracteres[i]} -> Valor Decimal: {conversao} * {BaseN}^{ExpoN} -> Resultado do Calculo: {resultado}");
                    resultadoT = resultadoT + resultado;
                }

                else
                {
                    Console.WriteLine("\n--------------------------------------------------------------------\n");
                    Console.WriteLine($"Error: O caractere \"{caracteres[i]}\" é inválido. A conversão não pode ser realizada.");
                    Console.WriteLine("--------------------------------------------------------------------\n");
                    Console.ReadLine();
                    return;
                }

            }

            Console.Write($"\nPasso {cont2 + 1}: Some o resultado dos calculos dos passos ");

            for (long i = 1; i <= cont2; i++)
            {
                if (i == cont2)
                {
                    Console.Write($"{i}.");
                }
                else
                {
                    Console.Write($"{i},");
                }
            }

            Console.Write("\n----------------------------------------------------------------\n");
            Console.Write($"Resultado: {resultadoT}");
            Console.Write("\n----------------------------------------------------------------\n");
            Console.ReadLine();

        }

        static void BinárioToOctal()
        {
        }

        static void OctalToBinário()
        {
        }
        static long CalculoPotencia(int BaseN,long ExpoN)
        {
            long resultadoPotencia = 1;

            for(long i = 0; i < ExpoN; i++)
            {
                resultadoPotencia = resultadoPotencia * BaseN;
            }

            return resultadoPotencia;
        }

        
    }
}
