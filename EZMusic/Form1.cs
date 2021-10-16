using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using static EZMusic.Program;
//有效代码行数 255
namespace EZMusic
{
    public partial class Form1 : Form
    {
        public bool isusing = false;
        public int indownloading = 0;
        public int inline = 0;
        public bool autod = true;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            cb_getpic.Checked = Properties.Settings.Default.isgetpic;
            cb_delafterfinish.Checked = Properties.Settings.Default.isdelafterfinish;
            tb_maxthread.Text = Properties.Settings.Default.maxthread.ToString();
            if (Properties.Settings.Default.isnetease)
                b_server.BackgroundImage = Properties.Resources.netease;
            checkBox1.Checked = true;
            l_dir.Text = Properties.Settings.Default.dir;
            Thread t1 = new Thread(downthread);
            t1.Start();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(searching);
            t.Start();
        }
        public void searching()
        {
            btn_search.Enabled = false;
            string url = null;
            if (Properties.Settings.Default.isnetease)
                url = "https://api.injahow.cn/meting/?server=netease&type=playlist&id=" + tb_searchbox.Text;
            else
                url = "https://api.injahow.cn/meting/?server=tencent&type=playlist&id=" + tb_searchbox.Text;
            string orijson = GetHttpRes(url);
            if (orijson == null || orijson == "{\"error\":\"unknown playlist id\"}")
            {
                btn_search.Enabled = true;
                return;

            }
            string myjson = "{\"asong\":" + orijson + "}";
            Root rb = JsonConvert.DeserializeObject<Root>(myjson);
            int index = 0;
            dgv_user.Rows.Clear();
            foreach (var item in rb.asong)
            {
                dgv_user.Rows.Add();
                dgv_user.Rows[index].Cells[0].Value = index + 1;
                dgv_user.Rows[index].Cells[1].Value = item.name;
                dgv_user.Rows[index].Cells[2].Value = item.artist;
                dgv_user.Rows[index].Cells[3].Value = item.url;
                dgv_user.Rows[index].Cells[4].Value = item.lrc;
                if (Properties.Settings.Default.isnetease) dgv_user.Rows[index].Cells[6].Value = "n"; else dgv_user.Rows[index].Cells[6].Value = "t";
                if (cb_getpic.Checked) dgv_user.Rows[index].Cells[5].Value = Image.FromStream(WebRequest.Create(item.cover).GetResponse().GetResponseStream());
                index++;
            }
            btn_search.Enabled = true;

        }
        public string GetHttpRes(string url,int timeout = 60000)
        {
            string retString = null;
            bool got = false;
            StreamReader myStreamReader = null;
            Stream myResponseStream = null;
            for (int i = 0; i < 5 && got == false; i++)
            {
                bool iserror = false;
                try
                {
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                    ServicePointManager.Expect100Continue = false;
                    ServicePointManager.DefaultConnectionLimit = 100;
                    ServicePointManager.CheckCertificateRevocationList = false;

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Method = "GET";
                    request.ContentType = "text/html; charset=UTF-8";
                    request.Timeout = timeout;

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    myResponseStream = response.GetResponseStream();
                }
                catch (WebException)
                {
                    iserror = true;
                    myResponseStream = null;
                    Thread.Sleep(10);


                }
                finally
                {
                    if(iserror)
                        got = false;
                    else
                        got = true;
                }
            }                
            if (got)
            {
                myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("UTF-8"));
                retString = myStreamReader.ReadToEnd();
            }
            else
                retString = null;

            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }
        private void cb_getpic_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isgetpic = cb_getpic.Checked;
            Properties.Settings.Default.Save();
        }
        private void b_server_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isnetease)
            {
                Properties.Settings.Default.isnetease = false;
                b_server.BackgroundImage = Properties.Resources.qq;
            }
            else
            {
                Properties.Settings.Default.isnetease = true;
                b_server.BackgroundImage = Properties.Resources.netease;
            }
            Properties.Settings.Default.Save();


        }
        private void b_addtodownload_Click(object sender, EventArgs e)
        {
            isusing = true;
            Thread.Sleep(10);
            int index = dgv_downlist.RowCount;
            foreach(DataGridViewRow row in dgv_user.Rows)
            {
                dgv_downlist.Rows.Add();
                dgv_downlist.Rows[index].Cells[0].Value=row.Cells[1].Value;
                dgv_downlist.Rows[index].Cells[1].Value = row.Cells[2].Value;
                dgv_downlist.Rows[index].Cells[2].Value = row.Cells[3].Value;
                dgv_downlist.Rows[index].Cells[3].Value = "waiting";
                if(row.Cells[6].Value=="t")dgv_downlist.Rows[index].Cells[4].Value = Properties.Resources.qq;else dgv_downlist.Rows[index].Cells[4].Value = Properties.Resources.netease;
                index++;
                inline++;
            }
            isusing = false;
        }
        private void b_downall_Click(object sender, EventArgs e)
        {
            isusing = true;
            Thread.Sleep(10);
            foreach (DataGridViewRow row in dgv_downlist.Rows)
            {
                if(row.Cells[3].Value == "waiting"|| row.Cells[3].Value == "failed") row.Cells[3].Value = "lined";

            }
            isusing = false;

        }
        public void downthread()
        {
            while (1==1)
            {
                while (indownloading < Properties.Settings.Default.maxthread && autod == true && inline!=0 && !isusing )
                {
                    foreach (DataGridViewRow row in dgv_downlist.Rows)
                    {
                        if(row.Cells[3].Value == "lined")
                        {
                            row.Cells[3].Value = "downloading";
                            string url = row.Cells[2].Value.ToString();
                            Thread thread = new Thread(() => startdown(url,l_dir.Text + ReplaceBadCharOfFileName(row.Cells[0].Value.ToString()) +".mp3",row));
                            thread.Start();
                            indownloading++;
                            inline--;
                            break;
                        }
                        if (isusing)
                            break;
                    }
                }
                Thread.Sleep(1000);
            }
        }
        public void startdown(string url,string filename ,DataGridViewRow row)
        {
            bool succeed = true;
            string tempFile = filename + ".temp"; //临时文件
            if (File.Exists(tempFile))
                File.Delete(tempFile);    //存在则删除
            if (File.Exists(filename))
                File.Delete(filename);    //存在则删除
            try
            {
                FileStream fs = new FileStream(tempFile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream responseStream = response.GetResponseStream();
                byte[] bArr = new byte[1024];
                int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                while (size > 0)
                {
                    fs.Write(bArr, 0, size);
                    size = responseStream.Read(bArr, 0, (int)bArr.Length);
                }
                fs.Close();
                responseStream.Close();
                File.Move(tempFile, filename);

            }
            catch (Exception ex)
            {
                succeed = false;
                row.Cells[5].Value = ex.Message;
            }
            if (succeed)
            {
                if (Properties.Settings.Default.isdelafterfinish)
                {
                isusing = true;
                Thread.Sleep(5);
                dgv_downlist.Rows.Remove(row);
                isusing = false;
                }
                else
                    row.Cells[3].Value = "finish";

            }
            else
                row.Cells[3].Value = "failed";
            indownloading--;
            return;           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            autod = checkBox1.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            dialog.SelectedPath = Properties.Settings.Default.dir;
 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath+"\\";
                l_dir.Text = foldPath;
                Properties.Settings.Default.dir = foldPath;
                Properties.Settings.Default.Save();
            }
        }
        private void dgv_downlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isusing = true;
            Thread.Sleep(10);
            dgv_downlist.Rows.Remove(dgv_downlist.CurrentRow);
            isusing = false;
        }
        private void b_stopall_Click(object sender, EventArgs e)
        {
            isusing = true;
            Thread.Sleep(10);
            foreach (DataGridViewRow row in dgv_downlist.Rows)
            {
                if (row.Cells[3].Value == "lined") row.Cells[3].Value = "waiting";

            }
            isusing = false;
        }
        private void cb_delafterfinish_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isdelafterfinish = cb_delafterfinish.Checked;
            Properties.Settings.Default.Save();
        }
        private void btn_savemaxthread_Click(object sender, EventArgs e)
        {
            int tmp;
            string t1 = tb_maxthread.Text;
            if (!int.TryParse(t1, out tmp))//如果转换失败（为false）时输出括号内容
            {
                tb_maxthread.Text = Properties.Settings.Default.maxthread.ToString();
            }

            else
            {
                if (0 < tmp && tmp < 11)
                {
                    Properties.Settings.Default.maxthread = tmp;
                    Properties.Settings.Default.Save();
                }
                else
                    tb_maxthread.Text = Properties.Settings.Default.maxthread.ToString();
            }
        }
        private void btn_delall_Click(object sender, EventArgs e)
        {
            isusing = true;
            Thread.Sleep(10);
            dgv_downlist.Rows.Clear();
            isusing = false;
        }
        public string ReplaceBadCharOfFileName(string fileName)
        {
            string str = fileName;
            str = str.Replace("\\", string.Empty);
            str = str.Replace("/", string.Empty);
            str = str.Replace(":", string.Empty);
            str = str.Replace("*", string.Empty);
            str = str.Replace("?", string.Empty);
            str = str.Replace("\"", string.Empty);
            str = str.Replace("<", string.Empty);
            str = str.Replace(">", string.Empty);
            str = str.Replace("|", string.Empty);
            return str;
        }
        private void btn_opennetease_Click(object sender, EventArgs e)
        {
            Process.Start("https://music.163.com");
        }
        private void btn_openqq_Click(object sender, EventArgs e)
        {
            Process.Start("https://y.qq.com");
        }
        private void btn_howtogetne_Click(object sender, EventArgs e)
        {
            new Form_helpne().ShowDialog();
        }
        private void btn_howtogetqq_Click(object sender, EventArgs e)
        {
            new Form_helpqq().ShowDialog();

        }
        private void btn_opensavefolder_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.dir);

        }
    }
}