using System;

namespace Validador_de_IP {
    internal class Program {
        static void Main(string[] args) {
            String ip = "";
            String[] octetos = new String[4];
            int contadorDePontos = 0;
            Boolean octetoEhValido = false;

            //Input do usuário
            Console.Write("Insira um endereço de IP: ");
            ip = Console.ReadLine();
            //Contar os pontos no endereço de IP inserido
            for (int i = 0; i < ip.Length; i++) { 
                if (ip[i] == '.') {
                    contadorDePontos++;
                }
            }
            //Criar um array de octetos a partir do endereço de IP
            octetos = ip.Split('.');
            //Checar se o endereço de IP tem quatro octetos
            if (octetos.Length == 4) {
                //Checar se todos os octetos são maiores ou iguais a 0 e menores ou iguais a 255
                if ((Convert.ToInt32(octetos[0]) >= 0 && Convert.ToInt32(octetos[0]) <= 255) && 
                    (Convert.ToInt32(octetos[1]) >= 0 && Convert.ToInt32(octetos[1]) <= 255) && 
                    (Convert.ToInt32(octetos[2]) >= 0 && Convert.ToInt32(octetos[2]) <= 255) && 
                    (Convert.ToInt32(octetos[3]) >= 0 && Convert.ToInt32(octetos[3]) <= 255)) {
                    octetoEhValido = true;
                } else {
                    Console.WriteLine("IP INVÁLIDO: Todos os octetos devem estar entre 0 e 255.");
                    octetoEhValido = false;
                } 
            } else {
                Console.WriteLine("IP INVÁLIDO: O endereço de IP deve ter quatro octetos.");
                octetoEhValido = false;
            }
            if (contadorDePontos == 3 && octetoEhValido) {
                Console.WriteLine($"O IP {ip} é um endereço válido!", ip);
            } 
        }   
    }
}
