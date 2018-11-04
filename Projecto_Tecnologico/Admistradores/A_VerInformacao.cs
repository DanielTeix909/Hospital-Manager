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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Projecto_Tecnologico.Admistradores
{
    public partial class A_VerInformacao : Form
    {
        int move;
        int moveX;
        int moveY;

        public A_VerInformacao()
        {
            InitializeComponent();

        }


        private void A_VerInformacao_Load(object sender, EventArgs e)
        {
            cb_functs.Hide();
            
        }

        private void dgv_funcionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Salários")

            {
                A_Salários fromix = (A_Salários)System.Windows.Forms.Application.OpenForms["A_Salários"];
                try
                {


                    fromix.tb_idempregado.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_empregado.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.tb_valorpago.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.tb_salbruto.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.tb_descontos.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_horas.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_extrah.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_refsalarial.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    fromix.tb_nfiscal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    fromix.tb_metodopag.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    fromix.cb_mes.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    

                }
                catch (Exception)
                {

                }

            }
            else if (cb_cargo.SelectedItem.ToString() == "Medicamentos")
            {

                A_Medicamentos fromix = (A_Medicamentos)System.Windows.Forms.Application.OpenForms["A_Medicamentos"];
                try
                {


                    fromix.tb_medicamento.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_refe.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.tb_quanti.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.tb_preco.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.tb_categoria.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_fabricante.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_efeitos.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_receita.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();


                }
                catch (Exception)
                {

                }
            }
           
      
            else if (cb_cargo.SelectedItem.ToString() == "Utentes")
            {


                A_Utentes fromix = (A_Utentes)System.Windows.Forms.Application.OpenForms["A_Utentes"];
                try
                {


                    //fromix.id = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_utente.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.dtp_datanasci.Value = (DateTime)dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value;
                    fromix.tb_genero.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.tb_nacionalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_natalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_medico.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_fiscal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    fromix.tb_cc.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    fromix.tb_segusocial.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    fromix.tb_estadocivil.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    fromix.tb_codpostal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                    fromix.tb_conselho.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                    fromix.tb_morada.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value.ToString();
                    fromix.tb_telefone.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[14].Value.ToString();
                    fromix.tb_email.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[15].Value.ToString();
                    fromix.tb_sanguineo.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[16].Value.ToString();
                    fromix.tb_taxas.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[17].Value.ToString();
                    fromix.dtp_emissao.Value = (DateTime)dgv_funcionarios.Rows[e.RowIndex].Cells[18].Value;
                    fromix.dtp_validade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[19].Value.ToString();


                }
                catch (Exception)
                {

                }

            }
            else if (cb_cargo.SelectedItem.ToString() == "Financiamento")
            {
                A_Financiamento fromix = (A_Financiamento)System.Windows.Forms.Application.OpenForms["A_Financiamento"];
                try
                {


                   // fromix.id = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_nomepaga.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.tb_refe.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.tb_valorapago.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.dtp_validade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_descricao.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_iva.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_identi_refe.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    fromix.tb_empresa.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    fromix.tb_conctooficial.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    fromix.cb_estado.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    fromix.dtp_emissao.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                 


                }
                catch (Exception)
                {

                }


            }
            
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Salários")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_empregado LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Medicamentos")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Tratamentos")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_utente LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Cirugias")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("id_paciente LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Utentes")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_completo LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Analises")
            {
                dgv_funcionarios.DataSource = BLL.Utentes.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Financiamento")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_produto LIKE '%{0}%'", tbPesquisa.Text);
            }
          
        }

        private void b_pesquisa_Click(object sender, EventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Salários")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_empregado LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Medicamentos")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Tratamentos")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_utente LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Cirugias")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("id_paciente LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Utentes")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_completo LIKE '%{0}%'", tbPesquisa.Text);
            }
            else if (cb_cargo.SelectedItem.ToString() == "Analises")
            {
                dgv_funcionarios.DataSource = BLL.Utentes.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Financiamento")
            {
                (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_produto LIKE '%{0}%'", tbPesquisa.Text);
            }

        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Salários")
            {
                dgv_funcionarios.DataSource = BLL.salarios.Load();

            }
            else if (cb_cargo.SelectedItem.ToString() == "Medicamentos")
            {
                dgv_funcionarios.DataSource = BLL.mediamentos.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Tratamentos")
            {
                dgv_funcionarios.DataSource = BLL.tratamentos.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Cirugias")
            {
                dgv_funcionarios.DataSource = BLL.cirugia.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Utentes")
            {
                dgv_funcionarios.DataSource = BLL.Utentes.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Analises")
            {
                dgv_funcionarios.DataSource = BLL.Utentes.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Financiamento")
            {
                dgv_funcionarios.DataSource = BLL.financiamento.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Historico Logs Funcionarios")
            {
                dgv_funcionarios.Hide();
                lb_historioco.Show();
                cb_functs.Show();

                if (cb_functs.Text == "Médico")
                {
                    var mainfolder = @"%USERPROFILE%\HospitalManager\logs_entrada\logs_medico.txt";
                    var filePath = Environment.ExpandEnvironmentVariables(mainfolder);
                    cb_functs.DataSource = File.ReadAllLines(filePath);

                }
                else if (cb_functs.Text == "Enfermeiros")
                {
                    var mainfolder1 = @"%USERPROFILE%\HospitalManager\logs_entrada\logs_enfermeiro.txt";
                    var filePath1 = Environment.ExpandEnvironmentVariables(mainfolder1);
                    cb_functs.DataSource = File.ReadAllLines(filePath1);
                }
                else if (cb_functs.Text == "Rececionistas")
                {
                    var mainfolder2 = @"%USERPROFILE%\HospitalManager\logs_entrada\logs_enfermeiro.txt";
                    var filePath2 = Environment.ExpandEnvironmentVariables(mainfolder2);
                    cb_functs.DataSource = File.ReadAllLines(filePath2);
                }
                else if (cb_functs.Text == "Laboratoristas")
                {
                    var mainfolder3 = @"%USERPROFILE%\HospitalManager\logs_entrada\logs_enfermeiro.txt";
                    var filePath3 = Environment.ExpandEnvironmentVariables(mainfolder3);
                    cb_functs.DataSource = File.ReadAllLines(filePath3);
                }
                else if (cb_functs.Text == "Adminstradores")
                {
                    var mainfolder4 = @"%USERPROFILE%\HospitalManager\logs_entrada\logs_adminstradores.txt";
                    var filePath4 = Environment.ExpandEnvironmentVariables(mainfolder4);
                    cb_functs.DataSource = File.ReadAllLines(filePath4);
                }
            }
        }

        private void pb_exportexcel_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Lista de Funcionarios";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);


                    for (int i = 0; i < dgv_funcionarios.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgv_funcionarios.Columns.Count; j++)
                        {
                            if ((dgv_funcionarios.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i + 1, j + 1] = dgv_funcionarios.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Exportar o Ficheiro" + ex.ToString());
            }
        }

        private void pb_exportpdf_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgv_funcionarios.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;


            foreach (DataGridViewColumn column in dgv_funcionarios.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dgv_funcionarios.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }


            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Informacoes.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

       
        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Admistradores)this.MdiParent).A_informacoes.Enabled = true;

            this.Close();
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Admistradores)this.MdiParent).pn_informações.Show();
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
    }
}