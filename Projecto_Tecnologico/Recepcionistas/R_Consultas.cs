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
using Projecto_Tecnologico.Recepcionistas;

namespace Projecto_Tecnologico
{
    public partial class R_Consultas : Form
    {
        int move;
        int moveX;
        int moveY;
        string id;
        public R_Consultas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Recepcionistas)this.MdiParent).pn_consultas.Show();
        }

        

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Recepcionistas)this.MdiParent).R_Consultas.Enabled = true;
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

        private void R_Consultas_Load(object sender, EventArgs e)
        {
            tb_horaregisto.Text = DateTime.Now.ToString("HH:mm:ss tt");
            tb_horaregisto.ReadOnly = true;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pb_marcar_Click(object sender, EventArgs e)
        {
            int ret = BLL.consultas.insertconsulta(lb_funt.Text,tb_refutente.Text, dtp_consulta.Value.ToString(), tb_horaconsulta.SelectionLength, tb_nome.Text, tb_medico.Text, cb_categoria.Text, tb_reftaxa.Text, cb_prioridade.Text, tb_oberv.Text, dtp_consulta.Value, tb_horaregisto.Text);
            tb_refutente.Clear();
            tb_horaconsulta.Clear();
            tb_nome.Clear();
            tb_medico.Clear();
            cb_categoria.Items.Clear();
            tb_reftaxa.Clear();
            cb_prioridade.Items.Clear();
            tb_oberv.Clear();
            tb_horaregisto.Clear();

        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
            BLL.consultas.updateconsulta(lb_funt.Text, tb_refutente.Text, dtp_consulta.Value.ToString(), tb_horaconsulta.SelectionLength, tb_nome.Text, tb_medico.Text, cb_categoria.Text, tb_reftaxa.Text, cb_prioridade.Text, tb_oberv.Text, dtp_consulta.Value, tb_horaregisto.Text);
            tb_refutente.Clear();
            tb_horaconsulta.Clear();
            tb_nome.Clear();
            tb_medico.Clear();
            cb_categoria.Items.Clear();
            tb_reftaxa.Clear();
            cb_prioridade.Items.Clear();
            tb_oberv.Clear();
            tb_horaregisto.Clear();
        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.consultas.deleteconsulta(id);
            tb_refutente.Clear();
            tb_horaconsulta.Clear();
            tb_nome.Clear();
            tb_medico.Clear();
            cb_categoria.Items.Clear();
            tb_reftaxa.Clear();
            cb_prioridade.Items.Clear();
            tb_oberv.Clear();
            tb_horaregisto.Clear();

        }

        private void tb_oberv_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            R_VerInformacao func = new R_VerInformacao();
            func.Show();
        }
    }
}
