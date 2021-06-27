namespace UAPA
{
    partial class fmrfacilitador
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
            this.btnconsulta = new System.Windows.Forms.Button();
            this.txtconsultaf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvconsultaf = new System.Windows.Forms.DataGridView();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.txtfeching = new System.Windows.Forms.TextBox();
            this.cmbdoc = new System.Windows.Forms.ComboBox();
            this.rtbestualcan = new System.Windows.Forms.RichTextBox();
            this.cmbsta = new System.Windows.Forms.ComboBox();
            this.btnnuevorg = new System.Windows.Forms.Button();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.txtide = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txteda = new System.Windows.Forms.TextBox();
            this.txtciu = new System.Windows.Forms.TextBox();
            this.txtpai = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtfcnaci = new System.Windows.Forms.TextBox();
            this.txtcodfac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaf)).BeginInit();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.tp1.Controls.Add(this.btnconsulta);
            this.tp1.Controls.Add(this.txtconsultaf);
            this.tp1.Controls.Add(this.label13);
            this.tp1.Controls.Add(this.dgvconsultaf);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(1028, 424);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Consultar facilitadores";
            this.tp1.Click += new System.EventHandler(this.tp1_Click);
            // 
            // btnconsulta
            // 
            this.btnconsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsulta.ForeColor = System.Drawing.Color.LightGray;
            this.btnconsulta.Location = new System.Drawing.Point(922, 29);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(89, 23);
            this.btnconsulta.TabIndex = 2;
            this.btnconsulta.Text = "CONSULTAR";
            this.btnconsulta.UseVisualStyleBackColor = true;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // txtconsultaf
            // 
            this.txtconsultaf.Location = new System.Drawing.Point(715, 31);
            this.txtconsultaf.Name = "txtconsultaf";
            this.txtconsultaf.Size = new System.Drawing.Size(175, 20);
            this.txtconsultaf.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(379, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ingrese el Código  Para Realizar la busqueda ========>>>>>";
            // 
            // dgvconsultaf
            // 
            this.dgvconsultaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultaf.Location = new System.Drawing.Point(6, 80);
            this.dgvconsultaf.Name = "dgvconsultaf";
            this.dgvconsultaf.Size = new System.Drawing.Size(1021, 334);
            this.dgvconsultaf.TabIndex = 0;
            this.dgvconsultaf.DoubleClick += new System.EventHandler(this.dgvconsultaf_DoubleClick);
            // 
            // tp2
            // 
            this.tp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.tp2.Controls.Add(this.txtfeching);
            this.tp2.Controls.Add(this.cmbdoc);
            this.tp2.Controls.Add(this.rtbestualcan);
            this.tp2.Controls.Add(this.cmbsta);
            this.tp2.Controls.Add(this.btnnuevorg);
            this.tp2.Controls.Add(this.cmbsex);
            this.tp2.Controls.Add(this.txtide);
            this.tp2.Controls.Add(this.label16);
            this.tp2.Controls.Add(this.txttel);
            this.tp2.Controls.Add(this.label15);
            this.tp2.Controls.Add(this.label14);
            this.tp2.Controls.Add(this.label12);
            this.tp2.Controls.Add(this.label11);
            this.tp2.Controls.Add(this.label10);
            this.tp2.Controls.Add(this.txtape);
            this.tp2.Controls.Add(this.txtdir);
            this.tp2.Controls.Add(this.txteda);
            this.tp2.Controls.Add(this.txtciu);
            this.tp2.Controls.Add(this.txtpai);
            this.tp2.Controls.Add(this.txtnom);
            this.tp2.Controls.Add(this.txtfcnaci);
            this.tp2.Controls.Add(this.txtcodfac);
            this.tp2.Controls.Add(this.label9);
            this.tp2.Controls.Add(this.label8);
            this.tp2.Controls.Add(this.label7);
            this.tp2.Controls.Add(this.label6);
            this.tp2.Controls.Add(this.label5);
            this.tp2.Controls.Add(this.label4);
            this.tp2.Controls.Add(this.label3);
            this.tp2.Controls.Add(this.label2);
            this.tp2.Controls.Add(this.label1);
            this.tp2.Controls.Add(this.btnregistrar);
            this.tp2.Controls.Add(this.pictureBox1);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(1028, 424);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Registrar facilitadores";
            this.tp2.Click += new System.EventHandler(this.tp2_Click);
            // 
            // txtfeching
            // 
            this.txtfeching.Location = new System.Drawing.Point(324, 103);
            this.txtfeching.Name = "txtfeching";
            this.txtfeching.Size = new System.Drawing.Size(116, 20);
            this.txtfeching.TabIndex = 12;
            // 
            // cmbdoc
            // 
            this.cmbdoc.FormattingEnabled = true;
            this.cmbdoc.Items.AddRange(new object[] {
            "Cedu",
            "Pasa"});
            this.cmbdoc.Location = new System.Drawing.Point(104, 150);
            this.cmbdoc.Name = "cmbdoc";
            this.cmbdoc.Size = new System.Drawing.Size(116, 21);
            this.cmbdoc.TabIndex = 4;
            // 
            // rtbestualcan
            // 
            this.rtbestualcan.Location = new System.Drawing.Point(238, 284);
            this.rtbestualcan.Name = "rtbestualcan";
            this.rtbestualcan.Size = new System.Drawing.Size(202, 53);
            this.rtbestualcan.TabIndex = 15;
            this.rtbestualcan.Text = "";
            // 
            // cmbsta
            // 
            this.cmbsta.FormattingEnabled = true;
            this.cmbsta.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmbsta.Location = new System.Drawing.Point(324, 199);
            this.cmbsta.Name = "cmbsta";
            this.cmbsta.Size = new System.Drawing.Size(116, 21);
            this.cmbsta.TabIndex = 14;
            // 
            // btnnuevorg
            // 
            this.btnnuevorg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnuevorg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevorg.ForeColor = System.Drawing.Color.LightGray;
            this.btnnuevorg.Location = new System.Drawing.Point(243, 362);
            this.btnnuevorg.Name = "btnnuevorg";
            this.btnnuevorg.Size = new System.Drawing.Size(86, 48);
            this.btnnuevorg.TabIndex = 16;
            this.btnnuevorg.Text = "Nuevo Registro";
            this.btnnuevorg.UseVisualStyleBackColor = true;
            this.btnnuevorg.Click += new System.EventHandler(this.btnnuevorg_Click);
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsex.Location = new System.Drawing.Point(324, 150);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(116, 21);
            this.cmbsex.TabIndex = 13;
            // 
            // txtide
            // 
            this.txtide.Location = new System.Drawing.Point(104, 199);
            this.txtide.Name = "txtide";
            this.txtide.Size = new System.Drawing.Size(116, 20);
            this.txtide.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(9, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "No. identificacion";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(104, 246);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(116, 20);
            this.txttel.TabIndex = 6;
            this.txttel.TextChanged += new System.EventHandler(this.txttel_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(283, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Edad ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(281, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(235, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Estudios Alcanzado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(225, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Fecha Nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(240, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha Ingreso ";
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(104, 103);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(116, 20);
            this.txtape.TabIndex = 3;
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(104, 295);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(116, 20);
            this.txtdir.TabIndex = 7;
            // 
            // txteda
            // 
            this.txteda.Location = new System.Drawing.Point(324, 59);
            this.txteda.Name = "txteda";
            this.txteda.Size = new System.Drawing.Size(116, 20);
            this.txteda.TabIndex = 11;
            // 
            // txtciu
            // 
            this.txtciu.Location = new System.Drawing.Point(104, 340);
            this.txtciu.Name = "txtciu";
            this.txtciu.Size = new System.Drawing.Size(116, 20);
            this.txtciu.TabIndex = 8;
            // 
            // txtpai
            // 
            this.txtpai.Location = new System.Drawing.Point(104, 384);
            this.txtpai.Name = "txtpai";
            this.txtpai.Size = new System.Drawing.Size(116, 20);
            this.txtpai.TabIndex = 9;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(104, 59);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(116, 20);
            this.txtnom.TabIndex = 2;
            // 
            // txtfcnaci
            // 
            this.txtfcnaci.Location = new System.Drawing.Point(324, 15);
            this.txtfcnaci.Name = "txtfcnaci";
            this.txtfcnaci.Size = new System.Drawing.Size(116, 20);
            this.txtfcnaci.TabIndex = 10;
            // 
            // txtcodfac
            // 
            this.txtcodfac.Location = new System.Drawing.Point(104, 15);
            this.txtcodfac.Name = "txtcodfac";
            this.txtcodfac.Size = new System.Drawing.Size(116, 20);
            this.txtcodfac.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(284, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sexo ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(58, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(71, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(46, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(49, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(17, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de docum.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(54, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(57, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo ";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnregistrar.Location = new System.Drawing.Point(340, 362);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(100, 48);
            this.btnregistrar.TabIndex = 17;
            this.btnregistrar.Text = "Registrar Facilitador";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UAPA.Properties.Resources.UAPA_celebra;
            this.pictureBox1.Location = new System.Drawing.Point(450, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.LightGray;
            this.label17.Location = new System.Drawing.Point(666, 477);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(215, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Regresar al Menu Principal ========>>>>>";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(908, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "MENU INICIO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::UAPA.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(1017, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // fmrfacilitador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1039, 512);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmrfacilitador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facilitadores";
            this.Load += new System.EventHandler(this.fmrfacilitador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaf)).EndInit();
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
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TextBox txtcodfac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnnuevorg;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txteda;
        private System.Windows.Forms.TextBox txtciu;
        private System.Windows.Forms.TextBox txtpai;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtfcnaci;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.TextBox txtconsultaf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvconsultaf;
        private System.Windows.Forms.TextBox txtide;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rtbestualcan;
        private System.Windows.Forms.ComboBox cmbsta;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.ComboBox cmbdoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtfeching;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}