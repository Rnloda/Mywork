namespace WinDemo
{
    partial class SubTeacher
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.lbID = new System.Windows.Forms.Label();
            this.CoBoxC2 = new System.Windows.Forms.ComboBox();
            this.CoBoxC1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CoBoxDay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CoBoxCL1 = new System.Windows.Forms.ComboBox();
            this.CoBoxCL2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(49, 168);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "确认";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(225, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "教学课程一：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "教学课程二：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(47, 11);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 12);
            this.lbID.TabIndex = 10;
            // 
            // CoBoxC2
            // 
            this.CoBoxC2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBoxC2.FormattingEnabled = true;
            this.CoBoxC2.Location = new System.Drawing.Point(83, 104);
            this.CoBoxC2.Name = "CoBoxC2";
            this.CoBoxC2.Size = new System.Drawing.Size(111, 20);
            this.CoBoxC2.TabIndex = 11;
            // 
            // CoBoxC1
            // 
            this.CoBoxC1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBoxC1.FormattingEnabled = true;
            this.CoBoxC1.Location = new System.Drawing.Point(83, 72);
            this.CoBoxC1.Name = "CoBoxC1";
            this.CoBoxC1.Size = new System.Drawing.Size(111, 20);
            this.CoBoxC1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "休假时间：";
            // 
            // CoBoxDay
            // 
            this.CoBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBoxDay.FormattingEnabled = true;
            this.CoBoxDay.Location = new System.Drawing.Point(273, 43);
            this.CoBoxDay.Name = "CoBoxDay";
            this.CoBoxDay.Size = new System.Drawing.Size(111, 20);
            this.CoBoxDay.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "负责班级一：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "负责班级二：";
            // 
            // CoBoxCL1
            // 
            this.CoBoxCL1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBoxCL1.FormattingEnabled = true;
            this.CoBoxCL1.Location = new System.Drawing.Point(273, 72);
            this.CoBoxCL1.Name = "CoBoxCL1";
            this.CoBoxCL1.Size = new System.Drawing.Size(111, 20);
            this.CoBoxCL1.TabIndex = 17;
            // 
            // CoBoxCL2
            // 
            this.CoBoxCL2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoBoxCL2.FormattingEnabled = true;
            this.CoBoxCL2.Location = new System.Drawing.Point(273, 104);
            this.CoBoxCL2.Name = "CoBoxCL2";
            this.CoBoxCL2.Size = new System.Drawing.Size(111, 20);
            this.CoBoxCL2.TabIndex = 18;
            // 
            // SubTeacher
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(396, 232);
            this.Controls.Add(this.CoBoxCL2);
            this.Controls.Add(this.CoBoxCL1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CoBoxDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoBoxC1);
            this.Controls.Add(this.CoBoxC2);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SubTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox CoBoxC2;
        private System.Windows.Forms.ComboBox CoBoxC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CoBoxDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CoBoxCL1;
        private System.Windows.Forms.ComboBox CoBoxCL2;
    }
}