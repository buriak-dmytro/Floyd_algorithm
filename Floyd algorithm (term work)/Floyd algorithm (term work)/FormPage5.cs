using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Floyd_algorythm__term_work_
{
    public partial class FormPage5 : Form
    {
        private int matrixSize;
        private int[,] matrixDataArray;
        private int[,] matrixShortestPaths;
        private int[] columnLength;
        private int[,] matrixSetHintsData;
        private int yCoordCurr = 6;

        public FormPage5(string[] matrixDataStrRows)
        {
            InitializeComponent();
            InitializeMatrixData(matrixDataStrRows);
        }

        private void InitializeMatrixData(string[] dataRaw)
        {
            matrixSize = dataRaw.Length;
            matrixDataArray = new int[matrixSize, matrixSize];
            matrixShortestPaths = new int[matrixSize, matrixSize];
            columnLength = new int[matrixSize];
            matrixSetHintsData = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                string[] dataRawNumbersInRow = Regex.Split(dataRaw[i], @"\s+");

                for (int j = 0; j < matrixSize; j++)
                {
                    string numberStr = dataRawNumbersInRow[j];

                    if (numberStr.Length > columnLength[j])
                    {
                        columnLength[j] = numberStr.Length;
                    }

                    if (!int.TryParse(numberStr, out matrixDataArray[i, j]))
                    {
                        matrixDataArray[i, j] = int.MaxValue;
                    }

                    matrixShortestPaths[i, j] = j;
                }
            }
        }

        private void FormPage5_Load(object sender, EventArgs e)
        {
            OutputMatrixData(ref yCoordCurr, this.PanelInitialMatrixData);

            yCoordCurr = 6;
        }

        private Label PlaceLabel(int i, int j, ref int xCoord, int yCoord, Panel panel)
        {
            Label labelTemp = new Label();
            labelTemp.TextAlign = ContentAlignment.MiddleCenter;
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
            labelTemp.MaximumSize = new Size(0, 18);
            labelTemp.Location = new Point(xCoord, yCoord);

            if (matrixSetHintsData[i, j] == 1)
            {
                labelTemp.BackColor = Color.Coral;
                toolTipShowShortestPath.SetToolTip(labelTemp, GenerateShortestPathRow(i, j));
                matrixSetHintsData[i, j] = 0;
            }

            panel.Controls.Add(labelTemp);

            xCoord += labelTemp.Size.Width + 6;

            return labelTemp;
        }

        private void OutputMatrixData(ref int yCoord, Panel panel)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                int xCoord = 6;

                for (int j = 0; j < matrixSize; j++)
                {
                    PlaceLabel(i, j, ref xCoord, yCoord, panel);
                }

                yCoord += 24;
            }

            yCoord += 24;
        }

        private void ButtonExecuteAlgorithm_Click(object sender, EventArgs e)
        {
            this.ButtonExecuteAlgorythm.Enabled = false;

            FloydAlgorithm();
        }

        private void FloydAlgorithm()
        {
            for (int k = 0; k < matrixSize; k++)
            {
                columnLength = new int[matrixSize];

                for (int i = 0; i < matrixSize; i++)
                {
                    for (int j = 0; j < matrixSize; j++)
                    {
                        if (matrixDataArray[i, k] != int.MaxValue & matrixDataArray[k, j] != int.MaxValue)
                        {
                            if (matrixDataArray[i, k] + matrixDataArray[k, j] < matrixDataArray[i, j])
                            {
                                matrixDataArray[i, j] = matrixDataArray[i, k] + matrixDataArray[k, j];
                                matrixShortestPaths[i, j] = matrixShortestPaths[i, k];
                                
                                matrixSetHintsData[i, j] = 1;
                            }
                        }

                        CheckChangeColumnLength(i, j);
                    }
                }

                OutputStageHeader(k);
                OutputMatrixData(ref yCoordCurr, PanelResultsOfWork);
                this.Refresh();
            }

            Label labelEmpty = new Label();
            labelEmpty.Location = new Point(0, yCoordCurr - 40);
            this.PanelResultsOfWork.Controls.Add(labelEmpty);
            yCoordCurr += 24;

            this.Refresh();
        }

        private void CheckChangeColumnLength(int i, int j)
        {
            int lengthTemp;
            if (matrixDataArray[i, j] == int.MaxValue)
                lengthTemp = 3;
            else
                lengthTemp = matrixDataArray[i, j].ToString().Length;

            if (lengthTemp > columnLength[j])
                columnLength[j] = lengthTemp;
        }

        private void OutputStageHeader(int k)
        {
            Label labelTemp = new Label();
            labelTemp.MinimumSize = new Size(285, 0);
            labelTemp.Text = $"Adjacency matrix after algorithm stage {k}:";
            labelTemp.Location = new Point(0, yCoordCurr);
            this.PanelResultsOfWork.Controls.Add(labelTemp);

            yCoordCurr += 24;
        }

        private string GenerateShortestPathRow(int i, int j)
        {
            string hintStr = "";
            int vertexCurr = i;

            hintStr += $"v[{i}]->({matrixDataArray[i, j]})->v[{j}] as ";

            hintStr += $"v[{vertexCurr}]";
            while (vertexCurr != j)
            {
                int left = vertexCurr;
                vertexCurr = matrixShortestPaths[vertexCurr, j];
                int right = vertexCurr;
                hintStr += $"->({matrixDataArray[left, right]})->v[{vertexCurr}]";
            }

            return hintStr;
        }

        private void ButtonAcceptResults_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
