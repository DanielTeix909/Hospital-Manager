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

namespace Projecto_Tecnologico.Recepcionistas
{
    public partial class R_cirugia : Form
    {
        int move;
        int moveX;
        int moveY;
        string id_cirugia;
        public R_cirugia()
        {
            InitializeComponent();
        }


        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Recepcionistas)this.MdiParent).pn_cirugia.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Recepcionistas)this.MdiParent).R_Cirugias.Enabled = true;
            this.Close();

        }

        private void R_cirugia_Load(object sender, EventArgs e)
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
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY - 170);
            }
        }

        private void pb_marcar_Click(object sender, EventArgs e)
        {
            int cirugia = BLL.cirugia.insert_cirugia(tb_referenciautente.Text, dtp_dataexame.Value, tb_nomeutente.Text, tb_nomemedico.Text, tb_cirugico.Text, cb_categoria.SelectedItem.ToString(), cb_prioridade.Text, cb_sanguineo.SelectedItem.ToString(), tb_referenciataxamoderadora.Text, dtp_emissao.Value, tb_horaregisto.Text);

            tb_referenciautente.Clear();
            tb_nomeutente.Clear();
            tb_nomemedico.Clear();
            tb_cirugico.Clear();
            cb_categoria.Items.Clear();
            cb_prioridade.Items.Clear();
            cb_sanguineo.Items.Clear();
            tb_referenciataxamoderadora.Clear();
            tb_horaregisto.Clear();

        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
            BLL.cirugia.update_cirugia(tb_referenciautente.Text, dtp_dataexame.Value, tb_nomeutente.Text, tb_nomemedico.Text, tb_cirugico.Text, cb_categoria.SelectedItem.ToString(), cb_prioridade.Text, cb_sanguineo.SelectedItem.ToString(), tb_referenciataxamoderadora.Text, dtp_emissao.Value, tb_horaregisto.Text);
            tb_referenciautente.Clear();
            tb_nomeutente.Clear();
            tb_nomemedico.Clear();
            tb_cirugico.Clear();
            cb_categoria.Items.Clear();
            cb_prioridade.Items.Clear();
            cb_sanguineo.Items.Clear();
            tb_referenciataxamoderadora.Clear();
            tb_horaregisto.Clear();
        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.cirugia.delete_cirugia(id_cirugia);
            tb_referenciautente.Clear();
            tb_nomeutente.Clear();
            tb_nomemedico.Clear();
            tb_cirugico.Clear();
            cb_categoria.Items.Clear();
            cb_prioridade.Items.Clear();
            cb_sanguineo.Items.Clear();
            tb_referenciataxamoderadora.Clear();
            tb_horaregisto.Clear();
        }
    }
}
