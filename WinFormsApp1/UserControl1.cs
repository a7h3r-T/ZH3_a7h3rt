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
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();

        public UserControl1()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = context.Instructors.ToList();
            dayBindingSource.DataSource = context.Days.ToList();
            timeBindingSource.DataSource = context.Times.ToList();
            roomBindingSource.DataSource = context.Rooms.ToList();

            Szűrés();
            Betöltés();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Szűrés();
        }

        private void Szűrés()
        {
            listBox1.DataSource = (from x in context.Courses
                                   where x.Name.Contains(textBox1.Text)
                                   select x).ToList();
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Betöltés();
        }

        private void Betöltés()
        {
            var selected = (Course)listBox1.SelectedItem;
            lessonBindingSource.DataSource = (from x in context.Lessons
                                              where x.CourseFk == selected.CourseSk
                                              select x).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ManualAdd();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }   

        }

        private void ManualAdd()
        {
            if ((int)dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value == 0)
            {
                var selected = (Course)listBox1.SelectedItem;
                DataGridViewRow newrow = dataGridView1.Rows[dataGridView1.Rows.Count - 2];
                Lesson lesson = new Lesson
                {
                    CourseFk = selected.CourseSk,
                    InstructorFk = (int?)newrow.Cells[1].Value,
                    DayFk = (byte?)newrow.Cells[2].Value,
                    TimeFk = (byte?)newrow.Cells[3].Value,
                    RoomFk = (int?)newrow.Cells[4].Value,
                };

                context.Add(lesson);
                context.SaveChanges();
                Betöltés();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult kérdés = MessageBox.Show("Biztos törölni szeretnéd?", "Tuti?", MessageBoxButtons.YesNo);
            if (kérdés == DialogResult.Yes)
            {
                try
                {
                    var selected = ((Lesson)lessonBindingSource.Current).LessonSk;
                    var törlendő = (from x in context.Lessons
                                    where selected == x.LessonSk
                                    select x).FirstOrDefault();

                    context.Remove(törlendő);
                    context.SaveChanges();
                    Betöltés();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
