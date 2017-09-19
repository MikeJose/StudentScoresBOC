using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentScoresBOC.Library;

namespace StudentScoresBOC
{
    public partial class UpdateStudent : Form
    {
        private int currentIndex;
        private int scoreIndex;

        public UpdateStudent()
        {
            InitializeComponent();
        }

        public UpdateStudent(Student newStudent, int studentIndex)
        {
            InitializeComponent();

            FillForm(newStudent);
            currentIndex = studentIndex;
            lsbxScoresUpdateStudent.SelectedIndex = 0;
        }

        //-------------------------------------------------------------------------
        //Button Clicks

        private void btnAddUpdateStudent_Click(object sender, EventArgs e)
        {
            AddUpdate addUpdate = new AddUpdate(currentIndex);
            addUpdate.ShowDialog();
            ClearForm();
            FillForm(StudentList.students[currentIndex]);
            SetIndex();
        }

        private void btnUpdateUpdateStudent_Click(object sender, EventArgs e)
        {
            UpdateUpdate updateUpdate = new UpdateUpdate(currentIndex, scoreIndex);
            updateUpdate.ShowDialog();
            ClearForm();
            FillForm(StudentList.students[currentIndex]);
            SetIndex();
        }

        private void btnRemoveUpdateStudent_Click(object sender, EventArgs e)
        {
            StudentList.RemoveStudent(StudentList.students[currentIndex]);
            this.Close();
        }

        private void btnClearUpdateStudent_Click(object sender, EventArgs e)
        {
            Student curStudent = StudentList.students[currentIndex];

            for (int i = 0; i < curStudent.scores.Count; i++)
            {
                curStudent.RemoveScore(0);
            }

            ClearForm();
            FillForm(StudentList.students[currentIndex]);
            SetIndex();
        }

        private void btnOkUpdateStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------------------------------------
        //Methods

        private void FillForm(Student student)
        {
            txtNameUpdateStudent.Text = student.Name;
            foreach(int score in student.scores)
            {
                lsbxScoresUpdateStudent.Items.Add(score);
            }           
        }

        private void ClearForm()
        {
            txtNameUpdateStudent.Text = "";

            int currentItems = lsbxScoresUpdateStudent.Items.Count;

            for (int i = 0; i < currentItems; i++)
            {
                lsbxScoresUpdateStudent.Items.RemoveAt(0);
            }
        }

        private void lsbxScoresUpdateStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoreIndex = lsbxScoresUpdateStudent.SelectedIndex;
        }

        private void SetIndex()
        {
            if(lsbxScoresUpdateStudent.Items.Count > 0)
            {
                lsbxScoresUpdateStudent.SelectedIndex = 0;
            }
        }

        //---------------------------------------------------------------------------
    }
}
