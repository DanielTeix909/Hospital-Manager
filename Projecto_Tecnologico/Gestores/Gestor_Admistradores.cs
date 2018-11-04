using Projecto_Tecnologico.Admistradores;
using Projecto_Tecnologico.Email_Sys;
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
namespace Projecto_Tecnologico
{
    public partial class Gestor_Admistradores : Form
    {
        int move;
        int moveX;
        int moveY;
        DateTime data_hora;



        public Gestor_Admistradores()
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

        
       

        private void A_Utentes_Click(object sender, EventArgs e)
        {
            A_Utentes utentes = new A_Utentes();
            utentes.MdiParent = this;
            utentes.Show();

            A_Utentes.Enabled = false;
        }




        private void A_Salários_Click(object sender, EventArgs e)
        {
            A_Salários salários = new A_Salários();
            salários.MdiParent = this;
            salários.Show();

            A_sala.Enabled = false;
        }


        private void A_Configurações_Click(object sender, EventArgs e)
        {
            A_Configurações configurações = new A_Configurações();
            configurações.MdiParent = this;
            configurações.Show();

            A_Configurações.Enabled = false;
        }
 private void A_Financiamento_Click(object sender, EventArgs e)
        {
            A_Financiamento financiamento = new A_Financiamento();
            financiamento.MdiParent = this;
            financiamento.Show();

            A_Financiamento.Enabled = false;
        }

       

        private void Ab_Funcinários_Click(object sender, EventArgs e)
        {
            A_Funcionarios funcionários = new A_Funcionarios();
            funcionários.MdiParent = this;
            funcionários.Show();

            Ab_Funcinários.Enabled = false;
        }
        
        private void A_email_Click(object sender, EventArgs e)
        {
            A_Email email = new A_Email();
            email.MdiParent = this;
            email.Show();

            A_email.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gestor_Admistradores_Load(object sender, EventArgs e)
        {
        
            pn_funcionarios.Hide();
           pn_utentes.Hide();
           pn_medicamentos.Hide();
           pn_informações.Hide();
           pn_financiamento.Hide();
           pn_salarios.Hide();
           pn_configuraçoes.Hide();
           pn_mail.Hide();


            string Entrada = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Logins Logs\entrada.txt");
            if (File.Exists(Entrada))
            {
                using (TextWriter tw = new StreamWriter(Entrada))
                {
                tw.WriteLine(Login.login,DateTime.Now);
                    tw.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                Ab_Funcinários.BringToFront();
            }    
            
        }

        private void Ab_Funcinários_MouseLeave(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                button1.BringToFront();
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                A_Utentes.BringToFront();
            }    
        }

        private void A_Utentes_MouseLeave(object sender, EventArgs e)
        {
            if (button2.Visible)
            {
                button2.BringToFront();
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (button3.Visible)
            {
                A_Medicamentos.BringToFront();
            }    
        }

        private void A_Medicamentos_MouseLeave(object sender, EventArgs e)
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
                A_informacoes.BringToFront();
            }    
        }

        private void A_informacoes_MouseLeave(object sender, EventArgs e)
        {
            if (button4.Visible)
            {
                button4.BringToFront();
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            if (button5.Visible)
            {
                A_Financiamento.BringToFront();
            }    
        }

        private void A_Financiamento_MouseLeave(object sender, EventArgs e)
        {
            if (button5.Visible)
            {
                button5.BringToFront();
            }
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            if (button6.Visible)
            {
                A_sala.BringToFront();
            }    
        }

        private void A_sala_MouseLeave(object sender, EventArgs e)
        {
            if (button6.Visible)
            {
                button6.BringToFront();
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            if (button7.Visible)
            {
                A_Configurações.BringToFront();
            }    
        }

        private void A_Configurações_MouseLeave(object sender, EventArgs e)
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
                A_email.BringToFront();
            }    
        }

        private void A_email_MouseLeave(object sender, EventArgs e)
        {
            if (button8.Visible)
            {
                button8.BringToFront();
            }
        }

        private void pn_medicamentosS_Click(object sender, EventArgs e)
        {
            A_Funcionarios funcionários = new A_Funcionarios();
            funcionários.MdiParent = this;
            funcionários.Show();
            pn_funcionarios.Hide();
        }

        private void A_Medicamentos_Click(object sender, EventArgs e)
        {
            A_Medicamentos medicamentos = new A_Medicamentos();
            medicamentos.MdiParent = this;
            medicamentos.Show();

            A_Medicamentos.Enabled = false;
        }

        private void A_informacoes_Click(object sender, EventArgs e)
        {
            A_VerInformacao info = new A_VerInformacao();
            info.MdiParent = this;
            info.Show();

            A_informacoes.Enabled = false;
        }

        private void pn_utentesS_Click(object sender, EventArgs e)
        {
A_Utentes utentes = new A_Utentes();
            utentes.MdiParent = this;
            utentes.Show();
            pn_utentes.Hide();
        }

        

        private void pn_informaçõesS_Click(object sender, EventArgs e)
        {
A_VerInformacao info = new A_VerInformacao();
            info.MdiParent = this;
            info.Show();
            pn_informações.Hide();
        }

        private void pn_financiamentoS_Click(object sender, EventArgs e)
        {
A_Financiamento financiamento = new A_Financiamento();
            financiamento.MdiParent = this;
            financiamento.Show();
            pn_financiamento.Hide();
        }

        private void pn_salariosS_Click(object sender, EventArgs e)
        {
            A_Salários salários = new A_Salários();
            salários.MdiParent = this;
            salários.Show();
            pn_salarios.Hide();
        }

        private void pn_configuraçoesS_Click(object sender, EventArgs e)
        {
A_Configurações configurações = new A_Configurações();
            configurações.MdiParent = this;
            configurações.Show();
            pn_configuraçoes.Hide();
        
        }

        private void pn_mailS_Click(object sender, EventArgs e)
        {
A_Email email = new A_Email();
            email.MdiParent = this;
            email.Show();
            pn_mail.Hide();
        }

        private void pn_medicamentosS_Click_1(object sender, EventArgs e)
        {
            A_Medicamentos medicamentos = new A_Medicamentos();
            medicamentos.MdiParent = this;
            medicamentos.Show();
            pn_medicamentos.Hide();
        }

        

        

        

        

        

       

        

        

       
    }
}
