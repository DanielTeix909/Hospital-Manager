using Projecto_Tecnologico.Laboratistas;
using Projecto_Tecnologico.Laboratoristas;
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

namespace Projecto_Tecnologico.Gestores
{
    public partial class Gestor_Laboratistas : Form
    {
        int move;
        int moveX;
        int moveY;
        DateTime data_hora;
        
        public Gestor_Laboratistas()
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
       
        

        

        

        

        private void L_Configurações_Click_1(object sender, EventArgs e)
        {
            L_Configuraçoes configurações = new L_Configuraçoes();
            configurações.MdiParent = this;
            configurações.Show();

            L_Configurações.Enabled = false;
        }

        private void L_Analises_Click_1(object sender, EventArgs e)
        {
            L_Analises analises = new L_Analises();
            analises.MdiParent = this;
            analises.Show();

            L_Analises.Enabled = false;
        }
        
        private void L_Stock_Click_1(object sender, EventArgs e)
        {
            L_Stock stock = new L_Stock();
            stock.MdiParent = this;
            stock.Show();

            L_Stock.Enabled = false;
        }

        private void L_email_Click(object sender, EventArgs e)
        {
            L_EMail mail = new L_EMail();
            mail.MdiParent = this;
            mail.Show();

            L_email.Enabled = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                L_Analises.BringToFront();
            }    
        }

        private void L_Analises_MouseLeave(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                button1.BringToFront();
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (button3.Visible)
            {
                L_Stock.BringToFront();
            }    
        }

        private void L_Stock_MouseLeave(object sender, EventArgs e)
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
                L_Configurações.BringToFront();
            }    
        }

        private void L_Configurações_MouseLeave(object sender, EventArgs e)
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
                L_email.BringToFront();
            }    
        }

        private void L_email_MouseLeave(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                button8.BringToFront();
            }
        }

        private void opções_Click_1(object sender, EventArgs e)
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

        private void b_min_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void b_max_Click(object sender, EventArgs e)
        {
         this.WindowState = FormWindowState.Maximized;
        }

        private void b_close_Click_1(object sender, EventArgs e)
        {
         Login login = new Login();
            login.Show();
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lb_data.Text = data_hora.ToLongDateString();
            lb_hora.Text = data_hora.ToLongTimeString();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
          move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

           
        

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
         move = 0;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
        if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void Gestor_Laboratistas_Load(object sender, EventArgs e)
        {
            pn_analises.Hide();
            pn_mail.Hide();
            pn_stock.Hide();
            pn_configuraçoes.Hide();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Login Logs\Entrada.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(Login.login, lb_data.Text, lb_hora.Text, "Laboratorista");
                    tw.Close();
                }
            }
        }

        private void pn_analisesS_Click(object sender, EventArgs e)
        {
            L_Analises analises = new L_Analises();
            analises.MdiParent = this;
            analises.Show();
            pn_analises.Hide();
        }

        private void pn_stockS_Click(object sender, EventArgs e)
        {
            L_Stock stock = new L_Stock();
            stock.MdiParent = this;
            stock.Show();
            pn_stock.Hide();
        }

        private void pn_configuraçoesS_Click(object sender, EventArgs e)
        {
            L_Configuraçoes configurações = new L_Configuraçoes();
            configurações.MdiParent = this;
            configurações.Show();
            pn_configuraçoes.Hide();
        }

        private void pn_mailS_Click(object sender, EventArgs e)
        {
            L_EMail mail = new L_EMail();
            mail.MdiParent = this;
            mail.Show();
            pn_mail.Hide();
        }
    }
      
    }

