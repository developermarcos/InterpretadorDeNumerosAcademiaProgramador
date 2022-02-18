using System;
using System.IO;
using System.Collections.Generic;

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
            string entradas = @"
                 __  __  __  __  __      __  __  
                |__ |__    ||__||__|   | __| __||__|
                 __||__|   ||__| __|   ||__  __|   |
            ";
            
            StringReader linhas = new StringReader(entradas);
            linhas.ReadLine();
            //Console.WriteLine(linha1String.Substring(0, 4));

            string linha1String = linhas.ReadLine().Trim();
            string linha2String = linhas.ReadLine().Trim();
            string linha3String = linhas.ReadLine().Trim();
            string[] linha1Letras = new string[9];
            string[] linha2Letras = new string[9];
            string[] linha3Letras = new string[9];
            if (linha1String[0] == '_')
                linha1String = " "+linha1String;
            if (linha2String[0] == '_')
                linha2String = " "+linha2String;
            if (linha3String[0] == '_')
                linha3String = " "+linha3String;

            #region linha 1
            int minimo = 0, maximo = 3, posicaoLetra = 0;
            for (int i = 0; i < linha1String.Length; i++)
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

            for (int i = 0; i < linha2String.Length; i++)
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

            for (int i = 0; i < linha3String.Length; i++)
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


            
            Console.Write("Linha 1: ");
            Console.WriteLine("{0}", linha1String);
            Console.Write("Linha 2: ");
            Console.WriteLine("{0}", linha2String);
            Console.Write("Linha 3: ");
            Console.WriteLine("{0}", linha3String);
           
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Posicao {0}", i);
                Console.WriteLine("{0}", linha1Letras[i]);
                Console.WriteLine("{0}", linha2Letras[i]);
                Console.WriteLine("{0}", linha3Letras[i]);
            }
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
