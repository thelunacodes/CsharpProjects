using System;

namespace Calculadora_de_Volume_Geral {
    internal class Program {
        static void Main(string[] args) {
            int opcao;
            double aresta, raio, volume, apotema, altura, comprimento, largura;
            double alturaBase, comprimentoBase;

            Console.WriteLine("\n=====================================\n\tCalculadora de Volume\n\t\tv1.0\n=====================================\n");
            Console.WriteLine("Insira o número correspondente à opção desejada:\n[0] Sair\n[1] Volume de um Cubo\n[2] Volume de uma esfera\n[3] Volume de um Cone\n[4] Volume de uma Pirâmide (base triangular)\n[5] Volume de uma Pirâmide (base quadrada)\n[6] Volume de uma Pirâmide (base hexagonal)\n[7] Volume de um Cilindro\n[8] Volume de um Paralelepipedo\n[9] Volume de um Prisma Hexagonal\n[10] Volume de um Prisma Pentagonal\n[11] Volume de um Prisma Triângular\n[12] Volume de um Tiroide (circular)\n[13] Volume de um Tiroide (quadrado)\n[14] Volume de um Dodecaedro\n[15] Volume de um Octaedro");

            //Input
            do {
                try {
                    Console.Write("\n> ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine("ERRO: Insira apenas números, por favor.");
                }
            } while (true);

            switch (opcao) {
                case 0:
                    //Sair 
                    Console.WriteLine("Tchau!");
                    break;
                case 1:
                    //Cubo 
                    //Comprimento arestas
                    do {
                        try {
                            Console.Write("Insira o comprimento das arestas (em cm): ");
                            aresta = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Pow(aresta, 3);
                    Console.WriteLine("O volume do cubo é: " + volume + " cm³");
                    break;
                case 2:
                    //Esfera 
                    //Raio
                    do {
                        try {
                            Console.Write("Insira o valor do raio (em cm): ");
                            raio = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Round(((4 * 3.14 * Math.Pow(raio, 3)) / 3), 2);
                    Console.WriteLine("O volume da esfera é: " + volume + " cm³");
                    break;
                case 3:
                    //Cone 
                    //Raio
                    do {
                        try {
                            Console.Write("Insira o valor do raio (em cm): ");
                            raio = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Altura
                    do {
                        try {
                            Console.Write("Insira o valor da altura (em cm): ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = (Math.Round(((3.14 * Math.Pow(raio, 2) * altura) / 3), 2));
                    Console.WriteLine("O volume do cone é: " + volume + " cm³");
                    break;
                case 4:
                    //Pirâmide (base triangular) 
                    //Comprimento base
                    do {
                        try {
                            Console.Write("Insira o comprimento da base (em cm): ");
                            comprimentoBase = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Altura base
                    do {
                        try {
                            Console.Write("Insira a altura da base (em cm): ");
                            alturaBase = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Altura
                    do {
                        try {
                            Console.Write("Insira a altura da pirâmide (em cm): ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Round(((((comprimentoBase * alturaBase) / 2) * altura) / 3), 2);
                    Console.WriteLine("O volume da Pirâmide é: " + volume + " cm³");
                    break;
                case 5:
                    //Pirâmide (base quadrada)
                    //Comprimento lateral base
                    do {
                        try {
                            Console.Write("Insira o comprimento da lateral da base (em cm): ");
                            comprimentoBase = Convert.ToDouble(Console.ReadLine());
                            break;
                        } catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true) ;
                    //Altura
                    do {
                        try {
                            Console.Write("Insira a altura da pirâmide (em cm): ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Round(((Math.Pow(comprimentoBase, 2) * altura) / 3), 2);
                    Console.WriteLine("O volume da Pirâmide é: " + volume + " cm³");
                    break;
                case 6:
                    //Pirâmide (base hexagonal) 
                    //Comprimento lateral base
                    do {
                        try {
                            Console.Write("Insira o comprimento da lateral da base (em cm): ");
                            comprimentoBase = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Altura
                    do {
                        try {
                            Console.Write("Insira a altura da pirâmide (em cm): ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Round((Math.Sqrt(3) / 2) * Math.Pow(comprimentoBase, 2) * altura, 2);
                    Console.WriteLine("O volume da Pirâmide (base hexagonal) é: " + volume + " cm³");
                    break;
                case 7:
                    //Cilindro 
                    //Raio
                    do {
                        try {
                            Console.Write("Insira o raio do cilindro (em cm): ");
                            raio = Convert.ToDouble(Console.ReadLine());    
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Altura
                    do {
                        try {
                            Console.Write("Insira a altura do cilindro (em cm): ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Round(3.14 * Math.Pow(raio, 2) * altura, 2);
                    Console.WriteLine("O volume do cilindro é: " + volume + " cm³");
                    break;
                case 8:
                    //Paralelepipedo
                    //Comprimento
                    do {
                        try {
                            Console.Write("Insira o comprimento do paralelepipedo (em cm): ");
                            comprimento = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Largura
                    do {
                        try {
                            Console.Write("Insira a largura do paralelepipedo (em cm): ");
                            largura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Altura
                    do {
                        try {
                            Console.Write("Insira a altura do paralelepipedo (em cm): ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Round(comprimento * largura * altura, 2);
                    Console.WriteLine("O volume do paralelepipedo é: " + volume + " cm³");
                    break;
                case 9:
                    //Prisma Hexagonal
                    //Comprimento lateral base
                    do {
                        try {
                            Console.Write("Insira o comprimento da lateral da base (em cm): ");
                            comprimentoBase = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");

                        }
                    } while (true);
                    //Altura 
                    do {
                        try {
                            Console.Write("Insira a altura do prisma (em cm): ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Round(((3 * Math.Sqrt(3) / 2) *  Math.Pow(comprimentoBase, 2) * altura), 2);
                    Console.WriteLine("O volume do prisma hexagonal é " + volume + " cm³");
                    break;
                case 10:
                    //Prisma Pentagonal 
                    //Apótema
                    do {
                        try {
                            Console.Write("Insira o comprimento do apótema (em cm): ");
                            apotema = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Comprimento Lateral Base
                    do {
                        try {
                            Console.Write("Insira o comprimento da lateral da base (em cm): ");
                            comprimentoBase = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Altura
                    do {
                        try {
                            Console.Write("Insira a altura do prisma (em cm): ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException) {
                            Console.WriteLine("ERRO: Insira apenas números, por favor.");
                        }
                    } while (true);
                    //Volume
                    volume = Math.Round(2.5 * apotema * comprimentoBase * altura, 2);
                    Console.WriteLine("O volume do prisma pentagonal: " + volume + " cm³");
                    break;
                case 11:
                    //Prisma Triângular => 1/2 * base * altura do triângulo * altura do prisma
                    break;
                case 12:
                    //Tiroide (circular) => 2 * pi ao quadrado * raio da circuferência ao quadrado * raio de revolução
                    break;
                case 13:
                    //Tiroide (quadrado) => 2 * pi * raio * área do quadrado
                    break;
                case 14:
                    //Dodecaedro => (15 + 7√5) / 4 * lado ao cubo
                    break;
                case 15:
                    //Octaedro => √2 / 3 * lado
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
