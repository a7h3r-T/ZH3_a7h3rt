using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();

        public UserControl2()
        {
            InitializeComponent();
            courseBindingSource.DataSource = context.Courses.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Course course = new Course
                    {
                        Name = form.textBox1.Text,
                        Code = form.textBox2.Text,
                    };

                    context.Add(course);
                    context.SaveChanges();
                    courseBindingSource.DataSource = context.Courses.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult kérdés = MessageBox.Show("Biztos törölni szeretnéd?", "Tuti?", MessageBoxButtons.YesNo);
            if (kérdés == DialogResult.Yes)
            {
                try
                {
                    var selected = ((Course)courseBindingSource.Current).CourseSk;
                    var törlendő = (from x in context.Courses
                                    where selected == x.CourseSk
                                    select x).FirstOrDefault();

                    context.Remove(törlendő);
                    context.SaveChanges();
                    courseBindingSource.DataSource = context.Courses.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
