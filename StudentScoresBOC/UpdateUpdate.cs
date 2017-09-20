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
    public partial class UpdateUpdate : Form
    {
        //private variables 

        private int selectedStudent;
        private int selectedScore;

        //---------------------------------------------------------------
        //Constructors

        public UpdateUpdate()
        {
            InitializeComponent();
        }

        public UpdateUpdate(int studentIndex, int scoreIndex)
        {
            InitializeComponent();

            selectedStudent = studentIndex;
            selectedScore = scoreIndex;
        }

        //----------------------------------------------------------------
        //Button Clicks

        private void btnCancelUpUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateUpUp_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                if(Convert.ToInt32(txtScoreUpdateUpdate.Text) < 101 && Convert.ToInt32(txtScoreUpdateUpdate.Text) > 0)
                {
                    Student student = StudentList.students[selectedStudent];
                    student.RemoveScore(selectedScore);
                    student.AddScore(Convert.ToInt32(txtScoreUpdateUpdate.Text));

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Must be 0-100", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtScoreUpdateUpdate.Text = "";
                    txtScoreUpdateUpdate.Focus();
                }
            }           
        }

        //-------------------------------------------------------------------
        //Validator

        private bool IsValid()
        {
            if (txtScoreUpdateUpdate.Text != "")
            {
                try
                {
                    Convert.ToInt32(txtScoreUpdateUpdate.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Only numeric characters are valid", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtScoreUpdateUpdate.Text = "";
                    txtScoreUpdateUpdate.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a score", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //--------------------------------------------------------------------
    }
}
