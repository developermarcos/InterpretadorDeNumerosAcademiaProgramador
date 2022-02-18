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



            //Console.Write(entradas);
            for (int i = 0; i < linha1Letras.Length; i++)
            {
                Console.Write(linha1Letras[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < linha2Letras.Length; i++)
            {
                Console.Write(linha2Letras[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < linha3Letras.Length; i++)
            {
                Console.Write(linha3Letras[i]);
            }

            Console.WriteLine("\nCinco: \n{0}\n{1}\n{2}", linha1Letras[0], linha2Letras[0], linha3Letras[0]);
            Console.WriteLine("\nSeis: \n{0}\n{1}\n{2}", linha1Letras[1], linha2Letras[1], linha3Letras[1]);
            Console.WriteLine("\nSete: \n{0}\n{1}\n{2}", linha1Letras[2], linha2Letras[2], linha3Letras[2]);
            Console.WriteLine("\nOito: \n{0}\n{1}\n{2}", linha1Letras[3], linha2Letras[3], linha3Letras[3]);
            Console.WriteLine("\nNove: \n{0}\n{1}\n{2}", linha1Letras[4], linha2Letras[4], linha3Letras[4]);
            Console.WriteLine("\nUm: \n{0}\n{1}\n{2}", linha1Letras[5], linha2Letras[5], linha3Letras[5]);
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
