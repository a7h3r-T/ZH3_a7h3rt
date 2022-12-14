using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel= true;
                button1.Enabled = false;
                errorProvider1.SetError(textBox1, "Nem lehet üres!");
            }
  
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            button1.Enabled = true;
            errorProvider1.SetError(textBox1, string.Empty);
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("^[A-Z0-9]{10}$");
            if (!r.IsMatch(textBox2.Text))
            {
                e.Cancel = true;
                button1.Enabled = false;
                errorProvider1.SetError(textBox2, "Csak nagy betű és szám lehet benne! Illetve Pontosan 10 karakternek kell lennie!");
            }  
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            button1.Enabled= true;
            errorProvider1.SetError(textBox2, string.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
