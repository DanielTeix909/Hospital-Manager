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
using System.Data;

namespace Projecto_Tecnologico.Admistradores
{
    public partial class A_VerFunc : Form
    {
        int move;
        int moveX;
        int moveY;

        string id;
        public A_VerFunc()
        {
            InitializeComponent();
        }

        private void b_pesquisa_Click(object sender, EventArgs e)
        {
            (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_completo LIKE '%{0}%'", tbPesquisa.Text);

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
            using (FileStream stream = new FileStream(folderPath + "Funcionarios.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
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
                    Microsoft.Office.Interop.Excel.Workbook ad22;
                    Microsoft.Office.Interop.Excel.Worksheet af44;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    ad22 = aplicacion.Workbooks.Add();
                    af44 =
                        (Microsoft.Office.Interop.Excel.Worksheet)ad22.Worksheets.get_Item(1);


                    for (int i = 0; i < dgv_funcionarios.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgv_funcionarios.Columns.Count; j++)
                        {
                            if ((dgv_funcionarios.Rows[i].Cells[j].Value == null) == false)
                            {
                                af44.Cells[i + 1, j + 1] = dgv_funcionarios.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    ad22.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    ad22.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Exportar o Ficheiro" + ex.ToString());
            }
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Médicos")
            {
                dgv_funcionarios.DataSource = BLL.medicos.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Enfermeiros")
            {
                dgv_funcionarios.DataSource = BLL.enfermeiros.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Repecionista")
            {
                dgv_funcionarios.DataSource = BLL.recepcionistas.Load();
            }
            else if (cb_cargo.SelectedItem.ToString() == "Não Docente")
            {
                dgv_funcionarios.DataSource = BLL.funcionarios.Load();
            }
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {

            (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("nome_completo LIKE '%{0}%'", tbPesquisa.Text);

        }

        private void dgv_funcionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cb_cargo.SelectedItem.ToString() == "Médicos")
            {



                A_Funcionarios fromix = (A_Funcionarios)System.Windows.Forms.Application.OpenForms["A_Funcionarios"];
                try
                {
                    id = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_medico.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.dtp_datanasci.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value);
                    fromix.cb_genero.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.tb_nacionalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_natalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_fiscal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_cc.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    fromix.cb_estadocivil.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    fromix.tb_segu_social.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    fromix.tb_telefone.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    fromix.tb_email.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                    fromix.tb_codpostal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.dtp_validade.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[14].Value);
                    fromix.pb_foto.Image = (System.Drawing.Image)dgv_funcionarios.Rows[e.RowIndex].Cells[15].Value;
                    fromix.cb_cargo.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[16].Value.ToString();
                    fromix.idlast = Convert.ToInt32(dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value);
                    fromix.tb_especialidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.tb_salario.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.tb_numsala.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();


                }
                catch (Exception)
                {

                }
            }
            else if (cb_cargo.SelectedItem.ToString() == "Enfermeiros")
            {



                A_Funcionarios fromix = (A_Funcionarios)System.Windows.Forms.Application.OpenForms["A_Funcionarios"];
                try
                {
                    id = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_medico.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.dtp_datanasci.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value);
                    fromix.cb_genero.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.tb_nacionalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_natalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_fiscal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_cc.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    fromix.cb_estadocivil.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    fromix.tb_segu_social.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    fromix.tb_telefone.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    fromix.tb_email.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                    fromix.tb_codpostal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.dtp_validade.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[14].Value);
                    fromix.pb_foto.Image = (System.Drawing.Image)dgv_funcionarios.Rows[e.RowIndex].Cells[15].Value;
                    fromix.cb_cargo.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[16].Value.ToString();
                    fromix.idlast = Convert.ToInt32(dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value);
                    fromix.tb_especialidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.tb_salario.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.tb_numsala.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();


                }
                catch (Exception)
                {

                }
            }
            else if (cb_cargo.SelectedItem.ToString() == "Repecionistas")
            {




                A_Funcionarios fromix = (A_Funcionarios)System.Windows.Forms.Application.OpenForms["A_Funcionarios"];
                try
                {
                    id = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_medico.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.dtp_datanasci.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value);
                    fromix.cb_genero.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.tb_nacionalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_natalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_fiscal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_cc.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    fromix.cb_estadocivil.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    fromix.tb_segu_social.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    fromix.tb_telefone.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    fromix.tb_email.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                    fromix.tb_codpostal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.dtp_validade.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[14].Value);
                    fromix.pb_foto.Image = (System.Drawing.Image)dgv_funcionarios.Rows[e.RowIndex].Cells[15].Value;
                    fromix.cb_cargo.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[16].Value.ToString();
                    fromix.idlast = Convert.ToInt32(dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value);
                    fromix.tb_especialidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.tb_salario.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.tb_numsala.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();


                }
                catch (Exception)
                {

                }
            }
            else if (cb_cargo.SelectedItem.ToString() == "Laboratoristas")
            {


                A_Funcionarios fromix = (A_Funcionarios)System.Windows.Forms.Application.OpenForms["A_Funcionarios"];
                try
                {
                    id = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_medico.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.dtp_datanasci.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value);
                    fromix.cb_genero.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.tb_nacionalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_natalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_fiscal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_cc.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    fromix.cb_estadocivil.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    fromix.tb_segu_social.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    fromix.tb_telefone.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    fromix.tb_email.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                    fromix.tb_codpostal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.dtp_validade.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[14].Value);
                    fromix.pb_foto.Image = (System.Drawing.Image)dgv_funcionarios.Rows[e.RowIndex].Cells[15].Value;
                    fromix.cb_cargo.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[16].Value.ToString();
                    fromix.idlast = Convert.ToInt32(dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value);
                    fromix.tb_especialidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.tb_salario.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.tb_numsala.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();

            
                }
                catch (Exception)
                {

                }
            }
            else if (cb_cargo.SelectedItem.ToString() == "Não Docente")
            {
                A_Funcionarios fromix = (A_Funcionarios)System.Windows.Forms.Application.OpenForms["A_Funcionarios"];
                try
                {
          
                    id = dgv_funcionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fromix.tb_medico.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    fromix.dtp_datanasci.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[2].Value);
                    fromix.cb_genero.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fromix.tb_nacionalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                    fromix.tb_natalidade.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                    fromix.tb_fiscal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                    fromix.tb_cc.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                    fromix.cb_estadocivil.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                    fromix.tb_segu_social.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                    fromix.tb_telefone.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                    fromix.tb_email.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[11].Value.ToString();
                    fromix.tb_codpostal.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                    fromix.dtp_emissao_contrato.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[13].Value);
                    fromix.dtp_validade.Value = Convert.ToDateTime(dgv_funcionarios.Rows[e.RowIndex].Cells[14].Value);
                    fromix.pb_foto.Image = (System.Drawing.Image)dgv_funcionarios.Rows[e.RowIndex].Cells[15].Value;
                    fromix.cb_cargo.Text = dgv_funcionarios.Rows[e.RowIndex].Cells[16].Value.ToString();



                }
                catch (Exception)
                {

                }
        }
            
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
