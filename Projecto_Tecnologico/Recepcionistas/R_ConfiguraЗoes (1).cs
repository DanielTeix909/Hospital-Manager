using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Tecnologico
{
    public partial class R_Configuraçoes : Form
    {
        int move;
        int moveX;
        int moveY;

        public R_Configuraçoes()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Dock = DockStyle.None;
        }

        private void b_max_Click(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Recepcionistas)this.MdiParent).R_Configurações.Enabled = true;
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

        private void R_Configuraçoes_Load(object sender, EventArgs e)
        {

        }
    }
}
