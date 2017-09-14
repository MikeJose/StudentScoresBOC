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

namespace StudentScoresBOC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            HandleMathDisplay();
        }

        //-------------------------------------------
        //Button Clicks

        private void btnAdd_Main_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Main_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Main_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------------------
        //Methods

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

        //-------------------------------------------
    }
}
