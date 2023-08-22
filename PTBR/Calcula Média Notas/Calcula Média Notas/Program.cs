using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;

namespace Calcula_Média_Notas {
    internal class Program {
        static void Main(string[] args) {
            List<Aluno> listaNotas = new List<Aluno>();
            string nome, opcao = "";
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
                        nota = Convert.ToDouble(Console.ReadLine());
                        //Trocar "," por "."
                        
                        //if (Convert.ToString(nota).Contains(",")) {
                        //    nota = Convert.ToDouble(Convert.ToString(nota).Replace(',','.'));
                        //}
                        Console.WriteLine(nota);
                    }
                    catch (FormatException) {
                        Console.WriteLine("ERRO: Apenas números, por favor.");
                    }
                } while (true);
                //Peso
                //do {
                //    try {
                //        Console.Write("Insira o peso dessa nota: ");
                //        peso = Convert.ToInt32(Console.ReadLine());
                //        break;
                //    }
                //    catch (FormatException) {
                //        Console.WriteLine("ERRO: Apenas números inteiros, por favor.");
                //    }
                //} while (true);
                peso = 1;
                //Adicionar objeto à lista
                listaNotas.Add(new Aluno(nome, nota, peso)) ;
                //Debug
                //Console.WriteLine($"\nNome: {nome}\nNota: {nota}\nPeso: {peso}");
                Console.WriteLine(listaNotas.Count);
                // Continuar?
                do {
                    Console.WriteLine("\nDeseja adicionar mais notas? (S para \"sim\" e N para \"não\").");
                    Console.Write("> ");
                    opcao = Console.ReadLine();
                    
                    switch (opcao.ToUpper()) {
                        case "S":
                            //UH HUH (sim)
                            break;
                        case "N":
                            //NUH UH (não)
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
                            Console.WriteLine("ERRO: Opção inválida.");
                            break;
                    }
                    //Não dar "break" se o usuário inseriu uma opção inválida
                    if ((opcao.ToUpper()).Equals("N") || (opcao.ToUpper()).Equals("S")) {
                        break;
                    }
                } while (true);
                //Quebrar o do while loop se o usuário escolheu não inserir mais notas
                if ((opcao.ToUpper()).Equals("N")) {
                    break;
                }
            } while (true);

        }
    }
}
