﻿namespace Projecto_Tecnologico.Enfermeiros
{
    partial class E_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_Email));
            this.lb_filename = new System.Windows.Forms.Label();
            this.tb_destinatario = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_assunto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_close = new System.Windows.Forms.Button();
            this.b_min = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mensagem = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb_send = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_send)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_filename
            // 
            this.lb_filename.AutoSize = true;
            this.lb_filename.Location = new System.Drawing.Point(140, 264);
            this.lb_filename.Name = "lb_filename";
            this.lb_filename.Size = new System.Drawing.Size(33, 13);
            this.lb_filename.TabIndex = 144;
            this.lb_filename.Text = "lb:_fa";
            // 
            // tb_destinatario
            // 
            this.tb_destinatario.BackColor = System.Drawing.Color.Silver;
            this.tb_destinatario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_destinatario.Location = new System.Drawing.Point(136, 57);
            this.tb_destinatario.Multiline = true;
            this.tb_destinatario.Name = "tb_destinatario";
            this.tb_destinatario.Size = new System.Drawing.Size(278, 19);
            this.tb_destinatario.TabIndex = 142;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(345, 264);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 139;
            this.checkBox1.Text = "Geral";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 138;
            this.label4.Text = "Assunto:";
            // 
            // tb_assunto
            // 
            this.tb_assunto.BackColor = System.Drawing.Color.Silver;
            this.tb_assunto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_assunto.Location = new System.Drawing.Point(136, 82);
            this.tb_assunto.Multiline = true;
            this.tb_assunto.Name = "tb_assunto";
            this.tb_assunto.Size = new System.Drawing.Size(278, 19);
            this.tb_assunto.TabIndex = 137;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.b_close);
            this.panel1.Controls.Add(this.b_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 48);
            this.panel1.TabIndex = 136;
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
            this.b_close.Location = new System.Drawing.Point(399, 3);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(29, 28);
            this.b_close.TabIndex = 374;
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_min
            // 
            this.b_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_min.Image = ((System.Drawing.Image)(resources.GetObject("b_min.Image")));
            this.b_min.Location = new System.Drawing.Point(369, 3);
            this.b_min.Name = "b_min";
            this.b_min.Size = new System.Drawing.Size(29, 28);
            this.b_min.TabIndex = 373;
            this.b_min.UseVisualStyleBackColor = true;
            this.b_min.Click += new System.EventHandler(this.b_min_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 135;
            this.label3.Text = "Email do Destinatário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "Mensagem:";
            // 
            // tb_mensagem
            // 
            this.tb_mensagem.BackColor = System.Drawing.Color.Silver;
            this.tb_mensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mensagem.Location = new System.Drawing.Point(24, 120);
            this.tb_mensagem.Multiline = true;
            this.tb_mensagem.Name = "tb_mensagem";
            this.tb_mensagem.Size = new System.Drawing.Size(390, 126);
            this.tb_mensagem.TabIndex = 132;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(77, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 35);
            this.pictureBox3.TabIndex = 146;
            this.pictureBox3.TabStop = false;
            // 
            // pb_send
            // 
            this.pb_send.BackColor = System.Drawing.Color.Transparent;
            this.pb_send.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_send.BackgroundImage")));
            this.pb_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_send.Location = new System.Drawing.Point(24, 252);
            this.pb_send.Name = "pb_send";
            this.pb_send.Size = new System.Drawing.Size(48, 35);
            this.pb_send.TabIndex = 145;
            this.pb_send.TabStop = false;
            // 
            // E_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(431, 299);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pb_send);
            this.Controls.Add(this.lb_filename);
            this.Controls.Add(this.tb_destinatario);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_assunto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "E_Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E_Email";
            this.Load += new System.EventHandler(this.E_Email_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_send)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_mensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_min;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_assunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tb_destinatario;
        private System.Windows.Forms.Label lb_filename;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pb_send;
    }
}