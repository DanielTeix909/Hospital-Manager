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
    public partial class R_MarcarExames : Form
    {
        int move;
        int moveX;
        int moveY;
        string id_exames;

        public R_MarcarExames()
        {
            InitializeComponent();
        }

        private void R_MarcarExames_Load(object sender, EventArgs e)
        {
            dtp_emissao.Text = DateTime.Now.ToString("HH:mm:ss tt");
            tb_horaregisto.ReadOnly = true;
            dtp_emissao.Enabled = false;
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Recepcionistas)this.MdiParent).pn_mexame.Show();
        }

        

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Recepcionistas)this.MdiParent).R_Marcarexame.Enabled = true;
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

        private void pb_editar_Click(object sender, EventArgs e)
        {
            int exame = BLL.exames.insertexames(tb_refutente.Text,dtp_dataexame.Value,tb_hora.Text,tb_nome.Text,tb_medico.Text,cb_categoria.SelectedItem.ToString(),cb_prioridade.SelectedItem.ToString(),tb_taxa.Text,tb_receita.Text,tb_oberv.Text,dtp_emissao.Value,dtp_validade.Value);
            tb_refutente.Clear();
            tb_hora.Clear();
            tb_nome.Clear();
            tb_medico.Clear();
            cb_categoria.Items.Clear();
            cb_prioridade.Items.Clear();
            tb_taxa.Clear();
            tb_receita.Clear();
            tb_oberv.Clear();

        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.exames.deleteexame(id_exames);
            tb_refutente.Clear();
            tb_hora.Clear();
            tb_nome.Clear();
            tb_medico.Clear();
            cb_categoria.Items.Clear();
            cb_prioridade.Items.Clear();
            tb_taxa.Clear();
            tb_receita.Clear();
            tb_oberv.Clear();
        }

        private void pb_marcar_Click(object sender, EventArgs e)
        {
            BLL.exames.updateexame(tb_refutente.Text, dtp_dataexame.Value, tb_hora.Text, tb_nome.Text, tb_medico.Text, cb_categoria.SelectedItem.ToString(), cb_prioridade.SelectedItem.ToString(), tb_taxa.Text, tb_receita.Text, tb_oberv.Text, dtp_emissao.Value, dtp_validade.Value);
            tb_refutente.Clear();
            tb_hora.Clear();
            tb_nome.Clear();
            tb_medico.Clear();
            cb_categoria.Items.Clear();
            cb_prioridade.Items.Clear();
            tb_taxa.Clear();
            tb_receita.Clear();
            tb_oberv.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            R_VerInformacao func = new R_VerInformacao();
            func.Show();
        }

        
    }
}
