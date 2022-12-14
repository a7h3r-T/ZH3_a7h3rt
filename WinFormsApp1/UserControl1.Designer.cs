namespace WinFormsApp1
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lessonSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.timeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 394);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonSkDataGridViewTextBoxColumn,
            this.instructorFkDataGridViewTextBoxColumn,
            this.dayFkDataGridViewTextBoxColumn,
            this.timeFkDataGridViewTextBoxColumn,
            this.roomFkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(161, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(566, 484);
            this.dataGridView1.TabIndex = 2;
            // 
            // lessonSkDataGridViewTextBoxColumn
            // 
            this.lessonSkDataGridViewTextBoxColumn.DataPropertyName = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.HeaderText = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.Name = "lessonSkDataGridViewTextBoxColumn";
            this.lessonSkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // instructorFkDataGridViewTextBoxColumn
            // 
            this.instructorFkDataGridViewTextBoxColumn.DataPropertyName = "InstructorFk";
            this.instructorFkDataGridViewTextBoxColumn.DataSource = this.instructorBindingSource;
            this.instructorFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.instructorFkDataGridViewTextBoxColumn.HeaderText = "InstructorFk";
            this.instructorFkDataGridViewTextBoxColumn.Name = "instructorFkDataGridViewTextBoxColumn";
            this.instructorFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.instructorFkDataGridViewTextBoxColumn.ValueMember = "InstructorSk";
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataSource = typeof(WinFormsApp1.Models.Instructor);
            // 
            // dayFkDataGridViewTextBoxColumn
            // 
            this.dayFkDataGridViewTextBoxColumn.DataPropertyName = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.DataSource = this.dayBindingSource;
            this.dayFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.dayFkDataGridViewTextBoxColumn.HeaderText = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.Name = "dayFkDataGridViewTextBoxColumn";
            this.dayFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dayFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dayFkDataGridViewTextBoxColumn.ValueMember = "DayId";
            // 
            // dayBindingSource
            // 
            this.dayBindingSource.DataSource = typeof(WinFormsApp1.Models.Day);
            // 
            // timeFkDataGridViewTextBoxColumn
            // 
            this.timeFkDataGridViewTextBoxColumn.DataPropertyName = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.DataSource = this.timeBindingSource;
            this.timeFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.timeFkDataGridViewTextBoxColumn.HeaderText = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.Name = "timeFkDataGridViewTextBoxColumn";
            this.timeFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.timeFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.timeFkDataGridViewTextBoxColumn.ValueMember = "TimeId";
            // 
            // timeBindingSource
            // 
            this.timeBindingSource.DataSource = typeof(WinFormsApp1.Models.Time);
            // 
            // roomFkDataGridViewTextBoxColumn
            // 
            this.roomFkDataGridViewTextBoxColumn.DataPropertyName = "RoomFk";
            this.roomFkDataGridViewTextBoxColumn.DataSource = this.roomBindingSource;
            this.roomFkDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.roomFkDataGridViewTextBoxColumn.HeaderText = "RoomFk";
            this.roomFkDataGridViewTextBoxColumn.Name = "roomFkDataGridViewTextBoxColumn";
            this.roomFkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomFkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roomFkDataGridViewTextBoxColumn.ValueMember = "RoomSk";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(WinFormsApp1.Models.Room);
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataSource = typeof(WinFormsApp1.Models.Lesson);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(3, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Változások mentése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(3, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Törlés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(730, 490);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn lessonSkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn instructorFkDataGridViewTextBoxColumn;
        private BindingSource instructorBindingSource;
        private DataGridViewComboBoxColumn dayFkDataGridViewTextBoxColumn;
        private BindingSource dayBindingSource;
        private DataGridViewComboBoxColumn timeFkDataGridViewTextBoxColumn;
        private BindingSource timeBindingSource;
        private DataGridViewComboBoxColumn roomFkDataGridViewTextBoxColumn;
        private BindingSource roomBindingSource;
        private BindingSource lessonBindingSource;
    }
}
