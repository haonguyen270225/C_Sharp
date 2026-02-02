namespace BaiTapChuong4
{
    partial class form_TimUocVaBoi
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tB_KetQua = new System.Windows.Forms.TextBox();
            this.b_Tim = new System.Windows.Forms.Button();
            this.b_BoQua = new System.Windows.Forms.Button();
            this.b_Thoat = new System.Windows.Forms.Button();
            this.rB_USCLN = new System.Windows.Forms.RadioButton();
            this.rB_BSCNN = new System.Windows.Forms.RadioButton();
            this.tB_NhapA = new System.Windows.Forms.TextBox();
            this.tB_NhapB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tB_NhapB);
            this.groupBox1.Controls.Add(this.tB_NhapA);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(367, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập !";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.rB_BSCNN);
            this.groupBox2.Controls.Add(this.rB_USCLN);
            this.groupBox2.Location = new System.Drawing.Point(398, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(216, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm !";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.b_Thoat);
            this.groupBox3.Controls.Add(this.b_BoQua);
            this.groupBox3.Controls.Add(this.b_Tim);
            this.groupBox3.Controls.Add(this.tB_KetQua);
            this.groupBox3.Location = new System.Drawing.Point(23, 240);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(591, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả !";
            // 
            // tB_KetQua
            // 
            this.tB_KetQua.Enabled = false;
            this.tB_KetQua.Location = new System.Drawing.Point(90, 46);
            this.tB_KetQua.Name = "tB_KetQua";
            this.tB_KetQua.Size = new System.Drawing.Size(461, 30);
            this.tB_KetQua.TabIndex = 0;
            // 
            // b_Tim
            // 
            this.b_Tim.Location = new System.Drawing.Point(46, 112);
            this.b_Tim.Name = "b_Tim";
            this.b_Tim.Size = new System.Drawing.Size(123, 53);
            this.b_Tim.TabIndex = 1;
            this.b_Tim.Text = "Tìm";
            this.b_Tim.UseVisualStyleBackColor = true;
            this.b_Tim.Click += new System.EventHandler(this.b_Tim_Click);
            // 
            // b_BoQua
            // 
            this.b_BoQua.Location = new System.Drawing.Point(244, 112);
            this.b_BoQua.Name = "b_BoQua";
            this.b_BoQua.Size = new System.Drawing.Size(123, 53);
            this.b_BoQua.TabIndex = 2;
            this.b_BoQua.Text = "Bỏ Qua";
            this.b_BoQua.UseVisualStyleBackColor = true;
            this.b_BoQua.Click += new System.EventHandler(this.b_BoQua_Click);
            // 
            // b_Thoat
            // 
            this.b_Thoat.Location = new System.Drawing.Point(428, 112);
            this.b_Thoat.Name = "b_Thoat";
            this.b_Thoat.Size = new System.Drawing.Size(123, 53);
            this.b_Thoat.TabIndex = 3;
            this.b_Thoat.Text = "Thoát";
            this.b_Thoat.UseVisualStyleBackColor = true;
            this.b_Thoat.Click += new System.EventHandler(this.b_Thoat_Click);
            // 
            // rB_USCLN
            // 
            this.rB_USCLN.AutoSize = true;
            this.rB_USCLN.Location = new System.Drawing.Point(24, 54);
            this.rB_USCLN.Name = "rB_USCLN";
            this.rB_USCLN.Size = new System.Drawing.Size(97, 27);
            this.rB_USCLN.TabIndex = 0;
            this.rB_USCLN.TabStop = true;
            this.rB_USCLN.Text = "USCLN";
            this.rB_USCLN.UseVisualStyleBackColor = true;
            this.rB_USCLN.CheckedChanged += new System.EventHandler(this.rB_USCLN_CheckedChanged);
            // 
            // rB_BSCNN
            // 
            this.rB_BSCNN.AutoSize = true;
            this.rB_BSCNN.Location = new System.Drawing.Point(24, 109);
            this.rB_BSCNN.Name = "rB_BSCNN";
            this.rB_BSCNN.Size = new System.Drawing.Size(97, 27);
            this.rB_BSCNN.TabIndex = 1;
            this.rB_BSCNN.TabStop = true;
            this.rB_BSCNN.Text = "BSCNN";
            this.rB_BSCNN.UseVisualStyleBackColor = true;
            this.rB_BSCNN.CheckedChanged += new System.EventHandler(this.rB_BSCNN_CheckedChanged);
            // 
            // tB_NhapA
            // 
            this.tB_NhapA.Location = new System.Drawing.Point(90, 51);
            this.tB_NhapA.Name = "tB_NhapA";
            this.tB_NhapA.Size = new System.Drawing.Size(208, 30);
            this.tB_NhapA.TabIndex = 4;
            this.tB_NhapA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_NhapA_KeyPress);
            // 
            // tB_NhapB
            // 
            this.tB_NhapB.Location = new System.Drawing.Point(90, 106);
            this.tB_NhapB.Name = "tB_NhapB";
            this.tB_NhapB.Size = new System.Drawing.Size(208, 30);
            this.tB_NhapB.TabIndex = 5;
            this.tB_NhapB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_NhapA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "A :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "B :";
            // 
            // form_TimUocVaBoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(636, 479);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_TimUocVaBoi";
            this.Text = "form_TimUocVaBoi";
            this.Load += new System.EventHandler(this.form_TimUocVaBoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_NhapB;
        private System.Windows.Forms.TextBox tB_NhapA;
        private System.Windows.Forms.RadioButton rB_BSCNN;
        private System.Windows.Forms.RadioButton rB_USCLN;
        private System.Windows.Forms.Button b_Thoat;
        private System.Windows.Forms.Button b_BoQua;
        private System.Windows.Forms.Button b_Tim;
        private System.Windows.Forms.TextBox tB_KetQua;
    }
}