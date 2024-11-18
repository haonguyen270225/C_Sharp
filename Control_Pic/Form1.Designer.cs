namespace Control_Pic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            picAnh = new PictureBox();
            lblTenAnh = new Label();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(53, 488);
            button1.Name = "button1";
            button1.Size = new Size(227, 94);
            button1.TabIndex = 0;
            button1.Text = "Chọn ảnh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // picAnh
            // 
            picAnh.Image = Properties.Resources._1;
            picAnh.Location = new Point(12, 12);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(776, 433);
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnh.TabIndex = 1;
            picAnh.TabStop = false;
            // 
            // lblTenAnh
            // 
            lblTenAnh.BackColor = Color.Silver;
            lblTenAnh.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenAnh.ForeColor = Color.FromArgb(255, 128, 128);
            lblTenAnh.Location = new Point(433, 488);
            lblTenAnh.Name = "lblTenAnh";
            lblTenAnh.Size = new Size(244, 94);
            lblTenAnh.TabIndex = 2;
            lblTenAnh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 594);
            Controls.Add(lblTenAnh);
            Controls.Add(picAnh);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox picAnh;
        private Label lblTenAnh;
    }
}
