namespace project_dog
{
    partial class signUp
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
            this.ok = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.idTb = new System.Windows.Forms.TextBox();
            this.pwTb = new System.Windows.Forms.TextBox();
            this.pwCTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(172, 408);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 0;
            this.ok.Text = "확인";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(160, 152);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 23);
            this.nameTb.TabIndex = 1;
            this.nameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(160, 205);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(100, 23);
            this.idTb.TabIndex = 2;
            // 
            // pwTb
            // 
            this.pwTb.Location = new System.Drawing.Point(160, 257);
            this.pwTb.Name = "pwTb";
            this.pwTb.PasswordChar = '*';
            this.pwTb.Size = new System.Drawing.Size(100, 23);
            this.pwTb.TabIndex = 3;
            // 
            // pwCTb
            // 
            this.pwCTb.Location = new System.Drawing.Point(160, 312);
            this.pwCTb.Name = "pwCTb";
            this.pwCTb.PasswordChar = '*';
            this.pwCTb.Size = new System.Drawing.Size(100, 23);
            this.pwCTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "비밀번호";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "비밀번호 확인";
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(411, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwCTb);
            this.Controls.Add(this.pwTb);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "signUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ok;
        private TextBox nameTb;
        private TextBox idTb;
        private TextBox pwTb;
        private TextBox pwCTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}