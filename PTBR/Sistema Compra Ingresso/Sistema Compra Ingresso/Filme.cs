using System;
using System.Collections.Generic;

namespace Sistema_Compra_Ingresso {
    internal class Filme {

        public string Nome { get; set; }
        
        public List<Sessao> Sessoes { get; set; }
        public string ClassificacaoIndicativa { get; set; }
        public string Duracao { get; set; }
        public string Genero { get; set; }
        public string Descricao { get; set; }

        public Filme (string nome, List<Sessao> sessoes, string classificacaoIndicativa, string duracao, string genero, string descricao) {
            Nome = nome;
            Sessoes = sessoes;
            ClassificacaoIndicativa = classificacaoIndicativa;
            Duracao = duracao;
            Genero = genero;
            Descricao = descricao;
        }
    }
}
