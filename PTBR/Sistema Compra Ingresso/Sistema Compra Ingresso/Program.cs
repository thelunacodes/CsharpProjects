using System;
using System.Collections.Generic;

namespace Sistema_Compra_Ingresso {
    internal class Program {
        static void Main(string[] args) {
            List<Filme> filmes = new List<Filme>();

            //Introdução
            Console.WriteLine("=============================\n\t  Compra de\n\tIngresso v0.0\n=============================\n");

            //Filmes
            filmes.Add(NovoFilme("Filme1", "Livre", "2h30min", "Masculino", "Descrição do filme blablabla"));

            //Filmes (nome, horário, indicação indicativa, 
            for (int i = 0; i < filmes.Count; i++) {
                //Debug
                Console.WriteLine($"Nome: {filmes[i].Nome}");
                Console.WriteLine($"Sessões: \n");
                for (int j = 0; j < filmes[i].Sessoes.Count; j++) {
                    Console.WriteLine($"{filmes[i].Sessoes[j].Horario}");
                }
                Console.WriteLine($"\nClassificação: {filmes[i].ClassificacaoIndicativa}");
                Console.WriteLine($"Duração: {filmes[i].Duracao}");
                Console.WriteLine($"Gênero: {filmes[i].Genero}");
                Console.WriteLine($"Descrição: {filmes[i].Descricao}");
            }
            //Escolha de Poltrona
            //Tipo de ingresso
            //Confirmação
        }
        static bool RandomBoolean() {
            Random random = new Random();
            int n = random.Next(2);
            return n == 1 ? true : false;
        }
        static Filme NovoFilme(string nome, string classificacao, string duracao, string genero, string descricao) {

            //Lista de Sessões
            List <Sessao> listaSessoes = new List<Sessao>();
            Random random = new Random();
            //Lista minutos
            string[] minutos = {"00", "05", "10", "15", "20", "25", "30", "35", "40" };
            string randHorario = "00:00";
            //Adicionar elementos a essa lista
            for (int i = 14; i < 22; i++) {
                //Gerar horário com base no valor de "i" e um elemento aleatório da lista de minutos
                randHorario = Convert.ToString(i) + ":" + minutos[random.Next(minutos.Length)];
                //Adicionar sessão à lista
                listaSessoes.Add(new Sessao(randHorario, random.Next(23), RandomBoolean(), RandomBoolean()));   
            }
            Filme filmasso = new Filme(nome, listaSessoes, classificacao, duracao, genero, descricao);
            return filmasso;

        }
    }
}
