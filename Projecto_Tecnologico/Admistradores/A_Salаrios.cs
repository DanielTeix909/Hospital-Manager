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
    public partial class A_Salários : Form
    {
        int move;
        int moveX;
        int moveY;
        string ID_salarios;

        public A_Salários()
        {
            InitializeComponent();
        }
        public static class ControlID
        {
            public static string TextData { get; set; }
            public static string TextData1 { get; set; }
            public static string TextData2 { get; set; }
            public static string TextData3 { get; set; }
            public static string TextData4 { get; set; }
            public static string TextData5 { get; set; }
            public static string TextData6 { get; set; }
            public static string TextData7 { get; set; }
            public static string TextData8 { get; set; }
            public static string TextData9 { get; set; }
            public static string TextData10 { get; set; }


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             ControlID.TextData = tb_idempregado.Text;
             ControlID.TextData1 = tb_empregado.Text;
             ControlID.TextData2 = tb_valorpago.Text;
             ControlID.TextData3 = tb_salbruto.Text;
             ControlID.TextData4 = tb_descontos.Text;
             ControlID.TextData5 = tb_horas.Text;
             ControlID.TextData6 = tb_extrah.Text;
             ControlID.TextData7 = tb_refsalarial.Text;
             ControlID.TextData8 = tb_nfiscal.Text;
             ControlID.TextData9 = tb_metodopag.Text;
             ControlID.TextData10 = cb_mes.Text;
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Admistradores)this.MdiParent).pn_salarios.Show();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Admistradores)this.MdiParent).A_sala.Enabled = true;
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
            BLL.salarios.insersalarios(tb_idempregado.Text, tb_empregado.Text, tb_valorpago.Text, tb_salbruto.Text, tb_descontos.Text, tb_horas.Text, tb_extrah.Text, tb_refsalarial.Text, tb_nfiscal.Text, tb_metodopag.Text, cb_mes.SelectedItem.ToString(),dtp_emissao.Value);
            tb_idempregado.Clear();
                tb_empregado.Clear();
            tb_valorpago.Clear();
            tb_salbruto.Clear();
            tb_descontos.Clear();
            tb_horas.Clear();
            tb_extrah.Clear();
            tb_refsalarial.Clear();
            tb_nfiscal.Clear();
            tb_metodopag.Clear();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\Registos\salarios.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(tb_empregado.Text, tb_valorpago, DateTime.Now, tb_horaregisto.Text);
                    tw.Close();
                }
            }

        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.salarios.deletesalarios(ID_salarios);
            tb_idempregado.Clear();
            tb_empregado.Clear();
            tb_valorpago.Clear();
            tb_salbruto.Clear();
            tb_descontos.Clear();
            tb_horas.Clear();
            tb_extrah.Clear();
            tb_refsalarial.Clear();
            tb_nfiscal.Clear();
            tb_metodopag.Clear();
        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
           BLL.salarios.updatesalarios(tb_idempregado.Text, tb_empregado.Text, tb_valorpago.Text, tb_salbruto.Text, tb_descontos.Text, tb_horas.Text, tb_extrah.Text, tb_refsalarial.Text, tb_nfiscal.Text, tb_metodopag.Text, cb_mes.SelectedItem.ToString(), dtp_emissao.Value);
            tb_idempregado.Clear();
            tb_empregado.Clear();
            tb_valorpago.Clear();
            tb_salbruto.Clear();
            tb_descontos.Clear();
            tb_horas.Clear();
            tb_extrah.Clear();
            tb_refsalarial.Clear();
            tb_nfiscal.Clear();
            tb_metodopag.Clear();
        }

        private void A_Salários_Load(object sender, EventArgs e)
        {
            tb_horaregisto.Text = DateTime.Now.ToString("HH:mm:ss tt");
            tb_horaregisto.ReadOnly = true;
            dtp_emissao.Enabled = false;
        }

    }
}
