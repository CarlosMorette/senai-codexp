﻿using System;

namespace Exercício_7 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Aula Vetores - Exercício 5\n\n");

            int[] vetor1 = new int[10];
            int indice = 0;
            int maior = 0;
            for (int i = 0; i <= 9; i++) {
                Console.Write ($"Insira o {i+1} valor: ");
                vetor1[i] = int.Parse (Console.ReadLine ());
                //maior = vetor1[i];
                if (maior < vetor1[i]) {
                    indice = i;
                    maior = vetor1[i];
                }
            }
            Console.WriteLine($"{maior} é o maior número, índice = {indice} ");
            

        }
    }
}