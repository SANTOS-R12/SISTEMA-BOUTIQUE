namespace SISTEMA
{
    partial class ErrorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.BorderRadius = 5;
            this.btnIniciar.ButtonText = "Aceptar";
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.DisabledColor = System.Drawing.Color.Gray;
            this.btnIniciar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIniciar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Iconimage")));
            this.btnIniciar.Iconimage_right = null;
            this.btnIniciar.Iconimage_right_Selected = null;
            this.btnIniciar.Iconimage_Selected = null;
            this.btnIniciar.IconMarginLeft = 0;
            this.btnIniciar.IconMarginRight = 0;
            this.btnIniciar.IconRightVisible = true;
            this.btnIniciar.IconRightZoom = 0D;
            this.btnIniciar.IconVisible = false;
            this.btnIniciar.IconZoom = 90D;
            this.btnIniciar.IsTab = false;
            this.btnIniciar.Location = new System.Drawing.Point(49, 178);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.btnIniciar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.btnIniciar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIniciar.selected = false;
            this.btnIniciar.Size = new System.Drawing.Size(108, 28);
            this.btnIniciar.TabIndex = 33;
            this.btnIniciar.Text = "Aceptar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciar.Textcolor = System.Drawing.Color.White;
            this.btnIniciar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(2, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 42);
            this.label1.TabIndex = 34;
            this.label1.Text = "Usuario y/o Contraseña Incorrecta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorLogin";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ErrorLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnIniciar;
        private System.Windows.Forms.Label label1;
    }
}