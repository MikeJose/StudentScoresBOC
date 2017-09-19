namespace StudentScoresBOC
{
    partial class UpdateStudent
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
            this.lblNameUpdateStudent = new System.Windows.Forms.Label();
            this.txtNameUpdateStudent = new System.Windows.Forms.TextBox();
            this.lblScoresUpdateStudent = new System.Windows.Forms.Label();
            this.lsbxScoresUpdateStudent = new System.Windows.Forms.ListBox();
            this.btnAddUpdateStudent = new System.Windows.Forms.Button();
            this.btnUpdateUpdateStudent = new System.Windows.Forms.Button();
            this.btnRemoveUpdateStudent = new System.Windows.Forms.Button();
            this.btnOkUpdateStudent = new System.Windows.Forms.Button();
            this.btnClearUpdateStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameUpdateStudent
            // 
            this.lblNameUpdateStudent.AutoSize = true;
            this.lblNameUpdateStudent.Location = new System.Drawing.Point(17, 9);
            this.lblNameUpdateStudent.Name = "lblNameUpdateStudent";
            this.lblNameUpdateStudent.Size = new System.Drawing.Size(38, 13);
            this.lblNameUpdateStudent.TabIndex = 0;
            this.lblNameUpdateStudent.Text = "Name:";
            // 
            // txtNameUpdateStudent
            // 
            this.txtNameUpdateStudent.Location = new System.Drawing.Point(61, 6);
            this.txtNameUpdateStudent.Name = "txtNameUpdateStudent";
            this.txtNameUpdateStudent.ReadOnly = true;
            this.txtNameUpdateStudent.Size = new System.Drawing.Size(173, 20);
            this.txtNameUpdateStudent.TabIndex = 1;
            this.txtNameUpdateStudent.TabStop = false;
            // 
            // lblScoresUpdateStudent
            // 
            this.lblScoresUpdateStudent.AutoSize = true;
            this.lblScoresUpdateStudent.Location = new System.Drawing.Point(12, 36);
            this.lblScoresUpdateStudent.Name = "lblScoresUpdateStudent";
            this.lblScoresUpdateStudent.Size = new System.Drawing.Size(43, 13);
            this.lblScoresUpdateStudent.TabIndex = 2;
            this.lblScoresUpdateStudent.Text = "Scores:";
            // 
            // lsbxScoresUpdateStudent
            // 
            this.lsbxScoresUpdateStudent.FormattingEnabled = true;
            this.lsbxScoresUpdateStudent.Location = new System.Drawing.Point(61, 36);
            this.lsbxScoresUpdateStudent.Name = "lsbxScoresUpdateStudent";
            this.lsbxScoresUpdateStudent.Size = new System.Drawing.Size(120, 147);
            this.lsbxScoresUpdateStudent.TabIndex = 3;
            this.lsbxScoresUpdateStudent.SelectedIndexChanged += new System.EventHandler(this.lsbxScoresUpdateStudent_SelectedIndexChanged);
            // 
            // btnAddUpdateStudent
            // 
            this.btnAddUpdateStudent.Location = new System.Drawing.Point(197, 36);
            this.btnAddUpdateStudent.Name = "btnAddUpdateStudent";
            this.btnAddUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdateStudent.TabIndex = 4;
            this.btnAddUpdateStudent.Text = "Add";
            this.btnAddUpdateStudent.UseVisualStyleBackColor = true;
            this.btnAddUpdateStudent.Click += new System.EventHandler(this.btnAddUpdateStudent_Click);
            // 
            // btnUpdateUpdateStudent
            // 
            this.btnUpdateUpdateStudent.Location = new System.Drawing.Point(197, 76);
            this.btnUpdateUpdateStudent.Name = "btnUpdateUpdateStudent";
            this.btnUpdateUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUpdateStudent.TabIndex = 5;
            this.btnUpdateUpdateStudent.Text = "Update";
            this.btnUpdateUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateUpdateStudent.Click += new System.EventHandler(this.btnUpdateUpdateStudent_Click);
            // 
            // btnRemoveUpdateStudent
            // 
            this.btnRemoveUpdateStudent.Location = new System.Drawing.Point(197, 117);
            this.btnRemoveUpdateStudent.Name = "btnRemoveUpdateStudent";
            this.btnRemoveUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveUpdateStudent.TabIndex = 6;
            this.btnRemoveUpdateStudent.Text = "Remove";
            this.btnRemoveUpdateStudent.UseVisualStyleBackColor = true;
            this.btnRemoveUpdateStudent.Click += new System.EventHandler(this.btnRemoveUpdateStudent_Click);
            // 
            // btnOkUpdateStudent
            // 
            this.btnOkUpdateStudent.Location = new System.Drawing.Point(20, 198);
            this.btnOkUpdateStudent.Name = "btnOkUpdateStudent";
            this.btnOkUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnOkUpdateStudent.TabIndex = 7;
            this.btnOkUpdateStudent.Text = "Ok";
            this.btnOkUpdateStudent.UseVisualStyleBackColor = true;
            this.btnOkUpdateStudent.Click += new System.EventHandler(this.btnOkUpdateStudent_Click);
            // 
            // btnClearUpdateStudent
            // 
            this.btnClearUpdateStudent.Location = new System.Drawing.Point(197, 156);
            this.btnClearUpdateStudent.Name = "btnClearUpdateStudent";
            this.btnClearUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnClearUpdateStudent.TabIndex = 8;
            this.btnClearUpdateStudent.Text = "Clear Scores";
            this.btnClearUpdateStudent.UseVisualStyleBackColor = true;
            this.btnClearUpdateStudent.Click += new System.EventHandler(this.btnClearUpdateStudent_Click);
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.btnClearUpdateStudent);
            this.Controls.Add(this.btnOkUpdateStudent);
            this.Controls.Add(this.btnRemoveUpdateStudent);
            this.Controls.Add(this.btnUpdateUpdateStudent);
            this.Controls.Add(this.btnAddUpdateStudent);
            this.Controls.Add(this.lsbxScoresUpdateStudent);
            this.Controls.Add(this.lblScoresUpdateStudent);
            this.Controls.Add(this.txtNameUpdateStudent);
            this.Controls.Add(this.lblNameUpdateStudent);
            this.Name = "UpdateStudent";
            this.Text = "Update Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameUpdateStudent;
        private System.Windows.Forms.TextBox txtNameUpdateStudent;
        private System.Windows.Forms.Label lblScoresUpdateStudent;
        private System.Windows.Forms.ListBox lsbxScoresUpdateStudent;
        private System.Windows.Forms.Button btnAddUpdateStudent;
        private System.Windows.Forms.Button btnUpdateUpdateStudent;
        private System.Windows.Forms.Button btnRemoveUpdateStudent;
        private System.Windows.Forms.Button btnOkUpdateStudent;
        private System.Windows.Forms.Button btnClearUpdateStudent;
    }
}