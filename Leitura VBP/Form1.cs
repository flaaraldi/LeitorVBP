using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Leitura_VBP
{
    public partial class Form1 : Form
    {
        string caminho = string.Empty;
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            openFile.Filter = "(*.vbp)|*.vbp";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gcPrinc.DataSource = null;
            dt.Columns.Add(" ", typeof(bool));
            dt.Columns.Add("Tipo");
            dt.Columns[1].ReadOnly = true;
            dt.Columns.Add("Nome"); 
            dt.Columns[2].ReadOnly = true;

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                caminho = openFile.FileName.Substring(0,openFile.FileName.LastIndexOf("\\"));
                System.IO.StreamReader sr = new System.IO.StreamReader(openFile.FileName, Encoding.Default);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if ((line.ToLower().Contains(".frm")) || (line.ToLower().Contains(".bas")) || (line.ToLower().Contains(".cls")))
                    {
                        if (line.ToLower().Contains("form="))
                            dt.Rows.Add(true, "Formulario", line.Replace("Form=", ""));
                        else if (line.ToLower().Contains("class="))
                            dt.Rows.Add(true, "Classe", line.Split(';')[1].ToString().Trim());
                        else if (line.ToLower().Contains("module="))
                            dt.Rows.Add(true, "Modulo", line.Split(';')[1].ToString().Trim());
                    }
                }

                gcPrinc.DataSource = dt;
                btnMarcar.Visible = true;

                sr.Close();
            }
            
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in dt.Rows)
	        {
		        item[0] = !(bool)item[0];
	        }
            dataGridView1.DataSource = dt;

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //   //(row.Cells[0] as DataGridViewCheckBoxCell).Value = !(bool)(row.Cells[0] as DataGridViewCheckBoxCell).Value;

            //   DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
            //   chk.Value = !(chk.Value == null ? false : (bool)chk.Value);

            //}
        }

        private void tbnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog salvar = new SaveFileDialog(); // novo 

                Excel.Application App; // Aplicação Excel
                Excel.Workbook WorkBook; // Pasta
                Excel.Worksheet WorkSheet; // Planilha
                object misValue = System.Reflection.Missing.Value;

                App = new Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);

                // passa as celulas do DataGridView para a Pasta do Excel
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 1; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dataGridView1[j, i];
                        WorkSheet.Cells[i + 1, j] = cell.Value;
                    }
                }

                // define algumas propriedades da caixa salvar
                salvar.Title = "Exportar para Excel";
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                salvar.ShowDialog(); // mostra

                // salva o arquivo
                if (salvar.CheckFileExists)
                {
                    WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                        Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    WorkBook.Close(true, misValue, misValue);
                    App.Quit(); // encerra o excel

                    MessageBox.Show("Exportado com sucesso!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Mensagem: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if ((bool)dataGridView1[0, i].Value)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(caminho + "\\" + dataGridView1[2, i].Value.ToString(), Encoding.Default );
                    string line = sr.ReadToEnd();
                    sr.Close();

                    line = line.Replace(txtLocalizar.Text, txtSubstituir.Text);
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(caminho + "\\" + dataGridView1[2, i].Value.ToString(),false, Encoding.Default);
                    sw.Write(line);

                    sw.Close();
                }
            }

            panel1.Visible = false;
        }
    }
}
