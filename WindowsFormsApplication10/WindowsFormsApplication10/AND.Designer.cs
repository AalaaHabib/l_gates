namespace WindowsFormsApplication10
{
    partial class AND
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.opened = new System.Windows.Forms.PictureBox();
            this.closed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opened)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closed)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(-78, 147);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "-";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-78, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "-";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(200, 69);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "-";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(200, 95);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(30, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "-";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication10.Properties.Resources.and1;
            this.pictureBox3.Location = new System.Drawing.Point(236, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 52);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // opened
            // 
            this.opened.Image = global::WindowsFormsApplication10.Properties.Resources.images__2_;
            this.opened.Location = new System.Drawing.Point(336, 12);
            this.opened.Name = "opened";
            this.opened.Size = new System.Drawing.Size(143, 173);
            this.opened.TabIndex = 6;
            this.opened.TabStop = false;
            this.opened.Visible = false;
            // 
            // closed
            // 
            this.closed.Image = global::WindowsFormsApplication10.Properties.Resources.images__3_;
            this.closed.Location = new System.Drawing.Point(336, 12);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(143, 173);
            this.closed.TabIndex = 5;
            this.closed.TabStop = false;
            // 
            // AND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 256);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.opened);
            this.Controls.Add(this.closed);
            this.Name = "AND";
            this.Text = "AND";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opened)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox opened;
        private System.Windows.Forms.PictureBox closed;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}