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
using System.IO;


namespace Projecto_Tecnologico
{
    public partial class M_Consultas : Form
    {
        int move;
        int moveX;
        int moveY;

        string id;
        public M_Consultas()
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
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY - 170);
            }
        }

        private void M_Consultas_Load(object sender, EventArgs e)
        {
            tb_horaregisto.Text = DateTime.Now.ToString("HH:mm:ss tt");
            tb_horaregisto.ReadOnly = true;
            dtp_emissao.Enabled = false;
        }

        private void pb_marcar_Click(object sender, EventArgs e)
        {
            int ret = BLL.consultas.insertconsulta(lb_func.Text,tb_idutente.Text, dtp_consulta.Value.ToString(), tb_hora.SelectionLength, tb_nomeutente.Text, tb_medico.Text, cb_categoria.Text, tb_idtaxa.Text, cb_prioridade.Text, tb_obervacoes.Text, dtp_consulta.Value, tb_horaregisto.Text);
            tb_idutente.Clear();
            tb_hora.Clear();
            tb_nomeutente.Clear();
            tb_medico.Clear();
            tb_idtaxa.Clear();
            tb_obervacoes.Clear();
   
        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
            BLL.consultas.updateconsulta(lb_func.Text,tb_idutente.Text, dtp_consulta.Value.ToString(), tb_hora.SelectionLength, tb_nomeutente.Text, tb_medico.Text, cb_categoria.Text, tb_idtaxa.Text, cb_prioridade.Text, tb_obervacoes.Text, dtp_consulta.Value, tb_horaregisto.Text);
            tb_idutente.Clear();
            tb_hora.Clear();
            tb_nomeutente.Clear();
            tb_medico.Clear();
            tb_idtaxa.Clear();
            tb_obervacoes.Clear();

        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.consultas.deleteconsulta(id);
            tb_idutente.Clear();
                   tb_hora.Clear();
            tb_nomeutente.Clear();
            tb_medico.Clear(); 
                tb_idtaxa.Clear();
            tb_obervacoes.Clear();
 
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Médicos)this.MdiParent).pn_consultas.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Médicos)this.MdiParent).M_Consultas.Enabled = true;
            this.Close();
        }

       
    }
}
