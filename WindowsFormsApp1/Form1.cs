using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ArrayList SName;
        //姓名列表
        private ArrayList SId;
        //学号列表
        private Random random;
        //随机数
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckStudent_Click(object sender, EventArgs e)
        {
            //CheckIn
            //点击学生姓名，随机抽取一个学生显示姓名和学号
            int index = random.Next(0, SName.Count);
            CheckStudent.Text = SName[index].ToString();
            CheckId.Text = SId[index].ToString();
            Arrived.Enabled = true;
            Absence.Enabled = true;
            AskLeave.Enabled = true;
        }

        private void Arrived_Click(object sender, EventArgs e)
        {
            //签到
            MessageBox.Show(CheckStudent.Text + " " + CheckId.Text + " 签到成功", "提示", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            Arrived.Enabled = false;
            Absence.Enabled = false;
            AskLeave.Enabled = false;
            //其他操作



            //Arrived
        }

        private void Absence_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(CheckStudent.Text + " " + CheckId.Text + " 缺席，确认吗？", "提示", 
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //确认缺席
            if(dr == DialogResult.Yes)
            {
                //记录缺席，可以自己改，这里提高被点到概率
                using (StreamWriter sw = new StreamWriter("./点名.txt", true))
                {
                    sw.WriteLine(CheckStudent.Text + " " + CheckId.Text);
                }
                Arrived.Enabled = false;
                Absence.Enabled = false;
                AskLeave.Enabled = false;
            }
            //Absence
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            //Asked for leave
            //请假
            //其他操作，如记录请假情况



            Arrived.Enabled = false;
            Absence.Enabled = false;
            AskLeave.Enabled = false;
        }

        private void StudentId_Click(object sender, EventArgs e)
        {
            //CheckIn
            //效果同点击学生姓名
            CheckStudent_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //读取数据
                using (StreamReader sr = new StreamReader("./点名.txt"))
                {
                    string line;
                    string[] S;
                    SName = new ArrayList();
                    SId = new ArrayList();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line != "")
                        {
                            S = line.Split(' ');
                            SName.Add(S[0]);
                            SId.Add(S[1]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("无法读取文件“点名.txt”，请检查。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if(SName != null && SId != null)
            {
                CheckStudent.Text = SName[0].ToString();
                CheckId.Text = SId[0].ToString();
                byte[] buffer = System.Guid.NewGuid().ToByteArray();
                int root = BitConverter.ToInt32(buffer, 0);
                random = new Random(root);
            }
            else
            {
                MessageBox.Show("“点名.txt”为空，无法继续进行，请检查", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
