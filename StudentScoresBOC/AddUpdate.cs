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
            Student student = StudentList.students[selected];
            student.AddScore(Convert.ToInt32(txtScoreAddUpdate.Text));

            this.Close();
        }

        private void btnCancelAddUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
