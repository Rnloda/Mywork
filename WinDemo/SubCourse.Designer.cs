namespace WinDemo
{
    partial class SubCourse
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
            this.txtCNAME = new System.Windows.Forms.TextBox();
            this.lbCID = new System.Windows.Forms.Label();
            this.lbCName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCNAME
            // 
            this.txtCNAME.Location = new System.Drawing.Point(104, 51);
            this.txtCNAME.Name = "txtCNAME";
            this.txtCNAME.Size = new System.Drawing.Size(123, 21);
            this.txtCNAME.TabIndex = 1;
            // 
            // lbCID
            // 
            this.lbCID.AutoSize = true;
            this.lbCID.Location = new System.Drawing.Point(33, 36);
            this.lbCID.Name = "lbCID";
            this.lbCID.Size = new System.Drawing.Size(0, 12);
            this.lbCID.TabIndex = 2;
            // 
            // lbCName
            // 
            this.lbCName.AutoSize = true;
            this.lbCName.Location = new System.Drawing.Point(33, 54);
            this.lbCName.Name = "lbCName";
            this.lbCName.Size = new System.Drawing.Size(65, 12);
            this.lbCName.TabIndex = 3;
            this.lbCName.Text = "课程名称：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(35, 118);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "确认";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(171, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SubCourse
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbCName);
            this.Controls.Add(this.lbCID);
            this.Controls.Add(this.txtCNAME);
            this.Name = "SubCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SubCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCNAME;
        private System.Windows.Forms.Label lbCID;
        private System.Windows.Forms.Label lbCName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}