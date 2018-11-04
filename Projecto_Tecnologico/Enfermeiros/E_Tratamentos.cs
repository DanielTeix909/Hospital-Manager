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
    public partial class E_Tratamentos : Form
    {
        int move;
        int moveX;
        int moveY;

        string id_tratamento;
        public E_Tratamentos()
        {
            InitializeComponent();
        }

        private void E_Tratamentos_Load(object sender, EventArgs e)
        {

        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Enfermeiros)this.MdiParent).pn_tratamentos.Show();
        }


        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Enfermeiros)this.MdiParent).E_Tratamentos.Enabled = true;
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

        private void pb_marcar_Click(object sender, EventArgs e)
        {
            int trats = BLL.tratamentos.inserttatamento(tb_refutente.Text, tb_enfermeiro.Text, dtp_tratamento.Value, tb_hora.Text, cb_prioridade.Text, tb_utente.Text, tb_doencas.Text, cb_categoria.SelectedItem.ToString(), tb_horas_trata.Text, tb_oberv.Text, dtp_emissao.Value,tb_hora.Text);

            tb_refutente.Clear();
            tb_enfermeiro.Clear(); 
            tb_hora.Clear(); 
            cb_prioridade.Items.Clear();
            tb_utente.Clear();
            tb_doencas.Clear();
            tb_horas_trata.Clear(); 
            tb_oberv.Clear();
            tb_hora.Clear();
        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.tratamentos.deletetatamento(id_tratamento);


            tb_refutente.Clear();
            tb_enfermeiro.Clear();
            tb_hora.Clear();
            cb_prioridade.Items.Clear();
            tb_utente.Clear();
            tb_doencas.Clear();
            tb_horas_trata.Clear();
            tb_oberv.Clear();
            tb_hora.Clear();
        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
            BLL.tratamentos.updatetratamento(tb_refutente.Text, tb_enfermeiro.Text, dtp_tratamento.Value, tb_hora.Text, cb_prioridade.Text, tb_utente.Text, tb_doencas.Text, cb_categoria.SelectedItem.ToString(), tb_horas_trata.Text, tb_oberv.Text, dtp_emissao.Value, tb_hora.Text);


            tb_refutente.Clear();
            tb_enfermeiro.Clear();
            tb_hora.Clear();
            cb_prioridade.Items.Clear();
            tb_utente.Clear();
            tb_doencas.Clear();
            tb_horas_trata.Clear();
            tb_oberv.Clear();
            tb_hora.Clear();
        }
    }
}
