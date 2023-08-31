using System;
using System.Threading;

namespace Calculadora_Volume {
    internal class Program {
        static void Main(string[] args) {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            int opcao;
            double aresta, raio, volume, apotema, altura, comprimento, largura, alturaBase, comprimentoBase;

            Console.WriteLine("=====================================\n\tCalculadora de Volume\n\t\tv1.0\n=====================================\n");
            Console.WriteLine("Insira o número correspondente à opção desejada:\n\n[1] Volume de um Cubo\n[2] Volume de uma esfera\n[3] Volume de um Cone\n[4] Volume de uma Pirâmide (base triangular)\n[5] Volume de uma Pirâmide (base quadrada)\n[6] Volume de uma Pirâmide (base hexagonal)\n[7] Volume de um Cilindro\n[8] Volume de um Paralelepipedo\n[9] Volume de um Prisma Hexagonal\n[10] Volume de um Prisma Pentagonal\n[11] Volume de um Prisma Triângular\n[12] Volume de um Dodecaedro\n[13] Volume de um Octaedro\n");

            //Input
            do {
                try {
                    Console.Write("> ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine("ERRO: Insira apenas números, por favor.");
                }
            } while (true);

            switch (opcao) {
                case 1:
                    //Cubo 
                    //Comprimento arestas (valor de teste: 12)
                    aresta = InputDimensoes("Insira o comprimento das arestas: ");
                    //Volume (resultado esperado: 1728 um³)
                    volume = Math.Pow(aresta, 3);
                    Console.WriteLine("O volume do cubo é: " + volume + " um²");
                    break;
                case 2:
                    //Esfera 
                    //Raio (valor de teste: 5)
                    raio = InputDimensoes("Insira o valor do raio: ");
                    //Volume (resultado esperado: 523,33 um³)
                    volume = Math.Round(((4 * 3.14 * Math.Pow(raio, 3)) / 3), 2);
                    Console.WriteLine("O volume da esfera é: " + volume + " um³");
                    break;
                case 3:
                    //Cone 
                    //Raio (valor de teste: 6)
                    raio = InputDimensoes("Insira o valor do raio: ");
                    //Altura (valor de teste: 8)
                    altura = InputDimensoes("Insira o valor da altura: ");
                    //Volume (resultado esperado: 301,44 um³)
                    volume = (Math.Round(((3.14 * Math.Pow(raio, 2) * altura) / 3), 2));
                    Console.WriteLine("O volume do cone é: " + volume + " um³");
                    break;
                case 4:
                    //Pirâmide (base triangular) 
                    //Comprimento base (valor de teste: 7)
                    comprimentoBase = InputDimensoes("Insira o comprimento da base triangular: ");
                    //Altura base (valor de teste: 2)
                    alturaBase = InputDimensoes("Insira a altura da base triangular: ");
                    //Altura (valor de teste: 9)
                    altura = InputDimensoes("Insira a altura da pirâmide: ");
                    //Volume (resultado esperado: 21 um³)
                    volume = Math.Round(((((comprimentoBase * alturaBase) / 2) * altura) / 3), 2);
                    Console.WriteLine("O volume da pirâmide de base triangular é: " + volume + " um³");
                    break;
                case 5:
                    //Pirâmide (base quadrada)
                    //Comprimento lateral base (valor de teste: 3)
                    comprimentoBase = InputDimensoes("Insira o comprimento de um dos lados da base quadrada: ");
                    //Altura (valor de teste: 6)
                    altura = InputDimensoes("Insira a altura da pirâmide: ");
                    //Volume (resultado esperado: 18 um³)
                    volume = Math.Round(((Math.Pow(comprimentoBase, 2) * altura) / 3), 2);
                    Console.WriteLine("O volume da pirâmide de base quadrada é: " + volume + " um³");
                    break;
                case 6:
                    //Pirâmide (base hexagonal) 
                    //Comprimento lateral base (valor de teste: 1)
                    comprimentoBase = InputDimensoes("Insira o comprimento de um dos lados da base hexagonal: ");
                    //Altura (valor de teste: 4)
                    altura = InputDimensoes("Insira a altura da pirâmide: ");
                    //Volume (resultado esperado: 3,46 um³)
                    volume = Math.Round((Math.Sqrt(3) / 2) * Math.Pow(comprimentoBase, 2) * altura, 2);
                    Console.WriteLine("O volume da pirâmide de base hexagonal é: " + volume + " um³");
                    break;
                case 7:
                    //Cilindro 
                    //Raio (valor de teste: 2)
                    raio = InputDimensoes("Insira o raio do cilindro: ");
                    //Altura (valor de teste: 10)
                    altura = InputDimensoes("Insira a altura do cilindro: ");
                    //Volume (resultado esperado: 125,6 um³)
                    volume = Math.Round(3.14 * Math.Pow(raio, 2) * altura, 2);
                    Console.WriteLine("O volume do cilindro é: " + volume + " um³");
                    break;
                case 8:
                    //Paralelepipedo
                    //Comprimento (valor de teste: 10)
                    comprimento = InputDimensoes("Insira o comprimento do paralelepipedo: ");
                    //Largura (valor de teste: 6)
                    largura = InputDimensoes("Insira a largura do paralelepipedo: ");
                    //Altura (valor de teste: 8)
                    altura = InputDimensoes("Insira a altura do paralelepipedo: ");
                    //Volume (resultado esperado: 480 um³)
                    volume = Math.Round(comprimento * largura * altura, 2);
                    Console.WriteLine("O volume do paralelepipedo é: " + volume + " um³");
                    break;
                case 9:
                    //Prisma Hexagonal
                    //Comprimento lateral base (valor de teste: 4)
                    comprimentoBase = InputDimensoes("Insira o comprimento de um dos lados da base hexagonal: ");
                    //Altura (valor de teste: 6) 
                    altura = InputDimensoes("Insira a altura do prisma: ");
                    //Volume (resultado esperado: 249,42 um³)
                    volume = Math.Round(((3 * Math.Sqrt(3) / 2) * Math.Pow(comprimentoBase, 2) * altura), 2);
                    Console.WriteLine("O volume do prisma hexagonal é: " + volume + " um³");
                    break;
                case 10:
                    //Prisma Pentagonal 
                    //Apótema (valor de teste: 5,5)
                    apotema = InputDimensoes("Insira o comprimento do apótema: ");
                    //Comprimento Lateral Base (valor de teste: 8)
                    comprimentoBase = InputDimensoes("Insira o comprimento de um dos lados da base pentagonal: ");
                    //Altura (valor de teste: 6)
                    altura = InputDimensoes("Insira a altura do prisma: ");
                    //Volume (resultado esperado: 660 um³)
                    volume = Math.Round(2.5 * apotema * comprimentoBase * altura, 2);
                    Console.WriteLine("O volume do prisma pentagonal é: " + volume + " um³");
                    break;
                case 11:
                    //Prisma Triângular
                    //Comprimento base (valor de teste: 4)
                    comprimentoBase = InputDimensoes("Insira o comprimento da base triangular: ");
                    //Altura base (valor de teste: 3)
                    alturaBase = InputDimensoes("Insira a altura da base triangular: ");
                    //Altura prisma (valor de teste: 5)
                    altura = InputDimensoes("Insira a altura do prisma: ");
                    //Volume (resultado esperado: 30 um³)
                    volume = Math.Round(0.5 * comprimentoBase * alturaBase * altura, 2);
                    Console.WriteLine("O volume do prisma triangular é: " + volume + " um³");
                    break;
                case 12:
                    //Dodecaedro
                    //Lado (valor de teste: 2)
                    comprimento = InputDimensoes("Insira o comprimento de um dos lados do dodecaedro: ");
                    //Volume (resultado esperado: 61,3 um³)
                    volume = Math.Round((15 + 7 * Math.Sqrt(5)) / 4 * Math.Pow(comprimento, 3), 2);
                    Console.WriteLine("O volume do dodecaedro é: " + volume + " um³");
                    break;
                case 13:
                    //Octaedro
                    //Lado (valor de teste: 4) 
                    comprimento = InputDimensoes("Insira o comprimento de um dos lados do octaedro: ");
                    //Volume (resultado esperado: 30,17 um³)
                    volume = Math.Round((Math.Sqrt(2) * Math.Pow(comprimento, 3)) / 3, 2);
                    Console.WriteLine("O volume do octaedro é: " + volume + " um³");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("\nObs: \"um\" = unidade de medida");
        }
        //Método pra receber input e lidar com erros
        public static double InputDimensoes(String msg) {
            string input = "";
            double atributo = 0;
            do {
                try {
                    Console.Write(msg);
                    input = Console.ReadLine().Replace(".", ",");
                    atributo = Convert.ToDouble(input);
                    return atributo;
                }
                catch (FormatException) {
                    Console.WriteLine("ERRO: Insira apenas números, por favor.");
                }
            } while (true);
        }

    }
}
