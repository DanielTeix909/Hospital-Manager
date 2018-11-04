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
    public partial class A_Utentes : Form
    {
        int move;
        int moveX;
        int moveY;
        Image img;
        string id_utente;
        public A_Utentes()
        {
            InitializeComponent();
       
        }
        public static class ControlID
        {
            public static string Utentetext { get; set; }
            public static string Utentetext11 { get; set; }
            public static string Utentetext12 { get; set; }
            public static string Utentetext13 { get; set; }
            public static string Utentetext14 { get; set; }
            public static string Utentetext15 { get; set; }
            public static string Utentetext16 { get; set; }
            public static string Utentetext17 { get; set; }
            public static string Utentetext18 { get; set; }
            public static string Utentetext19 { get; set; }
            public static string Utentetext110 { get; set; }
            public static string Utentetext111 { get; set; }
            public static string Utentetext112 { get; set; }
            public static string Utentetext113 { get; set; }
            public static string Utentetext114 { get; set; }
            public static string Utentetext115 { get; set; }
            public static object  Utentetext116 { get; set; }
            public static object Utentetext117 { get; set; }



        }
        public byte[] imgtobytearray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
        public Image bytetoarray(byte[] byteArrayin)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayin))
            {
                return Image.FromStream(mStream);
            }
        }

        private void A_Utentes_Load(object sender, EventArgs e)
        {
            ControlID.Utentetext = tb_utente.Text;
            ControlID.Utentetext11 = dtp_datanasci.Value.ToString();
            ControlID.Utentetext12 = tb_genero.Text;
            ControlID.Utentetext13 = tb_nacionalidade.Text;
            ControlID.Utentetext14 = tb_natalidade.Text;
            ControlID.Utentetext15 = tb_medico.Text;
            ControlID.Utentetext16 = tb_fiscal.Text;
            ControlID.Utentetext17 = tb_cc.Text;
            ControlID.Utentetext18 = tb_segusocial.Text;
            ControlID.Utentetext19 = tb_estadocivil.Text;
            ControlID.Utentetext110 = tb_codpostal.Text;
            ControlID.Utentetext111 = tb_conselho.Text;
            ControlID.Utentetext112 = tb_morada.Text;
            ControlID.Utentetext112 = tb_telefone.Text;
            ControlID.Utentetext113 = tb_email.Text;
            ControlID.Utentetext114 = tb_sanguineo.Text;
            ControlID.Utentetext115 = tb_taxas.Text;
            ControlID.Utentetext116 =dtp_emissao.Value;
                ControlID.Utentetext117 =dtp_validade.Value;
        }

    
     

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Admistradores)this.MdiParent).pn_utentes.Show();
        }

       

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Admistradores)this.MdiParent).A_Utentes.Enabled = true;
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
            byte[] fotoarray = imgtobytearray(img);
            int ret = BLL.Utentes.insertpacientes(tb_utente.Text, 
                dtp_datanasci.Value.ToString(), 
                tb_genero.Text, 
                tb_nacionalidade.Text,
                tb_natalidade.Text,
                tb_medico.Text,
                tb_fiscal.Text,
                tb_cc.Text,
                tb_segusocial.Text,
                tb_estadocivil.Text,
                tb_codpostal.Text,
                tb_conselho.Text,
                tb_morada.Text,
                tb_telefone.Text,
                tb_email.Text,
                tb_sanguineo.Text,
                tb_taxas.Text,
                dtp_emissao.Value,
                dtp_validade.Value, 
                fotoarray);

            tb_utente.Clear();
            tb_genero.Clear();
            tb_nacionalidade.Clear();
            tb_natalidade.Clear();
            tb_medico.Clear();
            tb_fiscal.Clear();
            tb_cc.Clear();
            tb_segusocial.Clear();
            tb_estadocivil.Clear();
            tb_codpostal.Clear();
            tb_conselho.Clear();
            tb_morada.Clear();
            tb_telefone.Clear();
            tb_email.Clear();
            tb_sanguineo.Clear();
            tb_taxas.Clear();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\DataBase Logs\Registados.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(tb_utente.Text, tb_cc, DateTime.Now, tb_horaregisto.Text);
                    tw.Close();
                }
            }
        }


        private void pb_editar_Click(object sender, EventArgs e)
        {
            byte[] barr = imgtobytearray(img);
       BLL.Utentes.updatepaciente(tb_utente.Text,
         dtp_datanasci.Value.ToString(),
         tb_genero.Text,
         tb_nacionalidade.Text,
         tb_natalidade.Text,
         tb_medico.Text,
         tb_fiscal.Text,
         tb_cc.Text,
         tb_segusocial.Text,
         tb_estadocivil.Text,
         tb_codpostal.Text,
         tb_conselho.Text,
         tb_morada.Text,
         tb_telefone.Text,
         tb_email.Text,
         tb_sanguineo.Text,
         tb_taxas.Text,
         dtp_emissao.Value,
       dtp_validade.Value, barr); 

            tb_utente.Clear();
            tb_genero.Clear();
            tb_nacionalidade.Clear();
            tb_natalidade.Clear();
            tb_medico.Clear();
            tb_fiscal.Clear();
            tb_cc.Clear();
            tb_segusocial.Clear();
            tb_estadocivil.Clear();
            tb_codpostal.Clear();
            tb_conselho.Clear();
            tb_morada.Clear();
            tb_telefone.Clear();
            tb_email.Clear();
            tb_sanguineo.Clear();
            tb_taxas.Clear();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\DataBase Logs\Editados.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(tb_utente.Text, tb_cc, DateTime.Now, tb_horaregisto.Text);
                    tw.Close();
                }
            }
        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.Utentes.deletepaciente(id_utente);
            tb_utente.Clear();
            tb_genero.Clear();
            tb_nacionalidade.Clear();
            tb_natalidade.Clear();
            tb_medico.Clear();
            tb_fiscal.Clear();
            tb_cc.Clear();
            tb_segusocial.Clear();
            tb_estadocivil.Clear();
            tb_codpostal.Clear();
            tb_conselho.Clear();
            tb_morada.Clear();
            tb_telefone.Clear();
            tb_email.Clear();
            tb_sanguineo.Clear();
            tb_taxas.Clear();

            string mainfolder = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\HospitalManager\DataBase Logs\Apagados.txt");
            if (File.Exists(mainfolder))
            {
                using (TextWriter tw = new StreamWriter(mainfolder))
                {
                    tw.WriteLine(tb_utente.Text, tb_cc, DateTime.Now, tb_horaregisto.Text);
                    tw.Close();
                }
            }

        }

        private void pb_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb_foto.Image = new Bitmap(dlg.OpenFile());
            }

            dlg.Dispose();

            pb_foto.SizeMode = PictureBoxSizeMode.Zoom;
            img = pb_foto.Image;
        }
    }
}
