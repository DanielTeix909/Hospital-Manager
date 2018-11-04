using Projecto_Tecnologico.Medicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.IO;
namespace Projecto_Tecnologico
{
    public partial class Gestor_Médicos : Form
    {
        int move;
        int moveX;
        int moveY;
        DateTime data_hora;

        public Gestor_Médicos()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.LightGray;
                  
                }


            }
        }

        private void Gestor_Médicos_Load(object sender, EventArgs e)
        {
            pn_consultas.Hide();
            pn_analises.Hide();
            pn_receitas.Hide();
            pn_informaçoes.Hide();
            pn_configuraçoes.Hide();
            pn_mail.Hide();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Login Logs\Entrada.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(Login.login, lb_data.Text, lb_hora.Text, "Médico");
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

        

        private void M_Consultas_Click(object sender, EventArgs e)
        {
            M_Consultas consultas = new M_Consultas();
            consultas.MdiParent = this;
            consultas.Show();

            M_Consultas.Enabled = false;
        }
        

       

        private void M_Configurações_Click(object sender, EventArgs e)
        {
            M_Configurações configuraçoes = new M_Configurações();
            configuraçoes.MdiParent = this;
            configuraçoes.Show();

            M_Configurações.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void M_Analises_Click(object sender, EventArgs e)
        {
            M_Analises analises = new M_Analises();
            analises.MdiParent = this;
            analises.Show();

            M_Analises.Enabled = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                M_Consultas.BringToFront();
            }
        }

        private void M_Consultas_MouseLeave(object sender, EventArgs e)
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
                M_informacoes.BringToFront();
            }
        }

       


        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (button3.Visible)
            {
                M_Analises.BringToFront();
            }
        }

        private void M_Analises_MouseLeave(object sender, EventArgs e)
        {
            if (button3.Visible)
            {
                button3.BringToFront();
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            if (button7.Visible)
            {
                M_Configurações.BringToFront();
            }
        }

        private void M_Configurações_MouseLeave(object sender, EventArgs e)
        {
            if (button7.Visible)
            {
                button7.BringToFront();
            }
        }


        

        private void pn_consultasS_Click(object sender, EventArgs e)
        {
            M_Consultas consultas = new M_Consultas();
            consultas.MdiParent = this;
            consultas.Show();
            pn_consultas.Hide();
        }

        private void pn_analisesS_Click(object sender, EventArgs e)
        {
            M_Analises analises = new M_Analises();
            analises.MdiParent = this;
            analises.Show();
            pn_analises.Hide();
        }

        

        private void pn_informaçoesS_Click(object sender, EventArgs e)
        {
            M_Informacao info = new M_Informacao();
            info.MdiParent = this;
            info.Show();
            pn_informaçoes.Hide();
        }

        private void pn_configuraçoesS_Click(object sender, EventArgs e)
        {
            M_Configurações configuraçoes = new M_Configurações();
            configuraçoes.MdiParent = this;
            configuraçoes.Show();
            pn_configuraçoes.Hide();
        }

        private void pn_mailS_Click(object sender, EventArgs e)
        {
            M_Email mail = new M_Email();
            mail.MdiParent = this;
            mail.Show();
            pn_mail.Hide();
        }

        private void pn_receitasS_Click(object sender, EventArgs e)
        {
            M_Receitas receitas = new M_Receitas();
            receitas.MdiParent = this;
            receitas.Show();
            pn_receitas.Hide();
        }

        private void M_email_Click(object sender, EventArgs e)
        {
            M_Email mail = new M_Email();
            mail.MdiParent = this;
            mail.Show();

            M_email.Enabled = false;
        }

        private void M_email_MouseLeave(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                button8.BringToFront();
            }
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                M_email.BringToFront();
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                M_Receitas.BringToFront();
            }
        }

        private void M_Receitas_MouseLeave(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                button2.BringToFront();
            }
        }

        private void M_Receitas_Click(object sender, EventArgs e)
        {
            M_Receitas receitas = new M_Receitas();
            receitas.MdiParent = this;
            receitas.Show();

            M_Receitas.Enabled = false;
        }

        private void M_informacoes_Click(object sender, EventArgs e)
        {
            M_Informacao info = new M_Informacao();
            info.MdiParent = this;
            info.Show();

            M_informacoes.Enabled = false;
        }

        private void M_informacoes_MouseLeave(object sender, EventArgs e)
        {
            if (button4.Visible)
            {
                button4.BringToFront();
            }
        }

         

         
    }
}
