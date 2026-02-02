namespace BaiTapChuong4
{
    partial class form_TinhToan
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoA = new System.Windows.Forms.TextBox();
            this.txt_SoB = new System.Windows.Forms.TextBox();
            this.btn_Cong = new System.Windows.Forms.Button();
            this.btn_Nhan = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_KetQua = new System.Windows.Forms.Button();
            this.btn_Chia = new System.Windows.Forms.Button();
            this.btn__Tru = new System.Windows.Forms.Button();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực Hiện Các Phép Tính";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_KetQua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_KetQua);
            this.groupBox1.Controls.Add(this.btn_Chia);
            this.groupBox1.Controls.Add(this.btn_Nhan);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn__Tru);
            this.groupBox1.Controls.Add(this.btn_Cong);
            this.groupBox1.Controls.Add(this.txt_SoB);
            this.groupBox1.Controls.Add(this.txt_SoA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bàn tính !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập số a :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập số b :";
            // 
            // txt_SoA
            // 
            this.txt_SoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoA.Location = new System.Drawing.Point(197, 57);
            this.txt_SoA.Name = "txt_SoA";
            this.txt_SoA.Size = new System.Drawing.Size(168, 30);
            this.txt_SoA.TabIndex = 2;
            // 
            // txt_SoB
            // 
            this.txt_SoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoB.Location = new System.Drawing.Point(197, 101);
            this.txt_SoB.Name = "txt_SoB";
            this.txt_SoB.Size = new System.Drawing.Size(168, 30);
            this.txt_SoB.TabIndex = 3;
            // 
            // btn_Cong
            // 
            this.btn_Cong.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Cong.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cong.Location = new System.Drawing.Point(-11, 188);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(146, 75);
            this.btn_Cong.TabIndex = 4;
            this.btn_Cong.Text = "+";
            this.btn_Cong.UseVisualStyleBackColor = false;
            // 
            // btn_Nhan
            // 
            this.btn_Nhan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Nhan.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Nhan.Location = new System.Drawing.Point(293, 188);
            this.btn_Nhan.Name = "btn_Nhan";
            this.btn_Nhan.Size = new System.Drawing.Size(146, 75);
            this.btn_Nhan.TabIndex = 7;
            this.btn_Nhan.Text = "*";
            this.btn_Nhan.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Xoa.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xoa.Location = new System.Drawing.Point(769, 188);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(146, 75);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_KetQua
            // 
            this.btn_KetQua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_KetQua.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_KetQua.Location = new System.Drawing.Point(606, 188);
            this.btn_KetQua.Name = "btn_KetQua";
            this.btn_KetQua.Size = new System.Drawing.Size(146, 75);
            this.btn_KetQua.TabIndex = 9;
            this.btn_KetQua.Text = "Kết Quả";
            this.btn_KetQua.UseVisualStyleBackColor = false;
            this.btn_KetQua.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Chia
            // 
            this.btn_Chia.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Chia.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Chia.Location = new System.Drawing.Point(445, 188);
            this.btn_Chia.Name = "btn_Chia";
            this.btn_Chia.Size = new System.Drawing.Size(146, 75);
            this.btn_Chia.TabIndex = 8;
            this.btn_Chia.Text = "/";
            this.btn_Chia.UseVisualStyleBackColor = false;
            // 
            // btn__Tru
            // 
            this.btn__Tru.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn__Tru.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__Tru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn__Tru.Location = new System.Drawing.Point(141, 188);
            this.btn__Tru.Name = "btn__Tru";
            this.btn__Tru.Size = new System.Drawing.Size(146, 75);
            this.btn__Tru.TabIndex = 5;
            this.btn__Tru.Text = "-";
            this.btn__Tru.UseVisualStyleBackColor = false;
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KetQua.Location = new System.Drawing.Point(573, 78);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(168, 30);
            this.txt_KetQua.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kết quả :";
            // 
            // form_TinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_TinhToan";
            this.Text = "Tính Toán !";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_TinhToan_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_TinhToan_FormClosed);
            this.Load += new System.EventHandler(this.form_TinhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_KetQua;
        private System.Windows.Forms.Button btn_Chia;
        private System.Windows.Forms.Button btn_Nhan;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn__Tru;
        private System.Windows.Forms.Button btn_Cong;
        private System.Windows.Forms.TextBox txt_SoB;
        private System.Windows.Forms.TextBox txt_SoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.Label label4;
    }
}