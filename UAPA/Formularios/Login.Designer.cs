namespace UAPA
{
    partial class fmrlogin
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.chbclave = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtusuario.Location = new System.Drawing.Point(313, 86);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(394, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.Text = "USUARIO";
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave);
            // 
            // txtclave
            // 
            this.txtclave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.ForeColor = System.Drawing.Color.DimGray;
            this.txtclave.Location = new System.Drawing.Point(313, 133);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(394, 20);
            this.txtclave.TabIndex = 2;
            this.txtclave.Text = "CONTRASEÑA";
            this.txtclave.Enter += new System.EventHandler(this.txtclave_Enter);
            this.txtclave.Leave += new System.EventHandler(this.txtclave_Leave);
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnentrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.FlatAppearance.BorderSize = 0;
            this.btnentrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnentrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnentrar.Location = new System.Drawing.Point(313, 226);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(168, 26);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalir.Location = new System.Drawing.Point(539, 226);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(168, 26);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // chbclave
            // 
            this.chbclave.AutoSize = true;
            this.chbclave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbclave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbclave.ForeColor = System.Drawing.Color.LightGray;
            this.chbclave.Location = new System.Drawing.Point(313, 180);
            this.chbclave.Name = "chbclave";
            this.chbclave.Size = new System.Drawing.Size(123, 17);
            this.chbclave.TabIndex = 3;
            this.chbclave.Text = "Visualizar contraseña";
            this.chbclave.UseVisualStyleBackColor = true;
            this.chbclave.CheckedChanged += new System.EventHandler(this.chbclave_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 291);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.pictureBox1.Image = global::UAPA.Properties.Resources.LOGO_AZUL;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(461, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::UAPA.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(742, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // fmrlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(764, 291);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chbclave);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrlogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fmrlogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fmrlogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.CheckBox chbclave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}