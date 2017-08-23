namespace WindowsFormsApplication10
{
    partial class XNOR
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closed = new System.Windows.Forms.PictureBox();
            this.opened = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opened)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(134, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "-";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "-";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication10.Properties.Resources.xor3;
            this.pictureBox1.Location = new System.Drawing.Point(170, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 104);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // closed
            // 
            this.closed.Image = global::WindowsFormsApplication10.Properties.Resources.images__3_;
            this.closed.Location = new System.Drawing.Point(541, 12);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(143, 173);
            this.closed.TabIndex = 7;
            this.closed.TabStop = false;
            this.closed.Visible = false;
            // 
            // opened
            // 
            this.opened.Image = global::WindowsFormsApplication10.Properties.Resources.images__2_;
            this.opened.Location = new System.Drawing.Point(541, 12);
            this.opened.Name = "opened";
            this.opened.Size = new System.Drawing.Size(143, 173);
            this.opened.TabIndex = 6;
            this.opened.TabStop = false;
            // 
            // XNOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 196);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.closed);
            this.Controls.Add(this.opened);
            this.Name = "XNOR";
            this.Text = "XNOR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opened)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox opened;
        private System.Windows.Forms.PictureBox closed;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}