namespace WindowsFormsApplication10
{
    partial class NOT
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.opened = new System.Windows.Forms.PictureBox();
            this.closed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opened)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closed)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(170, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "-";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication10.Properties.Resources.تنزيل;
            this.pictureBox2.Location = new System.Drawing.Point(233, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 167);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // opened
            // 
            this.opened.Image = global::WindowsFormsApplication10.Properties.Resources.images__2_;
            this.opened.Location = new System.Drawing.Point(544, 21);
            this.opened.Name = "opened";
            this.opened.Size = new System.Drawing.Size(143, 173);
            this.opened.TabIndex = 9;
            this.opened.TabStop = false;
            this.opened.Click += new System.EventHandler(this.opened_Click);
            // 
            // closed
            // 
            this.closed.Image = global::WindowsFormsApplication10.Properties.Resources.images__3_;
            this.closed.Location = new System.Drawing.Point(544, 21);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(143, 173);
            this.closed.TabIndex = 8;
            this.closed.TabStop = false;
            // 
            // NOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 277);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.opened);
            this.Controls.Add(this.closed);
            this.Name = "NOT";
            this.Text = "NOT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opened)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closed;
        private System.Windows.Forms.PictureBox opened;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}