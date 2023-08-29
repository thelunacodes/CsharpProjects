using System;

namespace Average_Score_Calculator {
    internal class Student {
        public string Name { get; set; }
        public double Score { get; set; }
        public int Weight { get; set; }

        public Student(string name, double score, int weight) {
            Name = name;
            Score = score;
            Weight = weight;
        }
    }
}
