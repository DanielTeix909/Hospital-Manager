﻿namespace Projecto_Tecnologico.Recepcionistas
{
    partial class R_MarcarExames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_MarcarExames));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.b_min = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_hora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.tb_medico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.dtp_dataexame = new System.Windows.Forms.DateTimePicker();
            this.tb_refutente = new System.Windows.Forms.TextBox();
            this.cb_prioridade = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_receita = new System.Windows.Forms.TextBox();
            this.tb_oberv = new System.Windows.Forms.TextBox();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_taxa = new System.Windows.Forms.TextBox();
            this.pb_marcar = new System.Windows.Forms.PictureBox();
            this.pb_editar = new System.Windows.Forms.PictureBox();
            this.pb_remover = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_emissao = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_validade = new System.Windows.Forms.DateTimePicker();
            this.tb_horaregisto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_marcar)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(621, 48);
            this.panel1.TabIndex = 78;
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
            this.b_close.Location = new System.Drawing.Point(589, 3);
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
            this.b_min.Location = new System.Drawing.Point(557, 3);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 7;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_hora);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_data);
            this.groupBox1.Controls.Add(this.tb_medico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.dtp_dataexame);
            this.groupBox1.Controls.Add(this.tb_refutente);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(10, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 187);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcar Exame";
            // 
            // tb_hora
            // 
            this.tb_hora.BackColor = System.Drawing.Color.Silver;
            this.tb_hora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_hora.Location = new System.Drawing.Point(177, 80);
            this.tb_hora.Multiline = true;
            this.tb_hora.Name = "tb_hora";
            this.tb_hora.Size = new System.Drawing.Size(95, 20);
            this.tb_hora.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 14);
            this.label7.TabIndex = 65;
            this.label7.Text = "Hora Exame:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 14);
            this.label2.TabIndex = 58;
            this.label2.Text = "Referência Utente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 14);
            this.label6.TabIndex = 62;
            this.label6.Text = "Nome do Médico:";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(6, 63);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(72, 14);
            this.lb_data.TabIndex = 42;
            this.lb_data.Text = "Data Exame:";
            // 
            // tb_medico
            // 
            this.tb_medico.BackColor = System.Drawing.Color.Silver;
            this.tb_medico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_medico.Location = new System.Drawing.Point(9, 160);
            this.tb_medico.Multiline = true;
            this.tb_medico.Name = "tb_medico";
            this.tb_medico.Size = new System.Drawing.Size(263, 20);
            this.tb_medico.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nome do Utente:";
            // 
            // tb_nome
            // 
            this.tb_nome.BackColor = System.Drawing.Color.Silver;
            this.tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nome.Location = new System.Drawing.Point(9, 120);
            this.tb_nome.Multiline = true;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(263, 20);
            this.tb_nome.TabIndex = 59;
            // 
            // dtp_dataexame
            // 
            this.dtp_dataexame.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dtp_dataexame.Location = new System.Drawing.Point(9, 80);
            this.dtp_dataexame.Name = "dtp_dataexame";
            this.dtp_dataexame.Size = new System.Drawing.Size(147, 20);
            this.dtp_dataexame.TabIndex = 47;
            // 
            // tb_refutente
            // 
            this.tb_refutente.BackColor = System.Drawing.Color.Silver;
            this.tb_refutente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_refutente.Location = new System.Drawing.Point(9, 39);
            this.tb_refutente.Multiline = true;
            this.tb_refutente.Name = "tb_refutente";
            this.tb_refutente.Size = new System.Drawing.Size(263, 20);
            this.tb_refutente.TabIndex = 57;
            // 
            // cb_prioridade
            // 
            this.cb_prioridade.BackColor = System.Drawing.Color.Silver;
            this.cb_prioridade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_prioridade.FormattingEnabled = true;
            this.cb_prioridade.Location = new System.Drawing.Point(357, 120);
            this.cb_prioridade.Name = "cb_prioridade";
            this.cb_prioridade.Size = new System.Drawing.Size(243, 21);
            this.cb_prioridade.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 68;
            this.label10.Text = "Prioridade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 14);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ref. Receita Médica:";
            // 
            // tb_receita
            // 
            this.tb_receita.BackColor = System.Drawing.Color.Silver;
            this.tb_receita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_receita.Location = new System.Drawing.Point(355, 201);
            this.tb_receita.Multiline = true;
            this.tb_receita.Name = "tb_receita";
            this.tb_receita.Size = new System.Drawing.Size(243, 20);
            this.tb_receita.TabIndex = 64;
            // 
            // tb_oberv
            // 
            this.tb_oberv.BackColor = System.Drawing.Color.Silver;
            this.tb_oberv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_oberv.Location = new System.Drawing.Point(357, 241);
            this.tb_oberv.Multiline = true;
            this.tb_oberv.Name = "tb_oberv";
            this.tb_oberv.Size = new System.Drawing.Size(241, 81);
            this.tb_oberv.TabIndex = 45;
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.Location = new System.Drawing.Point(354, 224);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(76, 14);
            this.lb_categoria.TabIndex = 46;
            this.lb_categoria.Text = "Obervações:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "Referência Taxa Moderadora:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.BackColor = System.Drawing.Color.Silver;
            this.cb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(357, 74);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(243, 21);
            this.cb_categoria.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "Categoria:";
            // 
            // tb_taxa
            // 
            this.tb_taxa.BackColor = System.Drawing.Color.Silver;
            this.tb_taxa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_taxa.Location = new System.Drawing.Point(354, 161);
            this.tb_taxa.Multiline = true;
            this.tb_taxa.Name = "tb_taxa";
            this.tb_taxa.Size = new System.Drawing.Size(243, 20);
            this.tb_taxa.TabIndex = 54;
            // 
            // pb_marcar
            // 
            this.pb_marcar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_marcar.BackgroundImage")));
            this.pb_marcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_marcar.Location = new System.Drawing.Point(169, 306);
            this.pb_marcar.Name = "pb_marcar";
            this.pb_marcar.Size = new System.Drawing.Size(49, 29);
            this.pb_marcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_marcar.TabIndex = 82;
            this.pb_marcar.TabStop = false;
            this.pb_marcar.Click += new System.EventHandler(this.pb_marcar_Click);
            // 
            // pb_editar
            // 
            this.pb_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_editar.BackgroundImage")));
            this.pb_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_editar.Location = new System.Drawing.Point(221, 306);
            this.pb_editar.Name = "pb_editar";
            this.pb_editar.Size = new System.Drawing.Size(52, 29);
            this.pb_editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_editar.TabIndex = 83;
            this.pb_editar.TabStop = false;
            this.pb_editar.Click += new System.EventHandler(this.pb_editar_Click);
            // 
            // pb_remover
            // 
            this.pb_remover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_remover.BackgroundImage")));
            this.pb_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_remover.Location = new System.Drawing.Point(282, 306);
            this.pb_remover.Name = "pb_remover";
            this.pb_remover.Size = new System.Drawing.Size(39, 29);
            this.pb_remover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_remover.TabIndex = 84;
            this.pb_remover.TabStop = false;
            this.pb_remover.Click += new System.EventHandler(this.pb_remover_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 67;
            this.label8.Text = "Data Emissão:";
            // 
            // dtp_emissao
            // 
            this.dtp_emissao.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dtp_emissao.Location = new System.Drawing.Point(13, 266);
            this.dtp_emissao.Name = "dtp_emissao";
            this.dtp_emissao.Size = new System.Drawing.Size(143, 20);
            this.dtp_emissao.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(184, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 14);
            this.label9.TabIndex = 85;
            this.label9.Text = "Data Validade:";
            // 
            // dtp_validade
            // 
            this.dtp_validade.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.dtp_validade.Location = new System.Drawing.Point(187, 266);
            this.dtp_validade.Name = "dtp_validade";
            this.dtp_validade.Size = new System.Drawing.Size(143, 20);
            this.dtp_validade.TabIndex = 86;
            // 
            // tb_horaregisto
            // 
            this.tb_horaregisto.BackColor = System.Drawing.Color.Silver;
            this.tb_horaregisto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_horaregisto.Location = new System.Drawing.Point(15, 306);
            this.tb_horaregisto.Multiline = true;
            this.tb_horaregisto.Name = "tb_horaregisto";
            this.tb_horaregisto.Size = new System.Drawing.Size(95, 20);
            this.tb_horaregisto.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 14);
            this.label11.TabIndex = 87;
            this.label11.Text = "Hora Emissao:";
            // 
            // R_MarcarExames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(621, 349);
            this.Controls.Add(this.tb_horaregisto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_prioridade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtp_validade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pb_remover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_emissao);
            this.Controls.Add(this.tb_receita);
            this.Controls.Add(this.pb_editar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb_marcar);
            this.Controls.Add(this.tb_oberv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_taxa);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "R_MarcarExames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R_MarcarExames";
            this.Load += new System.EventHandler(this.R_MarcarExames_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_marcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_receita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.TextBox tb_medico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_oberv;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.DateTimePicker dtp_dataexame;
        private System.Windows.Forms.TextBox tb_refutente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_taxa;
        private System.Windows.Forms.PictureBox pb_marcar;
        private System.Windows.Forms.TextBox tb_hora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_editar;
        private System.Windows.Forms.PictureBox pb_remover;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_emissao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_validade;
        private System.Windows.Forms.ComboBox cb_prioridade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.TextBox tb_horaregisto;
        private System.Windows.Forms.Label label11;
    }
}