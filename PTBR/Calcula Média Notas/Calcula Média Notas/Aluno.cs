using System;

namespace Calculadora_Média_Notas {
    internal class Aluno {
        public string Nome { get; set; }
        public double Nota { get; set; }
        public int Peso { get; set; }

        public Aluno(string nome, double nota, int peso) {
            Nome = nome;
            Nota = nota;
            Peso = peso;
        }
    }
}
