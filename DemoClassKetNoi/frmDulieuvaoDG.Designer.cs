namespace DemoClassKetNoi
{
    partial class frmDulieuvaoDG
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgQuequan = new System.Windows.Forms.DataGridView();
            this.MaQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuequan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(120, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị dữ liệu bảng Quê quán bằng DataGirbView";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgQuequan);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgQuequan
            // 
            this.dgQuequan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuequan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQQ,
            this.TenQQ});
            this.dgQuequan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQuequan.Location = new System.Drawing.Point(3, 16);
            this.dgQuequan.Name = "dgQuequan";
            this.dgQuequan.Size = new System.Drawing.Size(647, 403);
            this.dgQuequan.TabIndex = 0;
            // 
            // MaQQ
            // 
            this.MaQQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaQQ.DataPropertyName = "MaQQ";
            this.MaQQ.HeaderText = "Mã quê quán";
            this.MaQQ.Name = "MaQQ";
            // 
            // TenQQ
            // 
            this.TenQQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenQQ.DataPropertyName = "TenQQ";
            this.TenQQ.HeaderText = "Tên quê quán";
            this.TenQQ.Name = "TenQQ";
            // 
            // frmDulieuvaoDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDulieuvaoDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dữ liệu vào DG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDulieuvaoDG_FormClosing);
            this.Load += new System.EventHandler(this.frmDulieuvaoDG_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuequan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgQuequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQQ;
    }
}