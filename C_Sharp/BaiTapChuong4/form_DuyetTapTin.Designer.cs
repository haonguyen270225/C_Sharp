namespace BaiTapChuong4
{
    partial class form_DuyetTapTin
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
            this.lV_DuyetTapTin = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lV_DuyetTapTin
            // 
            this.lV_DuyetTapTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lV_DuyetTapTin.HideSelection = false;
            this.lV_DuyetTapTin.Location = new System.Drawing.Point(0, 0);
            this.lV_DuyetTapTin.Name = "lV_DuyetTapTin";
            this.lV_DuyetTapTin.Size = new System.Drawing.Size(696, 408);
            this.lV_DuyetTapTin.TabIndex = 0;
            this.lV_DuyetTapTin.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "ListVIew1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 86);
            this.button2.TabIndex = 2;
            this.button2.Text = "ListView2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // form_DuyetTapTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lV_DuyetTapTin);
            this.Name = "form_DuyetTapTin";
            this.Text = "form_DuyetTapTin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lV_DuyetTapTin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}