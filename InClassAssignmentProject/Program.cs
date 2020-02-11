using System;

namespace InClassAssignmentProject {
    class Program {
        static void Main(string[] args) {

            var majors = new Major[] {
                new Major(100, "Accounting", 1000),
                new Major(200, "Business", 1000),
                new Major(300, "Engineering", 1200),
                new Major(400, "Math", 1300),
                new Major(500, "Education", 1100)
            };

            for (var idx = 0; idx < majors.Length; idx++) {
                var major = majors[idx];
                major.Print();
                }
            var students = new Student[] {
                new Student(4, "Howard", "Hess", 1600, 3.70,majors[2]),
                new Student(3, "Adam", "Ant", 1300, 3.20, majors[0]),
                new Student(6, "James", "Joyce", 1100, 2.50, majors[1]),
                new Student(5, "Fred", "Flintstone", 1000, 2.00, majors[1])
                };
            foreach (var student in students) {
                student.Print();
                }
            }
        }//class====================================================================================
    }
