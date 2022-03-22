namespace BT4
{
    partial class Form1
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
            this.lbSh = new System.Windows.Forms.Label();
            this.cBLop = new System.Windows.Forms.ComboBox();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.dtGv = new System.Windows.Forms.DataGridView();
            this.btShow = new System.Windows.Forms.Button();
            this.btUpd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSh
            // 
            this.lbSh.AutoSize = true;
            this.lbSh.Location = new System.Drawing.Point(37, 28);
            this.lbSh.Name = "lbSh";
            this.lbSh.Size = new System.Drawing.Size(49, 16);
            this.lbSh.TabIndex = 0;
            this.lbSh.Text = "LopSH";
            // 
            // cBLop
            // 
            this.cBLop.FormattingEnabled = true;
            this.cBLop.Items.AddRange(new object[] {
            "20TCLC_DT2",
            "20TCLC_DT3",
            "20TCLC_DT4"});
            this.cBLop.Location = new System.Drawing.Point(111, 25);
            this.cBLop.Name = "cBLop";
            this.cBLop.Size = new System.Drawing.Size(155, 24);
            this.cBLop.TabIndex = 1;
            this.cBLop.SelectedIndexChanged += new System.EventHandler(this.cBLop_SelectedIndexChanged);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(490, 28);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(164, 22);
            this.tBSearch.TabIndex = 2;
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            // 
            // dtGv
            // 
            this.dtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGv.Location = new System.Drawing.Point(40, 90);
            this.dtGv.Name = "dtGv";
            this.dtGv.ReadOnly = true;
            this.dtGv.RowHeadersWidth = 51;
            this.dtGv.RowTemplate.Height = 24;
            this.dtGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGv.Size = new System.Drawing.Size(708, 244);
            this.dtGv.TabIndex = 4;
            this.dtGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGv_CellClick);
            this.dtGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(23, 357);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(108, 36);
            this.btShow.TabIndex = 5;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(158, 357);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(108, 36);
            this.btUpd.TabIndex = 6;
            this.btUpd.Text = "Update";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(282, 357);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(108, 36);
            this.btDel.TabIndex = 7;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(414, 357);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(108, 36);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(546, 357);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(108, 36);
            this.btSort.TabIndex = 9;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(660, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(674, 21);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(93, 37);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.dtGv);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.cBLop);
            this.Controls.Add(this.lbSh);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSh;
        private System.Windows.Forms.ComboBox cBLop;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.DataGridView dtGv;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btSearch;
    }
}

