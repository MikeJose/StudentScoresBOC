namespace StudentScoresBOC
{
    partial class AddStudent
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
            this.lblNameAddStudent = new System.Windows.Forms.Label();
            this.lblScoreAddStudent = new System.Windows.Forms.Label();
            this.lblAllScoresAddStudent = new System.Windows.Forms.Label();
            this.txtNameAddStudent = new System.Windows.Forms.TextBox();
            this.txtScoreAddStudent = new System.Windows.Forms.TextBox();
            this.txtAllScoresAddStudent = new System.Windows.Forms.TextBox();
            this.btnAddScoreAddStudent = new System.Windows.Forms.Button();
            this.btnClearAddStudent = new System.Windows.Forms.Button();
            this.btnCancelAddStudent = new System.Windows.Forms.Button();
            this.btnOkAddStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameAddStudent
            // 
            this.lblNameAddStudent.AutoSize = true;
            this.lblNameAddStudent.Location = new System.Drawing.Point(12, 12);
            this.lblNameAddStudent.Name = "lblNameAddStudent";
            this.lblNameAddStudent.Size = new System.Drawing.Size(38, 13);
            this.lblNameAddStudent.TabIndex = 0;
            this.lblNameAddStudent.Text = "Name:";
            // 
            // lblScoreAddStudent
            // 
            this.lblScoreAddStudent.AutoSize = true;
            this.lblScoreAddStudent.Location = new System.Drawing.Point(12, 47);
            this.lblScoreAddStudent.Name = "lblScoreAddStudent";
            this.lblScoreAddStudent.Size = new System.Drawing.Size(38, 13);
            this.lblScoreAddStudent.TabIndex = 1;
            this.lblScoreAddStudent.Text = "Score:";
            // 
            // lblAllScoresAddStudent
            // 
            this.lblAllScoresAddStudent.AutoSize = true;
            this.lblAllScoresAddStudent.Location = new System.Drawing.Point(7, 82);
            this.lblAllScoresAddStudent.Name = "lblAllScoresAddStudent";
            this.lblAllScoresAddStudent.Size = new System.Drawing.Size(43, 13);
            this.lblAllScoresAddStudent.TabIndex = 2;
            this.lblAllScoresAddStudent.Text = "Scores:";
            // 
            // txtNameAddStudent
            // 
            this.txtNameAddStudent.Location = new System.Drawing.Point(56, 9);
            this.txtNameAddStudent.Name = "txtNameAddStudent";
            this.txtNameAddStudent.Size = new System.Drawing.Size(139, 20);
            this.txtNameAddStudent.TabIndex = 3;
            // 
            // txtScoreAddStudent
            // 
            this.txtScoreAddStudent.Location = new System.Drawing.Point(56, 44);
            this.txtScoreAddStudent.Name = "txtScoreAddStudent";
            this.txtScoreAddStudent.Size = new System.Drawing.Size(139, 20);
            this.txtScoreAddStudent.TabIndex = 4;
            // 
            // txtAllScoresAddStudent
            // 
            this.txtAllScoresAddStudent.Location = new System.Drawing.Point(56, 79);
            this.txtAllScoresAddStudent.Name = "txtAllScoresAddStudent";
            this.txtAllScoresAddStudent.ReadOnly = true;
            this.txtAllScoresAddStudent.Size = new System.Drawing.Size(234, 20);
            this.txtAllScoresAddStudent.TabIndex = 5;
            this.txtAllScoresAddStudent.TabStop = false;
            // 
            // btnAddScoreAddStudent
            // 
            this.btnAddScoreAddStudent.Location = new System.Drawing.Point(215, 47);
            this.btnAddScoreAddStudent.Name = "btnAddScoreAddStudent";
            this.btnAddScoreAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddScoreAddStudent.TabIndex = 6;
            this.btnAddScoreAddStudent.Text = "Add Score";
            this.btnAddScoreAddStudent.UseVisualStyleBackColor = true;
            this.btnAddScoreAddStudent.Click += new System.EventHandler(this.btnAddScoreAddStudent_Click);
            // 
            // btnClearAddStudent
            // 
            this.btnClearAddStudent.Location = new System.Drawing.Point(215, 12);
            this.btnClearAddStudent.Name = "btnClearAddStudent";
            this.btnClearAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnClearAddStudent.TabIndex = 7;
            this.btnClearAddStudent.Text = "Clear Scores";
            this.btnClearAddStudent.UseVisualStyleBackColor = true;
            this.btnClearAddStudent.Click += new System.EventHandler(this.btnClearAddStudent_Click);
            // 
            // btnCancelAddStudent
            // 
            this.btnCancelAddStudent.Location = new System.Drawing.Point(215, 121);
            this.btnCancelAddStudent.Name = "btnCancelAddStudent";
            this.btnCancelAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddStudent.TabIndex = 8;
            this.btnCancelAddStudent.Text = "Cancel";
            this.btnCancelAddStudent.UseVisualStyleBackColor = true;
            this.btnCancelAddStudent.Click += new System.EventHandler(this.btnCancelAddStudent_Click);
            // 
            // btnOkAddStudent
            // 
            this.btnOkAddStudent.Location = new System.Drawing.Point(121, 121);
            this.btnOkAddStudent.Name = "btnOkAddStudent";
            this.btnOkAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnOkAddStudent.TabIndex = 9;
            this.btnOkAddStudent.Text = "Ok";
            this.btnOkAddStudent.UseVisualStyleBackColor = true;
            this.btnOkAddStudent.Click += new System.EventHandler(this.btnOkAddStudent_Click);
            // 
            // AddStudent
            // 
            this.AcceptButton = this.btnAddScoreAddStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelAddStudent;
            this.ClientSize = new System.Drawing.Size(302, 156);
            this.Controls.Add(this.btnOkAddStudent);
            this.Controls.Add(this.btnCancelAddStudent);
            this.Controls.Add(this.btnClearAddStudent);
            this.Controls.Add(this.btnAddScoreAddStudent);
            this.Controls.Add(this.txtAllScoresAddStudent);
            this.Controls.Add(this.txtScoreAddStudent);
            this.Controls.Add(this.txtNameAddStudent);
            this.Controls.Add(this.lblAllScoresAddStudent);
            this.Controls.Add(this.lblScoreAddStudent);
            this.Controls.Add(this.lblNameAddStudent);
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameAddStudent;
        private System.Windows.Forms.Label lblScoreAddStudent;
        private System.Windows.Forms.Label lblAllScoresAddStudent;
        private System.Windows.Forms.TextBox txtNameAddStudent;
        private System.Windows.Forms.TextBox txtScoreAddStudent;
        private System.Windows.Forms.TextBox txtAllScoresAddStudent;
        private System.Windows.Forms.Button btnAddScoreAddStudent;
        private System.Windows.Forms.Button btnClearAddStudent;
        private System.Windows.Forms.Button btnCancelAddStudent;
        private System.Windows.Forms.Button btnOkAddStudent;
    }
}