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

namespace Projecto_Tecnologico.Admistradores
{
    public partial class A_Financiamento : Form
    {
        string id_finan;

        int move;
        int moveX;
        int moveY;

        public static class ControlID
        {
            public static string FinanText { get; set; }
            public static string FinanText11 { get; set; }
            public static string FinanText12 { get; set; }
            public static string FinanText13 { get; set; }
            public static object FinanText14 { get; set; }
            public static string FinanText15 { get; set; }
            public static string FinanText16 { get; set; }
            public static string FinanText17 { get; set; }
            public static string FinanText18 { get; set; }
            public static string FinanText19 { get; set; }
            public static string FinanText110 { get; set; }
            public static object FinanText111 { get; set; }

        }
        public A_Financiamento()
        {
            InitializeComponent();
            ControlID.FinanText = tb_nomepaga.Text;     
            ControlID.FinanText11 = tb_refe.Text;
            ControlID.FinanText12 = tb_valorapago.Text;
            ControlID.FinanText13 = tb_quantidade.Text;
            ControlID.FinanText14 = dtp_validade.Value;
            ControlID.FinanText15 = tb_descricao.Text;
            ControlID.FinanText16 = tb_iva.Text;
            ControlID.FinanText17 = tb_identi_refe.Text;
            ControlID.FinanText18 = tb_empresa.Text;
            ControlID.FinanText19 = tb_conctooficial.Text;
            ControlID.FinanText110 = cb_estado.Text;
            ControlID.FinanText111 = dtp_emissao.Value;
           
          
        }
     
        private void A_Financiamento_Load(object sender, EventArgs e)
        {
            tb_horaregisto.Text = DateTime.Now.ToString("HH:mm:ss tt");
            tb_horaregisto.ReadOnly = true;
            dtp_emissao.Enabled = false;

        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Admistradores)this.MdiParent).pn_financiamento.Show();
        }


        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Admistradores)this.MdiParent).A_Financiamento.Enabled = true;
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
                this.SetDesktopLocation(MousePosition.X - moveX, (MousePosition.Y - moveY) - 170);
            }
        }

        private void pb_registar_Click(object sender, EventArgs e)
        {
            int ret = BLL.financiamento.insertfinan(tb_nomepaga.Text, tb_refe.Text, tb_valorapago.Text, tb_quantidade.Text, dtp_validade.Value, tb_descricao.Text, tb_iva.Text, tb_identi_refe.Text, tb_empresa.Text, tb_conctooficial.Text, cb_estado.Text, dtp_emissao.Value);
            tb_nomepaga.Clear();
            tb_refe.Clear();
            tb_valorapago.Clear();
            tb_quantidade.Clear();
            tb_descricao.Clear();
            tb_iva.Clear();
            tb_identi_refe.Clear();
            tb_empresa.Clear();
            tb_conctooficial.Clear();


        }


        private void pb_editar_Click(object sender, EventArgs e)
        {
           BLL.financiamento.updatefinan(tb_nomepaga.Text, tb_refe.Text, tb_valorapago.Text, tb_quantidade.Text, dtp_validade.Value, tb_descricao.Text, tb_iva.Text, tb_identi_refe.Text, tb_empresa.Text, tb_conctooficial.Text, cb_estado.Text, dtp_emissao.Value);
            tb_nomepaga.Clear();
            tb_refe.Clear();
            tb_valorapago.Clear();
            tb_quantidade.Clear();

            tb_descricao.Clear();
            tb_iva.Clear();
            tb_identi_refe.Clear();
            tb_empresa.Clear();
            tb_conctooficial.Clear();
        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.Utentes.deletepaciente(id_finan);
            tb_nomepaga.Clear();
            tb_refe.Clear();
            tb_valorapago.Clear();
            tb_quantidade.Clear();
            tb_descricao.Clear();
            tb_iva.Clear();
            tb_identi_refe.Clear();
            tb_empresa.Clear();
            tb_conctooficial.Clear();
        }
    }
}
