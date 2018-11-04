namespace Projecto_Tecnologico
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.painel_key = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CB_Previlégio = new System.Windows.Forms.ComboBox();
            this.TB_Nome = new System.Windows.Forms.TextBox();
            this.TB_Senha = new System.Windows.Forms.TextBox();
            this.b_Visivel = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PB_Entrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_incorrecto = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timercloser = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Entrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.painel_key);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.b_close.Location = new System.Drawing.Point(619, 1);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 14;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // painel_key
            // 
            this.painel_key.BackColor = System.Drawing.Color.Black;
            this.painel_key.Location = new System.Drawing.Point(505, 22);
            this.painel_key.Name = "painel_key";
            this.painel_key.Size = new System.Drawing.Size(10, 10);
            this.painel_key.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(213, 373);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // CB_Previlégio
            // 
            this.CB_Previlégio.FormattingEnabled = true;
            this.CB_Previlégio.Items.AddRange(new object[] {
            "Adminstrador",
            "Médico",
            "Enfermeiro",
            "Rececionista",
            "Laboratorista"});
            this.CB_Previlégio.Location = new System.Drawing.Point(493, 457);
            this.CB_Previlégio.Name = "CB_Previlégio";
            this.CB_Previlégio.Size = new System.Drawing.Size(110, 21);
            this.CB_Previlégio.TabIndex = 2;
            this.CB_Previlégio.SelectedIndexChanged += new System.EventHandler(this.CB_Previlégio_SelectedIndexChanged);
            // 
            // TB_Nome
            // 
            this.TB_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nome.Location = new System.Drawing.Point(254, 333);
            this.TB_Nome.Multiline = true;
            this.TB_Nome.Name = "TB_Nome";
            this.TB_Nome.Size = new System.Drawing.Size(196, 26);
            this.TB_Nome.TabIndex = 4;
            this.TB_Nome.TextChanged += new System.EventHandler(this.TB_Nome_TextChanged);
            // 
            // TB_Senha
            // 
            this.TB_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Senha.Location = new System.Drawing.Point(253, 376);
            this.TB_Senha.Multiline = true;
            this.TB_Senha.Name = "TB_Senha";
            this.TB_Senha.PasswordChar = '•';
            this.TB_Senha.Size = new System.Drawing.Size(196, 26);
            this.TB_Senha.TabIndex = 5;
            this.TB_Senha.TextChanged += new System.EventHandler(this.TB_Senha_TextChanged);
            // 
            // b_Visivel
            // 
            this.b_Visivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Visivel.FlatAppearance.BorderSize = 0;
            this.b_Visivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Visivel.Image = ((System.Drawing.Image)(resources.GetObject("b_Visivel.Image")));
            this.b_Visivel.Location = new System.Drawing.Point(423, 382);
            this.b_Visivel.Name = "b_Visivel";
            this.b_Visivel.Size = new System.Drawing.Size(23, 14);
            this.b_Visivel.TabIndex = 7;
            this.b_Visivel.UseVisualStyleBackColor = true;
            this.b_Visivel.Click += new System.EventHandler(this.b_Visivel_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(453, 452);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // PB_Entrar
            // 
            this.PB_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.PB_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Entrar.Image = ((System.Drawing.Image)(resources.GetObject("PB_Entrar.Image")));
            this.PB_Entrar.Location = new System.Drawing.Point(297, 457);
            this.PB_Entrar.Name = "PB_Entrar";
            this.PB_Entrar.Size = new System.Drawing.Size(111, 46);
            this.PB_Entrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Entrar.TabIndex = 9;
            this.PB_Entrar.TabStop = false;
            this.PB_Entrar.Click += new System.EventHandler(this.PB_Entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Com todos os Direitos Reservados @ Daniel; Miguel; Rodolfo 407 | Projecto Tecnoló" +
    "gico 2016";
            // 
            // lb_incorrecto
            // 
            this.lb_incorrecto.AutoSize = true;
            this.lb_incorrecto.BackColor = System.Drawing.Color.White;
            this.lb_incorrecto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_incorrecto.ForeColor = System.Drawing.Color.Maroon;
            this.lb_incorrecto.Location = new System.Drawing.Point(284, 405);
            this.lb_incorrecto.Name = "lb_incorrecto";
            this.lb_incorrecto.Size = new System.Drawing.Size(124, 18);
            this.lb_incorrecto.TabIndex = 11;
            this.lb_incorrecto.Text = "Login Incorrecto!";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(453, 490);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // timercloser
            // 
            this.timercloser.FormattingEnabled = true;
            this.timercloser.Items.AddRange(new object[] {
            "1 Minuto",
            "5 Minutos",
            "10 Minutos",
            "30 Minutos",
            "Nunca"});
            this.timercloser.Location = new System.Drawing.Point(491, 501);
            this.timercloser.Name = "timercloser";
            this.timercloser.Size = new System.Drawing.Size(110, 21);
            this.timercloser.TabIndex = 14;
            this.timercloser.SelectedIndexChanged += new System.EventHandler(this.timercloser_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 650);
            this.Controls.Add(this.timercloser);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lb_incorrecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_Entrar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.b_Visivel);
            this.Controls.Add(this.TB_Senha);
            this.Controls.Add(this.TB_Nome);
            this.Controls.Add(this.CB_Previlégio);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Entrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button b_Visivel;
        private System.Windows.Forms.Panel painel_key;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox PB_Entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_incorrecto;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox timercloser;
        public System.Windows.Forms.TextBox TB_Senha;
        public System.Windows.Forms.TextBox TB_Nome;
        public System.Windows.Forms.ComboBox CB_Previlégio;
    }
}

