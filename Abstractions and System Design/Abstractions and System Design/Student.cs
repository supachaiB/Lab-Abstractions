using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions_and_System_Design
{
    internal class Student
    {
        private string student_id;
        private string major;

        public Student(string student , string major)
        {
            this.student_id = student;
            this.major = major;
        }
    }
}
