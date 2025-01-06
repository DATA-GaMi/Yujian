using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yujian
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Read_Config();
            Scan_Thread.Text = (GetProcessorCount() * 5).ToString();
            Scan_Timeout.Text = "2";
            toolTip1.SetToolTip(Scan_Thread, Tooltip());
            
        }

        /// <summary>
        /// 获取读取文件并返回行数
        /// </summary>
        /// <param name="config_file_path"></param>
        /// <returns></returns>
        private static int ReadFile_ToRow(string config_file_path)
        {
            string[] lines = File.ReadAllLines(config_file_path);
            return lines.Length;
        }

        /// <summary>
        /// 获取CPU核心数
        /// </summary>
        /// <returns></returns>
        private int GetProcessorCount()
        {
            int coreCount = Environment.ProcessorCount;
            return coreCount;
        }


        private string Tooltip()
        {
            string result = "您电脑的CPU核心数为" + GetProcessorCount().ToString() + "，建议线程选择为" + (GetProcessorCount() * 5).ToString() + "条";
            return result;
        }





        /// <summary>
        /// 读取配置文件获取每配置文件中的行数
        /// </summary>
        private void Read_Config()
        {

            //读取DIR.txt行数
            DIR_box.Text = DIR_box.Text + " "+ ReadFile_ToRow(@"配置文件\DIR.txt").ToString();
            //ReadFile_ToRow(@"配置文件\DIR.txt");
            //读取ASP.txt行数
            ASP_box.Text = ASP_box.Text + " " + ReadFile_ToRow(@"配置文件\ASP.txt").ToString();
            //读取MDB.txt行数
            MDB_box.Text = MDB_box.Text + " " + ReadFile_ToRow(@"配置文件\MDB.txt").ToString();
            //读取ASPX.txt行数
            ASPX_box.Text = ASPX_box.Text + " " + ReadFile_ToRow(@"配置文件\ASPX.txt").ToString();
            //读取PHP.txt行数
            PHP_box.Text = PHP_box.Text + " " + ReadFile_ToRow(@"配置文件\PHP.txt").ToString();
            //读取JSP.txt行数
            JSP_box.Text = JSP_box.Text + " " + ReadFile_ToRow(@"配置文件\JSP.txt").ToString();

            //读取自定义字典CUSTOM.txt行数
            custom_dic.Text = custom_dic.Text + " " + ReadFile_ToRow(@"配置文件\CUSTOM.txt").ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("请输入网站域名!", "提示", MessageBoxButtons.OK);
                return;
            }
            else
            {
                button2.Enabled = true;
            }
            if (Scan_Thread.Text.Length == 0)
            {
                MessageBox.Show("请选择线程!", "提示", MessageBoxButtons.OK);
                return;
            }
            if(Scan_Timeout.Text.Length==0)
            {
                MessageBox.Show("请设置超时!", "提示", MessageBoxButtons.OK);
                return;
            }

            if(status200.Checked)
            {
                //使用HEAD方法请求网站
                //将结果输出在DataGridView上,包含ID，url地址，以及HTTP状态码
            }
            if(status403.Checked)
            {
                //使用HEAD方法请求网站
                //将结果输出在DataGridView上,包含ID，url地址，以及HTTP状态码
            }
            if (status3xx.Checked)
            {
                //使用HEAD方法请求网站
                //将结果输出在DataGridView上,包含ID，url地址，以及HTTP状态码
            }
            MessageBox.Show("开始运行");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Address.Index && e.RowIndex >= 0)
            {
                string url = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Process.Start(url);
            }
        }

        /// <summary>
        /// 发送HEAD请求
        /// </summary>
        /// <param name="url">url</param>
        /// <returns></returns>
        private int SendHeadRequest(string url)
        {
            try
            {
                // 创建HttpWebRequest对象
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "HEAD";

                // 设置一些常用属性（可根据实际需求调整或添加更多属性设置）
                httpWebRequest.Timeout = Convert.ToInt32(Scan_Timeout.Text);
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/5.0 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36";
                //Console.WriteLine(url);

                // 发送请求并获取响应
                using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    return (int)httpWebResponse.StatusCode;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    return (int)((HttpWebResponse)ex.Response).StatusCode;
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        private static List<List<string>> SplitList(List<string> sourceList, int parts)
        {
            List<List<string>> result = new List<List<string>>();
            int size = sourceList.Count / parts;
            int remainder = sourceList.Count % parts;

            int startIndex = 0;
            for (int i = 0; i < parts; i++)
            {
                int currentSize = size + (i < remainder ? 1 : 0);
                List<string> subList = sourceList.GetRange(startIndex, currentSize);
                result.Add(subList);
                startIndex += currentSize;
            }

            return result;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
