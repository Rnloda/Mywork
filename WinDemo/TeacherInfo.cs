using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Win.Data;

namespace WinDemo
{
    public partial class TeacherInfo : Form
    {
        ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        dbIntface dao = dbFactory.GetDataBase(ComClass.m_DB_Source, ComClass.m_DB_User, ComClass.m_DB_Pwd);
        public TeacherInfo()
        {
            InitializeComponent();
            ComClass com = new ComClass();
            com.DoubleBufferedGrid(grdview, true);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";
        }
        private void truncateTable()
        {
            string sql = "truncate table z_tmp_TimeTable";
            dao.ExecuteNonQuery(sql);
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strID = txtID.Text.Trim();
            string strName = txtName.Text.Trim();
            string strCourse = txtCourse.Text.Trim();
            string strDay = txtTimeOff.Text.Trim();           
            StringBuilder strSql = new StringBuilder();
            //ArrayList listSql = new ArrayList();

            if (strID.Length != 0)
            {
                strSql.Append(" where TID_ like '%"+ strID + "%'");
            }
            if (strName.Length != 0)
            {
                if (strSql.Length == 0)
                {
                    strSql.Append(" where Tname_ like '%" + strName + "%'");
                }
                else
                {
                    strSql.Append(" and Tname_ like '%" + strName + "%'");
                }
            }
            
            if (strDay.Length != 0)
            {
                if (strSql.Length == 0)
                {
                    strSql.Append(" where timeoff like '%" + strDay + "%'");
                }
                else
                {
                    strSql.Append(" and timeoff like '%" + strDay + "%'");
                }
            }
           
            if (strCourse.Length != 0)
            {
                if (strSql.Length == 0)
                {
                    strSql.Append(" where course1_ like '%" + strCourse + "%' or "+strSql+"course2_ like '%" + strCourse + "%'");
                }
                else
                {
                    strSql.Append(" and course1_ like '%" + strCourse + "%' or " + strSql + " and course2_ like '%" + strCourse + "%'");
                }
            }
            string str="select *from Z_TMP_TeacherInfo"+strSql;
            DataTable dtUser = dao.GetDataTable(str);
            grdview.DataSource = dtUser;
            
        }

        

        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            query();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            string Confirm = "增加教师需重新生成课表，确认继续修改？";
            DialogResult dr = MessageBox.Show(Confirm, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                truncateTable();
                SubTeacher addform = new SubTeacher();
                addform.getState(1);
                addform.ShowDialog();
            }

            query();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            string Confirm = "修改教师需要重新生成课表，确认继续修改？";
            DialogResult dr = MessageBox.Show(Confirm, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                truncateTable();
                string sql = "select * from Z_tmp_teacherinfo";
                object obj = dao.ExecuteScale(sql);
                if (obj == null)
                {
                    MessageBox.Show("当前数据库没有数据！");
                }
                else
                {
                    if (grdview.DataSource == null)
                    {
                        MessageBox.Show("请选中要修改的行！");
                        query();
                    }
                    else
                    {
                        string[] arr = new string[7];
                        for (int i = 0; i < 7; i++)
                        {
                            arr[i] = grdview[i, grdview.SelectedCells[i].RowIndex].Value.ToString();
                        }
                        SubTeacher alter = new SubTeacher();
                        alter.getState(2);
                        alter.getArry(arr);
                        alter.ShowDialog();
                    }
                }
                query();
            }
        }

        private void query()
        {
            //grdview.AutoGenerateColumns = false;
            string strsql = ("select * from z_tmp_teacherinfo");
            DataTable dtUser = dao.GetDataTable(strsql);
            grdview.DataSource = dtUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConfirmF = "删除教师需要重新生成课表，确认继续修改？";
            DialogResult dr1 = MessageBox.Show(ConfirmF, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr1 == DialogResult.OK)
            {
                truncateTable();
                string sql = "select * from Z_tmp_teacherinfo";
                object obj = dao.ExecuteScale(sql);
                if (obj == null)
                {
                    MessageBox.Show("当前数据库没有数据！");
                }
                else
                {
                    if (grdview.DataSource == null)
                    {
                        MessageBox.Show("请选中要删除的数据!");
                    }
                    else
                    {
                        string Confirm = string.Format("确认删除教师{0}，编号{1}?", grdview[1, grdview.SelectedCells[1].RowIndex].Value.ToString(), grdview[0, grdview.SelectedCells[0].RowIndex].Value.ToString());
                        DialogResult dr = MessageBox.Show(Confirm, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            string tmp = "delete from z_tmp_teacherinfo where TID_='" + grdview[0, grdview.SelectedCells[0].RowIndex].Value.ToString() + "'";

                            dao.ExecuteNonQuery(tmp);
                            string id_ = grdview[0, grdview.SelectedCells[0].RowIndex].Value.ToString();
                            string name = grdview[1, grdview.SelectedCells[1].RowIndex].Value.ToString();
                            log.InfoFormat("删除：编号{0},姓名{1}", id_, name);
                        }
                    }
                }
            }
            
            query();
        }

        private void grdview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Confirm = "修改教师需要重新生成课表，确认继续修改？";
            DialogResult dr = MessageBox.Show(Confirm, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                truncateTable();
                string[] arr = new string[7];
                for (int i = 0; i < 7; i++)
                {
                    arr[i] = grdview[i, grdview.SelectedCells[i].RowIndex].Value.ToString();
                }
                SubTeacher alter = new SubTeacher();
                alter.getState(2);
                alter.getArry(arr);
                alter.ShowDialog();
            }
            query();
        }

        private void btnEixt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
