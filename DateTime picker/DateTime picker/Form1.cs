using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRezervacija_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            DateTime dt1 = DateTimePickerDatum.Value;
            StringBuilder sb1 = new StringBuilder();

            sb1.Append("Vaš datum leta je:\n");
            sb1.Append(dt1.ToShortDateString() + "\n");

            DateTime dt2 = DateTimePickerVrijeme.Value;
            sb1.Append("Vaše vrijeme polaska je:\n");
            sb1.Append(dt2.ToShortTimeString());

            richTextBox1.AppendText(sb1.ToString());
        }
    }
}
