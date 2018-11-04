namespace Projecto_Tecnologico
{
    partial class Gestor_Recepcionistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestor_Recepcionistas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.b_min = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.b_max = new System.Windows.Forms.Button();
            this.opções = new System.Windows.Forms.Button();
            this.lb_hora = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.painel_opções = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.R_Marcarexame = new System.Windows.Forms.Button();
            this.R_Consultas = new System.Windows.Forms.Button();
            this.R_Cirugias = new System.Windows.Forms.Button();
            this.R_Analises = new System.Windows.Forms.Button();
            this.R_informacoes = new System.Windows.Forms.Button();
            this.R_Configurações = new System.Windows.Forms.Button();
            this.R_email = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_configuraçoes = new System.Windows.Forms.Panel();
            this.pn_configuraçoesS = new System.Windows.Forms.Panel();
            this.pn_mail = new System.Windows.Forms.Panel();
            this.pn_mailS = new System.Windows.Forms.Panel();
            this.pn_consultas = new System.Windows.Forms.Panel();
            this.pn_consultasS = new System.Windows.Forms.Panel();
            this.pn_cirugia = new System.Windows.Forms.Panel();
            this.pn_cirugiaS = new System.Windows.Forms.Panel();
            this.pn_analises = new System.Windows.Forms.Panel();
            this.pn_analisesS = new System.Windows.Forms.Panel();
            this.pn_informaçoes = new System.Windows.Forms.Panel();
            this.pn_informaçoesS = new System.Windows.Forms.Panel();
            this.pn_mexame = new System.Windows.Forms.Panel();
            this.pn_mexameS = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.painel_opções.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_configuraçoes.SuspendLayout();
            this.pn_mail.SuspendLayout();
            this.pn_consultas.SuspendLayout();
            this.pn_cirugia.SuspendLayout();
            this.pn_analises.SuspendLayout();
            this.pn_informaçoes.SuspendLayout();
            this.pn_mexame.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(590, 13);
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
            this.b_min.Location = new System.Drawing.Point(1289, 2);
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
            this.b_close.Location = new System.Drawing.Point(1345, 2);
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
            this.b_max.Location = new System.Drawing.Point(1317, 2);
            this.b_max.Name = "b_max";
            this.b_max.Size = new System.Drawing.Size(29, 28);
            this.b_max.TabIndex = 5;
            this.b_max.UseVisualStyleBackColor = true;
            this.b_max.Click += new System.EventHandler(this.b_max_Click);
            // 
            // opções
            // 
            this.opções.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opções.FlatAppearance.BorderSize = 0;
            this.opções.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opções.Image = ((System.Drawing.Image)(resources.GetObject("opções.Image")));
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
            this.painel_opções.Controls.Add(this.button2);
            this.painel_opções.Controls.Add(this.button1);
            this.painel_opções.Controls.Add(this.button5);
            this.painel_opções.Controls.Add(this.button3);
            this.painel_opções.Controls.Add(this.button4);
            this.painel_opções.Controls.Add(this.button7);
            this.painel_opções.Controls.Add(this.button8);
            this.painel_opções.Controls.Add(this.R_Marcarexame);
            this.painel_opções.Controls.Add(this.R_Consultas);
            this.painel_opções.Controls.Add(this.R_Cirugias);
            this.painel_opções.Controls.Add(this.R_Analises);
            this.painel_opções.Controls.Add(this.R_informacoes);
            this.painel_opções.Controls.Add(this.R_Configurações);
            this.painel_opções.Controls.Add(this.R_email);
            this.painel_opções.Location = new System.Drawing.Point(0, 45);
            this.painel_opções.Name = "painel_opções";
            this.painel_opções.Size = new System.Drawing.Size(217, 414);
            this.painel_opções.TabIndex = 4;
            this.painel_opções.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-1, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 51);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
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
            this.button1.Location = new System.Drawing.Point(-1, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 51);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(-2, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 51);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
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
            this.button3.Location = new System.Drawing.Point(-2, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 51);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
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
            this.button4.Location = new System.Drawing.Point(0, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 51);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
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
            this.button7.Location = new System.Drawing.Point(0, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 51);
            this.button7.TabIndex = 11;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseHover += new System.EventHandler(this.button7_MouseHover);
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
            this.button8.Location = new System.Drawing.Point(1, 353);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(216, 51);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // R_Marcarexame
            // 
            this.R_Marcarexame.BackColor = System.Drawing.Color.Transparent;
            this.R_Marcarexame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_Marcarexame.FlatAppearance.BorderSize = 0;
            this.R_Marcarexame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Marcarexame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Marcarexame.ForeColor = System.Drawing.Color.Black;
            this.R_Marcarexame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_Marcarexame.Location = new System.Drawing.Point(-2, 11);
            this.R_Marcarexame.Name = "R_Marcarexame";
            this.R_Marcarexame.Size = new System.Drawing.Size(219, 51);
            this.R_Marcarexame.TabIndex = 9;
            this.R_Marcarexame.Text = "Marcar Exame";
            this.R_Marcarexame.UseVisualStyleBackColor = false;
            this.R_Marcarexame.Click += new System.EventHandler(this.R_Marcarexame_Click);
            this.R_Marcarexame.MouseLeave += new System.EventHandler(this.R_Marcarexame_MouseLeave);
            // 
            // R_Consultas
            // 
            this.R_Consultas.BackColor = System.Drawing.Color.Transparent;
            this.R_Consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_Consultas.FlatAppearance.BorderSize = 0;
            this.R_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Consultas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Consultas.ForeColor = System.Drawing.Color.Black;
            this.R_Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_Consultas.Location = new System.Drawing.Point(-2, 68);
            this.R_Consultas.Name = "R_Consultas";
            this.R_Consultas.Size = new System.Drawing.Size(220, 51);
            this.R_Consultas.TabIndex = 7;
            this.R_Consultas.Text = "Consultas";
            this.R_Consultas.UseVisualStyleBackColor = false;
            this.R_Consultas.Click += new System.EventHandler(this.R_Consultas_Click);
            this.R_Consultas.MouseLeave += new System.EventHandler(this.R_Consultas_MouseLeave);
            // 
            // R_Cirugias
            // 
            this.R_Cirugias.BackColor = System.Drawing.Color.Transparent;
            this.R_Cirugias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_Cirugias.FlatAppearance.BorderSize = 0;
            this.R_Cirugias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Cirugias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Cirugias.ForeColor = System.Drawing.Color.Black;
            this.R_Cirugias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_Cirugias.Location = new System.Drawing.Point(-2, 125);
            this.R_Cirugias.Name = "R_Cirugias";
            this.R_Cirugias.Size = new System.Drawing.Size(220, 51);
            this.R_Cirugias.TabIndex = 10;
            this.R_Cirugias.Text = "Cirurgias";
            this.R_Cirugias.UseVisualStyleBackColor = false;
            this.R_Cirugias.Click += new System.EventHandler(this.R_Cirugias_Click);
            this.R_Cirugias.MouseLeave += new System.EventHandler(this.R_Cirugias_MouseLeave);
            // 
            // R_Analises
            // 
            this.R_Analises.BackColor = System.Drawing.Color.Transparent;
            this.R_Analises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_Analises.FlatAppearance.BorderSize = 0;
            this.R_Analises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Analises.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Analises.ForeColor = System.Drawing.Color.Black;
            this.R_Analises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_Analises.Location = new System.Drawing.Point(-1, 182);
            this.R_Analises.Name = "R_Analises";
            this.R_Analises.Size = new System.Drawing.Size(219, 51);
            this.R_Analises.TabIndex = 13;
            this.R_Analises.Text = "Análises";
            this.R_Analises.UseVisualStyleBackColor = false;
            this.R_Analises.Click += new System.EventHandler(this.R_Analises_Click);
            this.R_Analises.MouseLeave += new System.EventHandler(this.R_Analises_MouseLeave);
            // 
            // R_informacoes
            // 
            this.R_informacoes.BackColor = System.Drawing.Color.Transparent;
            this.R_informacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_informacoes.FlatAppearance.BorderSize = 0;
            this.R_informacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_informacoes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_informacoes.ForeColor = System.Drawing.Color.Black;
            this.R_informacoes.Location = new System.Drawing.Point(-2, 239);
            this.R_informacoes.Name = "R_informacoes";
            this.R_informacoes.Size = new System.Drawing.Size(219, 51);
            this.R_informacoes.TabIndex = 17;
            this.R_informacoes.Text = "Informações";
            this.R_informacoes.UseVisualStyleBackColor = false;
            this.R_informacoes.Click += new System.EventHandler(this.R_informacoes_Click);
            this.R_informacoes.MouseLeave += new System.EventHandler(this.R_informacoes_MouseLeave);
            // 
            // R_Configurações
            // 
            this.R_Configurações.BackColor = System.Drawing.Color.Transparent;
            this.R_Configurações.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_Configurações.FlatAppearance.BorderSize = 0;
            this.R_Configurações.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Configurações.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Configurações.ForeColor = System.Drawing.Color.Black;
            this.R_Configurações.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_Configurações.Location = new System.Drawing.Point(-1, 296);
            this.R_Configurações.Name = "R_Configurações";
            this.R_Configurações.Size = new System.Drawing.Size(219, 51);
            this.R_Configurações.TabIndex = 8;
            this.R_Configurações.Text = "Configurações";
            this.R_Configurações.UseVisualStyleBackColor = false;
            this.R_Configurações.Click += new System.EventHandler(this.R_Configurações_Click);
            this.R_Configurações.MouseLeave += new System.EventHandler(this.R_Configurações_MouseLeave);
            // 
            // R_email
            // 
            this.R_email.BackColor = System.Drawing.Color.Transparent;
            this.R_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_email.FlatAppearance.BorderSize = 0;
            this.R_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_email.ForeColor = System.Drawing.Color.Black;
            this.R_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.R_email.Location = new System.Drawing.Point(1, 353);
            this.R_email.Name = "R_email";
            this.R_email.Size = new System.Drawing.Size(216, 51);
            this.R_email.TabIndex = 15;
            this.R_email.Text = "E-Mail";
            this.R_email.UseVisualStyleBackColor = false;
            this.R_email.Click += new System.EventHandler(this.R_email_Click);
            this.R_email.MouseLeave += new System.EventHandler(this.R_email_MouseLeave);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pn_configuraçoes);
            this.panel2.Controls.Add(this.pn_mail);
            this.panel2.Controls.Add(this.pn_consultas);
            this.panel2.Controls.Add(this.pn_cirugia);
            this.panel2.Controls.Add(this.pn_analises);
            this.panel2.Controls.Add(this.pn_informaçoes);
            this.panel2.Controls.Add(this.pn_mexame);
            this.panel2.Controls.Add(this.lb_hora);
            this.panel2.Controls.Add(this.lb_data);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 713);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 67);
            this.panel2.TabIndex = 7;
            // 
            // pn_configuraçoes
            // 
            this.pn_configuraçoes.BackColor = System.Drawing.Color.Transparent;
            this.pn_configuraçoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_configuraçoes.BackgroundImage")));
            this.pn_configuraçoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_configuraçoes.Controls.Add(this.pn_configuraçoesS);
            this.pn_configuraçoes.Location = new System.Drawing.Point(391, 0);
            this.pn_configuraçoes.Name = "pn_configuraçoes";
            this.pn_configuraçoes.Size = new System.Drawing.Size(72, 67);
            this.pn_configuraçoes.TabIndex = 15;
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
            // pn_mail
            // 
            this.pn_mail.BackColor = System.Drawing.Color.Transparent;
            this.pn_mail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_mail.BackgroundImage")));
            this.pn_mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_mail.Controls.Add(this.pn_mailS);
            this.pn_mail.Location = new System.Drawing.Point(469, 0);
            this.pn_mail.Name = "pn_mail";
            this.pn_mail.Size = new System.Drawing.Size(72, 67);
            this.pn_mail.TabIndex = 14;
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
            // pn_consultas
            // 
            this.pn_consultas.BackColor = System.Drawing.Color.Transparent;
            this.pn_consultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_consultas.BackgroundImage")));
            this.pn_consultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_consultas.Controls.Add(this.pn_consultasS);
            this.pn_consultas.Location = new System.Drawing.Point(79, 0);
            this.pn_consultas.Name = "pn_consultas";
            this.pn_consultas.Size = new System.Drawing.Size(72, 67);
            this.pn_consultas.TabIndex = 13;
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
            // pn_cirugia
            // 
            this.pn_cirugia.BackColor = System.Drawing.Color.Transparent;
            this.pn_cirugia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_cirugia.BackgroundImage")));
            this.pn_cirugia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_cirugia.Controls.Add(this.pn_cirugiaS);
            this.pn_cirugia.Location = new System.Drawing.Point(157, 0);
            this.pn_cirugia.Name = "pn_cirugia";
            this.pn_cirugia.Size = new System.Drawing.Size(72, 67);
            this.pn_cirugia.TabIndex = 12;
            // 
            // pn_cirugiaS
            // 
            this.pn_cirugiaS.BackColor = System.Drawing.Color.Transparent;
            this.pn_cirugiaS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_cirugiaS.BackgroundImage")));
            this.pn_cirugiaS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_cirugiaS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_cirugiaS.Location = new System.Drawing.Point(16, 16);
            this.pn_cirugiaS.Name = "pn_cirugiaS";
            this.pn_cirugiaS.Size = new System.Drawing.Size(40, 33);
            this.pn_cirugiaS.TabIndex = 8;
            this.pn_cirugiaS.Click += new System.EventHandler(this.pn_cirugiaS_Click);
            // 
            // pn_analises
            // 
            this.pn_analises.BackColor = System.Drawing.Color.Transparent;
            this.pn_analises.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_analises.BackgroundImage")));
            this.pn_analises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_analises.Controls.Add(this.pn_analisesS);
            this.pn_analises.Location = new System.Drawing.Point(235, 0);
            this.pn_analises.Name = "pn_analises";
            this.pn_analises.Size = new System.Drawing.Size(72, 67);
            this.pn_analises.TabIndex = 11;
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
            // pn_informaçoes
            // 
            this.pn_informaçoes.BackColor = System.Drawing.Color.Transparent;
            this.pn_informaçoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_informaçoes.BackgroundImage")));
            this.pn_informaçoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_informaçoes.Controls.Add(this.pn_informaçoesS);
            this.pn_informaçoes.Location = new System.Drawing.Point(313, 0);
            this.pn_informaçoes.Name = "pn_informaçoes";
            this.pn_informaçoes.Size = new System.Drawing.Size(72, 67);
            this.pn_informaçoes.TabIndex = 10;
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
            // pn_mexame
            // 
            this.pn_mexame.BackColor = System.Drawing.Color.Transparent;
            this.pn_mexame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_mexame.BackgroundImage")));
            this.pn_mexame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_mexame.Controls.Add(this.pn_mexameS);
            this.pn_mexame.Location = new System.Drawing.Point(1, 0);
            this.pn_mexame.Name = "pn_mexame";
            this.pn_mexame.Size = new System.Drawing.Size(72, 67);
            this.pn_mexame.TabIndex = 9;
            // 
            // pn_mexameS
            // 
            this.pn_mexameS.BackColor = System.Drawing.Color.Transparent;
            this.pn_mexameS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_mexameS.BackgroundImage")));
            this.pn_mexameS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_mexameS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_mexameS.Location = new System.Drawing.Point(16, 16);
            this.pn_mexameS.Name = "pn_mexameS";
            this.pn_mexameS.Size = new System.Drawing.Size(40, 33);
            this.pn_mexameS.TabIndex = 8;
            this.pn_mexameS.Click += new System.EventHandler(this.pn_mexameS_Click);
            // 
            // Gestor_Recepcionistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 780);
            this.Controls.Add(this.painel_opções);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Gestor_Recepcionistas";
            this.Text = "Gestor_Recepcionistas";
            this.Load += new System.EventHandler(this.Gestor_Recepcionistas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painel_opções.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_configuraçoes.ResumeLayout(false);
            this.pn_mail.ResumeLayout(false);
            this.pn_consultas.ResumeLayout(false);
            this.pn_cirugia.ResumeLayout(false);
            this.pn_analises.ResumeLayout(false);
            this.pn_informaçoes.ResumeLayout(false);
            this.pn_mexame.ResumeLayout(false);
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
        public System.Windows.Forms.Button R_Configurações;
        public System.Windows.Forms.Button R_Consultas;
        private System.Windows.Forms.Timer timer4;
        public System.Windows.Forms.Button R_Cirugias;
        public System.Windows.Forms.Button R_Marcarexame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button R_Analises;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button R_email;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button R_informacoes;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Panel pn_mexame;
        private System.Windows.Forms.Panel pn_mexameS;
        public System.Windows.Forms.Panel pn_configuraçoes;
        private System.Windows.Forms.Panel pn_configuraçoesS;
        public System.Windows.Forms.Panel pn_mail;
        private System.Windows.Forms.Panel pn_mailS;
        public System.Windows.Forms.Panel pn_consultas;
        private System.Windows.Forms.Panel pn_consultasS;
        public System.Windows.Forms.Panel pn_cirugia;
        private System.Windows.Forms.Panel pn_cirugiaS;
        public System.Windows.Forms.Panel pn_analises;
        private System.Windows.Forms.Panel pn_analisesS;
        public System.Windows.Forms.Panel pn_informaçoes;
        private System.Windows.Forms.Panel pn_informaçoesS;
    }
}