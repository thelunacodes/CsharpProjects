using System;
using System.Collections.Generic;
using System.Threading;

namespace Sistema_Aluguel_Bike {
    internal class Program {
        static void Main(string[] args) {
            int opcao0 = 0;
            int opcao1 = 0;
            int opcao2 = 0;
            int opcao3 = 0;
            int opcao4 = 0, opcao4_B = 0;
            string modeloBike = "", tamanhoBike = "", corBike = "";
            string opcaoInvalidaString = "ERRO: Opção inválida!";
            string listaVaziaString = "ERRO: Lista vazia!";
            bool disponivelBike;
            double valAluguelBike, valDepositoBike;
            List<Bicicleta> listaBicicletas = new List<Bicicleta>();
            List<Cliente> listaClientes = new List<Cliente>();
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            //Placeholder Bike
            listaBicicletas.Add(new Bicicleta(listaBicicletas.Count, "modelo", "tamanho", "cor", 420.00, 69.00, true));

            do {
                switch (opcao0) {
                    case 0:
                        //INTRODUÇÃO + OPÇÕES
                        Console.WriteLine("==============================\n\tAluguel de Bike\n\t     v0.0\n==============================\n");
                        Console.WriteLine("Insira o número correspondente à opção desejada: \n");
                        Console.WriteLine("[1] Adicionar bike \n[2] Adicionar funcionário \n[3] Alugar bike \n[4] Listar bikes \n[5] Listar funcionários \n[6] Alugar bike\n[7] Histórico de aluguel\n[8] Histórico de manutenção\n[9] Histórico Clientes \n[10] Sair");
                        opcao0 = InputInt("\n> ");
                        break;
                    case 1:
                        //ADICIONAR BIKE
                        //modelo
                        modeloBike = InputString("Insira o modelo da bike: ");
                        //tamanho 
                        Console.WriteLine("Insira o tamanho da bike: \n");
                        Console.WriteLine("[1] Pequeno\n[2] Médio\n[3] Grande");
                        do {
                            opcao1 = InputInt("\n> ");
                            if (opcao1 < 1 || opcao1 > 3) {
                                Console.WriteLine(opcaoInvalidaString);
                            } else {
                                break;
                            }
                        } while (true);
                        if (opcao1 == 1) {
                            tamanhoBike = "Pequeno";
                        } else if (opcao1 == 2) {
                            tamanhoBike = "Médio";
                        } else if (opcao1 == 3) {
                            tamanhoBike = "Grande";
                        }
                        //cor
                        corBike = InputString("Insira a cor da bike: ");
                        //val aluguel
                        valAluguelBike = InputDouble("Insira o valor de aluguel: ");
                        //val depósito
                        valDepositoBike = InputDouble("Insira o valor de depósito: ");
                        //criar objeto
                        listaBicicletas.Add(new Bicicleta(listaBicicletas.Count, modeloBike, tamanhoBike, corBike, valAluguelBike, valDepositoBike, true));
                        opcao0 = 0;
                        break;
                    case 2:
                        //ADICIONAR FUNCIONÁRIO
                        break;
                    case 3:
                        //ALUGAR BIKE
                        break;
                    case 4:
                        //LISTAR BIKES
                        if (listaBicicletas.Count == 0) {
                            Console.WriteLine(listaVaziaString);
                            opcao0 = 0;
                        } else {
                            int minIndex = 0;
                            int maxIndex = 4;
                            int minPage = (maxIndex + 1) / 5;
                            int maxPage = Convert.ToInt32(Math.Round(Convert.ToDouble(listaBicicletas.Count) / 5 ) > 0 ? Math.Round(Convert.ToDouble(listaBicicletas.Count) + 1) : 1);
                            int index = 0;

                            do {
                                //INTRO + EXIBIR ITENS + OPÇÕES
                                Console.WriteLine("\n===================================\n\tLista de Bicicletas\n===================================\n");
                                Console.WriteLine($"Página {minPage}/{maxPage}:\n");
                                for (int i = 0; i < listaBicicletas.Count; i++) {
                                    Console.Write($"[{listaBicicletas[i].Id}] - {listaBicicletas[i].Modelo} {listaBicicletas[i].Tamanho} ");
                                    if (listaBicicletas[i].Disponivel) {
                                        Console.Write("(Disponível)");
                                    } else {
                                        Console.Write("(Indisponível)");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine("\n\nInsira o número correspondente à opção desejada: \n");
                                Console.WriteLine("[1] Acessar informações de uma bicicleta pelo ID \n[2] Remover bicicleta da lista \n[4] Página anterior \n[5] Próxima página \n[6] Sair");
                                do {
                                    opcao4 = InputInt("\n> ");
                                    if (opcao4 < 1 || opcao4 > 6) {
                                        Console.WriteLine(opcaoInvalidaString);
                                    } else {
                                        break;
                                    }
                                } while (true);
                                //ACESSAR INFORMAÇÕES PELO ID
                                if (opcao4 == 1) {
                                    opcao4_B = InputInt("\nInsira o ID da bicicleta: ");
                                    if (opcao4_B < 0 || opcao4_B > listaBicicletas.Count - 1) {
                                        Console.WriteLine(opcaoInvalidaString);
                                    }
                                    else {
                                        Console.WriteLine("\nID: " + listaBicicletas[opcao4_B].Id);
                                        Console.WriteLine("Modelo: " + listaBicicletas[opcao4_B].Modelo);
                                        Console.WriteLine("Tamanho: " + listaBicicletas[opcao4_B].Tamanho);
                                        Console.WriteLine("Cor: " + listaBicicletas[opcao4_B].Cor);
                                        Console.WriteLine("Aluguel: R$ " + String.Format("{0:0.00}", listaBicicletas[opcao4_B].ValAluguel));
                                        Console.WriteLine("Depósito: R$ " + String.Format("{0:0.00}", listaBicicletas[opcao4_B].ValDeposito));
                                        if (listaBicicletas[opcao4_B].Disponivel) {
                                            Console.WriteLine("Disponível: sim");
                                        }
                                        else {
                                            Console.WriteLine("Disponível: não");
                                        }
                                    }
                                    Thread.Sleep(2500);
                                } else if (opcao4 == 2) {
                                    
                                } else if (opcao4 == 6) {
                                    opcao0 = 0;
                                    break;
                                } 
                            } while (true);
                        }
                        break;
                    case 5:
                        //LISTAR FUNCIONÁRIO
                        break;
                    case 6:
                        //ALUGAR BIKE
                        break;
                    case 7:
                        //HISTÓRICO DE ALUGUEL
                        break;
                    case 8:
                        //HISTÓRICO DE MANUTENÇÃO
                        break;
                    case 9:
                        //HISTÓRICO DE CLIENTES
                        break;
                    case 10:
                        break;
                    default:
                        Console.WriteLine(opcaoInvalidaString);
                        opcao0 = 0;
                        break;
                }
                

                if (opcao0 == 10) {
                    break;
                }
            } while (true);
            
        }

        /* 
           =======================
                   Métodos
           ======================= 
        */

        //Input int
        static int InputInt(string inputMsg) {
            int atributo = 0;
            do {
                try {
                    Console.Write(inputMsg); 
                    atributo = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine("ERRO: Apenas números, por favor.");
                }
            } while (true);
            return atributo;
        }
        //Input double
        static double InputDouble(string inputMsg) {
            double atributo = 0;
            do {
                try {
                    Console.Write(inputMsg);
                    atributo = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine("ERRO: Apenas números, por favor.");
                }
            } while (true);
            return atributo;
        }
        //Input string
        static string InputString(string inputMsg) {
            string atributo = "";
            do {
                Console.Write(inputMsg);
                atributo = Console.ReadLine().Trim();
                if (atributo.Length != 0) {
                    break;
                }
            } while (true);
            return atributo;
        }
    }
}
