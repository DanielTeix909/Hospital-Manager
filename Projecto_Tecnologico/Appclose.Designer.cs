namespace Projecto_Tecnologico
{
    partial class Appclose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appclose));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sim = new System.Windows.Forms.Button();
            this.bt_nao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 30);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deseja sair da aplicação?";
            // 
            // bt_sim
            // 
            this.bt_sim.BackColor = System.Drawing.Color.Transparent;
            this.bt_sim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sim.BackgroundImage")));
            this.bt_sim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_sim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sim.FlatAppearance.BorderSize = 0;
            this.bt_sim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sim.Location = new System.Drawing.Point(81, 85);
            this.bt_sim.Name = "bt_sim";
            this.bt_sim.Size = new System.Drawing.Size(90, 75);
            this.bt_sim.TabIndex = 3;
            this.bt_sim.UseVisualStyleBackColor = false;
            this.bt_sim.Click += new System.EventHandler(this.bt_sim_Click);
            // 
            // bt_nao
            // 
            this.bt_nao.BackColor = System.Drawing.Color.Transparent;
            this.bt_nao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_nao.BackgroundImage")));
            this.bt_nao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_nao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_nao.FlatAppearance.BorderSize = 0;
            this.bt_nao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nao.Location = new System.Drawing.Point(193, 86);
            this.bt_nao.Name = "bt_nao";
            this.bt_nao.Size = new System.Drawing.Size(90, 74);
            this.bt_nao.TabIndex = 4;
            this.bt_nao.UseVisualStyleBackColor = false;
            this.bt_nao.Click += new System.EventHandler(this.bt_nao_Click);
            // 
            // Appclose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(366, 177);
            this.Controls.Add(this.bt_nao);
            this.Controls.Add(this.bt_sim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appclose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appclose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sim;
        private System.Windows.Forms.Button bt_nao;
    }
}