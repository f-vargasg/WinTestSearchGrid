using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
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

namespace WinTestSearchGrid
{
    public partial class FrmPrincTestSearch : Form
    {
        public FrmPrincTestSearch()
        {
            InitializeComponent();
        }

        private void butOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
            //solo los archivos excel
            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana
            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo
            //si al seleccionar el archivo damos Ok

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFileToImport.Text = dialog.FileName;
            }
        }

        private void butImportFile_Click(object sender, EventArgs e)
        {
            //DataSet ds = null;
            DataTable dt = new DataTable() ;
            DataRow dr;
            DataColumn idCoulumn;

            XSSFWorkbook hssfwb;
            try
            {
                using (FileStream file = new FileStream(txtFileToImport.Text, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new XSSFWorkbook(file);
                }

                XSSFFormulaEvaluator eval = new XSSFFormulaEvaluator(hssfwb);
                dt = new DataTable();
                // int maxColumns = 2;
                ISheet sheet = hssfwb.GetSheet("Sheet1");
                for (int row = 0; row <= sheet.LastRowNum; row++)
                {
                    #region processRows
                    if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
                    {
                        dr = dt.NewRow();
                        for (int ncol = 0; ncol < sheet.GetRow(row).LastCellNum; ncol++)
                        {
                            #region processColumns
                            ICell icel = sheet.GetRow(row).GetCell(ncol);
                            if (icel != null)
                            {
                                // string value = icel.StringCellValue;
                                #region process icel
                                string value = string.Empty;
                                switch (icel.CellType)
                                {
                                    case CellType.Unknown:
                                        break;
                                    case CellType.Numeric:
                                        value = icel.NumericCellValue.ToString();
                                        break;
                                    case CellType.String:
                                        value = icel.StringCellValue;
                                        break;
                                    case CellType.Formula:
                                        value = ProcessFormula(icel, eval);
                                        break;
                                    case CellType.Blank:
                                        value = string.Empty;
                                        break;
                                    case CellType.Boolean:
                                        value = (icel.BooleanCellValue ? "true" : "false");
                                        break;
                                    case CellType.Error:
                                        value = "Error";
                                        break;
                                    default:
                                        break;
                                }
                                #endregion process icel
                                string salida = string.Format("Row {0} = {1}", row, value);
                                Console.WriteLine(salida);
                                if (row == 0) // Header 
                                {
                                    idCoulumn = new DataColumn(value, Type.GetType("System.String"));
                                    dt.Columns.Add(idCoulumn);
                                }
                                else  // rows normales
                                {
                                    dr[ncol] = value;
                                }
                                // MessageBox.Show(salida);
                            }
                            #endregion processColumns
                        } // sheet.GetRow(row) != null
                        if (row != 0)
                        {
                            dt.Rows.Add(dr);
                        }
                        
                       
                        //MessageBox.Show(string.Format("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue));
                    }
                    #endregion processRows
                }

                // show datatable
                //ds.Tables.Add(dt);
                dgrData.AutoGenerateColumns = true;
                dgrData.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
            }
            
        }

        private static string ProcessFormula( ICell icel, 
                                              XSSFFormulaEvaluator eval)
        {
            string value;
            CellValue cv = eval.Evaluate(icel);
            value = string.Empty;
            switch (cv.CellType)
            {
                case CellType.Unknown:
                    break;
                case CellType.Numeric:
                    value = cv.NumberValue.ToString();
                    break;
                case CellType.String:
                    value = cv.StringValue;
                    break;
                case CellType.Formula:
                    break;
                case CellType.Blank:
                    break;
                case CellType.Boolean:
                    break;
                case CellType.Error:
                    break;
                default:
                    break;
            }

            return value;
        }

        private void buTestDataset_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt;
            DataRow dr;
            DataColumn idCoulumn;
            DataColumn nameCoulumn;
            int i = 0;

            dt = new DataTable();
            idCoulumn = new DataColumn("ID", Type.GetType("System.Int32"));
            nameCoulumn = new DataColumn("Name", Type.GetType("System.String"));

            dt.Columns.Add(idCoulumn);
            dt.Columns.Add(nameCoulumn);

            dr = dt.NewRow();
            dr["ID"] = 1;
            dr["Name"] = "Name1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ID"] = 2;
            dr["Name"] = "Name2";
            dt.Rows.Add(dr);

            ds.Tables.Add(dt);

            /*
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1]);
            }
            */

            DataTable dtAll = ds.Tables[0].Copy();
            for (i = 1; i < ds.Tables.Count; i++)
            {
                dtAll.Merge(ds.Tables[i]);
            }
            dgrData.AutoGenerateColumns = true;
            dgrData.DataSource = dtAll;

        }
    }
}
