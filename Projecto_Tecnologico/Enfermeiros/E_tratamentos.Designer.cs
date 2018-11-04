namespace Projecto_Tecnologico.Enfermeiros
{
    partial class E_Tratamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_Tratamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.b_min = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.cb_prioridade = new System.Windows.Forms.ComboBox();
            this.dtp_tratamento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_refutente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_horas_trata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_doencas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_oberv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_hora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_utente = new System.Windows.Forms.TextBox();
            this.tb_enfermeiro = new System.Windows.Forms.TextBox();
            this.lb_emissao = new System.Windows.Forms.Label();
            this.lb_de = new System.Windows.Forms.Label();
            this.pb_editar = new System.Windows.Forms.PictureBox();
            this.pb_remover = new System.Windows.Forms.PictureBox();
            this.pb_marcar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_emissao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_hora_registo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_marcar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.b_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 48);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // b_close
            // 
            this.b_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Image = ((System.Drawing.Image)(resources.GetObject("b_close.Image")));
            this.b_close.Location = new System.Drawing.Point(494, 3);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 9;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_min
            // 
            this.b_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_min.Image = ((System.Drawing.Image)(resources.GetObject("b_min.Image")));
            this.b_min.Location = new System.Drawing.Point(461, 3);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 7;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_categoria);
            this.groupBox1.Controls.Add(this.cb_prioridade);
            this.groupBox1.Controls.Add(this.dtp_tratamento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_refutente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_horas_trata);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_doencas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_oberv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_hora);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_utente);
            this.groupBox1.Controls.Add(this.tb_enfermeiro);
            this.groupBox1.Controls.Add(this.lb_emissao);
            this.groupBox1.Controls.Add(this.lb_de);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 273);
            this.groupBox1.TabIndex = 348;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação Tratamento:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.BackColor = System.Drawing.Color.Silver;
            this.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(261, 102);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(209, 21);
            this.cb_categoria.TabIndex = 366;
            // 
            // cb_prioridade
            // 
            this.cb_prioridade.BackColor = System.Drawing.Color.Silver;
            this.cb_prioridade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_prioridade.FormattingEnabled = true;
            this.cb_prioridade.Location = new System.Drawing.Point(10, 227);
            this.cb_prioridade.Name = "cb_prioridade";
            this.cb_prioridade.Size = new System.Drawing.Size(208, 21);
            this.cb_prioridade.TabIndex = 365;
            // 
            // dtp_tratamento
            // 
            this.dtp_tratamento.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dtp_tratamento.Location = new System.Drawing.Point(10, 134);
            this.dtp_tratamento.Name = "dtp_tratamento";
            this.dtp_tratamento.Size = new System.Drawing.Size(210, 20);
            this.dtp_tratamento.TabIndex = 364;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 362;
            this.label9.Text = "ID Utente:";
            // 
            // tb_refutente
            // 
            this.tb_refutente.BackColor = System.Drawing.Color.Silver;
            this.tb_refutente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_refutente.Location = new System.Drawing.Point(10, 44);
            this.tb_refutente.Multiline = true;
            this.tb_refutente.Name = "tb_refutente";
            this.tb_refutente.Size = new System.Drawing.Size(210, 20);
            this.tb_refutente.TabIndex = 363;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 360;
            this.label4.Text = "Categoria Tratamento:";
            // 
            // tb_horas_trata
            // 
            this.tb_horas_trata.BackColor = System.Drawing.Color.Silver;
            this.tb_horas_trata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_horas_trata.Location = new System.Drawing.Point(259, 151);
            this.tb_horas_trata.Multiline = true;
            this.tb_horas_trata.Name = "tb_horas_trata";
            this.tb_horas_trata.Size = new System.Drawing.Size(211, 20);
            this.tb_horas_trata.TabIndex = 359;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 358;
            this.label2.Text = "Nº de Horas Tratamento:";
            // 
            // tb_doencas
            // 
            this.tb_doencas.BackColor = System.Drawing.Color.Silver;
            this.tb_doencas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_doencas.Location = new System.Drawing.Point(259, 62);
            this.tb_doencas.Multiline = true;
            this.tb_doencas.Name = "tb_doencas";
            this.tb_doencas.Size = new System.Drawing.Size(211, 20);
            this.tb_doencas.TabIndex = 357;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 356;
            this.label1.Text = "Doenças Crónicas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 354;
            this.label10.Text = "Obervações:";
            // 
            // tb_oberv
            // 
            this.tb_oberv.BackColor = System.Drawing.Color.Silver;
            this.tb_oberv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_oberv.Location = new System.Drawing.Point(259, 208);
            this.tb_oberv.Multiline = true;
            this.tb_oberv.Name = "tb_oberv";
            this.tb_oberv.Size = new System.Drawing.Size(219, 51);
            this.tb_oberv.TabIndex = 355;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 350;
            this.label8.Text = "Hora Tratamento:";
            // 
            // tb_hora
            // 
            this.tb_hora.BackColor = System.Drawing.Color.Silver;
            this.tb_hora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_hora.Location = new System.Drawing.Point(10, 183);
            this.tb_hora.Multiline = true;
            this.tb_hora.Name = "tb_hora";
            this.tb_hora.Size = new System.Drawing.Size(210, 20);
            this.tb_hora.TabIndex = 351;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 300;
            this.label5.Text = "Nome Enfermeiro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 301;
            this.label3.Text = "Data Tratamento:";
            // 
            // tb_utente
            // 
            this.tb_utente.BackColor = System.Drawing.Color.Silver;
            this.tb_utente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_utente.Location = new System.Drawing.Point(259, 20);
            this.tb_utente.Multiline = true;
            this.tb_utente.Name = "tb_utente";
            this.tb_utente.Size = new System.Drawing.Size(211, 20);
            this.tb_utente.TabIndex = 313;
            // 
            // tb_enfermeiro
            // 
            this.tb_enfermeiro.BackColor = System.Drawing.Color.Silver;
            this.tb_enfermeiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_enfermeiro.Location = new System.Drawing.Point(10, 86);
            this.tb_enfermeiro.Multiline = true;
            this.tb_enfermeiro.Name = "tb_enfermeiro";
            this.tb_enfermeiro.Size = new System.Drawing.Size(208, 20);
            this.tb_enfermeiro.TabIndex = 299;
            // 
            // lb_emissao
            // 
            this.lb_emissao.AutoSize = true;
            this.lb_emissao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_emissao.Location = new System.Drawing.Point(7, 206);
            this.lb_emissao.Name = "lb_emissao";
            this.lb_emissao.Size = new System.Drawing.Size(70, 16);
            this.lb_emissao.TabIndex = 268;
            this.lb_emissao.Text = "Prioridade:";
            // 
            // lb_de
            // 
            this.lb_de.AutoSize = true;
            this.lb_de.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_de.Location = new System.Drawing.Point(258, 1);
            this.lb_de.Name = "lb_de";
            this.lb_de.Size = new System.Drawing.Size(88, 16);
            this.lb_de.TabIndex = 269;
            this.lb_de.Text = "Nome Utente:";
            // 
            // pb_editar
            // 
            this.pb_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_editar.BackgroundImage")));
            this.pb_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_editar.Location = new System.Drawing.Point(442, 333);
            this.pb_editar.Name = "pb_editar";
            this.pb_editar.Size = new System.Drawing.Size(45, 28);
            this.pb_editar.TabIndex = 351;
            this.pb_editar.TabStop = false;
            this.pb_editar.Click += new System.EventHandler(this.pb_editar_Click);
            // 
            // pb_remover
            // 
            this.pb_remover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_remover.BackgroundImage")));
            this.pb_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_remover.Location = new System.Drawing.Point(395, 333);
            this.pb_remover.Name = "pb_remover";
            this.pb_remover.Size = new System.Drawing.Size(41, 28);
            this.pb_remover.TabIndex = 350;
            this.pb_remover.TabStop = false;
            this.pb_remover.Click += new System.EventHandler(this.pb_remover_Click);
            // 
            // pb_marcar
            // 
            this.pb_marcar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_marcar.BackgroundImage")));
            this.pb_marcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_marcar.Location = new System.Drawing.Point(343, 333);
            this.pb_marcar.Name = "pb_marcar";
            this.pb_marcar.Size = new System.Drawing.Size(46, 28);
            this.pb_marcar.TabIndex = 349;
            this.pb_marcar.TabStop = false;
            this.pb_marcar.Click += new System.EventHandler(this.pb_marcar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 14);
            this.label6.TabIndex = 352;
            this.label6.Text = "Data Emissão:";
            // 
            // dtp_emissao
            // 
            this.dtp_emissao.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dtp_emissao.Location = new System.Drawing.Point(25, 330);
            this.dtp_emissao.Name = "dtp_emissao";
            this.dtp_emissao.Size = new System.Drawing.Size(143, 20);
            this.dtp_emissao.TabIndex = 353;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 354;
            this.label7.Text = "Hora:";
            // 
            // tb_hora_registo
            // 
            this.tb_hora_registo.BackColor = System.Drawing.Color.Silver;
            this.tb_hora_registo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_hora_registo.Location = new System.Drawing.Point(189, 330);
            this.tb_hora_registo.Multiline = true;
            this.tb_hora_registo.Name = "tb_hora_registo";
            this.tb_hora_registo.Size = new System.Drawing.Size(97, 20);
            this.tb_hora_registo.TabIndex = 360;
            // 
            // E_Tratamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(526, 381);
            this.Controls.Add(this.tb_hora_registo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_emissao);
            this.Controls.Add(this.pb_editar);
            this.Controls.Add(this.pb_remover);
            this.Controls.Add(this.pb_marcar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "E_Tratamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E_tratamentos";
            this.Load += new System.EventHandler(this.E_Tratamentos_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_marcar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_horas_trata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_doencas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_oberv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_utente;
        private System.Windows.Forms.TextBox tb_enfermeiro;
        private System.Windows.Forms.Label lb_emissao;
        private System.Windows.Forms.Label lb_de;
        private System.Windows.Forms.PictureBox pb_editar;
        private System.Windows.Forms.PictureBox pb_remover;
        private System.Windows.Forms.PictureBox pb_marcar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_emissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_hora_registo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_refutente;
        private System.Windows.Forms.DateTimePicker dtp_tratamento;
        private System.Windows.Forms.ComboBox cb_prioridade;
        private System.Windows.Forms.ComboBox cb_categoria;
    }
}