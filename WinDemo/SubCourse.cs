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
    public partial class SubCourse : Form
    {
        ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        dbIntface dao = dbFactory.GetDataBase(ComClass.m_DB_Source, ComClass.m_DB_User, ComClass.m_DB_Pwd);
        int state = 0;
        string[] arr;
        public SubCourse()
        {
            InitializeComponent();
        }

        private void SubCourse_Load(object sender, EventArgs e)
        {
            if (state == 1)
            {
                this.Text = "添加用户";
            }
            if (state == 2)
            {
                this.Text = "修改用户";
                lbCID.Text = "课程编号：" + arr[0];
                txtCNAME.Text = arr[1];
            }
        }
        public void getState(int state)
        {
            this.state = state;
        }
        public void getarr(string[] arr)
        {
            this.arr = arr;
        }
        public static int GetNextID(int[] iNumList)
        {
            if (iNumList == null || iNumList.Length == 0)
            {
                return 1;//若为空数组则id为1
            }
            else
            {
                if (iNumList[0] != 1)
                {
                    return 1;//若id没有1则给下个id赋值为1
                }
                else
                {
                    for (int i = 0, j = 1; j < iNumList.Length; i++, j++)
                    {
                        //如果出现断号，则补齐断号
                        if ((iNumList[j] - iNumList[i]) > 1)
                        {
                            return iNumList[i] + 1;
                        }
                    }
                    return iNumList[iNumList.Length - 1] + 1;
                }
            }
        }

            private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strCName = txtCNAME.Text.Trim();
            if(state == 1)
            {
                if (strCName.Length == 0)
                {
                    MessageBox.Show("请输入课程名称");
                }
                string strSql = "select CID_ from z_tmp_CourseSum";
                DataTable dt = new DataTable();
                dt = dao.GetDataTable(strSql);
                int[] arrayA = new int[dt.Rows.Count];
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    DataRow dr2 = dt.Rows[x];
                    arrayA[x] = Convert.ToInt16(dr2["CID_"]);
                }
                int strId = GetNextID(arrayA);
                int Cou = 0;
                string strsql = "insert into z_tmp_CourseSum (CID_,Cname_) values('"+ strId + "','" + strCName + "')";
                try
                {
                    Cou = dao.ExecuteNonQuery(strsql);

                }
                catch (Exception ex)
                {

                    log.Error(ex);
                }

                if (Cou > 0)
                {
                    MessageBox.Show("保存成功！");
                    this.Close();
                    log.InfoFormat("添加用户{0}", strCName);
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
            if (state == 2)
            {

                if (strCName.Length == 0)
                {
                    MessageBox.Show("请输入课程名称");
                }
                string sql = "update z_tmp_CourseSum set Cname_='" + strCName + "' where CID_='" + arr[0] + "'";
                int cou = 0;
                try
                {
                    cou = dao.ExecuteNonQuery(sql);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
                if (cou > 0)
                {
                    MessageBox.Show("保存成功！");
                    this.Close();
                    log.Debug("修改操作");
                }
                else
                {
                    MessageBox.Show("保存失败！");
                }
            }
        }
        
    }
}
