﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Projecto_Tecnologico
{
    public partial class A_Configurações : Form
    {
        int move;
        int moveX;
        int moveY;
        private Point lastPos;
        bool sslbool = true;
        private Color color;
        const int PASS_MIN = 0;
        const int PASS_MAX = 10;
        const string PASS_STRENGTH_FORMAT = "{0:F0}/{1}";
        public A_Configurações()
        {
            InitializeComponent();
        }
       
        private void A_Configurações_Load(object sender, EventArgs e)
        {
            tb_horaregisto.Text = DateTime.Now.ToString("HH:mm:ss tt");
            tb_horaregisto.ReadOnly = true;
            dtp_emissao.Enabled = false;

            pb_forca.Minimum = PASS_MIN;
            pb_forca.Maximum = PASS_MAX;
            pb_forca.Value = 0;
            UpdateProgressBar();
        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, (MousePosition.Y - moveY) - 170);
            }
        }
        private static int RatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return 0;
            int result = Math.Min(password.Length, 7);

            if (System.Text.RegularExpressions.Regex.Match(password, "[a-zA-Z]").Success)
                result += 1;

            if (System.Text.RegularExpressions.Regex.Match(password, "[0-9]").Success)
                result += 1;

            if (System.Text.RegularExpressions.Regex.Match(password, "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\{\\}\\[\\]\\:\\'\\;\\\"\\/\\?\\.\\>\\,\\<\\~\\`\\-\\\\_\\=\\+\\|]").Success)
                result += 1;
            return result;
        }
        private void UpdateProgressBar()
        {
            int strength = RatePassword(tb_newpass.Text);
            lb_forca.Text = string.Format(PASS_STRENGTH_FORMAT, strength, PASS_MAX);
            pb_forca.Value = strength;
            if (pb_forca.Value < 5)
                pb_forca.ForeColor = Color.Maroon;
            else
                pb_forca.ForeColor = Color.DarkGreen;
        }
        private void tb_newpass_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();

        }


        private void pic_registar_Click(object sender, EventArgs e)
        {

            bool key = false;

            DataTable dtfunc = BLL.prefil.authlogin(tb_login.Text, tb_pass.Text, "adminstrador");

            if (dtfunc.Rows.Count > 0)
            {
                BLL.prefil.updateprefil(tb_newpass.Text);

                if (!tb_newpass.Equals(tb_newpassrepit))
                {

                    MessageBox.Show("Senhas não são Iguais");
                }
            }
            else
            {
                MessageBox.Show("Login Incorrecto");
            }

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Alteracoes\config.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(tb_login.Text, "adminstrador", DateTime.Now, tb_horaregisto.Text);
                    tw.Close();
                }
            }
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Admistradores)this.MdiParent).pn_configuraçoes.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Admistradores)this.MdiParent).A_Configurações.Enabled = true;
            this.Close();
        }

       

    }
    }


