
namespace EZMusic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tc_tabctrl = new System.Windows.Forms.TabControl();
            this.tp_s = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic = new System.Windows.Forms.DataGridViewImageColumn();
            this.server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_searchbox = new System.Windows.Forms.TextBox();
            this.cb_getpic = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tp_d = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_delall = new System.Windows.Forms.Button();
            this.b_stopall = new System.Windows.Forms.Button();
            this.b_downall = new System.Windows.Forms.Button();
            this.dgv_downlist = new System.Windows.Forms.DataGridView();
            this.dname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dartist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromserver = new System.Windows.Forms.DataGridViewImageColumn();
            this.report = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_set = new System.Windows.Forms.TabPage();
            this.btn_opennetease = new System.Windows.Forms.Button();
            this.btn_openqq = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tp_help = new System.Windows.Forms.TabPage();
            this.b_addtodownload = new System.Windows.Forms.Button();
            this.b_server = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.l_dir = new System.Windows.Forms.Label();
            this.b_openfolder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_savemaxthread = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maxthread = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_delafterfinish = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_howtogetne = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_howtogetqq = new System.Windows.Forms.Button();
            this.btn_opensavefolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tc_tabctrl.SuspendLayout();
            this.tp_s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.tp_d.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_downlist)).BeginInit();
            this.tp_set.SuspendLayout();
            this.tp_help.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tc_tabctrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 292);
            this.panel1.TabIndex = 0;
            // 
            // tc_tabctrl
            // 
            this.tc_tabctrl.Controls.Add(this.tp_s);
            this.tc_tabctrl.Controls.Add(this.tp_d);
            this.tc_tabctrl.Controls.Add(this.tp_set);
            this.tc_tabctrl.Controls.Add(this.tp_help);
            this.tc_tabctrl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tc_tabctrl.Location = new System.Drawing.Point(0, 4);
            this.tc_tabctrl.Name = "tc_tabctrl";
            this.tc_tabctrl.SelectedIndex = 0;
            this.tc_tabctrl.Size = new System.Drawing.Size(533, 288);
            this.tc_tabctrl.TabIndex = 5;
            // 
            // tp_s
            // 
            this.tp_s.Controls.Add(this.btn_openqq);
            this.tp_s.Controls.Add(this.btn_opennetease);
            this.tp_s.Controls.Add(this.label6);
            this.tp_s.Controls.Add(this.label3);
            this.tp_s.Controls.Add(this.b_addtodownload);
            this.tp_s.Controls.Add(this.dgv_user);
            this.tp_s.Controls.Add(this.b_server);
            this.tp_s.Controls.Add(this.tb_searchbox);
            this.tp_s.Controls.Add(this.cb_getpic);
            this.tp_s.Controls.Add(this.btn_search);
            this.tp_s.Location = new System.Drawing.Point(4, 22);
            this.tp_s.Name = "tp_s";
            this.tp_s.Padding = new System.Windows.Forms.Padding(3);
            this.tp_s.Size = new System.Drawing.Size(525, 262);
            this.tp_s.TabIndex = 0;
            this.tp_s.Text = "搜索歌单";
            this.tp_s.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "←点击切换源";
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.author,
            this.url,
            this.lrc,
            this.pic,
            this.server});
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_user.Location = new System.Drawing.Point(3, 71);
            this.dgv_user.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersWidth = 10;
            this.dgv_user.RowTemplate.Height = 30;
            this.dgv_user.Size = new System.Drawing.Size(519, 188);
            this.dgv_user.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.HeaderText = "曲名";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // author
            // 
            this.author.HeaderText = "艺术家";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 85;
            // 
            // url
            // 
            this.url.HeaderText = "地址";
            this.url.MinimumWidth = 8;
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Width = 80;
            // 
            // lrc
            // 
            this.lrc.HeaderText = "歌词地址";
            this.lrc.Name = "lrc";
            this.lrc.ReadOnly = true;
            this.lrc.Width = 80;
            // 
            // pic
            // 
            this.pic.HeaderText = "图片";
            this.pic.Name = "pic";
            this.pic.ReadOnly = true;
            this.pic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // server
            // 
            this.server.HeaderText = "源";
            this.server.Name = "server";
            this.server.ReadOnly = true;
            this.server.Width = 30;
            // 
            // tb_searchbox
            // 
            this.tb_searchbox.Location = new System.Drawing.Point(103, 46);
            this.tb_searchbox.Margin = new System.Windows.Forms.Padding(2);
            this.tb_searchbox.Name = "tb_searchbox";
            this.tb_searchbox.Size = new System.Drawing.Size(314, 21);
            this.tb_searchbox.TabIndex = 0;
            // 
            // cb_getpic
            // 
            this.cb_getpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_getpic.AutoSize = true;
            this.cb_getpic.Location = new System.Drawing.Point(356, 25);
            this.cb_getpic.Name = "cb_getpic";
            this.cb_getpic.Size = new System.Drawing.Size(168, 16);
            this.cb_getpic.TabIndex = 3;
            this.cb_getpic.Text = "获取图片（需要更多时间）";
            this.cb_getpic.UseVisualStyleBackColor = true;
            this.cb_getpic.CheckedChanged += new System.EventHandler(this.cb_getpic_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Location = new System.Drawing.Point(420, 46);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 21);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tp_d
            // 
            this.tp_d.Controls.Add(this.checkBox1);
            this.tp_d.Controls.Add(this.btn_opensavefolder);
            this.tp_d.Controls.Add(this.btn_delall);
            this.tp_d.Controls.Add(this.b_stopall);
            this.tp_d.Controls.Add(this.b_downall);
            this.tp_d.Controls.Add(this.dgv_downlist);
            this.tp_d.Location = new System.Drawing.Point(4, 22);
            this.tp_d.Name = "tp_d";
            this.tp_d.Padding = new System.Windows.Forms.Padding(3);
            this.tp_d.Size = new System.Drawing.Size(525, 262);
            this.tp_d.TabIndex = 1;
            this.tp_d.Text = "下载列表";
            this.tp_d.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "自动下载队列中的任务";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_delall
            // 
            this.btn_delall.Location = new System.Drawing.Point(276, 5);
            this.btn_delall.Name = "btn_delall";
            this.btn_delall.Size = new System.Drawing.Size(62, 23);
            this.btn_delall.TabIndex = 1;
            this.btn_delall.Text = "清空列表";
            this.btn_delall.UseVisualStyleBackColor = true;
            this.btn_delall.Click += new System.EventHandler(this.btn_delall_Click);
            // 
            // b_stopall
            // 
            this.b_stopall.Location = new System.Drawing.Point(344, 5);
            this.b_stopall.Name = "b_stopall";
            this.b_stopall.Size = new System.Drawing.Size(85, 23);
            this.b_stopall.TabIndex = 1;
            this.b_stopall.Text = "停止所有任务";
            this.b_stopall.UseVisualStyleBackColor = true;
            this.b_stopall.Click += new System.EventHandler(this.b_stopall_Click);
            // 
            // b_downall
            // 
            this.b_downall.Location = new System.Drawing.Point(435, 5);
            this.b_downall.Name = "b_downall";
            this.b_downall.Size = new System.Drawing.Size(85, 23);
            this.b_downall.TabIndex = 1;
            this.b_downall.Text = "所有加入队列";
            this.b_downall.UseVisualStyleBackColor = true;
            this.b_downall.Click += new System.EventHandler(this.b_downall_Click);
            // 
            // dgv_downlist
            // 
            this.dgv_downlist.AllowUserToAddRows = false;
            this.dgv_downlist.AllowUserToDeleteRows = false;
            this.dgv_downlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_downlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dname,
            this.dartist,
            this.sourse,
            this.state,
            this.fromserver,
            this.report});
            this.dgv_downlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_downlist.Location = new System.Drawing.Point(3, 34);
            this.dgv_downlist.Name = "dgv_downlist";
            this.dgv_downlist.ReadOnly = true;
            this.dgv_downlist.RowTemplate.Height = 23;
            this.dgv_downlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_downlist.Size = new System.Drawing.Size(519, 225);
            this.dgv_downlist.TabIndex = 0;
            this.dgv_downlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_downlist_CellDoubleClick);
            // 
            // dname
            // 
            this.dname.HeaderText = "曲名";
            this.dname.Name = "dname";
            this.dname.ReadOnly = true;
            this.dname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dartist
            // 
            this.dartist.HeaderText = "艺术家";
            this.dartist.Name = "dartist";
            this.dartist.ReadOnly = true;
            this.dartist.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sourse
            // 
            this.sourse.HeaderText = "API链接";
            this.sourse.Name = "sourse";
            this.sourse.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "状态";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fromserver
            // 
            this.fromserver.HeaderText = "";
            this.fromserver.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.fromserver.Name = "fromserver";
            this.fromserver.ReadOnly = true;
            this.fromserver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fromserver.Width = 20;
            // 
            // report
            // 
            this.report.HeaderText = "report";
            this.report.Name = "report";
            this.report.ReadOnly = true;
            this.report.Width = 50;
            // 
            // tp_set
            // 
            this.tp_set.Controls.Add(this.flowLayoutPanel1);
            this.tp_set.Location = new System.Drawing.Point(4, 22);
            this.tp_set.Name = "tp_set";
            this.tp_set.Padding = new System.Windows.Forms.Padding(3);
            this.tp_set.Size = new System.Drawing.Size(525, 262);
            this.tp_set.TabIndex = 2;
            this.tp_set.Text = "设置";
            this.tp_set.UseVisualStyleBackColor = true;
            // 
            // btn_opennetease
            // 
            this.btn_opennetease.Location = new System.Drawing.Point(141, 18);
            this.btn_opennetease.Name = "btn_opennetease";
            this.btn_opennetease.Size = new System.Drawing.Size(101, 29);
            this.btn_opennetease.TabIndex = 7;
            this.btn_opennetease.Text = "网易云音乐官网";
            this.btn_opennetease.UseVisualStyleBackColor = true;
            this.btn_opennetease.Click += new System.EventHandler(this.btn_opennetease_Click);
            // 
            // btn_openqq
            // 
            this.btn_openqq.Location = new System.Drawing.Point(247, 18);
            this.btn_openqq.Name = "btn_openqq";
            this.btn_openqq.Size = new System.Drawing.Size(101, 29);
            this.btn_openqq.TabIndex = 7;
            this.btn_openqq.Text = "QQ音乐官网";
            this.btn_openqq.UseVisualStyleBackColor = true;
            this.btn_openqq.Click += new System.EventHandler(this.btn_openqq_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "键入你的歌单id";
            // 
            // tp_help
            // 
            this.tp_help.Controls.Add(this.flowLayoutPanel2);
            this.tp_help.Location = new System.Drawing.Point(4, 22);
            this.tp_help.Name = "tp_help";
            this.tp_help.Size = new System.Drawing.Size(525, 262);
            this.tp_help.TabIndex = 3;
            this.tp_help.Text = "帮助";
            this.tp_help.UseVisualStyleBackColor = true;
            // 
            // b_addtodownload
            // 
            this.b_addtodownload.BackColor = System.Drawing.Color.Transparent;
            this.b_addtodownload.BackgroundImage = global::EZMusic.Properties.Resources._00100_90x2;
            this.b_addtodownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_addtodownload.FlatAppearance.BorderSize = 0;
            this.b_addtodownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addtodownload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_addtodownload.Location = new System.Drawing.Point(469, 203);
            this.b_addtodownload.Name = "b_addtodownload";
            this.b_addtodownload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.b_addtodownload.Size = new System.Drawing.Size(48, 48);
            this.b_addtodownload.TabIndex = 5;
            this.b_addtodownload.Text = "加入列表";
            this.b_addtodownload.UseVisualStyleBackColor = false;
            this.b_addtodownload.Click += new System.EventHandler(this.b_addtodownload_Click);
            // 
            // b_server
            // 
            this.b_server.BackgroundImage = global::EZMusic.Properties.Resources.qq;
            this.b_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_server.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_server.Location = new System.Drawing.Point(11, 6);
            this.b_server.Name = "b_server";
            this.b_server.Size = new System.Drawing.Size(35, 35);
            this.b_server.TabIndex = 4;
            this.b_server.UseVisualStyleBackColor = true;
            this.b_server.Click += new System.EventHandler(this.b_server_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::EZMusic.Properties.Resources.EZmusic;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(519, 256);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::EZMusic.Properties.Resources._0_0_100;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.l_dir);
            this.panel2.Controls.Add(this.b_openfolder);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 37);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "保存到目录:";
            // 
            // l_dir
            // 
            this.l_dir.AutoSize = true;
            this.l_dir.Location = new System.Drawing.Point(80, 10);
            this.l_dir.Name = "l_dir";
            this.l_dir.Size = new System.Drawing.Size(197, 12);
            this.l_dir.TabIndex = 0;
            this.l_dir.Text = "C:\\Users\\Public\\Music\\NetEZmusic";
            // 
            // b_openfolder
            // 
            this.b_openfolder.Location = new System.Drawing.Point(433, 5);
            this.b_openfolder.Name = "b_openfolder";
            this.b_openfolder.Size = new System.Drawing.Size(75, 23);
            this.b_openfolder.TabIndex = 1;
            this.b_openfolder.Text = "选择";
            this.b_openfolder.UseVisualStyleBackColor = true;
            this.b_openfolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::EZMusic.Properties.Resources._0_0_100;
            this.panel3.Controls.Add(this.btn_savemaxthread);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_maxthread);
            this.panel3.Location = new System.Drawing.Point(3, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 36);
            this.panel3.TabIndex = 6;
            // 
            // btn_savemaxthread
            // 
            this.btn_savemaxthread.Location = new System.Drawing.Point(433, 5);
            this.btn_savemaxthread.Name = "btn_savemaxthread";
            this.btn_savemaxthread.Size = new System.Drawing.Size(75, 23);
            this.btn_savemaxthread.TabIndex = 5;
            this.btn_savemaxthread.Text = "完成";
            this.btn_savemaxthread.UseVisualStyleBackColor = true;
            this.btn_savemaxthread.Click += new System.EventHandler(this.btn_savemaxthread_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "最大下载线程（[1,10]默认5个线程）";
            // 
            // tb_maxthread
            // 
            this.tb_maxthread.Location = new System.Drawing.Point(210, 7);
            this.tb_maxthread.Name = "tb_maxthread";
            this.tb_maxthread.Size = new System.Drawing.Size(67, 21);
            this.tb_maxthread.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::EZMusic.Properties.Resources._0_0_100;
            this.panel4.Controls.Add(this.cb_delafterfinish);
            this.panel4.Location = new System.Drawing.Point(3, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 38);
            this.panel4.TabIndex = 7;
            // 
            // cb_delafterfinish
            // 
            this.cb_delafterfinish.AutoSize = true;
            this.cb_delafterfinish.Location = new System.Drawing.Point(3, 10);
            this.cb_delafterfinish.Name = "cb_delafterfinish";
            this.cb_delafterfinish.Size = new System.Drawing.Size(156, 16);
            this.cb_delafterfinish.TabIndex = 3;
            this.cb_delafterfinish.Text = "完成下载后自动删除任务";
            this.cb_delafterfinish.UseVisualStyleBackColor = true;
            this.cb_delafterfinish.CheckedChanged += new System.EventHandler(this.cb_delafterfinish_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::EZMusic.Properties.Resources._0_0_100;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(511, 48);
            this.panel5.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "线程：同时进行歌曲下载的个数；线程↑，下载速度↑，宽带占用↑";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "beta转正式版翻译完成，基本功能已实现，后续美化";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = global::EZMusic.Properties.Resources.EZmusic;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Controls.Add(this.panel7);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(525, 262);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::EZMusic.Properties.Resources._0_0_100;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.btn_howtogetne);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(254, 251);
            this.panel6.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(5, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 60);
            this.label9.TabIndex = 10;
            this.label9.Text = "请注意：\r\n网易云音乐歌单开放后将无法设置回隐私歌单，\r\n如果你不想自己的歌单被公开，可以全选歌单\r\n的所有歌曲并临时创建一个新的公开歌单，下\r\n载完后再将临时歌" +
    "单删除。\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "如果歌单是自己创建的，请务必将歌单设置\r\n为公开";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "网易云音乐官网";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_opennetease_Click);
            // 
            // btn_howtogetne
            // 
            this.btn_howtogetne.Location = new System.Drawing.Point(5, 38);
            this.btn_howtogetne.Name = "btn_howtogetne";
            this.btn_howtogetne.Size = new System.Drawing.Size(155, 23);
            this.btn_howtogetne.TabIndex = 0;
            this.btn_howtogetne.Text = "如何获取网易云音乐歌单ID？";
            this.btn_howtogetne.UseVisualStyleBackColor = true;
            this.btn_howtogetne.Click += new System.EventHandler(this.btn_howtogetne_Click);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::EZMusic.Properties.Resources._0_0_100;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.btn_howtogetqq);
            this.panel7.Location = new System.Drawing.Point(263, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(254, 251);
            this.panel7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "如果歌单是自己创建的，请务必将歌单设置\r\n为公开";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "QQ音乐官网";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_openqq_Click);
            // 
            // btn_howtogetqq
            // 
            this.btn_howtogetqq.Location = new System.Drawing.Point(3, 38);
            this.btn_howtogetqq.Name = "btn_howtogetqq";
            this.btn_howtogetqq.Size = new System.Drawing.Size(155, 23);
            this.btn_howtogetqq.TabIndex = 0;
            this.btn_howtogetqq.Text = "如何获取QQ音乐歌单ID？";
            this.btn_howtogetqq.UseVisualStyleBackColor = true;
            this.btn_howtogetqq.Click += new System.EventHandler(this.btn_howtogetqq_Click);
            // 
            // btn_opensavefolder
            // 
            this.btn_opensavefolder.Location = new System.Drawing.Point(192, 5);
            this.btn_opensavefolder.Name = "btn_opensavefolder";
            this.btn_opensavefolder.Size = new System.Drawing.Size(78, 23);
            this.btn_opensavefolder.TabIndex = 1;
            this.btn_opensavefolder.Text = "打开文件夹";
            this.btn_opensavefolder.UseVisualStyleBackColor = true;
            this.btn_opensavefolder.Click += new System.EventHandler(this.btn_opensavefolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 331);
            this.MinimumSize = new System.Drawing.Size(549, 331);
            this.Name = "Form1";
            this.Text = "EZmusic";
            this.panel1.ResumeLayout(false);
            this.tc_tabctrl.ResumeLayout(false);
            this.tp_s.ResumeLayout(false);
            this.tp_s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.tp_d.ResumeLayout(false);
            this.tp_d.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_downlist)).EndInit();
            this.tp_set.ResumeLayout(false);
            this.tp_help.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_searchbox;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.CheckBox cb_getpic;
        private System.Windows.Forms.Button b_server;
        private System.Windows.Forms.TabControl tc_tabctrl;
        private System.Windows.Forms.TabPage tp_s;
        private System.Windows.Forms.TabPage tp_d;
        private System.Windows.Forms.DataGridView dgv_downlist;
        private System.Windows.Forms.Button b_addtodownload;
        private System.Windows.Forms.Button b_downall;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tp_set;
        private System.Windows.Forms.Button b_openfolder;
        private System.Windows.Forms.Label l_dir;
        private System.Windows.Forms.Button b_stopall;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maxthread;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cb_delafterfinish;
        private System.Windows.Forms.Button btn_savemaxthread;
        private System.Windows.Forms.Button btn_delall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn lrc;
        private System.Windows.Forms.DataGridViewImageColumn pic;
        private System.Windows.Forms.DataGridViewTextBoxColumn server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dartist;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewImageColumn fromserver;
        private System.Windows.Forms.DataGridViewTextBoxColumn report;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_openqq;
        private System.Windows.Forms.Button btn_opennetease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tp_help;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_howtogetne;
        private System.Windows.Forms.Button btn_howtogetqq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_opensavefolder;
    }
}

