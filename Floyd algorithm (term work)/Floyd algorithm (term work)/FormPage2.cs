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
    public partial class FormPage2 : Form
    {
        public FormPage2()
        {
            InitializeComponent();
        }

        private void ButtonFile_Click(object sender, EventArgs e)
        {
            FormPage3 formPage3 = new FormPage3();
            this.Close();
            formPage3.Show();
        }

        private void ButtonManualInput_Click(object sender, EventArgs e)
        {
            FormPage4 formPage4 = new FormPage4();
            this.Close();
            formPage4.Show();
        }
    }
}
