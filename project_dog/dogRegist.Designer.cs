namespace project_dog
{
    partial class dogRegist
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.ReNameTb = new System.Windows.Forms.TextBox();
            this.ReAgeTb = new System.Windows.Forms.TextBox();
            this.ReVarTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boyCb = new System.Windows.Forms.CheckBox();
            this.girlCb = new System.Windows.Forms.CheckBox();
            this.NeuX = new System.Windows.Forms.CheckBox();
            this.NeuO = new System.Windows.Forms.CheckBox();
            this.roadPic = new System.Windows.Forms.Button();
            this.savePic = new System.Windows.Forms.Button();
            this.imgSearch = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(171, 449);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(75, 23);
            this.btnRegist.TabIndex = 1;
            this.btnRegist.Text = "등록";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // ReNameTb
            // 
            this.ReNameTb.Location = new System.Drawing.Point(159, 227);
            this.ReNameTb.Name = "ReNameTb";
            this.ReNameTb.Size = new System.Drawing.Size(100, 23);
            this.ReNameTb.TabIndex = 2;
            this.ReNameTb.TextChanged += new System.EventHandler(this.ReNameTb_TextChanged);
            // 
            // ReAgeTb
            // 
            this.ReAgeTb.Location = new System.Drawing.Point(159, 271);
            this.ReAgeTb.Name = "ReAgeTb";
            this.ReAgeTb.Size = new System.Drawing.Size(100, 23);
            this.ReAgeTb.TabIndex = 3;
            this.ReAgeTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReAgeTb_KeyPress);
            // 
            // ReVarTb
            // 
            this.ReVarTb.Location = new System.Drawing.Point(159, 316);
            this.ReVarTb.Name = "ReVarTb";
            this.ReVarTb.Size = new System.Drawing.Size(100, 23);
            this.ReVarTb.TabIndex = 4;
            this.ReVarTb.TextChanged += new System.EventHandler(this.ReVarTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "품종";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "성별";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "중성화";
            // 
            // boyCb
            // 
            this.boyCb.AutoSize = true;
            this.boyCb.Location = new System.Drawing.Point(164, 362);
            this.boyCb.Name = "boyCb";
            this.boyCb.Size = new System.Drawing.Size(38, 19);
            this.boyCb.TabIndex = 12;
            this.boyCb.Text = "남";
            this.boyCb.UseVisualStyleBackColor = true;
            this.boyCb.CheckedChanged += new System.EventHandler(this.boyCb_CheckedChanged);
            // 
            // girlCb
            // 
            this.girlCb.AutoSize = true;
            this.girlCb.Location = new System.Drawing.Point(226, 362);
            this.girlCb.Name = "girlCb";
            this.girlCb.Size = new System.Drawing.Size(38, 19);
            this.girlCb.TabIndex = 13;
            this.girlCb.Text = "여";
            this.girlCb.UseVisualStyleBackColor = true;
            this.girlCb.CheckedChanged += new System.EventHandler(this.girlCb_CheckedChanged);
            // 
            // NeuX
            // 
            this.NeuX.AutoSize = true;
            this.NeuX.Location = new System.Drawing.Point(226, 404);
            this.NeuX.Name = "NeuX";
            this.NeuX.Size = new System.Drawing.Size(33, 19);
            this.NeuX.TabIndex = 15;
            this.NeuX.Text = "X";
            this.NeuX.UseVisualStyleBackColor = true;
            this.NeuX.CheckedChanged += new System.EventHandler(this.NeuX_CheckedChanged);
            // 
            // NeuO
            // 
            this.NeuO.AutoSize = true;
            this.NeuO.Location = new System.Drawing.Point(164, 404);
            this.NeuO.Name = "NeuO";
            this.NeuO.Size = new System.Drawing.Size(35, 19);
            this.NeuO.TabIndex = 14;
            this.NeuO.Text = "O";
            this.NeuO.UseVisualStyleBackColor = true;
            this.NeuO.CheckedChanged += new System.EventHandler(this.NeuO_CheckedChanged);
            // 
            // roadPic
            // 
            this.roadPic.Location = new System.Drawing.Point(143, 179);
            this.roadPic.Name = "roadPic";
            this.roadPic.Size = new System.Drawing.Size(67, 24);
            this.roadPic.TabIndex = 16;
            this.roadPic.Text = "Read";
            this.roadPic.UseVisualStyleBackColor = true;
            this.roadPic.Click += new System.EventHandler(this.selPic_Click);
            // 
            // savePic
            // 
            this.savePic.Location = new System.Drawing.Point(207, 179);
            this.savePic.Name = "savePic";
            this.savePic.Size = new System.Drawing.Size(67, 24);
            this.savePic.TabIndex = 17;
            this.savePic.Text = "Save";
            this.savePic.UseVisualStyleBackColor = true;
            this.savePic.Click += new System.EventHandler(this.savePic_Click);
            // 
            // imgSearch
            // 
            this.imgSearch.FileName = "img";
            this.imgSearch.InitialDirectory = "C:";
            this.imgSearch.Title = "멋쟁이 강아지";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // dogRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(411, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.savePic);
            this.Controls.Add(this.roadPic);
            this.Controls.Add(this.NeuX);
            this.Controls.Add(this.NeuO);
            this.Controls.Add(this.girlCb);
            this.Controls.Add(this.boyCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReVarTb);
            this.Controls.Add(this.ReAgeTb);
            this.Controls.Add(this.ReNameTb);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dogRegist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dogRegist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnRegist;
        private TextBox ReNameTb;
        private TextBox ReAgeTb;
        private TextBox ReVarTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox boyCb;
        private CheckBox girlCb;
        private CheckBox NeuX;
        private CheckBox NeuO;
        private Button roadPic;
        private Button savePic;
        private OpenFileDialog imgSearch;
        private Label label6;
    }
}