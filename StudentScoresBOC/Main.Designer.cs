namespace StudentScoresBOC
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStudents = new System.Windows.Forms.Label();
            this.lsbxMain = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnAdd_Main = new System.Windows.Forms.Button();
            this.btnUpdate_Main = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit_Main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(9, 7);
            this.lblStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(52, 13);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.Text = "Students:";
            // 
            // lsbxMain
            // 
            this.lsbxMain.FormattingEnabled = true;
            this.lsbxMain.Location = new System.Drawing.Point(11, 32);
            this.lsbxMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbxMain.Name = "lsbxMain";
            this.lsbxMain.Size = new System.Drawing.Size(239, 95);
            this.lsbxMain.TabIndex = 1;
            this.lsbxMain.SelectedIndexChanged += new System.EventHandler(this.lsbxMain_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(118, 147);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Score Total:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(114, 171);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(69, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Score Count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(102, 194);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(81, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Score Average:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(186, 145);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(64, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TabStop = false;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(186, 169);
            this.txtCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(64, 20);
            this.txtCount.TabIndex = 6;
            this.txtCount.TabStop = false;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(186, 194);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(64, 20);
            this.txtAverage.TabIndex = 7;
            this.txtAverage.TabStop = false;
            // 
            // btnAdd_Main
            // 
            this.btnAdd_Main.Location = new System.Drawing.Point(273, 32);
            this.btnAdd_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd_Main.Name = "btnAdd_Main";
            this.btnAdd_Main.Size = new System.Drawing.Size(74, 27);
            this.btnAdd_Main.TabIndex = 8;
            this.btnAdd_Main.Text = "Add New";
            this.btnAdd_Main.UseVisualStyleBackColor = true;
            this.btnAdd_Main.Click += new System.EventHandler(this.btnAdd_Main_Click);
            // 
            // btnUpdate_Main
            // 
            this.btnUpdate_Main.Location = new System.Drawing.Point(273, 76);
            this.btnUpdate_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate_Main.Name = "btnUpdate_Main";
            this.btnUpdate_Main.Size = new System.Drawing.Size(74, 27);
            this.btnUpdate_Main.TabIndex = 9;
            this.btnUpdate_Main.Text = "Update";
            this.btnUpdate_Main.UseVisualStyleBackColor = true;
            this.btnUpdate_Main.Click += new System.EventHandler(this.btnUpdate_Main_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(273, 122);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 27);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit_Main
            // 
            this.btnExit_Main.Location = new System.Drawing.Point(284, 190);
            this.btnExit_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit_Main.Name = "btnExit_Main";
            this.btnExit_Main.Size = new System.Drawing.Size(74, 27);
            this.btnExit_Main.TabIndex = 11;
            this.btnExit_Main.Text = "Exit";
            this.btnExit_Main.UseVisualStyleBackColor = true;
            this.btnExit_Main.Click += new System.EventHandler(this.btnExit_Main_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 228);
            this.Controls.Add(this.btnExit_Main);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate_Main);
            this.Controls.Add(this.btnAdd_Main);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lsbxMain);
            this.Controls.Add(this.lblStudents);
            this.Name = "frmMain";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.ListBox lsbxMain;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnAdd_Main;
        private System.Windows.Forms.Button btnUpdate_Main;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit_Main;
    }
}

