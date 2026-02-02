namespace BaiTapChuong4
{
    partial class form_MonHoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_TenMon = new System.Windows.Forms.TextBox();
            this.TB_MaMon = new System.Windows.Forms.TextBox();
            this.TB_SoTinChi = new System.Windows.Forms.TextBox();
            this.DGW_DuLieu = new System.Windows.Forms.DataGridView();
            this.soThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_DuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín chỉ :";
            // 
            // TB_TenMon
            // 
            this.TB_TenMon.Location = new System.Drawing.Point(240, 93);
            this.TB_TenMon.Margin = new System.Windows.Forms.Padding(6);
            this.TB_TenMon.Name = "TB_TenMon";
            this.TB_TenMon.Size = new System.Drawing.Size(435, 39);
            this.TB_TenMon.TabIndex = 3;
            // 
            // TB_MaMon
            // 
            this.TB_MaMon.Location = new System.Drawing.Point(240, 169);
            this.TB_MaMon.Margin = new System.Windows.Forms.Padding(6);
            this.TB_MaMon.Name = "TB_MaMon";
            this.TB_MaMon.Size = new System.Drawing.Size(435, 39);
            this.TB_MaMon.TabIndex = 4;
            // 
            // TB_SoTinChi
            // 
            this.TB_SoTinChi.Location = new System.Drawing.Point(240, 265);
            this.TB_SoTinChi.Margin = new System.Windows.Forms.Padding(6);
            this.TB_SoTinChi.Name = "TB_SoTinChi";
            this.TB_SoTinChi.Size = new System.Drawing.Size(435, 39);
            this.TB_SoTinChi.TabIndex = 5;
            // 
            // DGW_DuLieu
            // 
            this.DGW_DuLieu.AllowUserToAddRows = false;
            this.DGW_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_DuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soThuTu,
            this.maMon,
            this.tenMon,
            this.soTinChi,
            this.ChiTiet});
            this.DGW_DuLieu.Location = new System.Drawing.Point(12, 340);
            this.DGW_DuLieu.Name = "DGW_DuLieu";
            this.DGW_DuLieu.ReadOnly = true;
            this.DGW_DuLieu.RowHeadersWidth = 51;
            this.DGW_DuLieu.RowTemplate.Height = 24;
            this.DGW_DuLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGW_DuLieu.Size = new System.Drawing.Size(806, 277);
            this.DGW_DuLieu.TabIndex = 6;
            this.DGW_DuLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DuLieu_CellContentClick);
            // 
            // soThuTu
            // 
            this.soThuTu.DataPropertyName = "STT";
            this.soThuTu.HeaderText = "STT";
            this.soThuTu.MinimumWidth = 6;
            this.soThuTu.Name = "soThuTu";
            this.soThuTu.ReadOnly = true;
            this.soThuTu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.soThuTu.Width = 70;
            // 
            // maMon
            // 
            this.maMon.DataPropertyName = "MaMon";
            this.maMon.HeaderText = "Mã Môn";
            this.maMon.MinimumWidth = 6;
            this.maMon.Name = "maMon";
            this.maMon.ReadOnly = true;
            this.maMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maMon.Width = 150;
            // 
            // tenMon
            // 
            this.tenMon.DataPropertyName = "TenMon";
            this.tenMon.HeaderText = "Tên Môn";
            this.tenMon.MinimumWidth = 6;
            this.tenMon.Name = "tenMon";
            this.tenMon.ReadOnly = true;
            this.tenMon.Width = 230;
            // 
            // soTinChi
            // 
            this.soTinChi.DataPropertyName = "SoTinChi";
            this.soTinChi.HeaderText = "Số Tín Chỉ";
            this.soTinChi.MinimumWidth = 6;
            this.soTinChi.Name = "soTinChi";
            this.soTinChi.ReadOnly = true;
            this.soTinChi.Width = 180;
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "chiTiet";
            this.ChiTiet.MinimumWidth = 6;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.ReadOnly = true;
            this.ChiTiet.Width = 125;
            // 
            // form_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 649);
            this.Controls.Add(this.DGW_DuLieu);
            this.Controls.Add(this.TB_SoTinChi);
            this.Controls.Add(this.TB_MaMon);
            this.Controls.Add(this.TB_TenMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "form_MonHoc";
            this.Text = "form_MonHoc";
            this.Load += new System.EventHandler(this.form_MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_DuLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_TenMon;
        private System.Windows.Forms.TextBox TB_MaMon;
        private System.Windows.Forms.TextBox TB_SoTinChi;
        private System.Windows.Forms.DataGridView DGW_DuLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTinChi;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTiet;
    }
}