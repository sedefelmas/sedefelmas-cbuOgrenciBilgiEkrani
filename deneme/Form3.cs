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
    public partial class Form3 : Form
    {
        Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        public void onaylaButton_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            this.Close();
            
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anneGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
