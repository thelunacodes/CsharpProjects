using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Sistema_Aluguel_Bike {
    internal class Program {
        static int opcao0 = 0, opcao1 = 0, opcao2 = 0, opcao3 = 0, opcao4 = 0, opcao4_b;
        static string modeloBike = "", tamanhoBike = "", corBike = "";
        static string opcaoInvalidaString = "ERRO: Opção inválida!";
        static string listaVaziaString = "ERRO: Lista vazia!";
        const string NOME_ARQUIVO = "bikes.csv";
        const string DIRETORIO = @"C:\Users\gabriel.luna\Desktop";
        static string caminho = Path.Combine(DIRETORIO, NOME_ARQUIVO);
        static bool disponivelBike;
        static double valAluguelBike, valDepositoBike;
        static List<Bicicleta> listaBicicletas = new List<Bicicleta>();
        static List<Cliente> listaClientes = new List<Cliente>();
        static List<Funcionario> listaFuncionarios = new List<Funcionario>();
        static List<string> listaLinhas = new List<string>();
        static void Main(string[] args) {
            LerArquivo();
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
                        ListarBikes();
                        opcao0 = 0;
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
        //Ler arquivo csv
        public static void LerArquivo() {
            if (!File.Exists(caminho)) {
                Console.WriteLine("ERRO: O arquivo não existe!");
            }
            try {
                using (StreamReader reader = new StreamReader(caminho)) {
                    string str = reader.ReadLine();
                    while (true) {
                        if (str == null) {
                            break;
                        }
                        char[] separator = new char[] { ';' };
                        string[] strArray = str.Split(separator);
                        listaBicicletas.Add(new Bicicleta(listaBicicletas.Count + 1, strArray[0].Trim(), strArray[1].Trim(), strArray[2].Trim(), Convert.ToDouble(strArray[3]), Convert.ToDouble(strArray[4]), Convert.ToBoolean(strArray[5])));
                        str = reader.ReadLine();
                    }
                }
                listaLinhas = File.ReadAllLines(caminho).ToList<string>();
            }
            catch (Exception exception1) {
                Console.WriteLine(exception1);
            }
        }

        //Exibir lista de bikes
        public static void ExibirLista() {
            if (listaBicicletas.Count == 0) {
                Console.WriteLine("ERRO: Não há contas para exibir.\n");
            }
            else {
                int num = 0;
                while (true) {
                    if (num >= listaBicicletas.Count) {
                        break;
                    }
                    Console.WriteLine(listaBicicletas[num].ToString());
                    num++;
                }
            }
        }

        //Listar Bikes
        public static void ListarBikes() {
            if (listaBicicletas.Count == 0) {
                Console.WriteLine(listaVaziaString);
            }
            else {
                int minIndex = 0;
                int maxIndex = 4;
                int minPage = (maxIndex + 1) / 5;
                int maxPage = Convert.ToInt32(Math.Round(Convert.ToDouble(listaBicicletas.Count) / 5) > 0 ? Math.Round(Convert.ToDouble(listaBicicletas.Count) + 1) : 1);
                int index = 0;

                do {

                    switch (opcao4) {
                        case 0:
                            Console.WriteLine("\n===================================\n\tLista de Bicicletas\n===================================\n");
                            //PÁGINA ATUAL + QUANT. PÁGINAS
                            Console.WriteLine($"Página {minPage}/{maxPage}:\n");
                            //EXIBIR BIKES
                            for (int i = 0; i < listaBicicletas.Count; i++) {
                                Console.Write($"[{listaBicicletas[i].Id}] - {listaBicicletas[i].Modelo} {listaBicicletas[i].Tamanho} ");
                                if (listaBicicletas[i].Disponivel) {
                                    Console.Write("(Disponível)");
                                }
                                else {
                                    Console.Write("(Indisponível)");
                                }
                                Console.WriteLine();
                            }
                            //OPÇÕES DE INPUT
                            Console.WriteLine("\n\nInsira o número correspondente à opção desejada: \n");
                            Console.WriteLine("[1] Acessar informações de uma bicicleta pelo ID \n[2] Remover bicicleta da lista \n[4] Página anterior \n[5] Próxima página \n[6] Sair");
                            opcao4 = InputInt("\n> ");
                            break;
                        case 1:
                            //ACESSAR INFORMAÇÕES PELO ID
                            opcao4_b = InputInt("\nInsira o ID da bicicleta: ");
                            if (opcao4_b < 0 || opcao4_b > listaBicicletas.Count - 1) {
                                Console.WriteLine(opcaoInvalidaString);
                            }
                            else {
                                Console.WriteLine("\nID: " + listaBicicletas[opcao4_b].Id);
                                Console.WriteLine("Modelo: " + listaBicicletas[opcao4_b].Modelo);
                                Console.WriteLine("Tamanho: " + listaBicicletas[opcao4_b].Tamanho);
                                Console.WriteLine("Cor: " + listaBicicletas[opcao4_b].Cor);
                                Console.WriteLine("Aluguel: R$ " + String.Format("{0:0.00}", listaBicicletas[opcao4_b].ValAluguel));
                                Console.WriteLine("Depósito: R$ " + String.Format("{0:0.00}", listaBicicletas[opcao4_b].ValDeposito));
                                if (listaBicicletas[opcao4_b].Disponivel) {
                                    Console.WriteLine("Disponível: sim");
                                }
                                else {
                                    Console.WriteLine("Disponível: não");
                                }
                            }
                            Thread.Sleep(2500);
                            break;
                        default:
                            Console.WriteLine(opcaoInvalidaString);
                            break;

                    }
                } while (true);
            }
        }
    }
}
