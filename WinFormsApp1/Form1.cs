namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc = new UserControl1();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc = new UserControl2();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 uc = new UserControl3();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kérdés = MessageBox.Show("Biztos be szeretnéd zárni?", "Tuti?", MessageBoxButtons.YesNo);
            if (kérdés == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}