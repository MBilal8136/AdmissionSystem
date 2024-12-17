using System;
using System.Collections.Generic;

namespace AdmissionSystem.Data
{
    public class StudentManager
    {
        List<Student> students= null;

        public StudentManager()
        {
            students = new List<Student>();
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }

        public List<Student> GetStudents() { 
            return students; 
        }

        public Student Search(int RollNumber)
        {
            foreach (Student student in students)
            {
                if(student.RollNumber == RollNumber) 
                    return student;
            }
            return null;
        }
    }
}
