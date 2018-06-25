namespace DemoClassKetNoi
{
    partial class frmDemo
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
            this.btDulieuvaoDG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btDulieuvaoCB = new System.Windows.Forms.Button();
            this.btDieuchinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDulieuvaoDG
            // 
            this.btDulieuvaoDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDulieuvaoDG.Location = new System.Drawing.Point(12, 74);
            this.btDulieuvaoDG.Name = "btDulieuvaoDG";
            this.btDulieuvaoDG.Size = new System.Drawing.Size(162, 68);
            this.btDulieuvaoDG.TabIndex = 0;
            this.btDulieuvaoDG.Text = "ĐỔ DỮ LIỆU VÀO DataGirdView";
            this.btDulieuvaoDG.UseVisualStyleBackColor = true;
            this.btDulieuvaoDG.Click += new System.EventHandler(this.btDulieuvaoDG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEMO CLASS KẾT NỐI";
            // 
            // btDulieuvaoCB
            // 
            this.btDulieuvaoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDulieuvaoCB.Location = new System.Drawing.Point(196, 74);
            this.btDulieuvaoCB.Name = "btDulieuvaoCB";
            this.btDulieuvaoCB.Size = new System.Drawing.Size(162, 68);
            this.btDulieuvaoCB.TabIndex = 2;
            this.btDulieuvaoCB.Text = "ĐỔ DỮ LIỆU VÀO ComboBox";
            this.btDulieuvaoCB.UseVisualStyleBackColor = true;
            this.btDulieuvaoCB.Click += new System.EventHandler(this.btDulieuvaoCB_Click);
            // 
            // btDieuchinh
            // 
            this.btDieuchinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDieuchinh.Location = new System.Drawing.Point(378, 74);
            this.btDieuchinh.Name = "btDieuchinh";
            this.btDieuchinh.Size = new System.Drawing.Size(162, 68);
            this.btDieuchinh.TabIndex = 3;
            this.btDieuchinh.Text = "Thêm, Sửa, Xoá";
            this.btDieuchinh.UseVisualStyleBackColor = true;
            this.btDieuchinh.Click += new System.EventHandler(this.btDieuchinh_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 155);
            this.Controls.Add(this.btDieuchinh);
            this.Controls.Add(this.btDulieuvaoCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDulieuvaoDG);
            this.Name = "frmDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo class kết nối";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDulieuvaoDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDulieuvaoCB;
        private System.Windows.Forms.Button btDieuchinh;
    }
}

