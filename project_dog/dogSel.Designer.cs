namespace project_dog
{
    partial class dogSel
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
            this.dogSelList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dogSelList)).BeginInit();
            this.SuspendLayout();
            // 
            // dogSelList
            // 
            this.dogSelList.AllowUserToAddRows = false;
            this.dogSelList.AllowUserToDeleteRows = false;
            this.dogSelList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dogSelList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dogSelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogSelList.Location = new System.Drawing.Point(-2, -1);
            this.dogSelList.Name = "dogSelList";
            this.dogSelList.ReadOnly = true;
            this.dogSelList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dogSelList.RowTemplate.Height = 25;
            this.dogSelList.Size = new System.Drawing.Size(524, 342);
            this.dogSelList.TabIndex = 0;
            this.dogSelList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dogSelList_CellDoubleClick_2);
            // 
            // dogSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(522, 340);
            this.Controls.Add(this.dogSelList);
            this.Name = "dogSel";
            this.Text = "dogSel";
            ((System.ComponentModel.ISupportInitialize)(this.dogSelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dogSelList;
    }
}