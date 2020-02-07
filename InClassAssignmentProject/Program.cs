using System;

namespace InClassAssignmentProject {
    class Program {
        static void Main(string[] args) {
            var accounting = new Major(100, "Accounting", 1000);
            var business = new Major(200, "Business", 1000);
            var engineering = new Major(300,"Engineering", 1200);
            accounting.Print();
            business.Print();
            engineering.Print();

            }
        }
    }
