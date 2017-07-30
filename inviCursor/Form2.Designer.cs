namespace inviCursor
{
    partial class Form2
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
            this.btnDificuldade = new System.Windows.Forms.Button();
            this.btnFácil = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnImpo = new System.Windows.Forms.Button();
            this.picCursor = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDificuldade
            // 
            this.btnDificuldade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDificuldade.ForeColor = System.Drawing.Color.Blue;
            this.btnDificuldade.Location = new System.Drawing.Point(12, 12);
            this.btnDificuldade.Name = "btnDificuldade";
            this.btnDificuldade.Size = new System.Drawing.Size(167, 64);
            this.btnDificuldade.TabIndex = 0;
            this.btnDificuldade.Text = "Dificuldade";
            this.btnDificuldade.UseVisualStyleBackColor = true;
            this.btnDificuldade.Click += new System.EventHandler(this.btnDificuldade_Click);
            // 
            // btnFácil
            // 
            this.btnFácil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFácil.ForeColor = System.Drawing.Color.Lime;
            this.btnFácil.Location = new System.Drawing.Point(12, 91);
            this.btnFácil.Name = "btnFácil";
            this.btnFácil.Size = new System.Drawing.Size(167, 35);
            this.btnFácil.TabIndex = 1;
            this.btnFácil.Text = "Fácil";
            this.btnFácil.UseVisualStyleBackColor = true;
            this.btnFácil.Click += new System.EventHandler(this.btnFácil_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMod.Location = new System.Drawing.Point(12, 132);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(166, 35);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "Moderada";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnImpo
            // 
            this.btnImpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpo.ForeColor = System.Drawing.Color.Red;
            this.btnImpo.Location = new System.Drawing.Point(12, 173);
            this.btnImpo.Name = "btnImpo";
            this.btnImpo.Size = new System.Drawing.Size(167, 34);
            this.btnImpo.TabIndex = 3;
            this.btnImpo.Text = "Impossivel";
            this.btnImpo.UseVisualStyleBackColor = true;
            // 
            // picCursor
            // 
            this.picCursor.Image = global::inviCursor.Properties.Resources.Mouse_cursor_icon;
            this.picCursor.Location = new System.Drawing.Point(13, 82);
            this.picCursor.Name = "picCursor";
            this.picCursor.Size = new System.Drawing.Size(166, 130);
            this.picCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCursor.TabIndex = 4;
            this.picCursor.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(13, 218);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(165, 46);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 356);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.picCursor);
            this.Controls.Add(this.btnImpo);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnFácil);
            this.Controls.Add(this.btnDificuldade);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picCursor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDificuldade;
        private System.Windows.Forms.Button btnFácil;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnImpo;
        private System.Windows.Forms.PictureBox picCursor;
        private System.Windows.Forms.Button btnSair;
    }
}