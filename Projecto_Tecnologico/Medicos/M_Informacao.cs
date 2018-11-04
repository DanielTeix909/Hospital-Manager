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
namespace Projecto_Tecnologico.Medicos
{
    public partial class M_Informacao : Form
    {
        int move;
        int moveX;
        int moveY;

        public M_Informacao()
        {
            InitializeComponent();
        }

        private void M_Exames_Load(object sender, EventArgs e)
        {

            
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


        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            (dgv_funcionarios.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", tbPesquisa.Text);
        }

        private void grid_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cb_cargo.SelectedItem.ToString() == "Consultas")
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
            else if (cb_cargo.SelectedItem.ToString() == "Analises")
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


            else if (cb_cargo.SelectedItem.ToString() == "Receitas")
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
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

        private void b_min_Click(object sender, EventArgs e)
        {
            this.Hide();
            ((Gestor_Médicos)this.MdiParent).pn_informaçoes.Show();
        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
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
            if (cb_cargo.SelectedItem.ToString() == "Medicamentos")
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

        private void b_pesquisa_Click(object sender, EventArgs e)
        {

        }

        private void b_close_Click(object sender, EventArgs e)
        {
            ((Gestor_Médicos)this.MdiParent).M_informacoes.Enabled = true;
            this.Close();
        }
    }
}
