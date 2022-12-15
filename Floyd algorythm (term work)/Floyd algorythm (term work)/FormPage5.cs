using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices; /* !!! */
using System.Text.RegularExpressions;

namespace Floyd_algorythm__term_work_
{
    public partial class FormPage5 : Form
    {
        /* !!! */
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();
        /* !!! */

        private int[,] matrixDataArray;
        private int yBlockStart = 0;
        private int[] columnLength;

        public FormPage5(string[] matrixDataStrRows)
        {
            InitializeComponent();
            FillMatrixDataArray(matrixDataStrRows);
        }

        private void FillMatrixDataArray(string[] dataRaw)
        {
            //AllocConsole(); /* !!! */

            matrixDataArray = new int[dataRaw.Length, dataRaw.Length];
            columnLength = new int[dataRaw.Length];

            for (int i = 0; i < dataRaw.Length; i++)
            {
                string[] dataRawNumbersInRow = Regex.Split(dataRaw[i], @"\s+");

                for (int j = 0; j < dataRawNumbersInRow.Length; j++)
                {
                    string numberStr = dataRawNumbersInRow[j];

                    //Console.WriteLine(numberStr.Length);
                    //Console.WriteLine("/");

                    if (numberStr.Length > columnLength[j])
                    {
                        columnLength[j] = numberStr.Length;
                    }

                    if (!int.TryParse(numberStr, out matrixDataArray[i, j]))
                    {
                        matrixDataArray[i, j] = int.MaxValue;
                    }

                    //Console.WriteLine(matrixDataArray[i, j]);
                    //Console.WriteLine();
                }

                //Console.WriteLine();
            }

            //for (int j = 0; j < matrixDataArray.GetLength(1); j++)
            //{
            //    Console.Write(columnLength[j] + " ");
            //}
        }

        private void FormPage5_Load(object sender, EventArgs e)
        {
            OutputMatrixData(ref yBlockStart, this.PanelInitialMatrixData);

            yBlockStart = 0;
        }
        
        private void OutputMatrixData(ref int yCoord, Panel panel)
        {
            for (int i = 0; i < matrixDataArray.GetLength(0); i++)
            {
                int xCoord = 0;

                for (int j = 0; j < matrixDataArray.GetLength(1); j++)
                {
                    Label labelTemp = new Label();
                    labelTemp.Font = new Font("Lucida Console", 10);

                    if (matrixDataArray[i, j] == int.MaxValue)
                    {
                        labelTemp.Text = "inf";
                    }
                    else
                    {
                        labelTemp.Text = matrixDataArray[i, j].ToString();
                    }
                    
                    labelTemp.MinimumSize = new Size(7 + 10 * columnLength[j], 0);
                    labelTemp.MaximumSize = new Size(0, 11);
                    labelTemp.Location = new Point(xCoord, yCoord);

                    panel.Controls.Add(labelTemp);

                    xCoord += labelTemp.Size.Width;
                }

                yCoord += 24;
            }
        }

        private void ButtonExecuteAlgorythm_Click(object sender, EventArgs e)
        {
            // method(1)
        }

        // method (1) which runs Floyd algorythm and output each of its stage

        private void ButtonAcceptResults_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
