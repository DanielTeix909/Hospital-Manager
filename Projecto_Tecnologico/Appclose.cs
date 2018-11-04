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
    public partial class Appclose : Form
    {
        int move;
        int moveX;
        int moveY;

        public Appclose()
        {
            InitializeComponent();
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

        private void bt_sim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_nao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
