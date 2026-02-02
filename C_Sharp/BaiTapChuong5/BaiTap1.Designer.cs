namespace BaiTapChuong5
{
    partial class BaiTap1
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
            this.b_Sua = new System.Windows.Forms.Button();
            this.b_Xoa = new System.Windows.Forms.Button();
            this.b_Them = new System.Windows.Forms.Button();
            this.TB_SoTiet = new System.Windows.Forms.TextBox();
            this.TB_TenMon = new System.Windows.Forms.TextBox();
            this.TB_MaMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DGW_ThongTinMonHoc = new System.Windows.Forms.DataGridView();
            this.maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_ThongTinMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_Sua);
            this.groupBox1.Controls.Add(this.b_Xoa);
            this.groupBox1.Controls.Add(this.b_Them);
            this.groupBox1.Controls.Add(this.TB_SoTiet);
            this.groupBox1.Controls.Add(this.TB_TenMon);
            this.groupBox1.Controls.Add(this.TB_MaMon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(559, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học !";
            // 
            // b_Sua
            // 
            this.b_Sua.BackColor = System.Drawing.Color.Tan;
            this.b_Sua.Location = new System.Drawing.Point(353, 204);
            this.b_Sua.Name = "b_Sua";
            this.b_Sua.Size = new System.Drawing.Size(123, 49);
            this.b_Sua.TabIndex = 8;
            this.b_Sua.Text = "Sửa";
            this.b_Sua.UseVisualStyleBackColor = false;
            this.b_Sua.Click += new System.EventHandler(this.b_Sua_Click);
            // 
            // b_Xoa
            // 
            this.b_Xoa.BackColor = System.Drawing.Color.Tan;
            this.b_Xoa.Location = new System.Drawing.Point(201, 204);
            this.b_Xoa.Name = "b_Xoa";
            this.b_Xoa.Size = new System.Drawing.Size(123, 49);
            this.b_Xoa.TabIndex = 7;
            this.b_Xoa.Text = "Xóa";
            this.b_Xoa.UseVisualStyleBackColor = false;
            this.b_Xoa.Click += new System.EventHandler(this.b_Xoa_Click);
            // 
            // b_Them
            // 
            this.b_Them.BackColor = System.Drawing.Color.Tan;
            this.b_Them.Location = new System.Drawing.Point(42, 204);
            this.b_Them.Name = "b_Them";
            this.b_Them.Size = new System.Drawing.Size(123, 49);
            this.b_Them.TabIndex = 6;
            this.b_Them.Text = "Thêm";
            this.b_Them.UseVisualStyleBackColor = false;
            this.b_Them.Click += new System.EventHandler(this.b_Them_Click);
            // 
            // TB_SoTiet
            // 
            this.TB_SoTiet.Location = new System.Drawing.Point(162, 161);
            this.TB_SoTiet.Name = "TB_SoTiet";
            this.TB_SoTiet.Size = new System.Drawing.Size(100, 27);
            this.TB_SoTiet.TabIndex = 5;
            // 
            // TB_TenMon
            // 
            this.TB_TenMon.Location = new System.Drawing.Point(162, 104);
            this.TB_TenMon.Name = "TB_TenMon";
            this.TB_TenMon.Size = new System.Drawing.Size(367, 27);
            this.TB_TenMon.TabIndex = 4;
            // 
            // TB_MaMon
            // 
            this.TB_MaMon.Location = new System.Drawing.Point(162, 56);
            this.TB_MaMon.Name = "TB_MaMon";
            this.TB_MaMon.Size = new System.Drawing.Size(100, 27);
            this.TB_MaMon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tính chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DGW_ThongTinMonHoc
            // 
            this.DGW_ThongTinMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_ThongTinMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMon,
            this.tenMon,
            this.soTinChi});
            this.DGW_ThongTinMonHoc.Location = new System.Drawing.Point(12, 282);
            this.DGW_ThongTinMonHoc.Name = "DGW_ThongTinMonHoc";
            this.DGW_ThongTinMonHoc.RowHeadersWidth = 51;
            this.DGW_ThongTinMonHoc.RowTemplate.Height = 24;
            this.DGW_ThongTinMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW_ThongTinMonHoc.Size = new System.Drawing.Size(541, 268);
            this.DGW_ThongTinMonHoc.TabIndex = 1;
            this.DGW_ThongTinMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_ThongTinMonHoc_CellContentClick);
            // 
            // maMon
            // 
            this.maMon.DataPropertyName = "MaMon";
            this.maMon.HeaderText = "Mã Môn";
            this.maMon.MinimumWidth = 6;
            this.maMon.Name = "maMon";
            this.maMon.ReadOnly = true;
            this.maMon.Width = 150;
            // 
            // tenMon
            // 
            this.tenMon.DataPropertyName = "TenMon";
            this.tenMon.HeaderText = "Tên Môn";
            this.tenMon.MinimumWidth = 6;
            this.tenMon.Name = "tenMon";
            this.tenMon.ReadOnly = true;
            this.tenMon.Width = 170;
            // 
            // soTinChi
            // 
            this.soTinChi.DataPropertyName = "SoTC";
            this.soTinChi.HeaderText = "Số Tín Chi";
            this.soTinChi.MinimumWidth = 6;
            this.soTinChi.Name = "soTinChi";
            this.soTinChi.ReadOnly = true;
            this.soTinChi.Width = 170;
            // 
            // BaiTap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 562);
            this.Controls.Add(this.DGW_ThongTinMonHoc);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaiTap1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaiTap1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_ThongTinMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SoTiet;
        private System.Windows.Forms.TextBox TB_TenMon;
        private System.Windows.Forms.TextBox TB_MaMon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DGW_ThongTinMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTinChi;
        private System.Windows.Forms.Button b_Them;
        private System.Windows.Forms.Button b_Xoa;
        private System.Windows.Forms.Button b_Sua;
    }
}

