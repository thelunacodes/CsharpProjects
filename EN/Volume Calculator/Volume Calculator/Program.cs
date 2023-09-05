using System;
using System.Threading;

namespace Volume_Calculator {
    internal class Program {
        static void Main(string[] args) {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("EN");
            int option;
            double edge, radius, volume, apothem, height, length, width, heightBase, lengthBase;

            Console.WriteLine("=================================\n\tVolume Calculator\n\t      v1.0\n=================================\n");
            Console.WriteLine("Insert the number corresponding to the desired option:\n\n[1] Cube volume\n[2] Sphere volume\n[3] Cone volume\n[4] Pyramid volume (triangular base)\n[5] Pyramid volume (square base)\n[6] Pyramid volume (hexagonal base)\n[7] Cylinder volume\n[8] Parallelepiped volume\n[9] Hexagonal prism volume\n[10] Pentagonal prism volume\n[11] Triangular prism volume\n[12] Dodecahedron volume\n[13] Octahedron volume\n");

            //Input
            do {
                try {
                    Console.Write("> ");
                    option = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine("ERROR: Only numbers, please.");
                }
            } while (true);

            switch (option) {
                case 1:
                    //Cube 
                    //Edge length (test value: 12)
                    edge = DimensionsInput("Insert the length of the edge: ");
                    //Volume (expected outcome: 1728 um³)
                    volume = Math.Pow(edge, 3);
                    Console.WriteLine("The volume of the cube is: " + volume + " um²");
                    break;
                case 2:
                    //Sphere 
                    //Radius (test value: 5)
                    radius = DimensionsInput("Insert the radius of the circumference: ");
                    //Volume (expected outcome: 523,33 um³)
                    volume = Math.Round(((4 * 3.14 * Math.Pow(radius, 3)) / 3), 2);
                    Console.WriteLine("The volume of the sphere is: " + volume + " um³");
                    break;
                case 3:
                    //Cone 
                    //Radius (test value: 6)
                    radius = DimensionsInput("Insert the radius of the circumference: ");
                    //Height (test value: 8)
                    height = DimensionsInput("Insert the height of the cone: ");
                    //Volume (expected outcome: 301,44 um³)
                    volume = (Math.Round(((3.14 * Math.Pow(radius, 2) * height) / 3), 2));
                    Console.WriteLine("The volume of the cone is: " + volume + " um³");
                    break;
                case 4:
                    //Pyramid (triangular base)
                    //Base length (test value: 7)
                    lengthBase = DimensionsInput("Insert the length of the triangular base: ");
                    //Base height (test value: 2)
                    heightBase = DimensionsInput("Insert the height of the triangular base: ");
                    //Height (test value: 9)
                    height = DimensionsInput("Insert the height of the pyramid: ");
                    //Volume (expected outcome: 21 um³)
                    volume = Math.Round(((((lengthBase * heightBase) / 2) * height) / 3), 2);
                    Console.WriteLine("The volume of the pyramid with triangular base is: " + volume + " um³");
                    break;
                case 5:
                    //Pyramid (square base)
                    //Square base side length (test value: 3)
                    lengthBase = DimensionsInput("Insert the length of the sides of the square base: ");
                    //Height (test value: 6)
                    height = DimensionsInput("Insert the height of the pyramid: ");
                    //Volume (expected outcome: 18 um³)
                    volume = Math.Round(((Math.Pow(lengthBase, 2) * height) / 3), 2);
                    Console.WriteLine("The volume of the pyramid with square base is: " + volume + " um³");
                    break;
                case 6:
                    //Pyramid (hexagonal base)
                    //Comprimento lateral base (test value: 1)
                    lengthBase = DimensionsInput("Insert the length of the sides of the hexagonal base: ");
                    //Height (test value: 4)
                    height = DimensionsInput("Insert the height of the pyramid: ");
                    //Volume (expected outcome: 3,46 um³)
                    volume = Math.Round((Math.Sqrt(3) / 2) * Math.Pow(lengthBase, 2) * height, 2);
                    Console.WriteLine("The volume of the pyramid with hexagonal base is: " + volume + " um³");
                    break;
                case 7:
                    //Cylinder 
                    //Radius (test value: 2)
                    radius = DimensionsInput("Insert the radius of the cylinder: ");
                    //Height (test value: 10)
                    height = DimensionsInput("Insert the height of the cylinder: ");
                    //Volume (expected outcome: 125,6 um³)
                    volume = Math.Round(3.14 * Math.Pow(radius, 2) * height, 2);
                    Console.WriteLine("The volume of the cylinder is: " + volume + " um³");
                    break;
                case 8:
                    //Parallelepiped
                    //Length (test value: 10)
                    length = DimensionsInput("Insert the length of the parallelepiped: ");
                    //Width (test value: 6)
                    width = DimensionsInput("Insert the width of the parallelepiped: ");
                    //Height (test value: 8)
                    height = DimensionsInput("Insert the height of the parallelepiped: ");
                    //Volume (expected outcome: 480 um³)
                    volume = Math.Round(length * width * height, 2);
                    Console.WriteLine("The volume of the parallelepiped is: " + volume + " um³");
                    break;
                case 9:
                    //Hexagonal Prism
                    //Base side length (test value: 4)
                    lengthBase = DimensionsInput("Insert the length of the sides of the hexagonal base: ");
                    //Height (test value: 6) 
                    height = DimensionsInput("Insert the height of the prism: ");
                    //Volume (expected outcome: 249,42 um³)
                    volume = Math.Round(((3 * Math.Sqrt(3) / 2) * Math.Pow(lengthBase, 2) * height), 2);
                    Console.WriteLine("The volume of the hexagonal prism is: " + volume + " um³");
                    break;
                case 10:
                    //Pentagonal Prism
                    //Apothem (test value: 5,5)
                    apothem = DimensionsInput("Insert the length of the apothem: ");
                    //Base side length (test value: 8)
                    lengthBase = DimensionsInput("Insert the length of the sides of the pentagonal base: ");
                    //Height (test value: 6)
                    height = DimensionsInput("Insert the height of the prism: ");
                    //Volume (expected outcome: 660 um³)
                    volume = Math.Round((2.5 * apothem * lengthBase * height), 2);
                    Console.WriteLine("The volume of the pentagonal prism is: " + volume + " um³");
                    break;
                case 11:
                    //Triangular prism
                    //Base length (test value: 4)
                    lengthBase = DimensionsInput("Insert the length of the triangular base: ");
                    //Base height (test value: 3)
                    heightBase = DimensionsInput("Insert the height of the triangular base: ");
                    //Height (test value: 5)
                    height = DimensionsInput("Insert the height of the prism: ");
                    //Volume (expected outcome: 30 um³)
                    volume = Math.Round(0.5 * lengthBase * heightBase * height, 2);
                    Console.WriteLine("The volume of the triangular prism is: " + volume + " um³");
                    break;
                case 12:
                    //Dodecahedron
                    //Side (test value: 2)
                    length = DimensionsInput("Insert the length of the side of the dodecahedron: ");
                    //Volume (expected outcome: 61,3 um³)
                    volume = Math.Round((15 + 7 * Math.Sqrt(5)) / 4 * Math.Pow(length, 3), 2);
                    Console.WriteLine("The volume of the dodecahedron is: " + volume + " um³");
                    break;
                case 13:
                    //Octahedron
                    //Lado (test value: 4) 
                    length = DimensionsInput("Insert the length of the side of the octahedron: ");
                    //Volume (expected outcome: 30,17 um³)
                    volume = Math.Round((Math.Sqrt(2) * Math.Pow(length, 3)) / 3, 2);
                    Console.WriteLine("The volume of the octahedron is: " + volume + " um³");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
            Console.WriteLine("\nP.S: \"um\" = unity of measurement");
        }
        //Method to receive user input and deal with any exception
        public static double DimensionsInput(String msg) {
            string input = "";
            double atribute = 0;
            do {
                try {
                    Console.Write(msg);
                    input = Console.ReadLine().Replace(",", ".");
                    atribute = Convert.ToDouble(input);
                    return atribute;
                }
                catch (FormatException) {
                    Console.WriteLine("ERROR: Only numbers, please.");
                }
            } while (true);
        }

    }
}
