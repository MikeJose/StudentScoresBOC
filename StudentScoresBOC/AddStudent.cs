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
    public partial class AddStudent : Form
    {
        //Private Variables

        private List<int> currentScores = new List<int>();
        
        public AddStudent()
        {
            InitializeComponent();

            txtNameAddStudent.Focus();
        }

        //----------------------------------------------------------------
        //Button Clicks

        private void btnOkAddStudent_Click(object sender, EventArgs e)
        {
            if(txtNameAddStudent.Text != "")
            {
                Student newStudent = new Student();
                newStudent.Name = txtNameAddStudent.Text;

                foreach(int score in currentScores)
                {
                    newStudent.AddScore(score);
                }
                StudentList.AddStudent(newStudent);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameAddStudent.Focus();
            }
            
        }

        private void btnCancelAddStudent_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            this.Close();
        }

        private void btnClearAddStudent_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            txtNameAddStudent.Focus();
        }

        private void btnAddScoreAddStudent_Click(object sender, EventArgs e)
        {
           if(ScoreValid())
            {
                if(Convert.ToInt32(txtScoreAddStudent.Text) < 101 && Convert.ToInt32(txtScoreAddStudent.Text) > 0)
                {
                    currentScores.Add(Convert.ToInt32(txtScoreAddStudent.Text));
                    txtAllScoresAddStudent.Text = "";
                    foreach (int score in currentScores)
                    {
                        txtAllScoresAddStudent.Text += score.ToString() + ", ";
                    }
                    txtScoreAddStudent.Text = "";
                    txtScoreAddStudent.Focus();
                }
                else
                {
                    MessageBox.Show("Must be 0-100", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtScoreAddStudent.Text = "";
                    txtScoreAddStudent.Focus();
                } 
            }
        }

        //----------------------------------------------------------------------
        //Methods

        private void ClearAllFields()
        {
            txtNameAddStudent.Text = "";
            txtScoreAddStudent.Text = "";
            txtAllScoresAddStudent.Text = "";
        }

        private bool ScoreValid()
        {
            if(txtScoreAddStudent.Text != "")
            {
                try
                {
                    Convert.ToInt32(txtScoreAddStudent.Text);
                    return true;
                }
                catch
                {
                    MessageBox.Show("Only numeric characters are valid", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtScoreAddStudent.Text = "";
                    txtScoreAddStudent.Focus();
                    return false;
                }                
            }
            else
            {
                MessageBox.Show("Please enter a score", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //----------------------------------------------------------------------       
    }
}
