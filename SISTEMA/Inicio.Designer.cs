namespace SISTEMA
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblCarga = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.btnContinuar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ptb5 = new System.Windows.Forms.PictureBox();
            this.ptb4 = new System.Windows.Forms.PictureBox();
            this.ptb3 = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.BackColor = System.Drawing.Color.Transparent;
            this.lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarga.ForeColor = System.Drawing.Color.White;
            this.lblCarga.Location = new System.Drawing.Point(156, 339);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(126, 20);
            this.lblCarga.TabIndex = 33;
            this.lblCarga.Text = "Cargando al 0 %";
            this.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(311, 339);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 12);
            this.lblTexto.TabIndex = 39;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1500;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinuar.BorderRadius = 5;
            this.btnContinuar.ButtonText = "Continuar";
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.DisabledColor = System.Drawing.Color.Gray;
            this.btnContinuar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContinuar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContinuar.Iconimage")));
            this.btnContinuar.Iconimage_right = null;
            this.btnContinuar.Iconimage_right_Selected = null;
            this.btnContinuar.Iconimage_Selected = null;
            this.btnContinuar.IconMarginLeft = 0;
            this.btnContinuar.IconMarginRight = 0;
            this.btnContinuar.IconRightVisible = true;
            this.btnContinuar.IconRightZoom = 0D;
            this.btnContinuar.IconVisible = false;
            this.btnContinuar.IconZoom = 90D;
            this.btnContinuar.IsTab = false;
            this.btnContinuar.Location = new System.Drawing.Point(130, 259);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnContinuar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(210)))), ((int)(((byte)(63)))));
            this.btnContinuar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContinuar.selected = false;
            this.btnContinuar.Size = new System.Drawing.Size(181, 44);
            this.btnContinuar.TabIndex = 40;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContinuar.Textcolor = System.Drawing.Color.White;
            this.btnContinuar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // ptb5
            // 
            this.ptb5.BackColor = System.Drawing.Color.Transparent;
            this.ptb5.BackgroundImage = global::SISTEMA.Properties.Resources.circle1;
            this.ptb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb5.Location = new System.Drawing.Point(263, 314);
            this.ptb5.Name = "ptb5";
            this.ptb5.Size = new System.Drawing.Size(20, 20);
            this.ptb5.TabIndex = 34;
            this.ptb5.TabStop = false;
            // 
            // ptb4
            // 
            this.ptb4.BackColor = System.Drawing.Color.Transparent;
            this.ptb4.BackgroundImage = global::SISTEMA.Properties.Resources.circle1;
            this.ptb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb4.Location = new System.Drawing.Point(237, 314);
            this.ptb4.Name = "ptb4";
            this.ptb4.Size = new System.Drawing.Size(20, 20);
            this.ptb4.TabIndex = 35;
            this.ptb4.TabStop = false;
            // 
            // ptb3
            // 
            this.ptb3.BackColor = System.Drawing.Color.Transparent;
            this.ptb3.BackgroundImage = global::SISTEMA.Properties.Resources.circle1;
            this.ptb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb3.Location = new System.Drawing.Point(211, 314);
            this.ptb3.Name = "ptb3";
            this.ptb3.Size = new System.Drawing.Size(20, 20);
            this.ptb3.TabIndex = 36;
            this.ptb3.TabStop = false;
            // 
            // ptb2
            // 
            this.ptb2.BackColor = System.Drawing.Color.Transparent;
            this.ptb2.BackgroundImage = global::SISTEMA.Properties.Resources.circle1;
            this.ptb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb2.Location = new System.Drawing.Point(185, 314);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(20, 20);
            this.ptb2.TabIndex = 37;
            this.ptb2.TabStop = false;
            // 
            // ptb1
            // 
            this.ptb1.BackColor = System.Drawing.Color.Transparent;
            this.ptb1.BackgroundImage = global::SISTEMA.Properties.Resources.circle1;
            this.ptb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb1.Location = new System.Drawing.Point(159, 314);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(20, 20);
            this.ptb1.TabIndex = 38;
            this.ptb1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(438, 368);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.ptb5);
            this.Controls.Add(this.ptb4);
            this.Controls.Add(this.ptb3);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptb5;
        private System.Windows.Forms.PictureBox ptb4;
        private System.Windows.Forms.PictureBox ptb3;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Timer timerTime;
        private Bunifu.Framework.UI.BunifuFlatButton btnContinuar;
    }
}