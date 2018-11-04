using Projecto_Tecnologico.Enfermeiros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessLogicLayer;
namespace Projecto_Tecnologico
{
    public partial class Gestor_Enfermeiros : Form
    {
        int move;
        int moveX;
        int moveY;
        DateTime data_hora;

        public Gestor_Enfermeiros()
        {
            InitializeComponent();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }

            }
        }

        private void Gestor_Enfermeiros_Load(object sender, EventArgs e)
        {
            pn_tratamentos.Hide();
            pn_informaçoes.Hide();
            pn_configuraçoes.Hide();
            pn_mail.Hide();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Login Logs\Entrada.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(Login.login, lb_data.Text, lb_hora.Text, "Enfermeiro");
                    tw.Close();
                }
            }
        }

        private void opções_Click(object sender, EventArgs e)
        {
            if (painel_opções.Visible)
            {
                painel_opções.Hide();
            }
            else
            {
                painel_opções.Show();
            }
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
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        

        

        

       

        private void E_Configurações_Click(object sender, EventArgs e)
        {
            E_Configurações configuraçoes = new E_Configurações();
            configuraçoes.MdiParent = this;
            configuraçoes.Show();

            E_Configurações.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lb_data.Text = data_hora.ToLongDateString();
            lb_hora.Text = data_hora.ToLongTimeString();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void b_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void E_Tratamentos_Click(object sender, EventArgs e)
        {
            E_Tratamentos tratamentos = new E_Tratamentos();
            tratamentos.MdiParent = this;
            tratamentos.Show();

            E_Tratamentos.Enabled = false;
        }

        private void E_email_Click(object sender, EventArgs e)
        {
            E_Email mail = new E_Email();
            mail.MdiParent = this;
            mail.Show();

            E_email.Enabled = false;
        }

        private void E_informacoes_Click(object sender, EventArgs e)
        {
            E_Informações informações = new E_Informações();
            informações.MdiParent = this;
            informações.Show();

            E_informacoes.Enabled = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                E_Tratamentos.BringToFront();
            }
        }

        private void E_Tratamentos_MouseLeave(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                button1.BringToFront();
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            if (button4.Visible)
            {
                E_informacoes.BringToFront();
            }
        }

        private void E_informacoes_MouseLeave(object sender, EventArgs e)
        {
            if (button4.Visible)
            {
                button4.BringToFront();
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            if (button7.Visible)
            {
                E_Configurações.BringToFront();
            }
        }

        private void E_Configurações_MouseLeave(object sender, EventArgs e)
        {
            if (button7.Visible)
            {
                button7.BringToFront();
            }
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                E_email.BringToFront();
            }
        }

        private void E_email_MouseLeave(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                button8.BringToFront();
            }
        }

        private void pn_tratamentosS_Click(object sender, EventArgs e)
        {
            E_Tratamentos tratamentos = new E_Tratamentos();
            tratamentos.MdiParent = this;
            tratamentos.Show();

            pn_tratamentos.Hide();
        }

        private void pn_informaçoesS_Click(object sender, EventArgs e)
        {
            E_Informações informações = new E_Informações();
            informações.MdiParent = this;
            informações.Show();

            pn_informaçoes.Hide();
        }

        private void pn_configuraçoesS_Click(object sender, EventArgs e)
        {
            E_Configurações configuraçoes = new E_Configurações();
            configuraçoes.MdiParent = this;
            configuraçoes.Show();

            pn_configuraçoes.Hide();
        }

        private void pn_mailS_Click(object sender, EventArgs e)
        {
            E_Email mail = new E_Email();
            mail.MdiParent = this;
            mail.Show();

            pn_mail.Hide();
        }
    }
}
