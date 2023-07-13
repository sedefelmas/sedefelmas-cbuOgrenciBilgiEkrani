using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kardesSayısıValue_TextChanged(object sender, EventArgs e)
        {

        }

        public void kaydetButonu_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
            this.Close();
        }

        private void anneCepTelefonu_Click(object sender, EventArgs e)
        {

        }

        private void anneSigortaEvet_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
