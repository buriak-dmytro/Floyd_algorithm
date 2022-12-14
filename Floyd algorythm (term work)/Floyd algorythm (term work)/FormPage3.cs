using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Floyd_algorythm__term_work_
{
    public partial class FormPage3 : Form
    {
        public FormPage3()
        {
            InitializeComponent();
        }

        private void ButtonConfirmFilePath_Click(object sender, EventArgs e)
        {
            string filePath = TextBoxFilePath.Text;

            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            string matrixDataStrRow = streamReader.ReadToEnd();

            streamReader.Close();
            fileStream.Close();

            FormPage5 formPage5 = new FormPage5(matrixDataStrRow);

            this.Close();

            formPage5.Show();
        }
    }
}
