using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public int Type { get; set; }

        public int Type2 { get; set; }

        public string Surename { get; set; }

        public int Age { get; set; }



        public override bool Equals(System.Object otherStudent)
        {
            if (!(otherStudent is Student))
            {
                return false;
            }
            else
            {
                Student newStudent = (Student)otherStudent;
                bool descriptionEquality = (this.Id == newStudent.Id && this.Name == newStudent.Name);
                return descriptionEquality;
            }
        }


    }
}
