namespace Projecto_Tecnologico
{
    partial class Gestor_Médicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestor_Médicos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.b_min = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.b_max = new System.Windows.Forms.Button();
            this.opções = new System.Windows.Forms.Button();
            this.lb_hora = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.painel_opções = new System.Windows.Forms.Panel();
            this.M_informacoes = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.M_email = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.M_Consultas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.M_Analises = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.M_Configurações = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.M_Receitas = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_configuraçoes = new System.Windows.Forms.Panel();
            this.pn_configuraçoesS = new System.Windows.Forms.Panel();
            this.pn_informaçoes = new System.Windows.Forms.Panel();
            this.pn_informaçoesS = new System.Windows.Forms.Panel();
            this.pn_mail = new System.Windows.Forms.Panel();
            this.pn_mailS = new System.Windows.Forms.Panel();
            this.pn_receitas = new System.Windows.Forms.Panel();
            this.pn_receitasS = new System.Windows.Forms.Panel();
            this.pn_analises = new System.Windows.Forms.Panel();
            this.pn_analisesS = new System.Windows.Forms.Panel();
            this.pn_consultas = new System.Windows.Forms.Panel();
            this.pn_consultasS = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.painel_opções.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_configuraçoes.SuspendLayout();
            this.pn_informaçoes.SuspendLayout();
            this.pn_mail.SuspendLayout();
            this.pn_receitas.SuspendLayout();
            this.pn_analises.SuspendLayout();
            this.pn_consultas.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 13);
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
            this.b_min.Location = new System.Drawing.Point(1288, 2);
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
            this.b_close.Location = new System.Drawing.Point(1344, 2);
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
            this.b_max.Location = new System.Drawing.Point(1316, 2);
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
            this.painel_opções.Controls.Add(this.button8);
            this.painel_opções.Controls.Add(this.M_email);
            this.painel_opções.Controls.Add(this.button1);
            this.painel_opções.Controls.Add(this.M_Consultas);
            this.painel_opções.Controls.Add(this.button3);
            this.painel_opções.Controls.Add(this.M_Analises);
            this.painel_opções.Controls.Add(this.button7);
            this.painel_opções.Controls.Add(this.M_Configurações);
            this.painel_opções.Controls.Add(this.button2);
            this.painel_opções.Controls.Add(this.M_Receitas);
            this.painel_opções.Controls.Add(this.button4);
            this.painel_opções.Controls.Add(this.M_informacoes);
            this.painel_opções.Location = new System.Drawing.Point(0, 45);
            this.painel_opções.Name = "painel_opções";
            this.painel_opções.Size = new System.Drawing.Size(217, 355);
            this.painel_opções.TabIndex = 3;
            this.painel_opções.Visible = false;
            // 
            // M_informacoes
            // 
            this.M_informacoes.BackColor = System.Drawing.Color.Transparent;
            this.M_informacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_informacoes.FlatAppearance.BorderSize = 0;
            this.M_informacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_informacoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_informacoes.ForeColor = System.Drawing.Color.Black;
            this.M_informacoes.Location = new System.Drawing.Point(0, 177);
            this.M_informacoes.Name = "M_informacoes";
            this.M_informacoes.Size = new System.Drawing.Size(219, 51);
            this.M_informacoes.TabIndex = 8;
            this.M_informacoes.Text = "Informações";
            this.M_informacoes.UseVisualStyleBackColor = false;
            this.M_informacoes.Click += new System.EventHandler(this.M_informacoes_Click);
            this.M_informacoes.MouseLeave += new System.EventHandler(this.M_informacoes_MouseLeave);
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
            this.button8.Location = new System.Drawing.Point(0, 291);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(216, 51);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // M_email
            // 
            this.M_email.BackColor = System.Drawing.Color.Transparent;
            this.M_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_email.FlatAppearance.BorderSize = 0;
            this.M_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_email.ForeColor = System.Drawing.Color.Black;
            this.M_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.M_email.Location = new System.Drawing.Point(0, 291);
            this.M_email.Name = "M_email";
            this.M_email.Size = new System.Drawing.Size(216, 51);
            this.M_email.TabIndex = 10;
            this.M_email.Text = "E-Mail";
            this.M_email.UseVisualStyleBackColor = false;
            this.M_email.Click += new System.EventHandler(this.M_email_Click);
            this.M_email.MouseLeave += new System.EventHandler(this.M_email_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 51);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // M_Consultas
            // 
            this.M_Consultas.BackColor = System.Drawing.Color.Transparent;
            this.M_Consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_Consultas.FlatAppearance.BorderSize = 0;
            this.M_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_Consultas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Consultas.ForeColor = System.Drawing.Color.Black;
            this.M_Consultas.Location = new System.Drawing.Point(0, 6);
            this.M_Consultas.Name = "M_Consultas";
            this.M_Consultas.Size = new System.Drawing.Size(217, 51);
            this.M_Consultas.TabIndex = 7;
            this.M_Consultas.Text = "Consultas";
            this.M_Consultas.UseVisualStyleBackColor = false;
            this.M_Consultas.Click += new System.EventHandler(this.M_Consultas_Click);
            this.M_Consultas.MouseLeave += new System.EventHandler(this.M_Consultas_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 51);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // M_Analises
            // 
            this.M_Analises.BackColor = System.Drawing.Color.Transparent;
            this.M_Analises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_Analises.FlatAppearance.BorderSize = 0;
            this.M_Analises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_Analises.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Analises.ForeColor = System.Drawing.Color.Black;
            this.M_Analises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.M_Analises.Location = new System.Drawing.Point(-2, 63);
            this.M_Analises.Name = "M_Analises";
            this.M_Analises.Size = new System.Drawing.Size(219, 51);
            this.M_Analises.TabIndex = 9;
            this.M_Analises.Text = "Análises";
            this.M_Analises.UseVisualStyleBackColor = false;
            this.M_Analises.Click += new System.EventHandler(this.M_Analises_Click);
            this.M_Analises.MouseLeave += new System.EventHandler(this.M_Analises_MouseLeave);
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
            this.button7.Location = new System.Drawing.Point(-1, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 51);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseHover += new System.EventHandler(this.button7_MouseHover);
            // 
            // M_Configurações
            // 
            this.M_Configurações.BackColor = System.Drawing.Color.Transparent;
            this.M_Configurações.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_Configurações.FlatAppearance.BorderSize = 0;
            this.M_Configurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_Configurações.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Configurações.ForeColor = System.Drawing.Color.Black;
            this.M_Configurações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.M_Configurações.Location = new System.Drawing.Point(-2, 234);
            this.M_Configurações.Name = "M_Configurações";
            this.M_Configurações.Size = new System.Drawing.Size(219, 51);
            this.M_Configurações.TabIndex = 8;
            this.M_Configurações.Text = "Configurações";
            this.M_Configurações.UseVisualStyleBackColor = false;
            this.M_Configurações.Click += new System.EventHandler(this.M_Configurações_Click);
            this.M_Configurações.MouseLeave += new System.EventHandler(this.M_Configurações_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-2, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 51);
            this.button2.TabIndex = 7;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // M_Receitas
            // 
            this.M_Receitas.BackColor = System.Drawing.Color.Transparent;
            this.M_Receitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.M_Receitas.FlatAppearance.BorderSize = 0;
            this.M_Receitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M_Receitas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Receitas.ForeColor = System.Drawing.Color.Black;
            this.M_Receitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.M_Receitas.Location = new System.Drawing.Point(-1, 120);
            this.M_Receitas.Name = "M_Receitas";
            this.M_Receitas.Size = new System.Drawing.Size(219, 51);
            this.M_Receitas.TabIndex = 6;
            this.M_Receitas.Text = "Receitas";
            this.M_Receitas.UseVisualStyleBackColor = false;
            this.M_Receitas.Click += new System.EventHandler(this.M_Receitas_Click);
            this.M_Receitas.MouseLeave += new System.EventHandler(this.M_Receitas_MouseLeave);
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
            this.button4.Location = new System.Drawing.Point(-1, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 51);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pn_configuraçoes);
            this.panel2.Controls.Add(this.pn_informaçoes);
            this.panel2.Controls.Add(this.pn_mail);
            this.panel2.Controls.Add(this.pn_receitas);
            this.panel2.Controls.Add(this.pn_analises);
            this.panel2.Controls.Add(this.pn_consultas);
            this.panel2.Controls.Add(this.lb_hora);
            this.panel2.Controls.Add(this.lb_data);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 713);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 67);
            this.panel2.TabIndex = 6;
            // 
            // pn_configuraçoes
            // 
            this.pn_configuraçoes.BackColor = System.Drawing.Color.Transparent;
            this.pn_configuraçoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_configuraçoes.BackgroundImage")));
            this.pn_configuraçoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_configuraçoes.Controls.Add(this.pn_configuraçoesS);
            this.pn_configuraçoes.Location = new System.Drawing.Point(313, 0);
            this.pn_configuraçoes.Name = "pn_configuraçoes";
            this.pn_configuraçoes.Size = new System.Drawing.Size(72, 67);
            this.pn_configuraçoes.TabIndex = 9;
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
            this.pn_informaçoes.Location = new System.Drawing.Point(235, 0);
            this.pn_informaçoes.Name = "pn_informaçoes";
            this.pn_informaçoes.Size = new System.Drawing.Size(72, 67);
            this.pn_informaçoes.TabIndex = 9;
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
            // pn_mail
            // 
            this.pn_mail.BackColor = System.Drawing.Color.Transparent;
            this.pn_mail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_mail.BackgroundImage")));
            this.pn_mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_mail.Controls.Add(this.pn_mailS);
            this.pn_mail.Location = new System.Drawing.Point(391, 0);
            this.pn_mail.Name = "pn_mail";
            this.pn_mail.Size = new System.Drawing.Size(72, 67);
            this.pn_mail.TabIndex = 11;
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
            // pn_receitas
            // 
            this.pn_receitas.BackColor = System.Drawing.Color.Transparent;
            this.pn_receitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_receitas.BackgroundImage")));
            this.pn_receitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_receitas.Controls.Add(this.pn_receitasS);
            this.pn_receitas.Location = new System.Drawing.Point(157, 0);
            this.pn_receitas.Name = "pn_receitas";
            this.pn_receitas.Size = new System.Drawing.Size(72, 67);
            this.pn_receitas.TabIndex = 10;
            // 
            // pn_receitasS
            // 
            this.pn_receitasS.BackColor = System.Drawing.Color.Transparent;
            this.pn_receitasS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_receitasS.BackgroundImage")));
            this.pn_receitasS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_receitasS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_receitasS.Location = new System.Drawing.Point(16, 16);
            this.pn_receitasS.Name = "pn_receitasS";
            this.pn_receitasS.Size = new System.Drawing.Size(40, 33);
            this.pn_receitasS.TabIndex = 8;
            this.pn_receitasS.Click += new System.EventHandler(this.pn_receitasS_Click);
            // 
            // pn_analises
            // 
            this.pn_analises.BackColor = System.Drawing.Color.Transparent;
            this.pn_analises.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_analises.BackgroundImage")));
            this.pn_analises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_analises.Controls.Add(this.pn_analisesS);
            this.pn_analises.Location = new System.Drawing.Point(79, 0);
            this.pn_analises.Name = "pn_analises";
            this.pn_analises.Size = new System.Drawing.Size(72, 67);
            this.pn_analises.TabIndex = 9;
            // 
            // pn_analisesS
            // 
            this.pn_analisesS.BackColor = System.Drawing.Color.Transparent;
            this.pn_analisesS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_analisesS.BackgroundImage")));
            this.pn_analisesS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_analisesS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_analisesS.Location = new System.Drawing.Point(16, 16);
            this.pn_analisesS.Name = "pn_analisesS";
            this.pn_analisesS.Size = new System.Drawing.Size(40, 33);
            this.pn_analisesS.TabIndex = 8;
            this.pn_analisesS.Click += new System.EventHandler(this.pn_analisesS_Click);
            // 
            // pn_consultas
            // 
            this.pn_consultas.BackColor = System.Drawing.Color.Transparent;
            this.pn_consultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_consultas.BackgroundImage")));
            this.pn_consultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_consultas.Controls.Add(this.pn_consultasS);
            this.pn_consultas.Location = new System.Drawing.Point(1, 0);
            this.pn_consultas.Name = "pn_consultas";
            this.pn_consultas.Size = new System.Drawing.Size(72, 67);
            this.pn_consultas.TabIndex = 8;
            // 
            // pn_consultasS
            // 
            this.pn_consultasS.BackColor = System.Drawing.Color.Transparent;
            this.pn_consultasS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_consultasS.BackgroundImage")));
            this.pn_consultasS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_consultasS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_consultasS.Location = new System.Drawing.Point(16, 16);
            this.pn_consultasS.Name = "pn_consultasS";
            this.pn_consultasS.Size = new System.Drawing.Size(40, 33);
            this.pn_consultasS.TabIndex = 8;
            this.pn_consultasS.Click += new System.EventHandler(this.pn_consultasS_Click);
            // 
            // Gestor_Médicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.painel_opções);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Gestor_Médicos";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Gestor_Médicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painel_opções.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_configuraçoes.ResumeLayout(false);
            this.pn_informaçoes.ResumeLayout(false);
            this.pn_mail.ResumeLayout(false);
            this.pn_receitas.ResumeLayout(false);
            this.pn_analises.ResumeLayout(false);
            this.pn_consultas.ResumeLayout(false);
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
        public System.Windows.Forms.Button M_Configurações;
        public System.Windows.Forms.Button M_Receitas;
        public System.Windows.Forms.Button M_Consultas;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Button M_Analises;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button M_email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Panel pn_configuraçoes;
        private System.Windows.Forms.Panel pn_configuraçoesS;
        public System.Windows.Forms.Panel pn_informaçoes;
        private System.Windows.Forms.Panel pn_informaçoesS;
        public System.Windows.Forms.Panel pn_mail;
        private System.Windows.Forms.Panel pn_mailS;
        public System.Windows.Forms.Panel pn_receitas;
        private System.Windows.Forms.Panel pn_receitasS;
        public System.Windows.Forms.Panel pn_analises;
        private System.Windows.Forms.Panel pn_analisesS;
        public System.Windows.Forms.Panel pn_consultas;
        private System.Windows.Forms.Panel pn_consultasS;
        public System.Windows.Forms.Button M_informacoes;
    }
}