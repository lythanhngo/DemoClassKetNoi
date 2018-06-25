namespace DemoClassKetNoi
{
    partial class frmDulieuvaoCB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKhuvuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgKhuvuc = new System.Windows.Forms.DataGridView();
            this.MaTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhuvuc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKhuvuc);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu vào ComboBox";
            // 
            // cbKhuvuc
            // 
            this.cbKhuvuc.FormattingEnabled = true;
            this.cbKhuvuc.Location = new System.Drawing.Point(26, 34);
            this.cbKhuvuc.Name = "cbKhuvuc";
            this.cbKhuvuc.Size = new System.Drawing.Size(253, 21);
            this.cbKhuvuc.TabIndex = 0;
            this.cbKhuvuc.SelectedIndexChanged += new System.EventHandler(this.cbKhuvuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(141, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hiển thị dữ liệu bảng Quê quán bằng ComboBox";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgKhuvuc);
            this.groupBox2.Location = new System.Drawing.Point(17, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 306);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khi chọn ComboBox hiển thị dữ liệu tương ứng";
            // 
            // dgKhuvuc
            // 
            this.dgKhuvuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhuvuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTS,
            this.HoTS,
            this.TenTS,
            this.TenKV});
            this.dgKhuvuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKhuvuc.Location = new System.Drawing.Point(3, 16);
            this.dgKhuvuc.Name = "dgKhuvuc";
            this.dgKhuvuc.Size = new System.Drawing.Size(647, 287);
            this.dgKhuvuc.TabIndex = 0;
            // 
            // MaTS
            // 
            this.MaTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTS.DataPropertyName = "MaTS";
            this.MaTS.HeaderText = "Mã thí sinh";
            this.MaTS.Name = "MaTS";
            // 
            // HoTS
            // 
            this.HoTS.DataPropertyName = "HoTS";
            this.HoTS.HeaderText = "Họ thí sinh";
            this.HoTS.Name = "HoTS";
            // 
            // TenTS
            // 
            this.TenTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTS.DataPropertyName = "TenTS";
            this.TenTS.HeaderText = "Tên thí sinh";
            this.TenTS.Name = "TenTS";
            // 
            // TenKV
            // 
            this.TenKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKV.DataPropertyName = "TenKV";
            this.TenKV.HeaderText = "Khu vực";
            this.TenKV.Name = "TenKV";
            // 
            // frmDulieuvaoCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDulieuvaoCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDulieuvaoCB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDulieuvaoCB_FormClosing);
            this.Load += new System.EventHandler(this.frmDulieuvaoCB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhuvuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKhuvuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgKhuvuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKV;
    }
}