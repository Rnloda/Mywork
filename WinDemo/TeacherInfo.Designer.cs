namespace WinDemo
{
    partial class TeacherInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnadd = new System.Windows.Forms.Button();
            this.grdview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeOff = new System.Windows.Forms.TextBox();
            this.btnEixt = new System.Windows.Forms.Button();
            this.TID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNAME_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COURSE1_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COURSE2_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCLASS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCLASS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMEOFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(938, 16);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "添加教师";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // grdview
            // 
            this.grdview.AllowUserToAddRows = false;
            this.grdview.AllowUserToDeleteRows = false;
            this.grdview.AllowUserToResizeColumns = false;
            this.grdview.AllowUserToResizeRows = false;
            this.grdview.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID_,
            this.TNAME_,
            this.COURSE1_,
            this.COURSE2_,
            this.CCLASS1,
            this.CCLASS2,
            this.TIMEOFF});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdview.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdview.Location = new System.Drawing.Point(3, 17);
            this.grdview.MultiSelect = false;
            this.grdview.Name = "grdview";
            this.grdview.ReadOnly = true;
            this.grdview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdview.RowTemplate.Height = 23;
            this.grdview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdview.Size = new System.Drawing.Size(1494, 625);
            this.grdview.TabIndex = 0;
            this.grdview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdview_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEixt);
            this.groupBox1.Controls.Add(this.txtTimeOff);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAlter);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.txtCourse);
            this.groupBox1.Controls.Add(this.lbCourse);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1500, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1069, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "删除教师";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(807, 16);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 29;
            this.btnAlter.Text = "修改教师";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(41, 18);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(111, 21);
            this.txtID.TabIndex = 28;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(6, 23);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(29, 12);
            this.lbID.TabIndex = 27;
            this.lbID.Text = "编号";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(369, 18);
            this.txtCourse.MaxLength = 20;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(111, 21);
            this.txtCourse.TabIndex = 26;
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(310, 23);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(53, 12);
            this.lbCourse.TabIndex = 25;
            this.lbCourse.Text = "负责课程";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(158, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 24;
            this.lbName.Text = "姓名";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(690, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "查找教师";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 18);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 21);
            this.txtName.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdview);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1500, 645);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "休假时间";
            // 
            // txtTimeOff
            // 
            this.txtTimeOff.Location = new System.Drawing.Point(551, 18);
            this.txtTimeOff.MaxLength = 20;
            this.txtTimeOff.Name = "txtTimeOff";
            this.txtTimeOff.Size = new System.Drawing.Size(111, 21);
            this.txtTimeOff.TabIndex = 32;
            // 
            // btnEixt
            // 
            this.btnEixt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEixt.Location = new System.Drawing.Point(1195, 16);
            this.btnEixt.Name = "btnEixt";
            this.btnEixt.Size = new System.Drawing.Size(75, 23);
            this.btnEixt.TabIndex = 33;
            this.btnEixt.Text = "返回";
            this.btnEixt.UseVisualStyleBackColor = true;
            this.btnEixt.Click += new System.EventHandler(this.btnEixt_Click);
            // 
            // TID_
            // 
            this.TID_.DataPropertyName = "TID_";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TID_.DefaultCellStyle = dataGridViewCellStyle8;
            this.TID_.HeaderText = "教师编号";
            this.TID_.Name = "TID_";
            this.TID_.ReadOnly = true;
            // 
            // TNAME_
            // 
            this.TNAME_.DataPropertyName = "TNAME_";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TNAME_.DefaultCellStyle = dataGridViewCellStyle9;
            this.TNAME_.HeaderText = "教师姓名";
            this.TNAME_.Name = "TNAME_";
            this.TNAME_.ReadOnly = true;
            // 
            // COURSE1_
            // 
            this.COURSE1_.DataPropertyName = "COURSE1_";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.COURSE1_.DefaultCellStyle = dataGridViewCellStyle10;
            this.COURSE1_.HeaderText = "负责课程1";
            this.COURSE1_.Name = "COURSE1_";
            this.COURSE1_.ReadOnly = true;
            // 
            // COURSE2_
            // 
            this.COURSE2_.DataPropertyName = "COURSE2_";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.COURSE2_.DefaultCellStyle = dataGridViewCellStyle11;
            this.COURSE2_.HeaderText = "负责课程2";
            this.COURSE2_.Name = "COURSE2_";
            this.COURSE2_.ReadOnly = true;
            // 
            // CCLASS1
            // 
            this.CCLASS1.DataPropertyName = "CCLASS1";
            this.CCLASS1.HeaderText = "负责班级1";
            this.CCLASS1.Name = "CCLASS1";
            this.CCLASS1.ReadOnly = true;
            // 
            // CCLASS2
            // 
            this.CCLASS2.DataPropertyName = "CCLASS2";
            this.CCLASS2.HeaderText = "负责班级2";
            this.CCLASS2.Name = "CCLASS2";
            this.CCLASS2.ReadOnly = true;
            // 
            // TIMEOFF
            // 
            this.TIMEOFF.DataPropertyName = "TIMEOFF";
            this.TIMEOFF.HeaderText = "休假时间";
            this.TIMEOFF.Name = "TIMEOFF";
            this.TIMEOFF.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 34;
            // 
            // TeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CancelButton = this.btnEixt;
            this.ClientSize = new System.Drawing.Size(1524, 713);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "教师信息维护";
            this.Load += new System.EventHandler(this.TeacherInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView grdview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTimeOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEixt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNAME_;
        private System.Windows.Forms.DataGridViewTextBoxColumn COURSE1_;
        private System.Windows.Forms.DataGridViewTextBoxColumn COURSE2_;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCLASS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCLASS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMEOFF;
        private System.Windows.Forms.Label label2;
    }
}