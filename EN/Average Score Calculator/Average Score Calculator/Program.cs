using System;
using System.Collections.Generic;
using System.Threading;

namespace Average_Score_Calculator {
    internal class Program {
        static void Main(string[] args) {
            List<Student> scoreList = new List<Student>();
            string name, input, opcao = "";
            double score, average, sum = 0;
            int weight;

            Console.WriteLine("===============================\n\t Average Score\n\tCalculator v1.0\n===============================");
            do {
                //Name
                Console.Write("\nInsert the student's name: ");
                name = Console.ReadLine();
                //Score
                do {
                    try {
                        Console.Write("Insert the student's score: ");
                        input = Console.ReadLine().Replace(",", ".");
                        score = Convert.ToDouble(input);
                        break;
                    }
                    catch (FormatException) {
                        Console.WriteLine("ERROR: Only numbers, please.");
                    }
                } while (true);
                //Weight
                do {
                    try {
                        Console.Write("Insert the score's weight: ");
                        weight = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException) {
                        Console.WriteLine("ERROR: Only integers, please.");
                    }
                } while (true);
                //Add object to list
                scoreList.Add(new Student(name, score, weight));
                //Continue?
                do {
                    Console.WriteLine("\nWould you like to add more scores? (Y for \"yes\" or N for \"no\").");
                    Console.Write("> ");
                    opcao = Console.ReadLine();

                    switch (opcao.ToUpper()) {
                        case "Y":
                            //YES
                            break;
                        case "N":
                            //NO
                            if (scoreList.Count != 0) {
                                for (int i = 0; i < scoreList.Count; i++) {
                                    sum += (scoreList[i].Score * scoreList[i].Weight);
                                }
                                average = sum / scoreList.Count;
                                Console.WriteLine($"The average score is: {Math.Round(average, 2)}");
                                for (int j = 0; j < scoreList.Count; j++) {
                                    if (scoreList[j].Score > average) {
                                        Console.WriteLine($"{scoreList[j].Name} scored above average!");
                                    }
                                }
                            }
                            else {
                                Console.WriteLine("The end!");
                            }
                            break;
                        default:
                            //Invalid input
                            Console.WriteLine("Error: Invalid input.");
                            break;
                    }
                    if ((opcao.ToUpper()).Equals("Y") || (opcao.ToUpper()).Equals("N")) {
                        break;
                    }
                } while (true);
                //Exit Break
                if ((opcao.ToUpper()).Equals("N")) {
                    break;
                }
            } while (true);

        }
    }
}
