using log4net;
using System;
using System.Collections;
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
    public partial class SubTeacher : Form
    {
        ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        dbIntface dao = dbFactory.GetDataBase(ComClass.m_DB_Source, ComClass.m_DB_User, ComClass.m_DB_Pwd);
        int states = 0;
        string[] arr;
        public SubTeacher()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//OneCyan.ssk";
        }
        public void getState(int i)
        {
           states = i;                                     
        }
        public void getArry(string[] arr)
        {
             this.arr = arr;
        }
        private bool OccupyCheck(string strC1, string strC2, string strCL1, string strCL2)
        {
            string[] sql = new string[8];
            int state = 0;
            sql[0] = "select *from z_tmp_teacherinfo where CClass1='" + strCL1 + "'and Course1_='" + strC1 + "'or  CClass1='" + strCL1 + "'and Course2_='" + strC2 + "'";
            sql[1] = "select *from z_tmp_teacherinfo where CClass1='" + strCL2 + "'and Course1_='" + strC1 + "'or  CClass1='" + strCL2 + "'and Course2_='" + strC2 + "'";
            sql[2] = "select *from z_tmp_teacherinfo where CClass2='" + strCL1 + "'and Course1_='" + strC1 + "'or  CClass2='" + strCL1 + "'and Course2_='" + strC2 + "'";
            sql[3] = "select *from z_tmp_teacherinfo where CClass2='" + strCL2 + "'and Course1_='" + strC1 + "'or  CClass2='" + strCL2 + "'and Course2_='" + strC2 + "'";
         
            //object obj0 = dao.ExecuteScale(sql[0]);
            //object obj1 = dao.ExecuteScale(sql[1]);
            //object obj2 = dao.ExecuteScale(sql[2]);
            //object obj3 = dao.ExecuteScale(sql[3]);

            for (int i = 0; i < 4; i++)
            {
                if (dao.ExecuteScale(sql[i]) != null)
                {                  
                    state = 1;
                }
            }
            if (state == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void SubTeacher_Load(object sender, EventArgs e)
        {
            string strsql = ("select * from z_tmp_COURSESUM order by CID_");
            string strDay = ("select * from z_tmp_TimeOff");
            string strClass = ("select * from z_tmp_Classinfo");
            DataTable dt1 = dao.GetDataTable(strsql);
            DataTable dt2 = dao.GetDataTable(strsql);
            DataTable dt3 = dao.GetDataTable(strDay);
            DataTable dt4 = dao.GetDataTable(strClass);
            DataTable dt5 = dao.GetDataTable(strClass);
            CoBoxC1.DataSource = dt1;
            CoBoxC1.DisplayMember = "CName_";
            CoBoxC1.ValueMember = "CID_";
            CoBoxC2.DataSource = dt2;
            CoBoxC2.DisplayMember = "CName_";
            CoBoxC2.ValueMember = "CID_";
            CoBoxDay.DataSource = dt3;
            CoBoxDay.DisplayMember = "Day_";
            CoBoxDay.ValueMember = "id_";
            CoBoxCL1.DataSource = dt4;
            CoBoxCL1 .DisplayMember= "ClassN_";
            CoBoxCL1.ValueMember = "ClassN_";
            CoBoxCL2.DataSource = dt5;
            CoBoxCL2.DisplayMember = "ClassN_";
            CoBoxCL2.ValueMember = "ClassN_";


            if (states == 1)
            {
                this.Text = "添加教师信息";            
            }
            if(states == 2)
            {
                this.Text = "修改教师信息";
                lbID.Text = "编号：" + arr[0];
                txtName.Text = arr[1];
                CoBoxC1.Text = arr[2];
                CoBoxC2.Text = arr[3];
                CoBoxDay.Text = arr[4];
                CoBoxCL1.Text = arr[5];
                CoBoxCL2.Text = arr[6];
                
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text.Trim();
            string strC1 = CoBoxC1.Text.Trim();
            string strC2 = CoBoxC2.Text.Trim();
            string strDay = CoBoxDay.Text.Trim();
            string strCL1 = CoBoxCL1.Text.Trim();
            string strCL2 = CoBoxCL2.Text.Trim();
            
            if (states == 1)
            {
               if (strName.Length == 0)
                {
                    MessageBox.Show("请输入姓名");
                    return;
                }
                if (strC1.Length == 0)
                {
                    MessageBox.Show("请选择负责课程一");
                    return;
                }
                if (strC2.Length == 0)
                {
                    MessageBox.Show("请选择负责课程二");
                    return;
                }
                if (strDay.Length == 0)
                {
                    MessageBox.Show("请输入休假日期");
                    return;
                }
                if (strCL1.Length == 0)
                {
                    MessageBox.Show("请输入负责课程一");
                    return;
                }
                if (strCL2.Length == 0)
                {
                    MessageBox.Show("请输入负责课程二");
                    return;
                }
                if (strC1 == strC2)
                {
                    MessageBox.Show("所选择的两门课程不能相同！");
                    return;
                }
                if (strCL1 == strCL2)
                {
                    MessageBox.Show("所选择的两负责班级不能相同！");
                    return;
                }
               if(OccupyCheck(strC1, strC2, strCL1, strCL2) == false)
                {
                    string message = string.Format("{0},{1}班级已存在负责课程{2}或{3}的老师", strCL1, strCL2,strC1,strC2);
                    MessageBox.Show(message);
                }
                else
                {
                    int Cou = 0;
                    string Sql = "insert into z_tmp_teacherinfo (tid_,tname_,course1_,course2_,timeoff,CClass1,CClass2) values(seq_teacher.nextval,'" + strName + "','" + strC1 + "','" + strC2 + "','" + strDay + "','" + strCL1 + "','" + strCL2 + "')";
                    try
                    {
                        Cou = dao.ExecuteNonQuery(Sql);

                    }
                    catch (Exception ex)
                    {

                        log.Error(ex);
                    }

                    if (Cou > 0)
                    {
                        MessageBox.Show("保存成功！");
                        this.Close();
                        log.InfoFormat("添加用户{0}", strName);
                    }
                    else
                    {
                        MessageBox.Show("保存失败！");
                    }
                }
                
            }
            if (states == 2)
            {
                if (strName.Length == 0)
                {
                    MessageBox.Show("请输入姓名");
                }
                if (strC1.Length == 0)
                {
                    MessageBox.Show("请输入负责课程一");
                }
                if (strC2.Length == 0)
                {
                    MessageBox.Show("请输入负责课程二");
                }
                if (strDay.Length == 0)
                {
                    MessageBox.Show("请输入休假日期");
                }
                if (strCL1.Length == 0)
                {
                    MessageBox.Show("请输入负责课程一");
                }
                if (strCL2.Length == 0)
                {
                    MessageBox.Show("请输入负责课程二");
                }
                if (strC1 == strC2)
                {
                    MessageBox.Show("所选择的两门课程不能相同！");
                    return;
                }
                if (strCL1 == strCL2)
                {
                    MessageBox.Show("所选择的两负责班级不能相同！");
                    return;
                }
                if (strC1 == strC2)
                {
                    MessageBox.Show("所选择的两门课程不能相同！");
                    return;
                }
                if (strCL1 == strCL2)
                {
                    MessageBox.Show("所选择的两负责班级不能相同！");
                    return;
                }
                if (OccupyCheck(strC1, strC2, strCL1, strCL2) == false)
                {
                    string message = string.Format("{0},{1}班级已存在负责课程{2}或{3}的老师", strCL1, strCL2, strC1, strC2);
                    MessageBox.Show(message);
                }
                else
                {
                    string sql = "update z_tmp_teacherinfo set tname_='" + strName + "',course1_='" + strC1 + "',course2_='" + strC2 + "',timeoff='" + strDay + "',CClass1='" + strCL1 + "',CClass2='" + strCL2 + "' where tid_ = '" + arr[0] + "'";
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
}
