namespace Projecto_Tecnologico
{
    partial class M_Configurações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Configurações));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_forca = new System.Windows.Forms.ProgressBar();
            this.lb_forca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_horaregisto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_newpassrepit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_close = new System.Windows.Forms.Button();
            this.tb_newpass = new System.Windows.Forms.TextBox();
            this.lb_especs = new System.Windows.Forms.Label();
            this.dtp_emissao = new System.Windows.Forms.DateTimePicker();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.pic_registar = new System.Windows.Forms.PictureBox();
            this.lb_emissao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_min = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_registar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_forca
            // 
            this.pb_forca.Location = new System.Drawing.Point(24, 229);
            this.pb_forca.Name = "pb_forca";
            this.pb_forca.Size = new System.Drawing.Size(162, 23);
            this.pb_forca.TabIndex = 200;
            // 
            // lb_forca
            // 
            this.lb_forca.AutoSize = true;
            this.lb_forca.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forca.ForeColor = System.Drawing.Color.Black;
            this.lb_forca.Location = new System.Drawing.Point(193, 230);
            this.lb_forca.Name = "lb_forca";
            this.lb_forca.Size = new System.Drawing.Size(59, 22);
            this.lb_forca.TabIndex = 199;
            this.lb_forca.Text = "Força";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 197;
            this.label3.Text = "Hora:";
            // 
            // tb_horaregisto
            // 
            this.tb_horaregisto.BackColor = System.Drawing.Color.Silver;
            this.tb_horaregisto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_horaregisto.Location = new System.Drawing.Point(93, 339);
            this.tb_horaregisto.Multiline = true;
            this.tb_horaregisto.Name = "tb_horaregisto";
            this.tb_horaregisto.Size = new System.Drawing.Size(146, 20);
            this.tb_horaregisto.TabIndex = 198;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 195;
            this.label2.Text = "Senha:";
            // 
            // tb_newpassrepit
            // 
            this.tb_newpassrepit.BackColor = System.Drawing.Color.Silver;
            this.tb_newpassrepit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_newpassrepit.Location = new System.Drawing.Point(24, 192);
            this.tb_newpassrepit.Multiline = true;
            this.tb_newpassrepit.Name = "tb_newpassrepit";
            this.tb_newpassrepit.Size = new System.Drawing.Size(227, 20);
            this.tb_newpassrepit.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 193;
            this.label1.Text = "Nova Senha:";
            // 
            // b_close
            // 
            this.b_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Image = ((System.Drawing.Image)(resources.GetObject("b_close.Image")));
            this.b_close.Location = new System.Drawing.Point(251, 3);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 120;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // tb_newpass
            // 
            this.tb_newpass.BackColor = System.Drawing.Color.Silver;
            this.tb_newpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_newpass.Location = new System.Drawing.Point(25, 144);
            this.tb_newpass.Multiline = true;
            this.tb_newpass.Name = "tb_newpass";
            this.tb_newpass.Size = new System.Drawing.Size(227, 20);
            this.tb_newpass.TabIndex = 194;
            this.tb_newpass.TextChanged += new System.EventHandler(this.tb_newpass_TextChanged);
            // 
            // lb_especs
            // 
            this.lb_especs.AutoSize = true;
            this.lb_especs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_especs.ForeColor = System.Drawing.Color.Black;
            this.lb_especs.Location = new System.Drawing.Point(21, 51);
            this.lb_especs.Name = "lb_especs";
            this.lb_especs.Size = new System.Drawing.Size(43, 16);
            this.lb_especs.TabIndex = 189;
            this.lb_especs.Text = "Login:";
            // 
            // dtp_emissao
            // 
            this.dtp_emissao.Location = new System.Drawing.Point(94, 313);
            this.dtp_emissao.Name = "dtp_emissao";
            this.dtp_emissao.Size = new System.Drawing.Size(145, 20);
            this.dtp_emissao.TabIndex = 187;
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.Color.Silver;
            this.tb_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_login.Location = new System.Drawing.Point(72, 53);
            this.tb_login.Multiline = true;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(172, 20);
            this.tb_login.TabIndex = 190;
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.ForeColor = System.Drawing.Color.Black;
            this.lb_categoria.Location = new System.Drawing.Point(14, 78);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(49, 16);
            this.lb_categoria.TabIndex = 191;
            this.lb_categoria.Text = "Senha:";
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.Silver;
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Location = new System.Drawing.Point(72, 79);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(172, 20);
            this.tb_pass.TabIndex = 192;
            // 
            // pic_registar
            // 
            this.pic_registar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_registar.BackgroundImage")));
            this.pic_registar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_registar.Location = new System.Drawing.Point(33, 262);
            this.pic_registar.Name = "pic_registar";
            this.pic_registar.Size = new System.Drawing.Size(100, 36);
            this.pic_registar.TabIndex = 188;
            this.pic_registar.TabStop = false;
            this.pic_registar.Click += new System.EventHandler(this.pic_registar_Click);
            // 
            // lb_emissao
            // 
            this.lb_emissao.AutoSize = true;
            this.lb_emissao.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_emissao.ForeColor = System.Drawing.Color.Black;
            this.lb_emissao.Location = new System.Drawing.Point(21, 311);
            this.lb_emissao.Name = "lb_emissao";
            this.lb_emissao.Size = new System.Drawing.Size(70, 17);
            this.lb_emissao.TabIndex = 186;
            this.lb_emissao.Text = "Emissão:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.b_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 48);
            this.panel1.TabIndex = 185;
            // 
            // b_min
            // 
            this.b_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_min.Image = ((System.Drawing.Image)(resources.GetObject("b_min.Image")));
            this.b_min.Location = new System.Drawing.Point(222, 3);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 119;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // M_Configurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(283, 370);
            this.Controls.Add(this.pb_forca);
            this.Controls.Add(this.lb_forca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_horaregisto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_newpassrepit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_newpass);
            this.Controls.Add(this.lb_especs);
            this.Controls.Add(this.dtp_emissao);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.pic_registar);
            this.Controls.Add(this.lb_emissao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "M_Configurações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M_Configurações";
            this.Load += new System.EventHandler(this.M_Configurações_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_registar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pb_forca;
        private System.Windows.Forms.Label lb_forca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_horaregisto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_newpassrepit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.TextBox tb_newpass;
        private System.Windows.Forms.Label lb_especs;
        private System.Windows.Forms.DateTimePicker dtp_emissao;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.PictureBox pic_registar;
        private System.Windows.Forms.Label lb_emissao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.Timer timer2;
    }
}