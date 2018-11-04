namespace Projecto_Tecnologico
{
    partial class M_Receitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Receitas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.b_min = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_validade = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_medicamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ref_receita = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.tb_medico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_obers = new System.Windows.Forms.TextBox();
            this.tb_utentes = new System.Windows.Forms.TextBox();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.tb_ref_utente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_taxa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pb_registar = new System.Windows.Forms.PictureBox();
            this.pb_editar = new System.Windows.Forms.PictureBox();
            this.pb_remover = new System.Windows.Forms.PictureBox();
            this.dtp_emissao = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_horaregisto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(749, 48);
            this.panel1.TabIndex = 10;
//            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.b_close.Location = new System.Drawing.Point(717, 3);
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
            this.b_min.Location = new System.Drawing.Point(686, 3);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 7;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_validade);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_medicamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_ref_receita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_data);
            this.groupBox1.Controls.Add(this.tb_medico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_obers);
            this.groupBox1.Controls.Add(this.tb_utentes);
            this.groupBox1.Controls.Add(this.lb_categoria);
            this.groupBox1.Controls.Add(this.tb_ref_utente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_categoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_taxa);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 203);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcar Receita";
            // 
            // dtp_validade
            // 
            this.dtp_validade.Location = new System.Drawing.Point(145, 152);
            this.dtp_validade.Name = "dtp_validade";
            this.dtp_validade.Size = new System.Drawing.Size(171, 20);
            this.dtp_validade.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Data Validade:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_medicamento
            // 
            this.tb_medicamento.BackColor = System.Drawing.Color.Silver;
            this.tb_medicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_medicamento.Location = new System.Drawing.Point(144, 59);
            this.tb_medicamento.Multiline = true;
            this.tb_medicamento.Name = "tb_medicamento";
            this.tb_medicamento.Size = new System.Drawing.Size(172, 20);
            this.tb_medicamento.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Receita Médica:";
            // 
            // tb_ref_receita
            // 
            this.tb_ref_receita.BackColor = System.Drawing.Color.Silver;
            this.tb_ref_receita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ref_receita.Location = new System.Drawing.Point(456, 79);
            this.tb_ref_receita.Multiline = true;
            this.tb_ref_receita.Name = "tb_ref_receita";
            this.tb_ref_receita.Size = new System.Drawing.Size(233, 20);
            this.tb_ref_receita.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Referência Utente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Nome do Médico:";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(41, 65);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(90, 16);
            this.lb_data.TabIndex = 42;
            this.lb_data.Text = "Medicamento:";
            // 
            // tb_medico
            // 
            this.tb_medico.BackColor = System.Drawing.Color.Silver;
            this.tb_medico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_medico.Location = new System.Drawing.Point(144, 120);
            this.tb_medico.Multiline = true;
            this.tb_medico.Name = "tb_medico";
            this.tb_medico.Size = new System.Drawing.Size(172, 20);
            this.tb_medico.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nome do Utente:";
            // 
            // tb_obers
            // 
            this.tb_obers.BackColor = System.Drawing.Color.Silver;
            this.tb_obers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_obers.Location = new System.Drawing.Point(456, 112);
            this.tb_obers.Multiline = true;
            this.tb_obers.Name = "tb_obers";
            this.tb_obers.Size = new System.Drawing.Size(233, 60);
            this.tb_obers.TabIndex = 45;
            // 
            // tb_utentes
            // 
            this.tb_utentes.BackColor = System.Drawing.Color.Silver;
            this.tb_utentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_utentes.Location = new System.Drawing.Point(144, 94);
            this.tb_utentes.Multiline = true;
            this.tb_utentes.Name = "tb_utentes";
            this.tb_utentes.Size = new System.Drawing.Size(172, 20);
            this.tb_utentes.TabIndex = 59;
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.Location = new System.Drawing.Point(370, 110);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(80, 16);
            this.lb_categoria.TabIndex = 46;
            this.lb_categoria.Text = "Obervações:";
            // 
            // tb_ref_utente
            // 
            this.tb_ref_utente.BackColor = System.Drawing.Color.Silver;
            this.tb_ref_utente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ref_utente.Location = new System.Drawing.Point(144, 28);
            this.tb_ref_utente.Multiline = true;
            this.tb_ref_utente.Name = "tb_ref_utente";
            this.tb_ref_utente.Size = new System.Drawing.Size(172, 20);
            this.tb_ref_utente.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = " Taxa Moderadora:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.BackColor = System.Drawing.Color.Silver;
            this.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(456, 22);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(233, 21);
            this.cb_categoria.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Categoria:";
            // 
            // tb_taxa
            // 
            this.tb_taxa.BackColor = System.Drawing.Color.Silver;
            this.tb_taxa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_taxa.Location = new System.Drawing.Point(456, 50);
            this.tb_taxa.Multiline = true;
            this.tb_taxa.Name = "tb_taxa";
            this.tb_taxa.Size = new System.Drawing.Size(233, 20);
            this.tb_taxa.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 66;
            this.label7.Text = "Data Emissão:";
            // 
            // pb_registar
            // 
            this.pb_registar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_registar.BackgroundImage")));
            this.pb_registar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_registar.Location = new System.Drawing.Point(140, 251);
            this.pb_registar.Name = "pb_registar";
            this.pb_registar.Size = new System.Drawing.Size(37, 27);
            this.pb_registar.TabIndex = 67;
            this.pb_registar.TabStop = false;
            this.pb_registar.Click += new System.EventHandler(this.pb_registar_Click);
            // 
            // pb_editar
            // 
            this.pb_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_editar.BackgroundImage")));
            this.pb_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_editar.Location = new System.Drawing.Point(190, 251);
            this.pb_editar.Name = "pb_editar";
            this.pb_editar.Size = new System.Drawing.Size(45, 27);
            this.pb_editar.TabIndex = 68;
            this.pb_editar.TabStop = false;
            this.pb_editar.Click += new System.EventHandler(this.pb_editar_Click);
            // 
            // pb_remover
            // 
            this.pb_remover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_remover.BackgroundImage")));
            this.pb_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_remover.Location = new System.Drawing.Point(241, 251);
            this.pb_remover.Name = "pb_remover";
            this.pb_remover.Size = new System.Drawing.Size(45, 27);
            this.pb_remover.TabIndex = 69;
            this.pb_remover.TabStop = false;
            this.pb_remover.Click += new System.EventHandler(this.pb_remover_Click);
            // 
            // dtp_emissao
            // 
            this.dtp_emissao.Location = new System.Drawing.Point(544, 263);
            this.dtp_emissao.Name = "dtp_emissao";
            this.dtp_emissao.Size = new System.Drawing.Size(150, 20);
            this.dtp_emissao.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(503, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 14);
            this.label9.TabIndex = 70;
            this.label9.Text = "Hora:";
            // 
            // tb_horaregisto
            // 
            this.tb_horaregisto.BackColor = System.Drawing.Color.Silver;
            this.tb_horaregisto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_horaregisto.Location = new System.Drawing.Point(544, 240);
            this.tb_horaregisto.Multiline = true;
            this.tb_horaregisto.Name = "tb_horaregisto";
            this.tb_horaregisto.Size = new System.Drawing.Size(124, 20);
            this.tb_horaregisto.TabIndex = 71;
            // 
            // M_Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(749, 301);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_horaregisto);
            this.Controls.Add(this.dtp_emissao);
            this.Controls.Add(this.pb_remover);
            this.Controls.Add(this.pb_editar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pb_registar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "M_Receitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M_Receitas";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.TextBox tb_medico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_obers;
        private System.Windows.Forms.TextBox tb_utentes;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.TextBox tb_ref_utente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_taxa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ref_receita;
        private System.Windows.Forms.PictureBox pb_registar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_medicamento;
        private System.Windows.Forms.PictureBox pb_editar;
        private System.Windows.Forms.PictureBox pb_remover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_validade;
        private System.Windows.Forms.DateTimePicker dtp_emissao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_horaregisto;
    }
}