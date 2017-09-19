namespace StudentScoresBOC
{
    partial class AddUpdate
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
            this.lblScoreAddUpdate = new System.Windows.Forms.Label();
            this.txtScoreAddUpdate = new System.Windows.Forms.TextBox();
            this.btnAddAddUpdate = new System.Windows.Forms.Button();
            this.btnCancelAddUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScoreAddUpdate
            // 
            this.lblScoreAddUpdate.AutoSize = true;
            this.lblScoreAddUpdate.Location = new System.Drawing.Point(42, 25);
            this.lblScoreAddUpdate.Name = "lblScoreAddUpdate";
            this.lblScoreAddUpdate.Size = new System.Drawing.Size(38, 13);
            this.lblScoreAddUpdate.TabIndex = 0;
            this.lblScoreAddUpdate.Text = "Score:";
            // 
            // txtScoreAddUpdate
            // 
            this.txtScoreAddUpdate.Location = new System.Drawing.Point(86, 22);
            this.txtScoreAddUpdate.Name = "txtScoreAddUpdate";
            this.txtScoreAddUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtScoreAddUpdate.TabIndex = 1;
            // 
            // btnAddAddUpdate
            // 
            this.btnAddAddUpdate.Location = new System.Drawing.Point(18, 62);
            this.btnAddAddUpdate.Name = "btnAddAddUpdate";
            this.btnAddAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddAddUpdate.TabIndex = 2;
            this.btnAddAddUpdate.Text = "Add";
            this.btnAddAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddAddUpdate.Click += new System.EventHandler(this.btnAddAddUpdate_Click);
            // 
            // btnCancelAddUpdate
            // 
            this.btnCancelAddUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAddUpdate.Location = new System.Drawing.Point(124, 62);
            this.btnCancelAddUpdate.Name = "btnCancelAddUpdate";
            this.btnCancelAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddUpdate.TabIndex = 3;
            this.btnCancelAddUpdate.Text = "Cancel";
            this.btnCancelAddUpdate.UseVisualStyleBackColor = true;
            this.btnCancelAddUpdate.Click += new System.EventHandler(this.btnCancelAddUpdate_Click);
            // 
            // AddUpdate
            // 
            this.AcceptButton = this.btnAddAddUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelAddUpdate;
            this.ClientSize = new System.Drawing.Size(218, 102);
            this.Controls.Add(this.btnCancelAddUpdate);
            this.Controls.Add(this.btnAddAddUpdate);
            this.Controls.Add(this.txtScoreAddUpdate);
            this.Controls.Add(this.lblScoreAddUpdate);
            this.Name = "AddUpdate";
            this.Text = "Add Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScoreAddUpdate;
        private System.Windows.Forms.TextBox txtScoreAddUpdate;
        private System.Windows.Forms.Button btnAddAddUpdate;
        private System.Windows.Forms.Button btnCancelAddUpdate;
    }
}