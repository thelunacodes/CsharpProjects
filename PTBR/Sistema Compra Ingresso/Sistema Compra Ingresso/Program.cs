using System;
using System.Collections.Generic;
using System.Media;

namespace Sistema_Compra_Ingresso {
    internal class Program {
        static void Main(string[] args) {
            List<Filme> filmes = new List<Filme>();
            int opcao1 = 0, opcao2 = 0;

            
            //Filmes
            filmes.Add(NovoFilme("Filme1", "Livre", "2h30min", "Masculino", "Descrição do filme blablabla"));
            do {
                //Introdução
                Console.WriteLine("=============================\n\t  Compra de\n\tIngresso v0.0\n=============================\n");
                Console.WriteLine("Insira o número correspondente ao filme que você deseja assistir: \n");

                //Exibir filmes "em cartaz"
                ExibirFilmes(filmes);

                //Escolha de filme
                do {
                    opcao1 = InputInt("\n> ");
                    if (opcao1 < 1 || opcao1 > (filmes.Count + 1)) {
                        Console.WriteLine("ERRO: Opção inválida!");
                    } else {
                        break;
                    }
                } while (true) ;
                if (opcao1 == (filmes.Count + 1)) {
                    //SAIR
                    break;
                } else {
                    //Exibir filme escolhido
                    Console.WriteLine($"\nNome: {filmes[opcao1 - 1].Nome}");
                    Console.WriteLine($"Duração: {filmes[opcao1 - 1].Duracao}");
                    Console.WriteLine($"Gênero: {filmes[opcao1 - 1].Genero}");
                    Console.WriteLine($"Descrição: {filmes[opcao1 - 1].Descricao}");
                    Console.WriteLine("\nInsira o número correspondente à sessão desejada: \n");
                    ExibirSessoes(filmes[opcao1 - 1].Sessoes);
                    //Escolha de sessão
                    do {
                        opcao2 = InputInt("\n> ");
                        if (opcao2 < 1 || opcao2 > (filmes[opcao1-1].Sessoes.Count + 1)) {
                            Console.WriteLine("ERRO: Opção inválida!");
                        } else {
                            break;
                        }
                        if (opcao2 == (filmes[opcao1].Sessoes.Count + 1)) {
                            //SAIR
                            break;
                        } else {

                        }
                    } while (true);
                    

                }




            } while (true);
            
            
            //Escolha de Poltrona
            //Tipo de ingresso
            //Confirmação
        }

        //=======================
        //        Métodos
        //=======================

        //Método que gera um valor booleano aleatório
        static bool RandomBoolean() {
            Random random = new Random();
            int n = random.Next(100);
            Console.WriteLine(n);
            if (n %2 == 0) {
                return false;
            } else {
                return true;
            }
        }

        //Método que cria uma nova instância do objeto filme
        static Filme NovoFilme(string nome, string classificacao, string duracao, string genero, string descricao) {
            List<Sessao> listaSessoes = new List<Sessao>();
            Random random = new Random();
            string[] minutos = { "00", "05", "10", "15", "20", "25", "30", "35", "40" };
            string randHorario = "00:00";

            //Adicionar elementos a essa lista
            for (int i = 14; i < 22; i++) {
                //Gerar horário com base no valor de "i" e um elemento aleatório da lista de minutos
                randHorario = Convert.ToString(i) + ":" + minutos[random.Next(minutos.Length)];
                //Adicionar sessão à lista
                listaSessoes.Add(new Sessao(randHorario, random.Next(1, 23), random.Next(0, 100), random.Next(0, 100)));
            }
            //Criar a instância do objeto Filme
            Filme filmasso = new Filme(nome, listaSessoes, classificacao, duracao, genero, descricao);
            return filmasso;
        }

        //Método que lida com inputs do tipo int
        static int InputInt(string msg) {
            int n = 0;

            do {
                try {
                    Console.Write(msg);
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine("ERRO: Apenas números, por favor.");
                }
            } while (true);
            return n;
        }

        //Método que exibe os filmes "em cartaz"
        static void ExibirFilmes(List<Filme> filmes) {
            for (int i = 0; i < filmes.Count; i++) {
                Console.WriteLine($"[{i + 1}] - {filmes[i].Nome}");
            }
            Console.WriteLine($"[{filmes.Count + 1}] - Sair");
        }
        
        //Método que exibe todas as sessões do filme em questão
        static void ExibirSessoes(List<Sessao> sessoes) {
            for (int i = 0; i < sessoes.Count; i++) {
                Console.Write($"[{i+1}] - {sessoes[i].Horario}, Sala {sessoes[i].SalaNum}");
                if (sessoes[i].TresDe % 2 == 0) {
                    Console.Write(", 3D");
                } 
                if (sessoes[i].Dublado % 2 == 0) {
                    Console.Write(", Dublado");
                } else {
                    Console.Write(", Legendado");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"[{sessoes.Count + 1}] - Sair");
        }
    }
}
