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
    public partial class FormPage4 : Form
    {
        public FormPage4()
        {
            InitializeComponent();
        }

        private void ButtonConfirmMatrixData_Click(object sender, EventArgs e)
        {
            string[] matrixDataStrRows = Regex.Split(RichTextBoxMatrixData.Text, @"\n");

            FormPage5 formPage5 = new FormPage5(matrixDataStrRows);
            formPage5.Show();

            this.Close();
        }
    }
}
