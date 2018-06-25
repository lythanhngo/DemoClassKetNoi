namespace DemoClassKetNoi
{
    partial class frmDieuchinh
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
            this.txtThemMa = new System.Windows.Forms.TextBox();
            this.txtThemTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgKhuvuc = new System.Windows.Forms.DataGridView();
            this.MaKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuaTen = new System.Windows.Forms.TextBox();
            this.txtSuaMa = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXoaTen = new System.Windows.Forms.TextBox();
            this.txtXoaMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThemUutien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSuaUutien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtXoaUutien = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhuvuc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtThemUutien);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtThemTen);
            this.groupBox1.Controls.Add(this.txtThemMa);
            this.groupBox1.Location = new System.Drawing.Point(15, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm khu vực";
            // 
            // txtThemMa
            // 
            this.txtThemMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtThemMa.Location = new System.Drawing.Point(102, 23);
            this.txtThemMa.Name = "txtThemMa";
            this.txtThemMa.Size = new System.Drawing.Size(137, 23);
            this.txtThemMa.TabIndex = 0;
            // 
            // txtThemTen
            // 
            this.txtThemTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtThemTen.Location = new System.Drawing.Point(102, 66);
            this.txtThemTen.Name = "txtThemTen";
            this.txtThemTen.Size = new System.Drawing.Size(137, 23);
            this.txtThemTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khu vực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khu vực";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btThem.Location = new System.Drawing.Point(102, 144);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 38);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSua.Location = new System.Drawing.Point(102, 144);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 38);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btXoa.Location = new System.Drawing.Point(102, 144);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 38);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgKhuvuc);
            this.groupBox2.Location = new System.Drawing.Point(15, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khu vực";
            // 
            // dgKhuvuc
            // 
            this.dgKhuvuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKhuvuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKV,
            this.TenKV});
            this.dgKhuvuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKhuvuc.Location = new System.Drawing.Point(3, 16);
            this.dgKhuvuc.Name = "dgKhuvuc";
            this.dgKhuvuc.Size = new System.Drawing.Size(794, 140);
            this.dgKhuvuc.TabIndex = 1;
            this.dgKhuvuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKhuvuc_CellClick);
            // 
            // MaKV
            // 
            this.MaKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKV.DataPropertyName = "MaKV";
            this.MaKV.HeaderText = "Mã khu vực";
            this.MaKV.Name = "MaKV";
            // 
            // TenKV
            // 
            this.TenKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKV.DataPropertyName = "TenKV";
            this.TenKV.HeaderText = "Tên khu vực";
            this.TenKV.Name = "TenKV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSuaUutien);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSuaTen);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.Controls.Add(this.txtSuaMa);
            this.groupBox3.Location = new System.Drawing.Point(288, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 200);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sửa khu vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khu vực";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã khu vực";
            // 
            // txtSuaTen
            // 
            this.txtSuaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSuaTen.Location = new System.Drawing.Point(102, 66);
            this.txtSuaTen.Name = "txtSuaTen";
            this.txtSuaTen.Size = new System.Drawing.Size(137, 23);
            this.txtSuaTen.TabIndex = 1;
            // 
            // txtSuaMa
            // 
            this.txtSuaMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSuaMa.Location = new System.Drawing.Point(102, 23);
            this.txtSuaMa.Name = "txtSuaMa";
            this.txtSuaMa.ReadOnly = true;
            this.txtSuaMa.Size = new System.Drawing.Size(137, 23);
            this.txtSuaMa.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtXoaUutien);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btXoa);
            this.groupBox4.Controls.Add(this.txtXoaTen);
            this.groupBox4.Controls.Add(this.txtXoaMa);
            this.groupBox4.Location = new System.Drawing.Point(560, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 200);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xoá khu vực";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên khu vực";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(14, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã khu vực";
            // 
            // txtXoaTen
            // 
            this.txtXoaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtXoaTen.Location = new System.Drawing.Point(102, 66);
            this.txtXoaTen.Name = "txtXoaTen";
            this.txtXoaTen.ReadOnly = true;
            this.txtXoaTen.Size = new System.Drawing.Size(137, 23);
            this.txtXoaTen.TabIndex = 1;
            // 
            // txtXoaMa
            // 
            this.txtXoaMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtXoaMa.Location = new System.Drawing.Point(102, 23);
            this.txtXoaMa.Name = "txtXoaMa";
            this.txtXoaMa.ReadOnly = true;
            this.txtXoaMa.Size = new System.Drawing.Size(137, 23);
            this.txtXoaMa.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thêm - Sửa - Xoá";
            // 
            // txtThemUutien
            // 
            this.txtThemUutien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtThemUutien.Location = new System.Drawing.Point(102, 107);
            this.txtThemUutien.Name = "txtThemUutien";
            this.txtThemUutien.Size = new System.Drawing.Size(137, 23);
            this.txtThemUutien.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(18, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ưu tiên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(18, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ưu tiên";
            // 
            // txtSuaUutien
            // 
            this.txtSuaUutien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSuaUutien.Location = new System.Drawing.Point(102, 107);
            this.txtSuaUutien.Name = "txtSuaUutien";
            this.txtSuaUutien.Size = new System.Drawing.Size(137, 23);
            this.txtSuaUutien.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(18, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ưu tiên";
            // 
            // txtXoaUutien
            // 
            this.txtXoaUutien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtXoaUutien.Location = new System.Drawing.Point(102, 107);
            this.txtXoaUutien.Name = "txtXoaUutien";
            this.txtXoaUutien.ReadOnly = true;
            this.txtXoaUutien.Size = new System.Drawing.Size(137, 23);
            this.txtXoaUutien.TabIndex = 9;
            // 
            // frmDieuchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 532);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDieuchinh";
            this.Text = "Điều chỉnh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDieuchinh_FormClosing);
            this.Load += new System.EventHandler(this.frmDieuchinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhuvuc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThemTen;
        private System.Windows.Forms.TextBox txtThemMa;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgKhuvuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuaTen;
        private System.Windows.Forms.TextBox txtSuaMa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXoaTen;
        private System.Windows.Forms.TextBox txtXoaMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThemUutien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSuaUutien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtXoaUutien;
    }
}