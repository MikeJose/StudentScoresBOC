using StudentScoresBOC.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentScoresBOC;

namespace StudentScoresBOC
{
    public partial class frmMain : Form
    {
        private bool isClearing = false;
        private int currentSelected;

        public frmMain()
        {
            InitializeComponent();            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DefaultStudents();            
        }

        //-------------------------------------------
        //Button Clicks

        private void btnAdd_Main_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            addStudentForm.ShowDialog();
            OnReturn();
        }

        private void btnUpdate_Main_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent(GetSelectedStudent(), currentSelected);
            updateStudent.ShowDialog();
            OnReturn();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lsbxMain.SelectedIndex;
            StudentList.RemoveStudent(StudentList.students[index]);
            OnReturn();
        }

        private void btnExit_Main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------------
        //Methods

        private Student GetSelectedStudent()
        {
            return StudentList.students[currentSelected];
        }

        private void OnReturn()
        {
            ClearListBox();
            isClearing = false;
            FillListBox();
            lsbxMain.SelectedIndex = 0;
        }

        private void FillListBox()
        {
            foreach(Student student in StudentList.students)
            {
                string allScores = "";
                foreach(int score in student.scores)
                {
                    allScores += score.ToString() + ", ";
                }
                lsbxMain.Items.Add(student.Name + "-" + allScores);
            }
        }

        private void HandleMathDisplay()
        {
            if(isValid())
            {
                int index = lsbxMain.SelectedIndex;
                Student selectedStudent = StudentList.students[index];

                int totalScoress = 0;
                int numScores = 0;
                int avgScores = 0;

                foreach(int score in selectedStudent.scores)
                {
                    totalScoress += score;
                    numScores++;
                }
                avgScores = totalScoress / numScores;

                txtTotal.Text = totalScoress.ToString();
                txtCount.Text = numScores.ToString();
                txtAverage.Text = avgScores.ToString();
            }
            else
            {
                txtTotal.Text = "0";
                txtCount.Text = "0";
                txtAverage.Text = "0";
            }
        }

        private bool isValid()
        {
            if(lsbxMain.Items.Count <= 0)
            {
                return false;
            }
            return true;
        }

        private void DefaultStudents()
        {
            Student matt = new Student("Matt Brigs", 95);
            Student chris = new Student("Chris Kole", 97);
            Student brian = new Student("Brian Wilks", 94);

            StudentList.AddStudent(matt);
            StudentList.AddStudent(chris);
            StudentList.AddStudent(brian);

            FillListBox();
                                                
            lsbxMain.SelectedIndex = 0;
        }

        private void ClearListBox()
        {
            isClearing = true;

            int currentItems = lsbxMain.Items.Count;

            for (int i = 0; i < currentItems; i++)
            {
                lsbxMain.Items.RemoveAt(0);
            }
        }

        private void lsbxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isClearing == false)
            {
                HandleMathDisplay();
            }

            currentSelected = lsbxMain.SelectedIndex;
        }

        //-------------------------------------------
    }
}
