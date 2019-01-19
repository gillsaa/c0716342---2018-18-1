using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0716342
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Mary", 3.8, 20);
            StudentInformation _John = new StudentInformation("John", 2.0, 10);
            StudentInformation _Mark = new StudentInformation("Mark", 0.2, 3);
            StudentInformation _Steve = new StudentInformation("Steve", 2.9, 16);
            StudentInformation _Cindy = new StudentInformation("Cindy", 3.9, 187);
        }

        class StudentInformation
        {
            string Name;
            string StudentNumber;
            public float GPA;
        public int Attendence;
            private string v1;
            private double v2;
            private int v3;

            public StudentInformation(string aName, string bStudentNumber,float cGPA,int dAttendence)
        {
            Name = aName;
            StudentNumber = bStudentNumber;
            GPA = cGPA;
            Attendence = dAttendence
           
        }

            public StudentInformation(string v1, double v2, int v3)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.v3 = v3;
            }
        }
    }
}
