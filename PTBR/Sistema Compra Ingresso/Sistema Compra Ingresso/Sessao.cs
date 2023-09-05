using System;
using System.Collections.Generic;

namespace Sistema_Compra_Ingresso {
    internal class Sessao {
        public string Horario { get; set; }
        public int SalaNum { get; set; }
        public bool TresDe { get; set; }
        public bool Dublado { get; set; }

        public Sessao(string horario, int salaNum, bool tresDe, bool dublado) {
            Horario = horario;
            SalaNum = salaNum;
            TresDe = tresDe;
            Dublado = dublado;
        }
    }
}
