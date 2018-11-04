namespace Projecto_Tecnologico.Enfermeiros
{
    partial class E_Informações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_Informações));
            this.pb_exportpdf = new System.Windows.Forms.PictureBox();
            this.pb_exportexcel = new System.Windows.Forms.PictureBox();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.grid_info = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_pesquisa = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.b_min = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportpdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportexcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_info)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_exportpdf
            // 
            this.pb_exportpdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exportpdf.BackgroundImage")));
            this.pb_exportpdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_exportpdf.Location = new System.Drawing.Point(67, 334);
            this.pb_exportpdf.Name = "pb_exportpdf";
            this.pb_exportpdf.Size = new System.Drawing.Size(36, 28);
            this.pb_exportpdf.TabIndex = 360;
            this.pb_exportpdf.TabStop = false;
            // 
            // pb_exportexcel
            // 
            this.pb_exportexcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exportexcel.BackgroundImage")));
            this.pb_exportexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_exportexcel.Location = new System.Drawing.Point(25, 335);
            this.pb_exportexcel.Name = "pb_exportexcel";
            this.pb_exportexcel.Size = new System.Drawing.Size(36, 28);
            this.pb_exportexcel.TabIndex = 359;
            this.pb_exportexcel.TabStop = false;
            // 
            // cb_cargo
            // 
            this.cb_cargo.BackColor = System.Drawing.Color.Silver;
            this.cb_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Tarefas ",
            "Medicamentos",
            "Utentes",
            "Tratamentos"});
            this.cb_cargo.Location = new System.Drawing.Point(25, 70);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(172, 21);
            this.cb_cargo.TabIndex = 358;
            this.cb_cargo.SelectedIndexChanged += new System.EventHandler(this.cb_cargo_SelectedIndexChanged);
            // 
            // grid_info
            // 
            this.grid_info.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_info.Location = new System.Drawing.Point(25, 97);
            this.grid_info.Name = "grid_info";
            this.grid_info.Size = new System.Drawing.Size(602, 224);
            this.grid_info.TabIndex = 357;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.b_pesquisa);
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.tbPesquisa);
            this.panel1.Controls.Add(this.b_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 48);
            this.panel1.TabIndex = 356;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // b_pesquisa
            // 
            this.b_pesquisa.BackColor = System.Drawing.Color.Transparent;
            this.b_pesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_pesquisa.FlatAppearance.BorderSize = 0;
            this.b_pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("b_pesquisa.Image")));
            this.b_pesquisa.Location = new System.Drawing.Point(384, 8);
            this.b_pesquisa.Name = "b_pesquisa";
            this.b_pesquisa.Size = new System.Drawing.Size(33, 28);
            this.b_pesquisa.TabIndex = 10;
            this.b_pesquisa.UseVisualStyleBackColor = false;
            this.b_pesquisa.Click += new System.EventHandler(this.b_pesquisa_Click);
            // 
            // b_close
            // 
            this.b_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Image = ((System.Drawing.Image)(resources.GetObject("b_close.Image")));
            this.b_close.Location = new System.Drawing.Point(619, 3);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 9;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPesquisa.Location = new System.Drawing.Point(15, 12);
            this.tbPesquisa.Multiline = true;
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(363, 21);
            this.tbPesquisa.TabIndex = 9;
            // 
            // b_min
            // 
            this.b_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_min.Image = ((System.Drawing.Image)(resources.GetObject("b_min.Image")));
            this.b_min.Location = new System.Drawing.Point(589, 3);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 7;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(109, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 28);
            this.pictureBox2.TabIndex = 361;
            this.pictureBox2.TabStop = false;
            // 
            // E_Informações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(651, 372);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_exportpdf);
            this.Controls.Add(this.pb_exportexcel);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.grid_info);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "E_Informações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E_Informações";
            this.Load += new System.EventHandler(this.E_Informações_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportpdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportexcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_info)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exportpdf;
        private System.Windows.Forms.PictureBox pb_exportexcel;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.DataGridView grid_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_pesquisa;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}