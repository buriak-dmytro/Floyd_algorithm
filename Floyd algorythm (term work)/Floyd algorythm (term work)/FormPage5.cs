using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floyd_algorythm__term_work_
{
    public partial class FormPage5 : Form
    {
        private string matrixDataStrRow;
        private int[,] matrixDataArray;

        public FormPage5(string matrixDataStrRow)
        {
            InitializeComponent();

            this.matrixDataStrRow = matrixDataStrRow;
            FillMatrixDataArray();


        }

        private void FillMatrixDataArray()
        {
            string[] matrixDataStrRowsArray = matrixDataStrRow.Split('\n');

            for (int i = 0; i < matrixDataStrRowsArray.Length; i++)
            {
                string[] matrixDataStrNumbersArray = matrixDataStrRowsArray[i].Split(' ');

                for (int j = 0; j < matrixDataStrNumbersArray.Length; j++)
                {
                    string numberStr = matrixDataStrNumbersArray[j].Trim(' ');

                    matrixDataArray[i, j] = int.Parse(numberStr);
                }
            }
        }

        private void FormPage5_Load(object sender, EventArgs e)
        {
            Label lbNew = new Label();
            lbNew.Text = matrixDataArray[1, 1].ToString();
            PanelInitialMatrixData.Controls.Add(lbNew);
            toolTipShowShortestPath.SetToolTip(lbNew, "[1, 1]");
        }
    }
}
