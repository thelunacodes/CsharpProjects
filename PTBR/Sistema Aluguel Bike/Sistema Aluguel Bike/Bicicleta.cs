using System;
using System.CodeDom;

namespace Sistema_Aluguel_Bike {
    internal class Bicicleta {
        public int Id {  get; set; }
        public string Modelo { get; set; }
        public string Tamanho { get; set; }
        public string Cor {  get; set; }
        public double ValAluguel { get; set; }
        public double ValDeposito { get; set; }
        public bool Disponivel { get; set; }

        public Bicicleta(int id, string modelo, string tamanho, string cor, double valAluguel, double valDeposito, bool disponivel) {
            Id = id;
            Modelo = modelo;
            Tamanho = tamanho;
            Cor = cor;
            ValAluguel = valAluguel;
            ValDeposito = valDeposito;
            Disponivel = disponivel;
        }
    }
}
