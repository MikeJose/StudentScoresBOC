using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentScoresBOC.Library;

namespace StudentScoresBOC.Library.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Student_AddScore()
        {
            //Arrange
            int input = 1;
            Student testStudent = new Student();

            //Act
           testStudent.AddScore(input);

            //Assert
            Assert.IsTrue(testStudent.scores.Contains(input));
        }

        [Test]
        public void StudentList_AddStudent()
        {
            Student testStudent = new Student();

            StudentList.AddStudent(testStudent);

            Assert.IsTrue(StudentList.students.Contains(testStudent));
        }

        [Test]
        public void StudentList_RemoveStudent()
        {
            Student testStudent = new Student();

            StudentList.AddStudent(testStudent);
            StudentList.RemoveStudent(testStudent);

            Assert.IsFalse(StudentList.students.Contains(testStudent));
            
        }
    }
}
