using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoresBOC.Library
{
    public class Student
    {
        public string Name { get; set; }

        public List<int> scores = new List<int>();

        //------------------------------------------------------
        //Constructors

        public Student ()
        {

        }

        public Student(string sName, int sScore)
        {
            Name = sName;
            AddScore(sScore);
        }

        //-------------------------------------------------------
        //Methods

        public void AddScore(int newScore)
        {
            scores.Add(newScore);
        }


    }

    public class StudentList
    {
        public static List<Student> students = new List<Student>();

        //-----------------------------------------------------------
        //Methods

        public static void AddStudent(Student newStudent)
        {
            students.Add(newStudent);
        }

        public static void RemoveStudent(Student newStudent)
        {
            students.Remove(newStudent);
        }
    }
}
