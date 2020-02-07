using System;
using System.Collections.Generic;
using System.Text;

namespace InClassAssignmentProject {
    class Student {
        public int Id;
        public string Firstname;
        public string Lastname;
        public int SAT;
        public decimal GPA;
        public int MajorId;
        public Student(int id,string firstname,string lastname,int sat,decimal gpa, int majorid) {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            SAT = sat;
            GPA = gpa;
            MajorId = majorid;
            }
        public void Print() {
            Console.WriteLine($"Id={Id},Firstname={Firstname},Lastname={Lastname},SAT={SAT},GPA={GPA},MajorId={MajorId}");
            }
        }//class======================================
    }
