using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Projecto_Tecnologico.Enfermeiros
{
    public partial class E_Email : Form
    {
        int move;
        int moveX;
        int moveY;

        public E_Email()
        {
            InitializeComponent();
        }

        private void E_Email_Load(object sender, EventArgs e)
        {

        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Enfermeiros)this.MdiParent).pn_mail.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Enfermeiros)this.MdiParent).E_email.Enabled = true;
            this.Close();
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
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY - 170);
            }
        }
    }
    }

