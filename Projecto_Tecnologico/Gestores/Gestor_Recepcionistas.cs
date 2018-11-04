using Projecto_Tecnologico.Recepcionistas;
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
    public partial class Gestor_Recepcionistas : Form
    {
        int move;
        int moveX;
        int moveY;
        DateTime data_hora;

        public Gestor_Recepcionistas()
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

        private void Gestor_Recepcionistas_Load(object sender, EventArgs e)
        {
            pn_analises.Hide();
            pn_mexame.Hide();
            pn_cirugia.Hide();
            pn_consultas.Hide();
            pn_informaçoes.Hide();
            pn_configuraçoes.Hide();
            pn_mail.Hide();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Login Logs\Entrada.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(Login.login, lb_data.Text, lb_hora.Text, "Rececionista");
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

       

        private void R_Consultas_Click(object sender, EventArgs e)
        {
            R_Consultas consultas = new R_Consultas();
            consultas.MdiParent = this;
            consultas.Show();

            R_Consultas.Enabled = false;
        }

        

        

        private void R_Configurações_Click(object sender, EventArgs e)
        {
            R_Configuraçoes configuraçoes = new R_Configuraçoes();
            configuraçoes.MdiParent = this;
            configuraçoes.Show();

            R_Configurações.Enabled = false;
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lb_data.Text = data_hora.ToLongDateString();
            lb_hora.Text = data_hora.ToLongTimeString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void R_Cirugias_Click(object sender, EventArgs e)
        {
            R_cirugia cirugia = new R_cirugia();
            cirugia.MdiParent = this;
            cirugia.Show();

            R_Cirugias.Enabled = false;
        }

        private void R_Marcarexame_Click(object sender, EventArgs e)
        {
           R_MarcarExames marcarexames = new R_MarcarExames();
            marcarexames.MdiParent = this;
            marcarexames.Show();

            R_Marcarexame.Enabled = false;
        }

        
       

        private void R_Analises_Click(object sender, EventArgs e)
        {
         R_Analises analises = new R_Analises();
            analises.MdiParent = this;
            analises.Show();

            R_Analises.Enabled = false;
        }

        private void R_informacoes_Click(object sender, EventArgs e)
        {
            R_VerInformacao info = new R_VerInformacao();
            info.MdiParent = this;
            info.Show();

            R_informacoes.Enabled = false;
        }

        private void R_email_Click(object sender, EventArgs e)
        {
            R_mail mail = new R_mail();
            mail.MdiParent = this;
            mail.Show();

            R_email.Enabled = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                R_Marcarexame.BringToFront();
            }    
        }

        private void R_Marcarexame_MouseLeave(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                button2.BringToFront();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                R_Consultas.BringToFront();
            }    
        }

        private void R_Consultas_MouseLeave(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                button1.BringToFront();
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            if (button5.Visible)
            {
                R_Cirugias.BringToFront();
            }    
        }

        private void R_Cirugias_MouseLeave(object sender, EventArgs e)
        {
            if (button5.Visible)
            {
                button5.BringToFront();
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (button3.Visible)
            {
                R_Analises.BringToFront();
            }    
        }

        private void R_Analises_MouseLeave(object sender, EventArgs e)
        {
            if (button3.Visible)
            {
                button3.BringToFront();
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            if (button4.Visible)
            {
                R_informacoes.BringToFront();
            }    
        }

        private void R_informacoes_MouseLeave(object sender, EventArgs e)
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
                R_Configurações.BringToFront();
            }    
        }

        private void R_Configurações_MouseLeave(object sender, EventArgs e)
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
                R_email.BringToFront();
            }    
        }

        private void R_email_MouseLeave(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                button8.BringToFront();
            }
        }

        private void pn_mexameS_Click(object sender, EventArgs e)
        {
            R_MarcarExames marcarexames = new R_MarcarExames();
            marcarexames.MdiParent = this;
            marcarexames.Show();
            pn_mexame.Hide();
        }

        private void pn_consultasS_Click(object sender, EventArgs e)
        {
            R_Consultas consultas = new R_Consultas();
            consultas.MdiParent = this;
            consultas.Show();
            pn_consultas.Hide();
        }

        private void pn_cirugiaS_Click(object sender, EventArgs e)
        {
            R_cirugia cirugia = new R_cirugia();
            cirugia.MdiParent = this;
            cirugia.Show();
            pn_cirugia.Hide();
        }

        private void pn_analisesS_Click(object sender, EventArgs e)
        {
            R_Analises analises = new R_Analises();
            analises.MdiParent = this;
            analises.Show();
            pn_analises.Hide();
        }

        private void pn_informaçoesS_Click(object sender, EventArgs e)
        {
            R_VerInformacao info = new R_VerInformacao();
            info.MdiParent = this;
            info.Show();
            pn_informaçoes.Hide();
        }

        private void pn_configuraçoesS_Click(object sender, EventArgs e)
        {
            R_Configuraçoes configuraçoes = new R_Configuraçoes();
            configuraçoes.MdiParent = this;
            configuraçoes.Show();
            pn_configuraçoes.Hide();
        }

        private void pn_mailS_Click(object sender, EventArgs e)
        {
            R_mail mail = new R_mail();
            mail.MdiParent = this;
            mail.Show();
            pn_mail.Hide();

        }
    }
}
