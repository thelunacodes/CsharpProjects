using System;
using System.Collections.Generic;
using System.Threading;

namespace Calculadora_Média_Notas {
    internal class Program {
        static void Main(string[] args) {
            List<Aluno> listaNotas = new List<Aluno>();
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            string nome, input, opcao = "";
            double nota, media, soma = 0;
            int peso;

            Console.WriteLine("==============================\n\tCalculadora de\n\t  Notas v1.0\n==============================");
            do {
                //Nome
                Console.Write("\nInsira o nome do(a) aluno(a): ");
                nome = Console.ReadLine();
                //Nota
                do {
                    try {
                        Console.Write("Insira a nota desse aluno: ");
                        input = Console.ReadLine().Replace(".", ",");
                        nota = Convert.ToDouble(input);
                        break;
                    }
                    catch (FormatException) {
                        Console.WriteLine("ERRO: Apenas números, por favor.");
                    }
                } while (true);
                //Peso
                do {
                    try {
                        Console.Write("Insira o peso dessa nota: ");
                        peso = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException) {
                        Console.WriteLine("ERRO: Apenas números inteiros, por favor.");
                    }
                } while (true);
                //Adicionar objeto à lista
                listaNotas.Add(new Aluno(nome, nota, peso)) ;
                // Continuar?
                do {
                    Console.WriteLine("\nDeseja adicionar mais notas? (S para \"sim\" ou N para \"não\").");
                    Console.Write("> ");
                    opcao = Console.ReadLine();
                    
                    switch (opcao.ToUpper()) {
                        case "S":
                            //SIM
                            break;
                        case "N":
                            //NÃO
                            if (listaNotas.Count != 0) {
                                for (int i = 0; i < listaNotas.Count; i++) {
                                    soma += (listaNotas[i].Nota * listaNotas[i].Peso);
                                }
                                media = soma / listaNotas.Count;
                                Console.WriteLine($"A média das notas é {Math.Round(media, 2)}");
                                for (int j = 0; j < listaNotas.Count; j++) {
                                    if (listaNotas[j].Nota > media) {
                                        Console.WriteLine($"{listaNotas[j].Nome} tirou uma nota cima da média!");
                                    }
                                }  
                            } else {
                                Console.WriteLine("Fim!");
                            }
                            break;
                        default:
                            //Opção inválida
                            Console.WriteLine("ERRO: Input inválido.");
                            break;
                    }
                    if ((opcao.ToUpper()).Equals("N") || (opcao.ToUpper()).Equals("S")) {
                        break;
                    }
                } while (true);
                //Break de encerramento
                if ((opcao.ToUpper()).Equals("N")) {
                    break;
                }
            } while (true);

        }
    }
}
