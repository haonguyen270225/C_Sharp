namespace BaiTapChuong4
{
    partial class form_GiaiPT
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
            this.rB_PT2 = new System.Windows.Forms.RadioButton();
            this.rB_PT1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_Thoat = new System.Windows.Forms.Button();
            this.b_Xoa = new System.Windows.Forms.Button();
            this.b_GiaiPT = new System.Windows.Forms.Button();
            this.tB_KetQua = new System.Windows.Forms.TextBox();
            this.tB_NhapC = new System.Windows.Forms.TextBox();
            this.tB_NhapB = new System.Windows.Forms.TextBox();
            this.tB_NhapA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình bặc 1 , 2 !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_PT2);
            this.groupBox1.Controls.Add(this.rB_PT1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phương trình :";
            // 
            // rB_PT2
            // 
            this.rB_PT2.AutoSize = true;
            this.rB_PT2.Location = new System.Drawing.Point(70, 98);
            this.rB_PT2.Name = "rB_PT2";
            this.rB_PT2.Size = new System.Drawing.Size(203, 27);
            this.rB_PT2.TabIndex = 3;
            this.rB_PT2.TabStop = true;
            this.rB_PT2.Text = "Phương trình bặc 2 !";
            this.rB_PT2.UseVisualStyleBackColor = true;
            this.rB_PT2.CheckedChanged += new System.EventHandler(this.rB_PT2_CheckedChanged);
            // 
            // rB_PT1
            // 
            this.rB_PT1.AutoSize = true;
            this.rB_PT1.Location = new System.Drawing.Point(70, 49);
            this.rB_PT1.Name = "rB_PT1";
            this.rB_PT1.Size = new System.Drawing.Size(203, 27);
            this.rB_PT1.TabIndex = 2;
            this.rB_PT1.TabStop = true;
            this.rB_PT1.Text = "Phương trình bặc 1 !";
            this.rB_PT1.UseVisualStyleBackColor = true;
            this.rB_PT1.CheckedChanged += new System.EventHandler(this.rB_PT1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_Thoat);
            this.groupBox2.Controls.Add(this.b_Xoa);
            this.groupBox2.Controls.Add(this.b_GiaiPT);
            this.groupBox2.Controls.Add(this.tB_KetQua);
            this.groupBox2.Controls.Add(this.tB_NhapC);
            this.groupBox2.Controls.Add(this.tB_NhapB);
            this.groupBox2.Controls.Add(this.tB_NhapA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 368);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // b_Thoat
            // 
            this.b_Thoat.Location = new System.Drawing.Point(431, 177);
            this.b_Thoat.Name = "b_Thoat";
            this.b_Thoat.Size = new System.Drawing.Size(121, 63);
            this.b_Thoat.TabIndex = 10;
            this.b_Thoat.Text = "Thoát";
            this.b_Thoat.UseVisualStyleBackColor = true;
            this.b_Thoat.Click += new System.EventHandler(this.b_Thoat_Click);
            // 
            // b_Xoa
            // 
            this.b_Xoa.Location = new System.Drawing.Point(431, 98);
            this.b_Xoa.Name = "b_Xoa";
            this.b_Xoa.Size = new System.Drawing.Size(121, 63);
            this.b_Xoa.TabIndex = 9;
            this.b_Xoa.Text = "Xóa";
            this.b_Xoa.UseVisualStyleBackColor = true;
            this.b_Xoa.Click += new System.EventHandler(this.b_Xoa_Click);
            // 
            // b_GiaiPT
            // 
            this.b_GiaiPT.Location = new System.Drawing.Point(431, 29);
            this.b_GiaiPT.Name = "b_GiaiPT";
            this.b_GiaiPT.Size = new System.Drawing.Size(121, 63);
            this.b_GiaiPT.TabIndex = 8;
            this.b_GiaiPT.Text = "Giải PT";
            this.b_GiaiPT.UseVisualStyleBackColor = true;
            this.b_GiaiPT.Click += new System.EventHandler(this.b_GiaiPT_Click);
            // 
            // tB_KetQua
            // 
            this.tB_KetQua.Enabled = false;
            this.tB_KetQua.Location = new System.Drawing.Point(109, 191);
            this.tB_KetQua.Multiline = true;
            this.tB_KetQua.Name = "tB_KetQua";
            this.tB_KetQua.Size = new System.Drawing.Size(316, 171);
            this.tB_KetQua.TabIndex = 7;
            // 
            // tB_NhapC
            // 
            this.tB_NhapC.Location = new System.Drawing.Point(109, 129);
            this.tB_NhapC.Name = "tB_NhapC";
            this.tB_NhapC.Size = new System.Drawing.Size(141, 30);
            this.tB_NhapC.TabIndex = 6;
            // 
            // tB_NhapB
            // 
            this.tB_NhapB.Location = new System.Drawing.Point(109, 83);
            this.tB_NhapB.Name = "tB_NhapB";
            this.tB_NhapB.Size = new System.Drawing.Size(141, 30);
            this.tB_NhapB.TabIndex = 5;
            // 
            // tB_NhapA
            // 
            this.tB_NhapA.Location = new System.Drawing.Point(109, 43);
            this.tB_NhapA.Name = "tB_NhapA";
            this.tB_NhapA.Size = new System.Drawing.Size(141, 30);
            this.tB_NhapA.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhập c :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kết quả :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập b :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập a :";
            // 
            // form_GiaiPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "form_GiaiPT";
            this.Text = "Giải Phương Trình Bặc 1 - 2 !";
            this.Load += new System.EventHandler(this.form_GiaiPT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_PT2;
        private System.Windows.Forms.RadioButton rB_PT1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tB_KetQua;
        private System.Windows.Forms.TextBox tB_NhapC;
        private System.Windows.Forms.TextBox tB_NhapB;
        private System.Windows.Forms.TextBox tB_NhapA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_Thoat;
        private System.Windows.Forms.Button b_Xoa;
        private System.Windows.Forms.Button b_GiaiPT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}