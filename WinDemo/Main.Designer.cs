namespace WinDemo
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.基础信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.MuneCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.报表管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.MenuTimeTable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 基础信息ToolStripMenuItem
            // 
            this.基础信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser,
            this.MenuTeacher,
            this.MuneCourse,
            this.MenuTimeTable});
            this.基础信息ToolStripMenuItem.Name = "基础信息ToolStripMenuItem";
            this.基础信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基础信息ToolStripMenuItem.Text = "基础信息";
            this.基础信息ToolStripMenuItem.Click += new System.EventHandler(this.Form1_Load);
            // 
            // MenuUser
            // 
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Size = new System.Drawing.Size(152, 22);
            this.MenuUser.Text = "人员管理";
            this.MenuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // MenuTeacher
            // 
            this.MenuTeacher.Name = "MenuTeacher";
            this.MenuTeacher.Size = new System.Drawing.Size(152, 22);
            this.MenuTeacher.Text = "教师信息维护";
            this.MenuTeacher.Click += new System.EventHandler(this.MenuTeacher_Click);
            // 
            // MuneCourse
            // 
            this.MuneCourse.Name = "MuneCourse";
            this.MuneCourse.Size = new System.Drawing.Size(152, 22);
            this.MuneCourse.Text = "课程信息维护";
            this.MuneCourse.Click += new System.EventHandler(this.MuneCourse_Click);
            // 
            // 报表管理ToolStripMenuItem
            // 
            this.报表管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人员报表ToolStripMenuItem});
            this.报表管理ToolStripMenuItem.Name = "报表管理ToolStripMenuItem";
            this.报表管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.报表管理ToolStripMenuItem.Text = "报表管理";
            // 
            // 人员报表ToolStripMenuItem
            // 
            this.人员报表ToolStripMenuItem.Name = "人员报表ToolStripMenuItem";
            this.人员报表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.人员报表ToolStripMenuItem.Text = "人员报表";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息ToolStripMenuItem,
            this.报表管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // MenuTimeTable
            // 
            this.MenuTimeTable.Name = "MenuTimeTable";
            this.MenuTimeTable.Size = new System.Drawing.Size(152, 22);
            this.MenuTimeTable.Text = "课表查询";
            this.MenuTimeTable.Click += new System.EventHandler(this.MenuTimeTable_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 412);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "演示界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem 基础信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuUser;
        private System.Windows.Forms.ToolStripMenuItem 报表管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人员报表ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripMenuItem MenuTeacher;
        private System.Windows.Forms.ToolStripMenuItem MuneCourse;
        private System.Windows.Forms.ToolStripMenuItem MenuTimeTable;
    }
}

