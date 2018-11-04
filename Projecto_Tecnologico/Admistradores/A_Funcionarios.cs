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
    
    public partial class A_Funcionarios : Form
    {

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
        int move;
        int moveX;
        int moveY;
        Image arrayfoto;
        Image arraycetificado;
        string id_funcionario;
        string id_medico;
        public int idlast;
        Image img;

        public A_Funcionarios()
        {
            InitializeComponent();

        }


        private void b_min_Click(object sender, EventArgs e)
        {

            this.Hide();
            ((Gestor_Admistradores)this.MdiParent).pn_funcionarios.Show();
       
        }

        public void b_close_Click(object sender, EventArgs e)
        {
         
        ((Gestor_Admistradores)this.MdiParent).Ab_Funcinários.Enabled = true;

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

        private void A_Médicos_Load(object sender, EventArgs e)
        {
            tb_horaregisto.Text = DateTime.Now.ToString("HH:mm:ss tt");
            tb_horaregisto.ReadOnly = true;
            dtp_emissao.Enabled = false;
        }

        private void pb_registar_Click(object sender, EventArgs e)
        {
            byte[] fotoarray = imgtobytearray(img);      
            int funcionario = BLL.funcionarios.insertfuncionarios(tb_medico.Text, dtp_datanasci.Value, cb_genero.Text, tb_nacionalidade.Text, tb_natalidade.Text
                , tb_fiscal.Text, tb_cc.Text, cb_estadocivil.Text,tb_segu_social.Text,tb_telefone.Text,tb_email.Text,tb_codpostal.Text,tb_morada.Text,dtp_emissao.Value, dtp_validade.Value, fotoarray, cb_cargo.SelectedItem.ToString());

       idlast =(int) BLL.funcionarios.maxid("");
            
            if (cb_cargo.SelectedItem.ToString() == "Médicos")
            {
                byte[] mediccertificado = imgtobytearray(arraycetificado);
               int medico = BLL.medicos.insertmedicos(idlast, mediccertificado, tb_especialidade.Text, tb_salario.Text, dtp_emissao_contrato.Value, tb_numsala.Text);

            }
            else if (cb_cargo.SelectedItem.ToString() == "Enfermeiros")
            {
                byte[] infercetificado = imgtobytearray(arraycetificado);
              int enfermeiros = BLL.enfermeiros.insertenfermeiros(idlast, infercetificado, tb_especialidade.Text, tb_salario.Text, dtp_validade.Value);

            }
            else if (cb_cargo.SelectedItem.ToString() == "Recepcionistas")
            {
                byte[] recepcerttificado = imgtobytearray(arraycetificado);
             int recepiconistas = BLL.recepcionistas.insertrecepcionista(idlast, recepcerttificado, tb_especialidade.Text, tb_salario.Text, dtp_validade.Value, tb_numsala.Text);

            }
            else if (cb_cargo.SelectedItem.ToString() == "Laboratistas")
            {
                byte[] labocertificado = imgtobytearray(arraycetificado);
               int laboratistas = BLL.Laboratistas.inserlaboratistas(idlast, labocertificado, tb_especialidade.Text, tb_salario.Text, dtp_validade.Value, tb_numsala.Text);
            }

            tb_medico.Clear();
            cb_genero.Items.Clear();
            tb_nacionalidade.Clear();
            tb_natalidade.Clear();
            tb_fiscal.Clear();
            cb_estadocivil.Items.Clear();
            tb_segu_social.Clear();
            tb_telefone.Clear();
            tb_email.Clear();
            tb_codpostal.Clear();
            tb_morada.Clear();

            cb_cargo.Items.Clear();
            tb_especialidade.Clear();
            tb_salario.Clear();
            tb_numsala.Clear();

            NovoPrefil perfil = new NovoPrefil();
            perfil.Show();
        }

        private void pb_remover_Click(object sender, EventArgs e)
        {
            BLL.funcionarios.deletefuncionario(id_funcionario);
            BLL.medicos.deletemedicos(id_medico);

            tb_medico.Clear();
            cb_genero.Items.Clear();
            tb_nacionalidade.Clear();
            tb_natalidade.Clear();
            tb_fiscal.Clear();
            cb_estadocivil.Items.Clear();
            tb_segu_social.Clear();
            tb_telefone.Clear();
            tb_email.Clear();
            tb_codpostal.Clear();
            tb_morada.Clear();

            cb_cargo.Items.Clear();
            tb_especialidade.Clear();
            tb_salario.Clear();
            tb_numsala.Clear();

        }

        private void pb_editar_Click(object sender, EventArgs e)
        {
            byte[] fotoarray = imgtobytearray(arrayfoto);
            BLL.funcionarios.updatefuncionario(tb_medico.Text, dtp_datanasci.Value, cb_genero.Text, tb_nacionalidade.Text, tb_natalidade.Text
                , tb_fiscal.Text, tb_cc.Text, cb_estadocivil.Text, tb_segu_social.Text, tb_telefone.Text, tb_email.Text, tb_codpostal.Text, tb_morada.Text, dtp_emissao.Value, dtp_validade.Value, fotoarray, cb_cargo.SelectedItem.ToString());

            if (cb_cargo.SelectedItem.ToString() == "Médicos")
            {
                byte[] mediccertificado = imgtobytearray(arraycetificado);
                int medico = BLL.medicos.updatemedicos(mediccertificado, tb_especialidade.Text, tb_salario.Text, dtp_emissao_contrato.Value, tb_numsala.Text);

            }
            else if (cb_cargo.SelectedItem.ToString() == "Enfermeiros")
            {
                byte[] infercetificado = imgtobytearray(arraycetificado);
                int enfermeiros = BLL.enfermeiros.updateenfermeiro(infercetificado, tb_especialidade.Text, tb_salario.Text, dtp_validade.Value);

            }
            else if (cb_cargo.SelectedItem.ToString() == "Recepcionistas")
            {
                byte[] recepcerttificado = imgtobytearray(arraycetificado);
                int recepiconistas = BLL.recepcionistas.updaterecepcionista(recepcerttificado, tb_especialidade.Text, tb_salario.Text, dtp_validade.Value, tb_numsala.Text);

            }
            else if (cb_cargo.SelectedItem.ToString() == "Laboratistas")
            {
                byte[] labocertificado = imgtobytearray(arraycetificado);
                int laboratistas = BLL.Laboratistas.updatelaboratistas(labocertificado, tb_especialidade.Text, tb_salario.Text, dtp_validade.Value, tb_numsala.Text);
            }

            tb_medico.Clear();
            cb_genero.Items.Clear();
            tb_nacionalidade.Clear();
            tb_natalidade.Clear();
            tb_fiscal.Clear();
            cb_estadocivil.Items.Clear();
            tb_segu_social.Clear();
            tb_telefone.Clear();
            tb_email.Clear();
            tb_codpostal.Clear();
            tb_morada.Clear();

            cb_cargo.Items.Clear();
            tb_especialidade.Clear();
            tb_salario.Clear();
            tb_numsala.Clear();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            A_VerFunc func = new A_VerFunc();
            func.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb_foto.Image = new Bitmap(dlg.OpenFile());
            }

            dlg.Dispose();

          //  pb_foto.SizeMode = PictureBoxSizeMode.Zoom;
            img = pb_foto.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pb_foto.Image = null;
        }

        private void pn_p_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                arraycetificado = new Bitmap(dlg.OpenFile());
            }

            dlg.Dispose();
        }

        public void tb_medico_TextChanged(object sender, EventArgs e)
        {

        }

        public void cb_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
