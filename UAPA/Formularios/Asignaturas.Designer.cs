namespace UAPA
{
    partial class fmrasignaturas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.btnconsultaA = new System.Windows.Forms.Button();
            this.txtconsultaA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvconsultaA = new System.Windows.Forms.DataGridView();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbestatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnnuevorgA = new System.Windows.Forms.Button();
            this.txthorast = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txthorasp = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcreditos = new System.Windows.Forms.TextBox();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtcodasig = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaA)).BeginInit();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.tp1.Controls.Add(this.btnconsultaA);
            this.tp1.Controls.Add(this.txtconsultaA);
            this.tp1.Controls.Add(this.label13);
            this.tp1.Controls.Add(this.dgvconsultaA);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(1050, 424);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Consultar asignaturas";
            this.tp1.Click += new System.EventHandler(this.tp1_Click);
            // 
            // btnconsultaA
            // 
            this.btnconsultaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btnconsultaA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnconsultaA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsultaA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultaA.ForeColor = System.Drawing.Color.LightGray;
            this.btnconsultaA.Location = new System.Drawing.Point(942, 28);
            this.btnconsultaA.Name = "btnconsultaA";
            this.btnconsultaA.Size = new System.Drawing.Size(89, 23);
            this.btnconsultaA.TabIndex = 2;
            this.btnconsultaA.Text = "CONSULTAR";
            this.btnconsultaA.UseVisualStyleBackColor = false;
            this.btnconsultaA.Click += new System.EventHandler(this.btnconsultaA_Click);
            // 
            // txtconsultaA
            // 
            this.txtconsultaA.Location = new System.Drawing.Point(730, 30);
            this.txtconsultaA.Name = "txtconsultaA";
            this.txtconsultaA.Size = new System.Drawing.Size(175, 20);
            this.txtconsultaA.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(378, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ingrese el Código Para Realizar la Consulta ========>>>>>";
            // 
            // dgvconsultaA
            // 
            this.dgvconsultaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultaA.Location = new System.Drawing.Point(6, 77);
            this.dgvconsultaA.Name = "dgvconsultaA";
            this.dgvconsultaA.Size = new System.Drawing.Size(1035, 338);
            this.dgvconsultaA.TabIndex = 0;
            this.dgvconsultaA.DoubleClick += new System.EventHandler(this.dgvconsultaA_DoubleClick);
            // 
            // tp2
            // 
            this.tp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.tp2.Controls.Add(this.pictureBox1);
            this.tp2.Controls.Add(this.cmbestatus);
            this.tp2.Controls.Add(this.label4);
            this.tp2.Controls.Add(this.btnnuevorgA);
            this.tp2.Controls.Add(this.txthorast);
            this.tp2.Controls.Add(this.label16);
            this.tp2.Controls.Add(this.txthorasp);
            this.tp2.Controls.Add(this.txtnombre);
            this.tp2.Controls.Add(this.txtcreditos);
            this.tp2.Controls.Add(this.txtpre);
            this.tp2.Controls.Add(this.txtclave);
            this.tp2.Controls.Add(this.txtcodasig);
            this.tp2.Controls.Add(this.label8);
            this.tp2.Controls.Add(this.label6);
            this.tp2.Controls.Add(this.label5);
            this.tp2.Controls.Add(this.label3);
            this.tp2.Controls.Add(this.label2);
            this.tp2.Controls.Add(this.label1);
            this.tp2.Controls.Add(this.btnguardar);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(1050, 424);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Registrar asignaturas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UAPA.Properties.Resources._116996482_10157288570051767_2666069195324034681_o;
            this.pictureBox1.Location = new System.Drawing.Point(544, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // cmbestatus
            // 
            this.cmbestatus.FormattingEnabled = true;
            this.cmbestatus.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmbestatus.Location = new System.Drawing.Point(103, 229);
            this.cmbestatus.Name = "cmbestatus";
            this.cmbestatus.Size = new System.Drawing.Size(116, 21);
            this.cmbestatus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(49, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Status";
            // 
            // btnnuevorgA
            // 
            this.btnnuevorgA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btnnuevorgA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevorgA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevorgA.ForeColor = System.Drawing.Color.LightGray;
            this.btnnuevorgA.Location = new System.Drawing.Point(234, 301);
            this.btnnuevorgA.Name = "btnnuevorgA";
            this.btnnuevorgA.Size = new System.Drawing.Size(100, 33);
            this.btnnuevorgA.TabIndex = 9;
            this.btnnuevorgA.Text = "Nuevo Registro";
            this.btnnuevorgA.UseVisualStyleBackColor = false;
            this.btnnuevorgA.Click += new System.EventHandler(this.btnnuevorgA_Click);
            // 
            // txthorast
            // 
            this.txthorast.Location = new System.Drawing.Point(351, 90);
            this.txthorast.Name = "txthorast";
            this.txthorast.Size = new System.Drawing.Size(116, 20);
            this.txthorast.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(255, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Horas Teóricas";
            // 
            // txthorasp
            // 
            this.txthorasp.Location = new System.Drawing.Point(351, 138);
            this.txthorasp.Name = "txthorasp";
            this.txthorasp.Size = new System.Drawing.Size(116, 20);
            this.txthorasp.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(103, 183);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(116, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtcreditos
            // 
            this.txtcreditos.Location = new System.Drawing.Point(351, 187);
            this.txtcreditos.Name = "txtcreditos";
            this.txtcreditos.Size = new System.Drawing.Size(116, 20);
            this.txtcreditos.TabIndex = 7;
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(351, 232);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(116, 20);
            this.txtpre.TabIndex = 8;
            this.txtpre.TextChanged += new System.EventHandler(this.txtpre_TextChanged);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(103, 139);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(116, 20);
            this.txtclave.TabIndex = 2;
            // 
            // txtcodasig
            // 
            this.txtcodasig.Location = new System.Drawing.Point(103, 96);
            this.txtcodasig.Name = "txtcodasig";
            this.txtcodasig.Size = new System.Drawing.Size(116, 20);
            this.txtcodasig.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(256, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Pre. Requisitos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(244, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cantidad Créditos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(252, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Horas Prácticas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(52, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(42, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(43, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo ";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.LightGray;
            this.btnguardar.Location = new System.Drawing.Point(349, 301);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(118, 33);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Registrar Asignatura";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(662, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Regresar al Menu Principal ========>>>>>";
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.btninicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.ForeColor = System.Drawing.Color.LightGray;
            this.btninicio.Location = new System.Drawing.Point(918, 464);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(103, 36);
            this.btninicio.TabIndex = 11;
            this.btninicio.Text = "MENU INICIO";
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::UAPA.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(1034, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // fmrasignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1057, 512);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrasignaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.fmrasignaturas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaA)).EndInit();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.Button btnconsultaA;
        private System.Windows.Forms.TextBox txtconsultaA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvconsultaA;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TextBox txthorast;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txthorasp;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcreditos;
        private System.Windows.Forms.TextBox txtpre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtcodasig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevorgA;
        private System.Windows.Forms.ComboBox cmbestatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}