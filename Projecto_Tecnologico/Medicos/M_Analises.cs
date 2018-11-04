using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Tecnologico.Medicos
{
    public partial class M_Analises : Form
    {
        int move;
        int moveX;
        int moveY;

        public M_Analises()
        {
            InitializeComponent();
        }

        private void pb_registar_Click(object sender, EventArgs e)
        {
            //int regreceita = BLL.receitas.insertreceitas(tb_medicamento.Text, tb_ref_utente.Text, tb_medico.Text, tb_utentes.Text, tb_medico.Text, cb_categoria.Text, tb_taxa.Text, tb_ref_receita.Text, tb_obers.Text, dtp_emissao.Value, dtp_validade.Value);
            //tb_medicamento.Clear();
            //tb_ref_utente.Clear();
            //tb_medico.Clear();
            //tb_utentes.Clear();
            //tb_medico.Clear();
            //cb_categoria.Items.Clear();
            //tb_taxa.Clear();
            //tb_ref_receita.Clear();
            //tb_obers.Clear();
        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            //int regreceita = BLL.receitas.insertreceitas(tb_medicamento.Text, tb_ref_utente.Text, tb_medico.Text, tb_utentes.Text, tb_medico.Text, cb_categoria.Text, tb_taxa.Text, tb_ref_receita.Text, tb_obers.Text, dtp_emissao.Value, dtp_validade.Value);
            //tb_medicamento.Clear();
            //tb_ref_utente.Clear();
            //tb_medico.Clear();
            //tb_utentes.Clear();
            //tb_medico.Clear();
            //cb_categoria.Items.Clear();
            //tb_taxa.Clear();
            //tb_ref_receita.Clear();
            //tb_obers.Clear();
        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
            //int regreceita = BLL.receitas.deletereceitas(id_receitas);
            //tb_medicamento.Clear();
            //tb_ref_utente.Clear();
            //tb_medico.Clear();
            //tb_utentes.Clear();
            //tb_medico.Clear();
            //cb_categoria.Items.Clear();
            //tb_taxa.Clear();
            //tb_ref_receita.Clear();
            //tb_obers.Clear();
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Médicos)this.MdiParent).pn_analises.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Médicos)this.MdiParent).M_Analises.Enabled = true;
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
