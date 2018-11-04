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

namespace Projecto_Tecnologico.Enfermeiros
{
    public partial class E_Informações : Form
    {
        int move;
        int moveX;
        int moveY;

        public E_Informações()
        {
            InitializeComponent();
        }

        private void b_pesquisa_Click(object sender, EventArgs e)
        {
            (grid_info.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", tbPesquisa.Text);
        }

        private void E_Informações_Load(object sender, EventArgs e)
        {
           
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Enfermeiros)this.MdiParent).pn_informaçoes.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Enfermeiros)this.MdiParent).E_informacoes.Enabled = true;
            this.Close();
        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Utentes")
            {
                grid_info.DataSource = BLL.salarios.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Medicamentos")
            {
                grid_info.DataSource = BLL.mediamentos.Load();
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
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY - 170);
            }
        }
    }
}
