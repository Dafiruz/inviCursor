namespace inviCursor
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.picTarget2 = new System.Windows.Forms.PictureBox();
            this.picTarget3 = new System.Windows.Forms.PictureBox();
            this.picTarget = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTarget2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // picTarget2
            // 
            this.picTarget2.Image = global::inviCursor.Properties.Resources.plate;
            this.picTarget2.Location = new System.Drawing.Point(163, 31);
            this.picTarget2.Name = "picTarget2";
            this.picTarget2.Size = new System.Drawing.Size(100, 100);
            this.picTarget2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTarget2.TabIndex = 2;
            this.picTarget2.TabStop = false;
            // 
            // picTarget3
            // 
            this.picTarget3.Image = global::inviCursor.Properties.Resources.plate;
            this.picTarget3.Location = new System.Drawing.Point(81, 137);
            this.picTarget3.Name = "picTarget3";
            this.picTarget3.Size = new System.Drawing.Size(100, 100);
            this.picTarget3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTarget3.TabIndex = 1;
            this.picTarget3.TabStop = false;
            // 
            // picTarget
            // 
            this.picTarget.Image = global::inviCursor.Properties.Resources.plate;
            this.picTarget.Location = new System.Drawing.Point(7, 48);
            this.picTarget.Name = "picTarget";
            this.picTarget.Size = new System.Drawing.Size(100, 100);
            this.picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTarget.TabIndex = 0;
            this.picTarget.TabStop = false;
            this.picTarget.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 214);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picTarget2);
            this.Controls.Add(this.picTarget3);
            this.Controls.Add(this.picTarget);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.picTarget2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.PictureBox picTarget3;
        private System.Windows.Forms.PictureBox picTarget2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer time;
    }
}