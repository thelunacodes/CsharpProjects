using System;
using System.Collections.Generic;

namespace Sistema_Compra_Ingresso {
    internal class Sessao {
        public string Horario { get; set; }
        public int SalaNum { get; set; }
        public int TresDe { get; set; }
        public int Dublado { get; set; }

        public Sessao(string horario, int salaNum, int tresDe, int dublado) {
            Horario = horario;
            SalaNum = salaNum;
            TresDe = tresDe;
            Dublado = dublado;
        }
    }
}
