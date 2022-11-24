namespace project_dog
{
    partial class reserveList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReserve = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numCb = new System.Windows.Forms.CheckBox();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.reserveDataList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.perNumTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.perAgeTb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registList = new System.Windows.Forms.ToolStripMenuItem();
            this.입양완료갱얼지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.perAddressTb = new System.Windows.Forms.TextBox();
            this.perAddressLb = new System.Windows.Forms.Label();
            this.dogIdTb = new System.Windows.Forms.TextBox();
            this.btnDogSel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.manCb = new System.Windows.Forms.CheckBox();
            this.womanCb = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.nameCb = new System.Windows.Forms.CheckBox();
            this.adminName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reserveDataList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReserve
            // 
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReserve.Location = new System.Drawing.Point(93, 591);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(116, 27);
            this.btnReserve.TabIndex = 41;
            this.btnReserve.Text = "입양 예약";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(990, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 27);
            this.button2.TabIndex = 40;
            this.button2.Text = "분양 완료";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numCb
            // 
            this.numCb.AutoSize = true;
            this.numCb.Location = new System.Drawing.Point(485, 147);
            this.numCb.Name = "numCb";
            this.numCb.Size = new System.Drawing.Size(50, 19);
            this.numCb.TabIndex = 33;
            this.numCb.Text = "번호";
            this.numCb.UseVisualStyleBackColor = true;
            this.numCb.CheckedChanged += new System.EventHandler(this.numCb_CheckedChanged);
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTb.Location = new System.Drawing.Point(269, 142);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(117, 27);
            this.searchTb.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(392, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 27);
            this.button4.TabIndex = 30;
            this.button4.Text = "검색";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // reserveDataList
            // 
            this.reserveDataList.AllowUserToAddRows = false;
            this.reserveDataList.AllowUserToDeleteRows = false;
            this.reserveDataList.AllowUserToResizeColumns = false;
            this.reserveDataList.AllowUserToResizeRows = false;
            this.reserveDataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reserveDataList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reserveDataList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reserveDataList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reserveDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reserveDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reserveDataList.DefaultCellStyle = dataGridViewCellStyle2;
            this.reserveDataList.GridColor = System.Drawing.SystemColors.Control;
            this.reserveDataList.Location = new System.Drawing.Point(269, 175);
            this.reserveDataList.Name = "reserveDataList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reserveDataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.reserveDataList.RowTemplate.Height = 25;
            this.reserveDataList.Size = new System.Drawing.Size(914, 485);
            this.reserveDataList.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "예정일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "전화번호";
            // 
            // perNumTb
            // 
            this.perNumTb.Location = new System.Drawing.Point(93, 443);
            this.perNumTb.Name = "perNumTb";
            this.perNumTb.Size = new System.Drawing.Size(116, 23);
            this.perNumTb.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "성별";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "나이";
            // 
            // perAgeTb
            // 
            this.perAgeTb.Location = new System.Drawing.Point(93, 325);
            this.perAgeTb.Name = "perAgeTb";
            this.perAgeTb.Size = new System.Drawing.Size(116, 23);
            this.perAgeTb.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 147);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 11, 24, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 23);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registList,
            this.입양완료갱얼지ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 27);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registList
            // 
            this.registList.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registList.Name = "registList";
            this.registList.Size = new System.Drawing.Size(84, 23);
            this.registList.Text = "강아지 목록";
            this.registList.Click += new System.EventHandler(this.registList_Click);
            // 
            // 입양완료갱얼지ToolStripMenuItem
            // 
            this.입양완료갱얼지ToolStripMenuItem.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.입양완료갱얼지ToolStripMenuItem.Name = "입양완료갱얼지ToolStripMenuItem";
            this.입양완료갱얼지ToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.입양완료갱얼지ToolStripMenuItem.Text = "분양 완료";
            this.입양완료갱얼지ToolStripMenuItem.Click += new System.EventHandler(this.입양완료갱얼지ToolStripMenuItem_Click);
            // 
            // perNameTb
            // 
            this.perNameTb.Location = new System.Drawing.Point(93, 269);
            this.perNameTb.Name = "perNameTb";
            this.perNameTb.Size = new System.Drawing.Size(116, 23);
            this.perNameTb.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "이름";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 54;
            this.label6.Text = "강아지 번호";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1092, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 27);
            this.button3.TabIndex = 55;
            this.button3.Text = "분양 취소";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // perAddressTb
            // 
            this.perAddressTb.Location = new System.Drawing.Point(93, 487);
            this.perAddressTb.Multiline = true;
            this.perAddressTb.Name = "perAddressTb";
            this.perAddressTb.Size = new System.Drawing.Size(116, 88);
            this.perAddressTb.TabIndex = 56;
            // 
            // perAddressLb
            // 
            this.perAddressLb.AutoSize = true;
            this.perAddressLb.Location = new System.Drawing.Point(43, 488);
            this.perAddressLb.Name = "perAddressLb";
            this.perAddressLb.Size = new System.Drawing.Size(31, 15);
            this.perAddressLb.TabIndex = 57;
            this.perAddressLb.Text = "주소";
            // 
            // dogIdTb
            // 
            this.dogIdTb.Location = new System.Drawing.Point(93, 205);
            this.dogIdTb.Name = "dogIdTb";
            this.dogIdTb.ReadOnly = true;
            this.dogIdTb.Size = new System.Drawing.Size(116, 23);
            this.dogIdTb.TabIndex = 53;
            // 
            // btnDogSel
            // 
            this.btnDogSel.Location = new System.Drawing.Point(215, 205);
            this.btnDogSel.Name = "btnDogSel";
            this.btnDogSel.Size = new System.Drawing.Size(41, 23);
            this.btnDogSel.TabIndex = 58;
            this.btnDogSel.Text = "선택";
            this.btnDogSel.UseVisualStyleBackColor = true;
            this.btnDogSel.Click += new System.EventHandler(this.btnDogSel_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1156, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 59;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // manCb
            // 
            this.manCb.AutoSize = true;
            this.manCb.Location = new System.Drawing.Point(93, 386);
            this.manCb.Name = "manCb";
            this.manCb.Size = new System.Drawing.Size(38, 19);
            this.manCb.TabIndex = 60;
            this.manCb.Text = "남";
            this.manCb.UseVisualStyleBackColor = true;
            this.manCb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // womanCb
            // 
            this.womanCb.AutoSize = true;
            this.womanCb.Location = new System.Drawing.Point(159, 385);
            this.womanCb.Name = "womanCb";
            this.womanCb.Size = new System.Drawing.Size(38, 19);
            this.womanCb.TabIndex = 61;
            this.womanCb.Text = "여";
            this.womanCb.UseVisualStyleBackColor = true;
            this.womanCb.CheckedChanged += new System.EventHandler(this.womanCb_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(597, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 27);
            this.button6.TabIndex = 62;
            this.button6.Text = "조회";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // nameCb
            // 
            this.nameCb.AutoSize = true;
            this.nameCb.Location = new System.Drawing.Point(539, 147);
            this.nameCb.Name = "nameCb";
            this.nameCb.Size = new System.Drawing.Size(50, 19);
            this.nameCb.TabIndex = 63;
            this.nameCb.Text = "이름";
            this.nameCb.UseVisualStyleBackColor = true;
            this.nameCb.CheckedChanged += new System.EventHandler(this.nameCb_CheckedChanged);
            // 
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminName.Location = new System.Drawing.Point(15, 27);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(47, 17);
            this.adminName.TabIndex = 64;
            this.adminName.Text = "관리자";
            this.adminName.Click += new System.EventHandler(this.adminName_Click);
            // 
            // reserveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.adminName);
            this.Controls.Add(this.nameCb);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.womanCb);
            this.Controls.Add(this.manCb);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDogSel);
            this.Controls.Add(this.perAddressLb);
            this.Controls.Add(this.perAddressTb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dogIdTb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.perNumTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perAgeTb);
            this.Controls.Add(this.perNameTb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numCb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reserveDataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reserveList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reserveList";
            ((System.ComponentModel.ISupportInitialize)(this.reserveDataList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReserve;
        private Button button2;
        private CheckBox numCb;
        private TextBox searchTb;
        private Button button4;
        private DataGridView reserveDataList;
        private Label label5;
        private Label label4;
        private TextBox perNumTb;
        private Label label3;
        private Label label2;
        private TextBox perAgeTb;
        private DateTimePicker dateTimePicker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registList;
        private ToolStripMenuItem 입양완료갱얼지ToolStripMenuItem;
        private TextBox perNameTb;
        private Label label1;
        private Label label6;
        private Button button3;
        private TextBox perAddressTb;
        private Label perAddressLb;
        private TextBox dogIdTb;
        private Button btnDogSel;
        private Button button5;
        private CheckBox manCb;
        private CheckBox womanCb;
        private Button button6;
        private CheckBox nameCb;
        private Label adminName;
    }
}