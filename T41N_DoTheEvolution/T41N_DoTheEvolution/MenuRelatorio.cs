using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace T41N_DoTheEvolution
{
    public partial class MenuRelatorio : Form
    {
        Principal principal;
        public MenuRelatorio(Principal _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void btnVoltarRelatorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarRelatorio_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void DGVrelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Listar()
        {
            try
            {
                SqlConnection connection = new
                               SqlConnection(Properties.Settings.Default.strConexao.ToString());

                SqlCommand command = new SqlCommand();
                command.CommandText = "ps_Relatorio";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;


                command.Parameters.AddWithValue("dataPeriodoInicial", dtpPeriodoInicial.Value);
                command.Parameters.AddWithValue("dataPeriodoFinal", dtpPeriodoFinal.Value);
                command.Parameters.AddWithValue("nomeCliente", txtClienteRelatorio.Text);
                command.Parameters.AddWithValue("nomeMotoboy", txtMotoboyRelatorio.Text);
                command.Parameters.AddWithValue("nomeFuncionario", txtFuncionarioRelatorio.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable ds = new DataTable();

                adapter.Fill(ds);

                DGVrelatorio.DataSource = ds;

            }
            catch (Exception ex) { lblMensagem.Text = ex.HResult + ":" + ex.Message; }


            

        }

        private void btnExportarRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirRelatorio_Click(object sender, EventArgs e)
        {


            if (DGVrelatorio.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {


                            PdfPTable pdfTable = new PdfPTable(DGVrelatorio.ColumnCount);

                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 90;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pdfTable.DefaultCell.BorderWidth = 1;
                            //Adding Header row
                            foreach (DataGridViewColumn column in DGVrelatorio.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                                pdfTable.AddCell(cell);
                            }

                            //Adding DataRow
                            foreach (DataGridViewRow row in DGVrelatorio.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfTable.AddCell("");

                                    }
                                    else
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());

                                    }


                                }
                            }



                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }




        }






        private void btnNovoRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void MenuRelatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
