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

        public FormPage5(string matrixDataStrRow)
        {
            InitializeComponent();
            this.matrixDataStrRow = matrixDataStrRow;
        }

        private void FormPage5_Load(object sender, EventArgs e)
        {
            Label lbNew = new Label();
            lbNew.Text = matrixDataStrRow /* "lbNew" */;
            PanelInitialMatrixData.Controls.Add(lbNew);
            toolTipShowShortestPath.SetToolTip(lbNew, "lbNew");
        }
    }
}
