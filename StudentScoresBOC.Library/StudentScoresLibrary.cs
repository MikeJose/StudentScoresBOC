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

        public Student(string newName, int score, int scoreTwo, int scoreThree)
        {
            Name = newName;
            scores.Add(score);
            scores.Add(scoreTwo);
            scores.Add(scoreThree);
        }

        //-------------------------------------------------------
        //Methods

        public void AddScore(int newScore)
        {
            scores.Add(newScore);
        }

        public void RemoveScore(int index)
        {
            scores.RemoveAt(index);
        }


    }

    public class StudentList
    {
        public static List<Student> students = new List<Student>();

        public StudentList()
        {

        }

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
