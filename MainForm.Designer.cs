namespace Yujian
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTTP_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.status3xx = new System.Windows.Forms.CheckBox();
            this.status403 = new System.Windows.Forms.CheckBox();
            this.status200 = new System.Windows.Forms.CheckBox();
            this.JSP_box = new System.Windows.Forms.CheckBox();
            this.PHP_box = new System.Windows.Forms.CheckBox();
            this.ASPX_box = new System.Windows.Forms.CheckBox();
            this.MDB_box = new System.Windows.Forms.CheckBox();
            this.ASP_box = new System.Windows.Forms.CheckBox();
            this.DIR_box = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Scan_Timeout = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Scan_Thread = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.custom_dic = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 769);
            this.panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 720);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1078, 37);
            this.progressBar1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(921, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "扫描速度: 0/秒";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(761, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "扫描线程: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Address,
            this.HTTP_STATUS,
            this.Column1});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 487);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // ID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.FillWeight = 44.85837F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Address.DefaultCellStyle = dataGridViewCellStyle4;
            this.Address.FillWeight = 291.5779F;
            this.Address.HeaderText = "地址";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HTTP_STATUS
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HTTP_STATUS.DefaultCellStyle = dataGridViewCellStyle5;
            this.HTTP_STATUS.FillWeight = 45.45454F;
            this.HTTP_STATUS.HeaderText = "HTTP响应";
            this.HTTP_STATUS.MaxInputLength = 4;
            this.HTTP_STATUS.MinimumWidth = 8;
            this.HTTP_STATUS.Name = "HTTP_STATUS";
            this.HTTP_STATUS.ReadOnly = true;
            this.HTTP_STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 18.10924F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "扫描信息: 准备就绪...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.custom_dic);
            this.groupBox1.Controls.Add(this.status3xx);
            this.groupBox1.Controls.Add(this.status403);
            this.groupBox1.Controls.Add(this.status200);
            this.groupBox1.Controls.Add(this.JSP_box);
            this.groupBox1.Controls.Add(this.PHP_box);
            this.groupBox1.Controls.Add(this.ASPX_box);
            this.groupBox1.Controls.Add(this.MDB_box);
            this.groupBox1.Controls.Add(this.ASP_box);
            this.groupBox1.Controls.Add(this.DIR_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Scan_Timeout);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Scan_Thread);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // status3xx
            // 
            this.status3xx.AutoSize = true;
            this.status3xx.Location = new System.Drawing.Point(942, 118);
            this.status3xx.Name = "status3xx";
            this.status3xx.Size = new System.Drawing.Size(97, 22);
            this.status3xx.TabIndex = 17;
            this.status3xx.Text = "探测3xx";
            this.status3xx.UseVisualStyleBackColor = true;
            // 
            // status403
            // 
            this.status403.AutoSize = true;
            this.status403.Location = new System.Drawing.Point(942, 90);
            this.status403.Name = "status403";
            this.status403.Size = new System.Drawing.Size(97, 22);
            this.status403.TabIndex = 16;
            this.status403.Text = "探测403";
            this.status403.UseVisualStyleBackColor = true;
            // 
            // status200
            // 
            this.status200.AutoSize = true;
            this.status200.Checked = true;
            this.status200.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status200.Location = new System.Drawing.Point(942, 62);
            this.status200.Name = "status200";
            this.status200.Size = new System.Drawing.Size(97, 22);
            this.status200.TabIndex = 15;
            this.status200.Text = "探测200";
            this.status200.UseVisualStyleBackColor = true;
            // 
            // JSP_box
            // 
            this.JSP_box.AutoSize = true;
            this.JSP_box.Checked = true;
            this.JSP_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.JSP_box.Location = new System.Drawing.Point(587, 118);
            this.JSP_box.Name = "JSP_box";
            this.JSP_box.Size = new System.Drawing.Size(70, 22);
            this.JSP_box.TabIndex = 14;
            this.JSP_box.Text = "JSP:";
            this.JSP_box.UseVisualStyleBackColor = true;
            // 
            // PHP_box
            // 
            this.PHP_box.AutoSize = true;
            this.PHP_box.Checked = true;
            this.PHP_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PHP_box.Location = new System.Drawing.Point(587, 88);
            this.PHP_box.Name = "PHP_box";
            this.PHP_box.Size = new System.Drawing.Size(70, 22);
            this.PHP_box.TabIndex = 13;
            this.PHP_box.Text = "PHP:";
            this.PHP_box.UseVisualStyleBackColor = true;
            // 
            // ASPX_box
            // 
            this.ASPX_box.AutoSize = true;
            this.ASPX_box.Checked = true;
            this.ASPX_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ASPX_box.Location = new System.Drawing.Point(587, 60);
            this.ASPX_box.Name = "ASPX_box";
            this.ASPX_box.Size = new System.Drawing.Size(79, 22);
            this.ASPX_box.TabIndex = 12;
            this.ASPX_box.Text = "ASPX:";
            this.ASPX_box.UseVisualStyleBackColor = true;
            // 
            // MDB_box
            // 
            this.MDB_box.AutoSize = true;
            this.MDB_box.Checked = true;
            this.MDB_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MDB_box.Location = new System.Drawing.Point(419, 118);
            this.MDB_box.Name = "MDB_box";
            this.MDB_box.Size = new System.Drawing.Size(70, 22);
            this.MDB_box.TabIndex = 11;
            this.MDB_box.Text = "MDB:";
            this.MDB_box.UseVisualStyleBackColor = true;
            // 
            // ASP_box
            // 
            this.ASP_box.AutoSize = true;
            this.ASP_box.Checked = true;
            this.ASP_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ASP_box.Location = new System.Drawing.Point(419, 90);
            this.ASP_box.Name = "ASP_box";
            this.ASP_box.Size = new System.Drawing.Size(70, 22);
            this.ASP_box.TabIndex = 10;
            this.ASP_box.Text = "ASP:";
            this.ASP_box.UseVisualStyleBackColor = true;
            // 
            // DIR_box
            // 
            this.DIR_box.AutoSize = true;
            this.DIR_box.Checked = true;
            this.DIR_box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DIR_box.Location = new System.Drawing.Point(419, 62);
            this.DIR_box.Name = "DIR_box";
            this.DIR_box.Size = new System.Drawing.Size(70, 22);
            this.DIR_box.TabIndex = 9;
            this.DIR_box.Text = "DIR:";
            this.DIR_box.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "（秒 超时的页面被丢弃）";
            // 
            // Scan_Timeout
            // 
            this.Scan_Timeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Scan_Timeout.FormattingEnabled = true;
            this.Scan_Timeout.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.Scan_Timeout.Location = new System.Drawing.Point(77, 105);
            this.Scan_Timeout.Name = "Scan_Timeout";
            this.Scan_Timeout.Size = new System.Drawing.Size(94, 26);
            this.Scan_Timeout.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "超时:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "（条 CPU核心 * 5最佳）";
            // 
            // Scan_Thread
            // 
            this.Scan_Thread.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Scan_Thread.FormattingEnabled = true;
            this.Scan_Thread.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.Scan_Thread.Location = new System.Drawing.Point(77, 60);
            this.Scan_Thread.Name = "Scan_Thread";
            this.Scan_Thread.Size = new System.Drawing.Size(94, 26);
            this.Scan_Thread.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "线程:";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(942, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "停止扫描";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "开始扫描";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(679, 28);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "域名:";
            // 
            // custom_dic
            // 
            this.custom_dic.AutoSize = true;
            this.custom_dic.Checked = true;
            this.custom_dic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.custom_dic.Location = new System.Drawing.Point(762, 63);
            this.custom_dic.Name = "custom_dic";
            this.custom_dic.Size = new System.Drawing.Size(97, 22);
            this.custom_dic.TabIndex = 18;
            this.custom_dic.Text = "CUSTOM:";
            this.custom_dic.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 769);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "《回忆御剑》御剑后台扫描工具 独家版 Create By:Desec https://www.github.com/DATA-GaMi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Scan_Thread;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox status3xx;
        private System.Windows.Forms.CheckBox status403;
        private System.Windows.Forms.CheckBox status200;
        private System.Windows.Forms.CheckBox JSP_box;
        private System.Windows.Forms.CheckBox PHP_box;
        private System.Windows.Forms.CheckBox ASPX_box;
        private System.Windows.Forms.CheckBox MDB_box;
        private System.Windows.Forms.CheckBox ASP_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Scan_Timeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox DIR_box;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTTP_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.CheckBox custom_dic;
    }
}

