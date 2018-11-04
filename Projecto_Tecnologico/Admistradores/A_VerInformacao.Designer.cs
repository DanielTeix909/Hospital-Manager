namespace Projecto_Tecnologico.Admistradores
{
    partial class A_VerInformacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_VerInformacao));
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.b_min = new System.Windows.Forms.Button();
            this.pn_p = new System.Windows.Forms.Panel();
            this.b_pesquisa = new System.Windows.Forms.Button();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.dgv_funcionarios = new System.Windows.Forms.DataGridView();
            this.pb_exportpdf = new System.Windows.Forms.PictureBox();
            this.pb_exportexcel = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_historioco = new System.Windows.Forms.ListBox();
            this.cb_functs = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportpdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportexcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_cargo
            // 
            this.cb_cargo.BackColor = System.Drawing.Color.Silver;
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Salários",
            "Medicamentos",
            "Tratamentos",
            "Cirugias",
            "Utentes",
            "Analises",
            "Financiamento",
            "Historico Logs Funcionarios"});
            this.cb_cargo.Location = new System.Drawing.Point(12, 65);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(159, 21);
            this.cb_cargo.TabIndex = 352;
            this.cb_cargo.SelectedIndexChanged += new System.EventHandler(this.cb_cargo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.b_min);
            this.panel1.Controls.Add(this.pn_p);
            this.panel1.Controls.Add(this.b_pesquisa);
            this.panel1.Controls.Add(this.tbPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 48);
            this.panel1.TabIndex = 350;
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
            this.b_close.Location = new System.Drawing.Point(678, 3);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 355;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_min
            // 
            this.b_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_min.Image = ((System.Drawing.Image)(resources.GetObject("b_min.Image")));
            this.b_min.Location = new System.Drawing.Point(643, 3);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 354;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // pn_p
            // 
            this.pn_p.BackColor = System.Drawing.Color.Black;
            this.pn_p.Location = new System.Drawing.Point(492, 19);
            this.pn_p.Name = "pn_p";
            this.pn_p.Size = new System.Drawing.Size(16, 14);
            this.pn_p.TabIndex = 352;
            // 
            // b_pesquisa
            // 
            this.b_pesquisa.BackColor = System.Drawing.Color.Transparent;
            this.b_pesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_pesquisa.BackgroundImage")));
            this.b_pesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b_pesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_pesquisa.FlatAppearance.BorderSize = 0;
            this.b_pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_pesquisa.Location = new System.Drawing.Point(381, 8);
            this.b_pesquisa.Name = "b_pesquisa";
            this.b_pesquisa.Size = new System.Drawing.Size(30, 28);
            this.b_pesquisa.TabIndex = 10;
            this.b_pesquisa.UseVisualStyleBackColor = false;
            this.b_pesquisa.Click += new System.EventHandler(this.b_pesquisa_Click);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPesquisa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisa.Location = new System.Drawing.Point(12, 12);
            this.tbPesquisa.Multiline = true;
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(363, 21);
            this.tbPesquisa.TabIndex = 9;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            // 
            // dgv_funcionarios
            // 
            this.dgv_funcionarios.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionarios.Location = new System.Drawing.Point(12, 92);
            this.dgv_funcionarios.Name = "dgv_funcionarios";
            this.dgv_funcionarios.Size = new System.Drawing.Size(670, 184);
            this.dgv_funcionarios.TabIndex = 351;
            this.dgv_funcionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funcionarios_CellContentClick);
            // 
            // pb_exportpdf
            // 
            this.pb_exportpdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exportpdf.BackgroundImage")));
            this.pb_exportpdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_exportpdf.Location = new System.Drawing.Point(51, 284);
            this.pb_exportpdf.Name = "pb_exportpdf";
            this.pb_exportpdf.Size = new System.Drawing.Size(36, 28);
            this.pb_exportpdf.TabIndex = 354;
            this.pb_exportpdf.TabStop = false;
            this.pb_exportpdf.Click += new System.EventHandler(this.pb_exportpdf_Click);
            // 
            // pb_exportexcel
            // 
            this.pb_exportexcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exportexcel.BackgroundImage")));
            this.pb_exportexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_exportexcel.Location = new System.Drawing.Point(9, 285);
            this.pb_exportexcel.Name = "pb_exportexcel";
            this.pb_exportexcel.Size = new System.Drawing.Size(36, 28);
            this.pb_exportexcel.TabIndex = 353;
            this.pb_exportexcel.TabStop = false;
            this.pb_exportexcel.Click += new System.EventHandler(this.pb_exportexcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_historioco
            // 
            this.lb_historioco.BackColor = System.Drawing.Color.Silver;
            this.lb_historioco.FormattingEnabled = true;
            this.lb_historioco.Location = new System.Drawing.Point(12, 92);
            this.lb_historioco.Name = "lb_historioco";
            this.lb_historioco.Size = new System.Drawing.Size(670, 186);
            this.lb_historioco.TabIndex = 355;
            // 
            // cb_functs
            // 
            this.cb_functs.BackColor = System.Drawing.Color.Silver;
            this.cb_functs.FormattingEnabled = true;
            this.cb_functs.Items.AddRange(new object[] {
            "Médico",
            "Enfermeiros",
            "Rececionistas",
            "Administradores",
            "Laboratoristas"});
            this.cb_functs.Location = new System.Drawing.Point(207, 65);
            this.cb_functs.Name = "cb_functs";
            this.cb_functs.Size = new System.Drawing.Size(121, 21);
            this.cb_functs.TabIndex = 356;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(93, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.TabIndex = 357;
            this.pictureBox1.TabStop = false;
            // 
            // A_VerInformacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(710, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_functs);
            this.Controls.Add(this.lb_historioco);
            this.Controls.Add(this.pb_exportpdf);
            this.Controls.Add(this.pb_exportexcel);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_funcionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_VerInformacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_Informacao";
            this.Load += new System.EventHandler(this.A_VerInformacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportpdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportexcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_pesquisa;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.DataGridView dgv_funcionarios;
        private System.Windows.Forms.PictureBox pb_exportpdf;
        private System.Windows.Forms.PictureBox pb_exportexcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Panel pn_p;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.ListBox lb_historioco;
        private System.Windows.Forms.ComboBox cb_functs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}