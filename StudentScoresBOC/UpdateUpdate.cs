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
            Student student = StudentList.students[selectedStudent];
            student.RemoveScore(selectedScore);
            student.AddScore(Convert.ToInt32(txtScoreUpdateUpdate.Text));

            this.Close();
        }

        //-------------------------------------------------------------------
    }
}
