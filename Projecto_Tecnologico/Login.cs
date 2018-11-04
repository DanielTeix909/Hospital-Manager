using Projecto_Tecnologico.Gestores;
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
    public partial class Login : Form
    {
        int move;
        int moveX;
        int moveY;

        string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\");
        string logsentrada = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\logs_entrada");
        string logssaida = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\logs_saida");
        string logserrados = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\logserrados");
        string hmsname = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\hmsconfig.txt");

        public Login()
        {
            InitializeComponent();
        }
     
            public static string login = "";
            public static int timerx { get; set; }
        
            public void Login_Load(object sender, EventArgs e)
        {         
            lb_incorrecto.Hide();

          login = TB_Nome.Text;
            

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void CB_Previlégio_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void b_Visivel_Click(object sender, EventArgs e)
        {
            string text = TB_Senha.Text;

            if (painel_key.Visible)
            {
                TB_Senha.UseSystemPasswordChar = true;
                TB_Senha.Text = text;
                painel_key.Hide();
            }
            else
            {
                TB_Senha.UseSystemPasswordChar = false;
                TB_Senha.Text = text;
                painel_key.Show();
            }

        }

        private void PB_Entrar_Click(object sender, EventArgs e)
        {
            DataTable dtfunc = BLL.prefil.authlogin(TB_Nome.Text, TB_Senha.Text, CB_Previlégio.SelectedItem.ToString());

           if (dtfunc.Rows.Count > 0)
                {
                if (CB_Previlégio.SelectedItem.ToString() == "Adminstrador")
                {

                    //Gestor_Admistradores login = new Gestor_Admistradores();
                    //Application.Run(new Gestor_Admistradores());
                    //this.Close();
                    Gestor_Admistradores f2 = new Gestor_Admistradores();
                    f2.Show();
                    this.Hide();
                }
                else if (CB_Previlégio.SelectedItem.ToString() == "Médico")
                {
                    Gestor_Médicos f2 = new Gestor_Médicos();
                    f2.Show();
                    this.Hide();
                }

                else if (CB_Previlégio.SelectedItem.ToString() == "Rececionista")
                {
                    Gestor_Recepcionistas f3 = new Gestor_Recepcionistas();
                    f3.Show();
                    this.Hide();
                }

                else if (CB_Previlégio.SelectedItem.ToString() == "Enfermeiro")
                {
                    Gestor_Enfermeiros f4 = new Gestor_Enfermeiros();
                    f4.Show();
                    this.Hide();
                }

                else if (CB_Previlégio.SelectedItem.ToString() == "Laboratorista")
                {
                    Gestor_Laboratistas f5 = new Gestor_Laboratistas();
                    f5.Show();
                    this.Hide();
                }

                else if (CB_Previlégio.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Selecione o Cargo Pretendido");
                }


                if (CB_Previlégio.Text == "1 Minuto")
                {
                    timer1.Tick += timer1_Tick;
                    timer1.Interval = 10000;
                    timer1.Start();
                    timerx = 1000;

                }

                if (CB_Previlégio.Text == "5 Minutos")
                {
                    timer1.Tick += timer1_Tick;
                    timer1.Interval = 50000;
                    timer1.Start();
                    timerx = 50000;
                }

                if (CB_Previlégio.Text == "10 Minutos")
                {
                    timer1.Tick += timer1_Tick;
                    timer1.Interval = 100000;
                    timer1.Start();
                    timerx = 100000;
                }
                if (CB_Previlégio.Text == "30 Minutos")
                {
                    timer1.Tick += timer1_Tick;
                    timer1.Interval = 300000;
                    timer1.Start();
                    timerx = 300000;
                }
                if (CB_Previlégio.Text == "Nunca")
                {

                }
            }
            else
            {
                lb_incorrecto.Show();
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Appclose appclose =  new Appclose();
            appclose.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timercloser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TB_Nome_TextChanged(object sender, EventArgs e)
        {
            lb_incorrecto.Hide();
        }

        private void TB_Senha_TextChanged(object sender, EventArgs e)
        {
            lb_incorrecto.Hide();
        }
    }
}
