namespace Projecto_Tecnologico
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.tb_nomehpl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_remover = new System.Windows.Forms.PictureBox();
            this.pb_abrir = new System.Windows.Forms.PictureBox();
            this.Administrador = new System.Windows.Forms.GroupBox();
            this.lb_forca = new System.Windows.Forms.Label();
            this.pb_forca = new System.Windows.Forms.ProgressBar();
            this.tb_admin = new System.Windows.Forms.TextBox();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.pb_fechar = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_emailadm = new System.Windows.Forms.TextBox();
            this.tb_passemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_nao = new System.Windows.Forms.CheckBox();
            this.cb_sim = new System.Windows.Forms.CheckBox();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_smtp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_abrir)).BeginInit();
            this.Administrador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fechar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nomehpl
            // 
            this.tb_nomehpl.BackColor = System.Drawing.Color.Silver;
            this.tb_nomehpl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nomehpl.Location = new System.Drawing.Point(301, 255);
            this.tb_nomehpl.Multiline = true;
            this.tb_nomehpl.Name = "tb_nomehpl";
            this.tb_nomehpl.Size = new System.Drawing.Size(253, 20);
            this.tb_nomehpl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(298, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Admin:";
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.Silver;
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Location = new System.Drawing.Point(16, 87);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(252, 20);
            this.tb_pass.TabIndex = 6;
            this.tb_pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password Admin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Logótipo do Hospital:";
            // 
            // pb_remover
            // 
            this.pb_remover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_remover.BackgroundImage")));
            this.pb_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_remover.Location = new System.Drawing.Point(134, 278);
            this.pb_remover.Name = "pb_remover";
            this.pb_remover.Size = new System.Drawing.Size(40, 27);
            this.pb_remover.TabIndex = 18;
            this.pb_remover.TabStop = false;
            this.pb_remover.Click += new System.EventHandler(this.pb_remover_Click);
            // 
            // pb_abrir
            // 
            this.pb_abrir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_abrir.BackgroundImage")));
            this.pb_abrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_abrir.Location = new System.Drawing.Point(88, 278);
            this.pb_abrir.Name = "pb_abrir";
            this.pb_abrir.Size = new System.Drawing.Size(40, 27);
            this.pb_abrir.TabIndex = 17;
            this.pb_abrir.TabStop = false;
            this.pb_abrir.Click += new System.EventHandler(this.pb_abrir_Click);
            // 
            // Administrador
            // 
            this.Administrador.Controls.Add(this.lb_forca);
            this.Administrador.Controls.Add(this.pb_forca);
            this.Administrador.Controls.Add(this.tb_admin);
            this.Administrador.Controls.Add(this.tb_pass);
            this.Administrador.Controls.Add(this.label3);
            this.Administrador.Controls.Add(this.label2);
            this.Administrador.ForeColor = System.Drawing.Color.Maroon;
            this.Administrador.Location = new System.Drawing.Point(286, 64);
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(286, 146);
            this.Administrador.TabIndex = 15;
            this.Administrador.TabStop = false;
            this.Administrador.Text = "Novo Adminstrador";
            // 
            // lb_forca
            // 
            this.lb_forca.AutoSize = true;
            this.lb_forca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forca.ForeColor = System.Drawing.Color.Black;
            this.lb_forca.Location = new System.Drawing.Point(215, 116);
            this.lb_forca.Name = "lb_forca";
            this.lb_forca.Size = new System.Drawing.Size(53, 16);
            this.lb_forca.TabIndex = 217;
            this.lb_forca.Text = "lb_forca";
            // 
            // pb_forca
            // 
            this.pb_forca.Location = new System.Drawing.Point(17, 116);
            this.pb_forca.Name = "pb_forca";
            this.pb_forca.Size = new System.Drawing.Size(192, 18);
            this.pb_forca.TabIndex = 218;
            // 
            // tb_admin
            // 
            this.tb_admin.BackColor = System.Drawing.Color.Silver;
            this.tb_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_admin.Location = new System.Drawing.Point(16, 42);
            this.tb_admin.Multiline = true;
            this.tb_admin.Name = "tb_admin";
            this.tb_admin.Size = new System.Drawing.Size(252, 20);
            this.tb_admin.TabIndex = 4;
            // 
            // pb_foto
            // 
            this.pb_foto.BackColor = System.Drawing.Color.Transparent;
            this.pb_foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_foto.BackgroundImage")));
            this.pb_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_foto.Location = new System.Drawing.Point(38, 78);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(210, 194);
            this.pb_foto.TabIndex = 16;
            this.pb_foto.TabStop = false;
            // 
            // pb_fechar
            // 
            this.pb_fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_fechar.BackgroundImage")));
            this.pb_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_fechar.Location = new System.Drawing.Point(359, 295);
            this.pb_fechar.Name = "pb_fechar";
            this.pb_fechar.Size = new System.Drawing.Size(109, 29);
            this.pb_fechar.TabIndex = 19;
            this.pb_fechar.TabStop = false;
            this.pb_fechar.Click += new System.EventHandler(this.pb_fechar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 48);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // b_close
            // 
            this.b_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Image = ((System.Drawing.Image)(resources.GetObject("b_close.Image")));
            this.b_close.Location = new System.Drawing.Point(825, 3);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 32;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_emailadm);
            this.groupBox1.Controls.Add(this.tb_passemail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(597, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 108);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciais Email:";
            // 
            // tb_emailadm
            // 
            this.tb_emailadm.BackColor = System.Drawing.Color.Silver;
            this.tb_emailadm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_emailadm.Location = new System.Drawing.Point(7, 39);
            this.tb_emailadm.Multiline = true;
            this.tb_emailadm.Name = "tb_emailadm";
            this.tb_emailadm.Size = new System.Drawing.Size(214, 20);
            this.tb_emailadm.TabIndex = 4;
            // 
            // tb_passemail
            // 
            this.tb_passemail.BackColor = System.Drawing.Color.Silver;
            this.tb_passemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_passemail.Location = new System.Drawing.Point(6, 78);
            this.tb_passemail.Multiline = true;
            this.tb_passemail.Name = "tb_passemail";
            this.tb_passemail.PasswordChar = '*';
            this.tb_passemail.Size = new System.Drawing.Size(214, 20);
            this.tb_passemail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_nao);
            this.groupBox2.Controls.Add(this.cb_sim);
            this.groupBox2.Controls.Add(this.tb_porta);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_smtp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(597, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 148);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Administrativo";
            // 
            // cb_nao
            // 
            this.cb_nao.AutoSize = true;
            this.cb_nao.Location = new System.Drawing.Point(106, 119);
            this.cb_nao.Name = "cb_nao";
            this.cb_nao.Size = new System.Drawing.Size(46, 17);
            this.cb_nao.TabIndex = 13;
            this.cb_nao.Text = "Não";
            this.cb_nao.UseVisualStyleBackColor = true;
            this.cb_nao.CheckedChanged += new System.EventHandler(this.cb_nao_CheckedChanged);
            // 
            // cb_sim
            // 
            this.cb_sim.AutoSize = true;
            this.cb_sim.Location = new System.Drawing.Point(57, 119);
            this.cb_sim.Name = "cb_sim";
            this.cb_sim.Size = new System.Drawing.Size(43, 17);
            this.cb_sim.TabIndex = 12;
            this.cb_sim.Text = "Sim";
            this.cb_sim.UseVisualStyleBackColor = true;
            this.cb_sim.CheckedChanged += new System.EventHandler(this.cb_sim_CheckedChanged);
            // 
            // tb_porta
            // 
            this.tb_porta.BackColor = System.Drawing.Color.Silver;
            this.tb_porta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_porta.Location = new System.Drawing.Point(7, 89);
            this.tb_porta.Multiline = true;
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(214, 20);
            this.tb_porta.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Porta:";
            // 
            // tb_smtp
            // 
            this.tb_smtp.BackColor = System.Drawing.Color.Silver;
            this.tb_smtp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_smtp.Location = new System.Drawing.Point(7, 49);
            this.tb_smtp.Multiline = true;
            this.tb_smtp.Name = "tb_smtp";
            this.tb_smtp.Size = new System.Drawing.Size(214, 20);
            this.tb_smtp.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SSL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Smtp Server:";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(856, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_fechar);
            this.Controls.Add(this.pb_remover);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.pb_abrir);
            this.Controls.Add(this.tb_nomehpl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Administrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreConfig";
            this.Load += new System.EventHandler(this.PreConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_remover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_abrir)).EndInit();
            this.Administrador.ResumeLayout(false);
            this.Administrador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fechar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Administrador;
        private System.Windows.Forms.PictureBox pb_remover;
        private System.Windows.Forms.PictureBox pb_abrir;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_forca;
        public System.Windows.Forms.ProgressBar pb_forca;
        public System.Windows.Forms.TextBox tb_porta;
        public System.Windows.Forms.CheckBox cb_sim;
        public System.Windows.Forms.CheckBox cb_nao;
        public System.Windows.Forms.TextBox tb_smtp;
        public System.Windows.Forms.TextBox tb_passemail;
        public System.Windows.Forms.TextBox tb_emailadm;
        public System.Windows.Forms.PictureBox pb_fechar;
        public System.Windows.Forms.TextBox tb_admin;
        public System.Windows.Forms.TextBox tb_pass;
        public System.Windows.Forms.TextBox tb_nomehpl;
    }
}