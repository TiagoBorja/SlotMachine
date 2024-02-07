using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 novoForm = new Form2();        
            novoForm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 novoForm = new Form3();
            novoForm.Show();
            this.Hide();
        }
    }
}
