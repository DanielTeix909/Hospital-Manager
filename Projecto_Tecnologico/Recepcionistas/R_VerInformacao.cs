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
    public partial class R_VerInformacao : Form
    {
        int move;
        int moveX;
        int moveY;

        public R_VerInformacao()
        {
            InitializeComponent();
        }

        private void R_VerInformacao_Load(object sender, EventArgs e)
        {
            
        }

        private void grid_marcacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Exames Marcados")

            {
                A_Salários.ControlID.TextData = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                A_Salários.ControlID.TextData1 = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                A_Salários.ControlID.TextData2 = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                A_Salários.ControlID.TextData3 = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                A_Salários.ControlID.TextData4 = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                A_Salários.ControlID.TextData5 = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                A_Salários.ControlID.TextData6 = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                A_Salários.ControlID.TextData7 = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();

                A_Salários.ControlID.TextData8 = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                A_Salários.ControlID.TextData9 = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                A_Salários.ControlID.TextData10 = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
            else if (cb_cargo.SelectedItem.ToString() == "Consultas Marcadas")
            {
                A_Salários.ControlID.TextData = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                A_Salários.ControlID.TextData1 = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                A_Salários.ControlID.TextData2 = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                A_Salários.ControlID.TextData3 = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                A_Salários.ControlID.TextData4 = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                A_Salários.ControlID.TextData5 = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                A_Salários.ControlID.TextData6 = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                A_Salários.ControlID.TextData7 = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();

                A_Salários.ControlID.TextData8 = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                A_Salários.ControlID.TextData9 = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                A_Salários.ControlID.TextData10 = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Analises Marcadas")
            {
                A_Salários.ControlID.TextData = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                A_Salários.ControlID.TextData1 = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                A_Salários.ControlID.TextData2 = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                A_Salários.ControlID.TextData3 = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                A_Salários.ControlID.TextData4 = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                A_Salários.ControlID.TextData5 = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                A_Salários.ControlID.TextData6 = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                A_Salários.ControlID.TextData7 = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();

                A_Salários.ControlID.TextData8 = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                A_Salários.ControlID.TextData9 = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                A_Salários.ControlID.TextData10 = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void b_pesquisa_Click(object sender, EventArgs e)
        {
            (dgv_funcionarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", tbPesquisa.Text);
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Recepcionistas)this.MdiParent).pn_informaçoes.Show();
        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Consultas")
            {
                dgv_funcionarios.DataSource = BLL.salarios.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Analises")
            {
                dgv_funcionarios.DataSource = BLL.mediamentos.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Exames")
            {
                dgv_funcionarios.DataSource = BLL.tratamentos.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Medicamentos")
            {
                dgv_funcionarios.DataSource = BLL.cirugia.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Receitas")
            {
                dgv_funcionarios.DataSource = BLL.Utentes.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Utentes")
            {
                dgv_funcionarios.DataSource = BLL.Utentes.Load();
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Recepcionistas)this.MdiParent).R_informacoes.Enabled = true;
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
