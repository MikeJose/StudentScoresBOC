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
    public partial class AddUpdate : Form
    {
        private int selected;

        public AddUpdate()
        {
            InitializeComponent();
        }

        public AddUpdate(int index)
        {
            InitializeComponent();

            selected = index;
        }

        private void btnAddAddUpdate_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                if(Convert.ToInt32(txtScoreAddUpdate.Text) < 101 && Convert.ToInt32(txtScoreAddUpdate.Text) > 0)
                {
                    Student student = StudentList.students[selected];
                    student.AddScore(Convert.ToInt32(txtScoreAddUpdate.Text));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Must be 0-100", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtScoreAddUpdate.Text = "";
                    txtScoreAddUpdate.Focus();
                }
            }           
        }

        private void btnCancelAddUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValid()
        {
            if (txtScoreAddUpdate.Text != "")
            {
                try
                {
                    Convert.ToInt32(txtScoreAddUpdate.Text);
                    return true;
                }
                catch
                {
                    MessageBox.Show("Only numeric characters are valid", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtScoreAddUpdate.Text = "";
                    txtScoreAddUpdate.Focus();
                    return false;
                }               
            }
            MessageBox.Show("Please enter a score", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

    }
}
