using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string numeros = @"
            //         __  __        __   __  __   __   __   __ 
            //      |  __| __| |__| |__  |__    | |__| |__| |  |
            //      | |__  __|    |  __| |__|   | |__|  __| |__|
            //";
            string[] numeroParteAcima = { " __ ", "    ", " __ ", " __ ", "    ", " __ ", " __ ", " __ ", " __ ", " __ " };
            string[] numeroParteMedia = { "|  |", "   |", " __|", " __|", "|__|", "|__ ", "|__ ", "   |", "|__|", "|__|" };
            string[] numeroParteBaixo = { "|__|", "   |", "|__ ", " __|", "   |", " __|", "|__|", "   |", "|__|", " __|" };
            string entradas = @"
                 __  __  __  __  __      __  __  
                |__ |__    ||__||__|   | __| __||__|
                 __||__|   ||__| __|   ||__  __|   |

                 __      __  __      __  __  __  __ 
                 __||__|   ||__|   | __||__ |__ |__|
                 __|   |   ||__|   ||__  __||__| __|

                 __  __  __  __  __      __  __     
                 __| __||__ |__ |__||__|   ||__|   |
                 __||__  __||__| __|   |   ||__|   |

                 __  __  __  __  __  __      __     
                |  | __||__ |__    ||__|   ||__||__|
                |__||__  __||__|   ||__|   | __|   |
            ";
            //025678194
            string imprimir = "";
            int quantidadeLinhasComCaracteres = 4;
            int quantidadeDeCaracteresPorLinha = 9;
            string[] caracteresPorLinhaSeparados = new string[quantidadeDeCaracteresPorLinha];
            StringReader linhas = new StringReader(entradas);
            

            for (int x = 0; x < quantidadeLinhasComCaracteres; x++)
            {
                linhas.ReadLine();
                string linha1String = linhas.ReadLine().Trim();
                string linha2String = linhas.ReadLine().Trim();
                string linha3String = linhas.ReadLine().Trim();

                string[] linha1Letras = new string[9];
                string[] linha2Letras = new string[9];
                string[] linha3Letras = new string[9];

                for (int i = linha1String.Length; i < (quantidadeDeCaracteresPorLinha * 4); i++)
                    linha1String += " ";
                for (int i = linha2String.Length; i < (quantidadeDeCaracteresPorLinha * 4); i++)
                    linha2String += " ";
                for (int i = linha3String.Length; i < (quantidadeDeCaracteresPorLinha * 4); i++)
                    linha3String += " ";

                if (linha1String[0] == '_')
                    linha1String = " "+linha1String;
                if (linha2String[0] == '_')
                    linha2String = " "+linha2String;
                if (linha3String[0] == '_')
                    linha3String = " "+linha3String;

                #region linha 1
                int minimo = 0, maximo = 3, posicaoLetra = 0;
                for (int i = 0; i < (linha1String.Length - 1); i++)
                {
                    if (minimo == maximo)
                    {
                        maximo += 4;
                        posicaoLetra++;
                        linha1Letras[posicaoLetra] += Convert.ToChar(linha1String[i]).ToString();
                    }
                    else
                    {
                        linha1Letras[posicaoLetra] += Convert.ToChar(linha1String[i]).ToString();
                        minimo = i;
                    }
                }
                #endregion linha 1

                #region linha 2
                minimo = 0;
                maximo = 3;
                posicaoLetra = 0;

                for (int i = 0; i < (linha2String.Length - 1); i++)
                {
                    if (minimo == maximo)
                    {
                        maximo += 4;
                        posicaoLetra++;
                        linha2Letras[posicaoLetra] += Convert.ToChar(linha2String[i]).ToString();
                    }
                    else
                    {
                        linha2Letras[posicaoLetra] += Convert.ToChar(linha2String[i]).ToString();
                        minimo = i;
                    }
                }
                #endregion

                #region linha 3
                minimo = 0;
                maximo = 3;
                posicaoLetra = 0;

                for (int i = 0; i < (linha3String.Length - 1); i++)
                {
                    if (minimo == maximo)
                    {
                        maximo += 4;
                        posicaoLetra++;
                        linha3Letras[posicaoLetra] += Convert.ToChar(linha3String[i]).ToString();
                    }
                    else
                    {
                        linha3Letras[posicaoLetra] += Convert.ToChar(linha3String[i]).ToString();
                        minimo = i;
                    }
                }
                #endregion
                
                string conjuntoNumero = "";
                
                for (int i = 0; i < 9; i++)
                {
                    if (linha1Letras[i] == numeroParteAcima[0] && linha2Letras[i] == numeroParteMedia[0] && linha3Letras[i] == numeroParteBaixo[0])
                    {
                        conjuntoNumero += " 0";
                    }
                    else if(linha1Letras[i] == numeroParteAcima[1] && linha2Letras[i] == numeroParteMedia[1] && linha3Letras[i] == numeroParteBaixo[1])
                    {
                        conjuntoNumero += " 1";
                    }
                    else if (linha1Letras[i] == numeroParteAcima[2] && linha2Letras[i] == numeroParteMedia[2] && linha3Letras[i] == numeroParteBaixo[2])
                    {
                        conjuntoNumero += " 2";
                    }
                    else if (linha1Letras[i] == numeroParteAcima[3] && linha2Letras[i] == numeroParteMedia[3] && linha3Letras[i] == numeroParteBaixo[3])
                    {
                        conjuntoNumero += " 3";
                    }
                    else if (linha1Letras[i] == numeroParteAcima[4] && linha2Letras[i] == numeroParteMedia[4] && linha3Letras[i] == numeroParteBaixo[4])
                    {
                        conjuntoNumero += " 4";
                    }
                    else if (linha1Letras[i] == numeroParteAcima[5] && linha2Letras[i] == numeroParteMedia[5] && linha3Letras[i] == numeroParteBaixo[5])
                    {
                        conjuntoNumero += " 5";
                    }
                    else if (linha1Letras[i] == numeroParteAcima[6] && linha2Letras[i] == numeroParteMedia[6] && linha3Letras[i] == numeroParteBaixo[6])
                    {
                        conjuntoNumero += " 6";
                    }
                    else if (linha1Letras[i] == numeroParteAcima[7] && linha2Letras[i] == numeroParteMedia[7] && linha3Letras[i] == numeroParteBaixo[7])
                    {
                        conjuntoNumero += " 7";
                    }
                    else if (linha1Letras[i] == numeroParteAcima[8] && linha2Letras[i] == numeroParteMedia[8] && linha3Letras[i] == numeroParteBaixo[8])
                    {
                        conjuntoNumero += " 8";
                    }
                    else if (linha1Letras[i] == numeroParteAcima[9] && linha2Letras[i] == numeroParteMedia[9] && linha3Letras[i] == numeroParteBaixo[9])
                    {
                        conjuntoNumero += " 9";
                    }
                }
                for (int y = 0; y <  linha1String.Length; y++)
                    Console.Write("{0}", linha1String[y]);
                Console.WriteLine();
                for(int y = 0; y <  linha2String.Length - 1; y++)
                    Console.Write("{0}", linha2String[y]);
                Console.WriteLine();
                for (int y = 0; y <  linha3String.Length; y++)
                    Console.Write("{0}", linha3String[y]);
                Console.WriteLine();

                Console.WriteLine("{0}", conjuntoNumero);
            }


            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
