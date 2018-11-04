namespace Projecto_Tecnologico.Admistradores
{
    partial class A_Financiamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Financiamento));
            this.pb_editar = new System.Windows.Forms.PictureBox();
            this.pb_remover = new System.Windows.Forms.PictureBox();
            this.dtp_emissao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_registar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_identi_refe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_representante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_conctooficial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_iva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_nomepaga = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.dtp_validade = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_valorapago = new System.Windows.Forms.TextBox();
            this.tb_refe = new System.Windows.Forms.TextBox();
            this.lb_emissao = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_p = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.b_min = new System.Windows.Forms.Button();
            this.tb_horaregisto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_editar
            // 
            this.pb_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_editar.BackgroundImage")));
            this.pb_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_editar.Location = new System.Drawing.Point(482, 334);
            this.pb_editar.Name = "pb_editar";
            this.pb_editar.Size = new System.Drawing.Size(38, 38);
            this.pb_editar.TabIndex = 354;
            this.pb_editar.TabStop = false;
            this.pb_editar.Click += new System.EventHandler(this.pb_editar_Click);
            // 
            // pb_remover
            // 
            this.pb_remover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_remover.BackgroundImage")));
            this.pb_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_remover.Location = new System.Drawing.Point(526, 334);
            this.pb_remover.Name = "pb_remover";
            this.pb_remover.Size = new System.Drawing.Size(46, 38);
            this.pb_remover.TabIndex = 353;
            this.pb_remover.TabStop = false;
            this.pb_remover.Click += new System.EventHandler(this.pb_remover_Click);
            // 
            // dtp_emissao
            // 
            this.dtp_emissao.Location = new System.Drawing.Point(358, 302);
            this.dtp_emissao.Name = "dtp_emissao";
            this.dtp_emissao.Size = new System.Drawing.Size(152, 20);
            this.dtp_emissao.TabIndex = 351;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 350;
            this.label6.Text = "Data de Emissão:";
            // 
            // pb_registar
            // 
            this.pb_registar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_registar.BackgroundImage")));
            this.pb_registar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_registar.Location = new System.Drawing.Point(428, 334);
            this.pb_registar.Name = "pb_registar";
            this.pb_registar.Size = new System.Drawing.Size(48, 38);
            this.pb_registar.TabIndex = 349;
            this.pb_registar.TabStop = false;
            this.pb_registar.Click += new System.EventHandler(this.pb_registar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_identi_refe);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_representante);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_empresa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_conctooficial);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(345, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 182);
            this.groupBox2.TabIndex = 348;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registar Pagamento";
            // 
            // tb_identi_refe
            // 
            this.tb_identi_refe.BackColor = System.Drawing.Color.Silver;
            this.tb_identi_refe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_identi_refe.Location = new System.Drawing.Point(60, 44);
            this.tb_identi_refe.Multiline = true;
            this.tb_identi_refe.Name = "tb_identi_refe";
            this.tb_identi_refe.Size = new System.Drawing.Size(192, 20);
            this.tb_identi_refe.TabIndex = 325;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 18);
            this.label10.TabIndex = 324;
            this.label10.Text = "Identidade Referencial:";
            // 
            // tb_representante
            // 
            this.tb_representante.BackColor = System.Drawing.Color.Silver;
            this.tb_representante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_representante.Location = new System.Drawing.Point(128, 113);
            this.tb_representante.Multiline = true;
            this.tb_representante.Name = "tb_representante";
            this.tb_representante.Size = new System.Drawing.Size(150, 20);
            this.tb_representante.TabIndex = 323;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 322;
            this.label9.Text = "Representate:";
            // 
            // tb_empresa
            // 
            this.tb_empresa.BackColor = System.Drawing.Color.Silver;
            this.tb_empresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_empresa.Location = new System.Drawing.Point(128, 76);
            this.tb_empresa.Multiline = true;
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Size = new System.Drawing.Size(150, 20);
            this.tb_empresa.TabIndex = 321;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 320;
            this.label8.Text = "Empresa:";
            // 
            // tb_conctooficial
            // 
            this.tb_conctooficial.BackColor = System.Drawing.Color.Silver;
            this.tb_conctooficial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_conctooficial.Location = new System.Drawing.Point(128, 151);
            this.tb_conctooficial.Multiline = true;
            this.tb_conctooficial.Name = "tb_conctooficial";
            this.tb_conctooficial.Size = new System.Drawing.Size(150, 20);
            this.tb_conctooficial.TabIndex = 319;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 318;
            this.label7.Text = "Contacto Oficial:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_iva);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tb_nomepaga);
            this.groupBox1.Controls.Add(this.tb_descricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_quantidade);
            this.groupBox1.Controls.Add(this.dtp_validade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_valorapago);
            this.groupBox1.Controls.Add(this.tb_refe);
            this.groupBox1.Controls.Add(this.lb_emissao);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 338);
            this.groupBox1.TabIndex = 347;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registar Pagamento";
            // 
            // tb_iva
            // 
            this.tb_iva.BackColor = System.Drawing.Color.Silver;
            this.tb_iva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_iva.Location = new System.Drawing.Point(122, 301);
            this.tb_iva.Multiline = true;
            this.tb_iva.Name = "tb_iva";
            this.tb_iva.Size = new System.Drawing.Size(196, 20);
            this.tb_iva.TabIndex = 329;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 320;
            this.label2.Text = "Nome Pagamento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 18);
            this.label12.TabIndex = 328;
            this.label12.Text = "IVA:";
            // 
            // tb_nomepaga
            // 
            this.tb_nomepaga.BackColor = System.Drawing.Color.Silver;
            this.tb_nomepaga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nomepaga.Location = new System.Drawing.Point(160, 29);
            this.tb_nomepaga.Multiline = true;
            this.tb_nomepaga.Name = "tb_nomepaga";
            this.tb_nomepaga.Size = new System.Drawing.Size(158, 20);
            this.tb_nomepaga.TabIndex = 319;
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.Color.Silver;
            this.tb_descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_descricao.Location = new System.Drawing.Point(122, 230);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(196, 54);
            this.tb_descricao.TabIndex = 318;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 317;
            this.label1.Text = "Descrição:";
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.BackColor = System.Drawing.Color.Silver;
            this.tb_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_quantidade.Location = new System.Drawing.Point(122, 145);
            this.tb_quantidade.Multiline = true;
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(196, 20);
            this.tb_quantidade.TabIndex = 312;
            // 
            // dtp_validade
            // 
            this.dtp_validade.Location = new System.Drawing.Point(149, 188);
            this.dtp_validade.Name = "dtp_validade";
            this.dtp_validade.Size = new System.Drawing.Size(169, 20);
            this.dtp_validade.TabIndex = 311;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 307;
            this.label4.Text = "Data de Validade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 300;
            this.label5.Text = "Referência:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 301;
            this.label3.Text = "Valor a Pago:";
            // 
            // tb_valorapago
            // 
            this.tb_valorapago.BackColor = System.Drawing.Color.Silver;
            this.tb_valorapago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_valorapago.Location = new System.Drawing.Point(122, 104);
            this.tb_valorapago.Multiline = true;
            this.tb_valorapago.Name = "tb_valorapago";
            this.tb_valorapago.Size = new System.Drawing.Size(196, 20);
            this.tb_valorapago.TabIndex = 302;
            // 
            // tb_refe
            // 
            this.tb_refe.BackColor = System.Drawing.Color.Silver;
            this.tb_refe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_refe.Location = new System.Drawing.Point(122, 70);
            this.tb_refe.Multiline = true;
            this.tb_refe.Name = "tb_refe";
            this.tb_refe.Size = new System.Drawing.Size(196, 20);
            this.tb_refe.TabIndex = 299;
            // 
            // lb_emissao
            // 
            this.lb_emissao.AutoSize = true;
            this.lb_emissao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_emissao.Location = new System.Drawing.Point(9, 147);
            this.lb_emissao.Name = "lb_emissao";
            this.lb_emissao.Size = new System.Drawing.Size(93, 18);
            this.lb_emissao.TabIndex = 268;
            this.lb_emissao.Text = "Quantidade:";
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.Silver;
            this.cb_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(428, 239);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(196, 21);
            this.cb_estado.TabIndex = 331;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(342, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 330;
            this.label13.Text = "Estado:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pn_p);
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.b_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 45);
            this.panel1.TabIndex = 346;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pn_p
            // 
            this.pn_p.BackColor = System.Drawing.Color.Black;
            this.pn_p.Location = new System.Drawing.Point(345, 15);
            this.pn_p.Name = "pn_p";
            this.pn_p.Size = new System.Drawing.Size(16, 14);
            this.pn_p.TabIndex = 358;
            // 
            // b_close
            // 
            this.b_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Image = ((System.Drawing.Image)(resources.GetObject("b_close.Image")));
            this.b_close.Location = new System.Drawing.Point(614, 2);
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
            this.b_min.Location = new System.Drawing.Point(579, 2);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 7;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // tb_horaregisto
            // 
            this.tb_horaregisto.BackColor = System.Drawing.Color.Silver;
            this.tb_horaregisto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_horaregisto.Location = new System.Drawing.Point(523, 302);
            this.tb_horaregisto.Multiline = true;
            this.tb_horaregisto.Name = "tb_horaregisto";
            this.tb_horaregisto.Size = new System.Drawing.Size(85, 20);
            this.tb_horaregisto.TabIndex = 356;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(520, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 355;
            this.label11.Text = "Horas:";
            // 
            // A_Financiamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(645, 400);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_horaregisto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pb_editar);
            this.Controls.Add(this.pb_remover);
            this.Controls.Add(this.dtp_emissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pb_registar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_Financiamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_Financiamento";
            this.Load += new System.EventHandler(this.A_Financiamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_emissao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel pn_p;
        public System.Windows.Forms.TextBox tb_horaregisto;
        public System.Windows.Forms.TextBox tb_refe;
        public System.Windows.Forms.TextBox tb_valorapago;
        public System.Windows.Forms.DateTimePicker dtp_validade;
        public System.Windows.Forms.TextBox tb_quantidade;
        public System.Windows.Forms.TextBox tb_descricao;
        public System.Windows.Forms.TextBox tb_nomepaga;
        public System.Windows.Forms.TextBox tb_iva;
        public System.Windows.Forms.ComboBox cb_estado;
        public System.Windows.Forms.TextBox tb_conctooficial;
        public System.Windows.Forms.TextBox tb_empresa;
        public System.Windows.Forms.TextBox tb_representante;
        public System.Windows.Forms.TextBox tb_identi_refe;
        public System.Windows.Forms.PictureBox pb_registar;
        public System.Windows.Forms.DateTimePicker dtp_emissao;
        public System.Windows.Forms.PictureBox pb_remover;
        public System.Windows.Forms.PictureBox pb_editar;
    }
}