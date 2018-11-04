namespace Projecto_Tecnologico.Laboratistas
{
    partial class L_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L_Stock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.b_min = new System.Windows.Forms.Button();
            this.b_pesquisa = new System.Windows.Forms.Button();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.dgv_funcionarios = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_exportpdf = new System.Windows.Forms.PictureBox();
            this.pb_exportexcel = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportpdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportexcel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.b_min);
            this.panel1.Controls.Add(this.b_pesquisa);
            this.panel1.Controls.Add(this.tbPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 48);
            this.panel1.TabIndex = 350;
            // 
            // b_close
            // 
            this.b_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_close.Image = ((System.Drawing.Image)(resources.GetObject("b_close.Image")));
            this.b_close.Location = new System.Drawing.Point(593, 3);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 14;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_min
            // 
            this.b_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_min.Image = ((System.Drawing.Image)(resources.GetObject("b_min.Image")));
            this.b_min.Location = new System.Drawing.Point(562, 3);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 13;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // b_pesquisa
            // 
            this.b_pesquisa.BackColor = System.Drawing.Color.Transparent;
            this.b_pesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_pesquisa.FlatAppearance.BorderSize = 0;
            this.b_pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("b_pesquisa.Image")));
            this.b_pesquisa.Location = new System.Drawing.Point(381, 9);
            this.b_pesquisa.Name = "b_pesquisa";
            this.b_pesquisa.Size = new System.Drawing.Size(34, 27);
            this.b_pesquisa.TabIndex = 10;
            this.b_pesquisa.UseVisualStyleBackColor = false;
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
            // 
            // cb_cargo
            // 
            this.cb_cargo.BackColor = System.Drawing.Color.Silver;
            this.cb_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Médico",
            "Enfermeiro",
            "Laboratista",
            "Não Docente",
            "Repecionista",
            "Administradores"});
            this.cb_cargo.Location = new System.Drawing.Point(24, 57);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(159, 21);
            this.cb_cargo.TabIndex = 352;
            // 
            // dgv_funcionarios
            // 
            this.dgv_funcionarios.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionarios.Location = new System.Drawing.Point(24, 84);
            this.dgv_funcionarios.Name = "dgv_funcionarios";
            this.dgv_funcionarios.Size = new System.Drawing.Size(575, 184);
            this.dgv_funcionarios.TabIndex = 351;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(108, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 28);
            this.pictureBox2.TabIndex = 364;
            this.pictureBox2.TabStop = false;
            // 
            // pb_exportpdf
            // 
            this.pb_exportpdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exportpdf.BackgroundImage")));
            this.pb_exportpdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_exportpdf.Location = new System.Drawing.Point(66, 273);
            this.pb_exportpdf.Name = "pb_exportpdf";
            this.pb_exportpdf.Size = new System.Drawing.Size(36, 28);
            this.pb_exportpdf.TabIndex = 363;
            this.pb_exportpdf.TabStop = false;
            // 
            // pb_exportexcel
            // 
            this.pb_exportexcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_exportexcel.BackgroundImage")));
            this.pb_exportexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_exportexcel.Location = new System.Drawing.Point(24, 274);
            this.pb_exportexcel.Name = "pb_exportexcel";
            this.pb_exportexcel.Size = new System.Drawing.Size(36, 28);
            this.pb_exportexcel.TabIndex = 362;
            this.pb_exportexcel.TabStop = false;
            // 
            // L_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(625, 309);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_exportpdf);
            this.Controls.Add(this.pb_exportexcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.dgv_funcionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "L_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L_Stock";
            this.Load += new System.EventHandler(this.L_Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportpdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exportexcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.DataGridView dgv_funcionarios;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Button b_pesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_exportpdf;
        private System.Windows.Forms.PictureBox pb_exportexcel;
    }
}