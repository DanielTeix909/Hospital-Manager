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
using Projecto_Tecnologico.Admistradores;


namespace Projecto_Tecnologico
{
    public partial class A_Medicamentos : Form
    {
        int move;
        int moveX;
        int moveY;
        string id_medicamentos;

        public static class ControlID
        {
            public static string Meditext { get; set; }
            public static string Meditext11 { get; set; }
            public static string Meditext12 { get; set; }
            public static string Meditext13 { get; set; }
            public static string Meditext14 { get; set; }
            public static string Meditext15 { get; set; }
            public static string Meditext16 { get; set; }
            public static string Meditext17 { get; set; }
            public static string Meditext18 { get; set; }
            public static string Meditext19 { get; set; }
            public static string Meditext110 { get; set; }


        }
        public A_Medicamentos()
        {
            InitializeComponent();
            ControlID.Meditext = tb_medicamento.Text;
            ControlID.Meditext11 = tb_refe.Text;
            ControlID.Meditext12 = tb_quanti.Text;
            ControlID.Meditext13 = tb_preco.Text;
            ControlID.Meditext14 = tb_categoria.Text;
            ControlID.Meditext15 = tb_fabricante.Text;
            ControlID.Meditext16 = tb_efeitos.Text;
            ControlID.Meditext17 = tb_receita.Text;
        }

        private void A_Medicamentos_Load(object sender, EventArgs e)
        {
            tb_horaregisto.Text = DateTime.Now.ToString("HH:mm:ss tt");
            tb_horaregisto.ReadOnly = true;
            dtp_emissao.Enabled = false;
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Admistradores)this.MdiParent).pn_medicamentos.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Admistradores)this.MdiParent).A_Medicamentos.Enabled = true;
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
            int ret = BLL.mediamentos.insertmedi(tb_medicamento.Text,tb_refe.Text, tb_quanti.Text,tb_preco.Text,tb_categoria.Text
                ,tb_fabricante.Text,tb_efeitos.Text,tb_efeitos.Text,tb_receita.Text,dtp_emissao.Value, dtp_validade.Value);

            tb_medicamento.Clear();
            tb_refe.Clear();
            tb_quanti.Clear();
            tb_preco.Clear();
            tb_categoria.Clear();

            tb_fabricante.Clear();
            tb_efeitos.Clear();
            tb_efeitos.Clear();
            tb_receita.Clear();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Registos\medicamentos.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(tb_medicamento.Text, tb_refe.Text, DateTime.Now, tb_horaregisto.Text);
                    tw.Close();
                }
            }

        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.mediamentos.deletemedi(id_medicamentos);

            tb_medicamento.Clear();
            tb_refe.Clear();
            tb_quanti.Clear();
            tb_preco.Clear();
            tb_categoria.Clear();

            tb_fabricante.Clear();
            tb_efeitos.Clear();
            tb_efeitos.Clear();
            tb_receita.Clear();

            
        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
            BLL.mediamentos.updatemedi(tb_medicamento.Text, tb_refe.Text, tb_quanti.Text, tb_preco.Text, tb_categoria.Text
                , tb_fabricante.Text, tb_efeitos.Text, tb_efeitos.Text, tb_receita.Text, dtp_emissao.Value, dtp_validade.Value);

            tb_medicamento.Clear();
                 tb_refe.Clear();
            tb_quanti.Clear();
            tb_preco.Clear();
            tb_categoria.Clear();

            tb_fabricante.Clear();
            tb_efeitos.Clear();
            tb_efeitos.Clear();
            tb_receita.Clear();

        }
    }
}
