namespace Projecto_Tecnologico
{
    partial class Gestor_Enfermeiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestor_Enfermeiros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.b_min = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.b_max = new System.Windows.Forms.Button();
            this.opções = new System.Windows.Forms.Button();
            this.lb_hora = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.painel_opções = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.E_email = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.E_informacoes = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.E_Configurações = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.E_Tratamentos = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_mail = new System.Windows.Forms.Panel();
            this.pn_mailS = new System.Windows.Forms.Panel();
            this.pn_configuraçoes = new System.Windows.Forms.Panel();
            this.pn_configuraçoesS = new System.Windows.Forms.Panel();
            this.pn_informaçoes = new System.Windows.Forms.Panel();
            this.pn_informaçoesS = new System.Windows.Forms.Panel();
            this.pn_tratamentos = new System.Windows.Forms.Panel();
            this.pn_tratamentosS = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.painel_opções.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_mail.SuspendLayout();
            this.pn_configuraçoes.SuspendLayout();
            this.pn_informaçoes.SuspendLayout();
            this.pn_tratamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.b_min);
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.b_max);
            this.panel1.Controls.Add(this.opções);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 46);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "UTILIZADOR :";
            // 
            // b_min
            // 
            this.b_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_min.Image = ((System.Drawing.Image)(resources.GetObject("b_min.Image")));
            this.b_min.Location = new System.Drawing.Point(1289, 1);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 4;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // b_close
            // 
            this.b_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Image = ((System.Drawing.Image)(resources.GetObject("b_close.Image")));
            this.b_close.Location = new System.Drawing.Point(1344, 1);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 3;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_max
            // 
            this.b_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_max.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_max.Image = ((System.Drawing.Image)(resources.GetObject("b_max.Image")));
            this.b_max.Location = new System.Drawing.Point(1316, 1);
            this.b_max.Name = "b_max";
            this.b_max.Size = new System.Drawing.Size(29, 28);
            this.b_max.TabIndex = 5;
            this.b_max.UseVisualStyleBackColor = true;
            this.b_max.Click += new System.EventHandler(this.b_max_Click);
            // 
            // opções
            // 
            this.opções.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opções.BackgroundImage")));
            this.opções.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.opções.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opções.FlatAppearance.BorderSize = 0;
            this.opções.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opções.Location = new System.Drawing.Point(3, 5);
            this.opções.Name = "opções";
            this.opções.Size = new System.Drawing.Size(45, 38);
            this.opções.TabIndex = 0;
            this.opções.UseVisualStyleBackColor = true;
            this.opções.Click += new System.EventHandler(this.opções_Click);
            // 
            // lb_hora
            // 
            this.lb_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_hora.AutoSize = true;
            this.lb_hora.BackColor = System.Drawing.Color.Transparent;
            this.lb_hora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.Color.Black;
            this.lb_hora.Location = new System.Drawing.Point(1264, 16);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(0, 18);
            this.lb_hora.TabIndex = 2;
            // 
            // lb_data
            // 
            this.lb_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_data.AutoSize = true;
            this.lb_data.BackColor = System.Drawing.Color.Transparent;
            this.lb_data.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.ForeColor = System.Drawing.Color.Black;
            this.lb_data.Location = new System.Drawing.Point(1226, 40);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(0, 18);
            this.lb_data.TabIndex = 1;
            // 
            // painel_opções
            // 
            this.painel_opções.BackColor = System.Drawing.Color.Transparent;
            this.painel_opções.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painel_opções.BackgroundImage")));
            this.painel_opções.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.painel_opções.Controls.Add(this.button7);
            this.painel_opções.Controls.Add(this.E_Configurações);
            this.painel_opções.Controls.Add(this.button1);
            this.painel_opções.Controls.Add(this.E_Tratamentos);
            this.painel_opções.Controls.Add(this.button4);
            this.painel_opções.Controls.Add(this.E_informacoes);
            this.painel_opções.Controls.Add(this.button8);
            this.painel_opções.Controls.Add(this.E_email);
            this.painel_opções.Location = new System.Drawing.Point(-2, 46);
            this.painel_opções.Name = "painel_opções";
            this.painel_opções.Size = new System.Drawing.Size(219, 240);
            this.painel_opções.TabIndex = 4;
            this.painel_opções.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(0, 177);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(216, 51);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // E_email
            // 
            this.E_email.BackColor = System.Drawing.Color.Transparent;
            this.E_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E_email.FlatAppearance.BorderSize = 0;
            this.E_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.E_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_email.ForeColor = System.Drawing.Color.Black;
            this.E_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.E_email.Location = new System.Drawing.Point(-2, 177);
            this.E_email.Name = "E_email";
            this.E_email.Size = new System.Drawing.Size(216, 51);
            this.E_email.TabIndex = 12;
            this.E_email.Text = "E-Mail";
            this.E_email.UseVisualStyleBackColor = false;
            this.E_email.Click += new System.EventHandler(this.E_email_Click);
            this.E_email.MouseLeave += new System.EventHandler(this.E_email_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 51);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // E_informacoes
            // 
            this.E_informacoes.BackColor = System.Drawing.Color.Transparent;
            this.E_informacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E_informacoes.FlatAppearance.BorderSize = 0;
            this.E_informacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.E_informacoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_informacoes.ForeColor = System.Drawing.Color.Black;
            this.E_informacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.E_informacoes.Location = new System.Drawing.Point(0, 63);
            this.E_informacoes.Name = "E_informacoes";
            this.E_informacoes.Size = new System.Drawing.Size(216, 51);
            this.E_informacoes.TabIndex = 15;
            this.E_informacoes.Text = "Informações";
            this.E_informacoes.UseVisualStyleBackColor = false;
            this.E_informacoes.Click += new System.EventHandler(this.E_informacoes_Click);
            this.E_informacoes.MouseLeave += new System.EventHandler(this.E_informacoes_MouseLeave);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(-1, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 51);
            this.button7.TabIndex = 14;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseHover += new System.EventHandler(this.button7_MouseHover);
            // 
            // E_Configurações
            // 
            this.E_Configurações.BackColor = System.Drawing.Color.Transparent;
            this.E_Configurações.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E_Configurações.FlatAppearance.BorderSize = 0;
            this.E_Configurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.E_Configurações.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_Configurações.ForeColor = System.Drawing.Color.Black;
            this.E_Configurações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.E_Configurações.Location = new System.Drawing.Point(-2, 120);
            this.E_Configurações.Name = "E_Configurações";
            this.E_Configurações.Size = new System.Drawing.Size(217, 51);
            this.E_Configurações.TabIndex = 8;
            this.E_Configurações.Text = "Configurações";
            this.E_Configurações.UseVisualStyleBackColor = false;
            this.E_Configurações.Click += new System.EventHandler(this.E_Configurações_Click);
            this.E_Configurações.MouseLeave += new System.EventHandler(this.E_Configurações_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-1, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 51);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // E_Tratamentos
            // 
            this.E_Tratamentos.BackColor = System.Drawing.Color.Transparent;
            this.E_Tratamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E_Tratamentos.FlatAppearance.BorderSize = 0;
            this.E_Tratamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.E_Tratamentos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_Tratamentos.ForeColor = System.Drawing.Color.Black;
            this.E_Tratamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.E_Tratamentos.Location = new System.Drawing.Point(-2, 6);
            this.E_Tratamentos.Name = "E_Tratamentos";
            this.E_Tratamentos.Size = new System.Drawing.Size(217, 51);
            this.E_Tratamentos.TabIndex = 9;
            this.E_Tratamentos.Text = "Tratamentos";
            this.E_Tratamentos.UseVisualStyleBackColor = false;
            this.E_Tratamentos.Click += new System.EventHandler(this.E_Tratamentos_Click);
            this.E_Tratamentos.MouseLeave += new System.EventHandler(this.E_Tratamentos_MouseLeave);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pn_mail);
            this.panel2.Controls.Add(this.pn_configuraçoes);
            this.panel2.Controls.Add(this.pn_informaçoes);
            this.panel2.Controls.Add(this.pn_tratamentos);
            this.panel2.Controls.Add(this.lb_hora);
            this.panel2.Controls.Add(this.lb_data);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 713);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 67);
            this.panel2.TabIndex = 13;
            // 
            // pn_mail
            // 
            this.pn_mail.BackColor = System.Drawing.Color.Transparent;
            this.pn_mail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_mail.BackgroundImage")));
            this.pn_mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_mail.Controls.Add(this.pn_mailS);
            this.pn_mail.Location = new System.Drawing.Point(235, 0);
            this.pn_mail.Name = "pn_mail";
            this.pn_mail.Size = new System.Drawing.Size(72, 67);
            this.pn_mail.TabIndex = 16;
            // 
            // pn_mailS
            // 
            this.pn_mailS.BackColor = System.Drawing.Color.Transparent;
            this.pn_mailS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_mailS.BackgroundImage")));
            this.pn_mailS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_mailS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_mailS.Location = new System.Drawing.Point(16, 16);
            this.pn_mailS.Name = "pn_mailS";
            this.pn_mailS.Size = new System.Drawing.Size(40, 33);
            this.pn_mailS.TabIndex = 8;
            this.pn_mailS.Click += new System.EventHandler(this.pn_mailS_Click);
            // 
            // pn_configuraçoes
            // 
            this.pn_configuraçoes.BackColor = System.Drawing.Color.Transparent;
            this.pn_configuraçoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_configuraçoes.BackgroundImage")));
            this.pn_configuraçoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_configuraçoes.Controls.Add(this.pn_configuraçoesS);
            this.pn_configuraçoes.Location = new System.Drawing.Point(157, 0);
            this.pn_configuraçoes.Name = "pn_configuraçoes";
            this.pn_configuraçoes.Size = new System.Drawing.Size(72, 67);
            this.pn_configuraçoes.TabIndex = 16;
            // 
            // pn_configuraçoesS
            // 
            this.pn_configuraçoesS.BackColor = System.Drawing.Color.Transparent;
            this.pn_configuraçoesS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_configuraçoesS.BackgroundImage")));
            this.pn_configuraçoesS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_configuraçoesS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_configuraçoesS.Location = new System.Drawing.Point(16, 16);
            this.pn_configuraçoesS.Name = "pn_configuraçoesS";
            this.pn_configuraçoesS.Size = new System.Drawing.Size(40, 33);
            this.pn_configuraçoesS.TabIndex = 8;
            this.pn_configuraçoesS.Click += new System.EventHandler(this.pn_configuraçoesS_Click);
            // 
            // pn_informaçoes
            // 
            this.pn_informaçoes.BackColor = System.Drawing.Color.Transparent;
            this.pn_informaçoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_informaçoes.BackgroundImage")));
            this.pn_informaçoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_informaçoes.Controls.Add(this.pn_informaçoesS);
            this.pn_informaçoes.Location = new System.Drawing.Point(79, 0);
            this.pn_informaçoes.Name = "pn_informaçoes";
            this.pn_informaçoes.Size = new System.Drawing.Size(72, 67);
            this.pn_informaçoes.TabIndex = 16;
            // 
            // pn_informaçoesS
            // 
            this.pn_informaçoesS.BackColor = System.Drawing.Color.Transparent;
            this.pn_informaçoesS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_informaçoesS.BackgroundImage")));
            this.pn_informaçoesS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_informaçoesS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_informaçoesS.Location = new System.Drawing.Point(16, 16);
            this.pn_informaçoesS.Name = "pn_informaçoesS";
            this.pn_informaçoesS.Size = new System.Drawing.Size(40, 33);
            this.pn_informaçoesS.TabIndex = 8;
            this.pn_informaçoesS.Click += new System.EventHandler(this.pn_informaçoesS_Click);
            // 
            // pn_tratamentos
            // 
            this.pn_tratamentos.BackColor = System.Drawing.Color.Transparent;
            this.pn_tratamentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_tratamentos.BackgroundImage")));
            this.pn_tratamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_tratamentos.Controls.Add(this.pn_tratamentosS);
            this.pn_tratamentos.Location = new System.Drawing.Point(1, 0);
            this.pn_tratamentos.Name = "pn_tratamentos";
            this.pn_tratamentos.Size = new System.Drawing.Size(72, 67);
            this.pn_tratamentos.TabIndex = 15;
            // 
            // pn_tratamentosS
            // 
            this.pn_tratamentosS.BackColor = System.Drawing.Color.Transparent;
            this.pn_tratamentosS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_tratamentosS.BackgroundImage")));
            this.pn_tratamentosS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_tratamentosS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_tratamentosS.Location = new System.Drawing.Point(16, 16);
            this.pn_tratamentosS.Name = "pn_tratamentosS";
            this.pn_tratamentosS.Size = new System.Drawing.Size(40, 33);
            this.pn_tratamentosS.TabIndex = 8;
            this.pn_tratamentosS.Click += new System.EventHandler(this.pn_tratamentosS_Click);
            // 
            // Gestor_Enfermeiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.painel_opções);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Gestor_Enfermeiros";
            this.Text = "Gestor_Enfermeiros";
            this.Load += new System.EventHandler(this.Gestor_Enfermeiros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painel_opções.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_mail.ResumeLayout(false);
            this.pn_configuraçoes.ResumeLayout(false);
            this.pn_informaçoes.ResumeLayout(false);
            this.pn_tratamentos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_max;
        private System.Windows.Forms.Button opções;
        private System.Windows.Forms.Panel painel_opções;
        public System.Windows.Forms.Button E_Configurações;
        private System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.Button E_Tratamentos;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button E_email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button E_informacoes;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel pn_tratamentos;
        private System.Windows.Forms.Panel pn_tratamentosS;
        public System.Windows.Forms.Panel pn_mail;
        private System.Windows.Forms.Panel pn_mailS;
        public System.Windows.Forms.Panel pn_configuraçoes;
        private System.Windows.Forms.Panel pn_configuraçoesS;
        public System.Windows.Forms.Panel pn_informaçoes;
        private System.Windows.Forms.Panel pn_informaçoesS;
    }
}