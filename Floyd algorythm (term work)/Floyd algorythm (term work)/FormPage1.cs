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
    public partial class FormPage1 : Form
    {
        public FormPage1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            FormPage2 formPage2 = new FormPage2();
            formPage2.Show();
        }

        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
