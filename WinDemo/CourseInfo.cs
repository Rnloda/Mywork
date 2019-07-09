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
    public partial class CourseInfo : Form
    {
        ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        dbIntface dao = dbFactory.GetDataBase(ComClass.m_DB_Source, ComClass.m_DB_User, ComClass.m_DB_Pwd);
        public CourseInfo()
        {
            InitializeComponent();
            ComClass com = new ComClass();
            com.DoubleBufferedGrid(grdView, true);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//DiamondBlue.ssk";

        }
        private void truncateTable()
        {
            string sql = "truncate table z_tmp_TimeTable";
            dao.ExecuteNonQuery(sql);
        }
        private void query()
        {
            dbIntface dao = dbFactory.GetDataBase(ComClass.m_DB_Source, ComClass.m_DB_User, ComClass.m_DB_Pwd);
            //grdview.AutoGenerateColumns = false;
            string strsql = ("select * from z_tmp_COURSESUM order by CID_");
            DataTable dtUser = dao.GetDataTable(strsql);
            grdView.DataSource = dtUser;
        }

        private void CourseInfo_Load(object sender, EventArgs e)
        {
            query();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { string Confirm = "添加课程需要重新生成课表，确认继续添加？";
            DialogResult dr = MessageBox.Show(Confirm, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                truncateTable();
                SubCourse addform = new SubCourse();
                addform.getState(1);
                addform.ShowDialog();
            }
            query();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Confirm = "删除课程需要重新生成课表，确认继续删除？";
            DialogResult dr = MessageBox.Show(Confirm, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                truncateTable();
                string sql = "select * from Z_tmp_CourseSum";
                object obj = dao.ExecuteScale(sql);
                if (obj == null)
                {
                    MessageBox.Show("当前数据库没有数据！");
                }
                else
                {
                    if (grdView.DataSource == null)
                    {
                        MessageBox.Show("请选中要删除的数据!");
                    }
                    else
                    {
                        string Confirm1 = string.Format("确认删除课程{0}，编号{1}?", grdView[1, grdView.SelectedCells[1].RowIndex].Value.ToString(), grdView[0, grdView.SelectedCells[0].RowIndex].Value.ToString());
                        DialogResult dr1 = MessageBox.Show(Confirm1, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr1 == DialogResult.OK)
                        {
                            string tmp = "delete from z_tmp_CourseSum where CID_='" + grdView[0, grdView.SelectedCells[0].RowIndex].Value.ToString() + "'";

                            dao.ExecuteNonQuery(tmp);
                            string id_ = grdView[0, grdView.SelectedCells[0].RowIndex].Value.ToString();
                            string name = grdView[1, grdView.SelectedCells[1].RowIndex].Value.ToString();
                            log.InfoFormat("删除：{0},名称{1}", id_, name);
                        }
                    }
                }
            }

            query();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder strsql = new StringBuilder();
            string strCID = txtCID.Text.Trim();
            string strCNAME = txtCNAME.Text.Trim();
            if(strCID.Length != 0)
            {
                strsql.Append(" where CID_ like '%" + strCID + "%'");
            }
            if (strCNAME.Length != 0)
            {
                if (strsql.Length == 0)
                {
                    strsql.Append(" where CName_ like '%" + strCNAME + "%'");
                }
                else
                {
                    strsql.Append(" and CName_ like '%" + strCNAME + "%'");
                }
            }
            string strSql = "select *from z_tmp_CourseSum" + strsql+" order by Cid_";
            dao.ExecuteScale(strSql);
            DataTable dtUser = dao.GetDataTable(strSql);
            grdView.DataSource = dtUser;

        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            string Confirm = "修改课程需要重新生成课表，确认继续修改？";
            DialogResult dr = MessageBox.Show(Confirm, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                truncateTable();
                if (grdView.DataSource == null)
                {
                    MessageBox.Show("请选中要修改的行！");
                    query();
                }
                else
                {
                    string[] arr = new string[2];
                    for (int i = 0; i < 2; i++)
                    {
                        arr[i] = grdView[i, grdView.SelectedCells[i].RowIndex].Value.ToString();
                    }
                    SubCourse alter = new SubCourse();
                    alter.getState(2);
                    alter.getarr(arr);
                    alter.ShowDialog();
                }
            }
            query();
        }

        private void grdView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Confirm = "修改课程需要重新生成课表，确认继续修改？";
            DialogResult dr = MessageBox.Show(Confirm, "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                truncateTable();
                string[] arr = new string[2];
                for (int i = 0; i < 2; i++)
                {
                    arr[i] = grdView[i, grdView.SelectedCells[i].RowIndex].Value.ToString();
                }
                SubCourse alter = new SubCourse();
                alter.getState(2);
                alter.getarr(arr);
                alter.ShowDialog();
            }
            query();
        }
    }
}
