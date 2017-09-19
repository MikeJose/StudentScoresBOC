namespace StudentScoresBOC
{
    partial class UpdateUpdate
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
            this.lblScoreUpdateUpdate = new System.Windows.Forms.Label();
            this.txtScoreUpdateUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateUpUp = new System.Windows.Forms.Button();
            this.btnCancelUpUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScoreUpdateUpdate
            // 
            this.lblScoreUpdateUpdate.AutoSize = true;
            this.lblScoreUpdateUpdate.Location = new System.Drawing.Point(31, 15);
            this.lblScoreUpdateUpdate.Name = "lblScoreUpdateUpdate";
            this.lblScoreUpdateUpdate.Size = new System.Drawing.Size(38, 13);
            this.lblScoreUpdateUpdate.TabIndex = 0;
            this.lblScoreUpdateUpdate.Text = "Score:";
            // 
            // txtScoreUpdateUpdate
            // 
            this.txtScoreUpdateUpdate.Location = new System.Drawing.Point(75, 12);
            this.txtScoreUpdateUpdate.Name = "txtScoreUpdateUpdate";
            this.txtScoreUpdateUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtScoreUpdateUpdate.TabIndex = 1;
            // 
            // btnUpdateUpUp
            // 
            this.btnUpdateUpUp.Location = new System.Drawing.Point(17, 48);
            this.btnUpdateUpUp.Name = "btnUpdateUpUp";
            this.btnUpdateUpUp.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUpUp.TabIndex = 2;
            this.btnUpdateUpUp.Text = "Update";
            this.btnUpdateUpUp.UseVisualStyleBackColor = true;
            this.btnUpdateUpUp.Click += new System.EventHandler(this.btnUpdateUpUp_Click);
            // 
            // btnCancelUpUp
            // 
            this.btnCancelUpUp.Location = new System.Drawing.Point(112, 48);
            this.btnCancelUpUp.Name = "btnCancelUpUp";
            this.btnCancelUpUp.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpUp.TabIndex = 3;
            this.btnCancelUpUp.Text = "Cancel";
            this.btnCancelUpUp.UseVisualStyleBackColor = true;
            this.btnCancelUpUp.Click += new System.EventHandler(this.btnCancelUpUp_Click);
            // 
            // UpdateUpdate
            // 
            this.AcceptButton = this.btnUpdateUpUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelUpUp;
            this.ClientSize = new System.Drawing.Size(203, 86);
            this.Controls.Add(this.btnCancelUpUp);
            this.Controls.Add(this.btnUpdateUpUp);
            this.Controls.Add(this.txtScoreUpdateUpdate);
            this.Controls.Add(this.lblScoreUpdateUpdate);
            this.Name = "UpdateUpdate";
            this.Text = "Update Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScoreUpdateUpdate;
        private System.Windows.Forms.TextBox txtScoreUpdateUpdate;
        private System.Windows.Forms.Button btnUpdateUpUp;
        private System.Windows.Forms.Button btnCancelUpUp;
    }
}