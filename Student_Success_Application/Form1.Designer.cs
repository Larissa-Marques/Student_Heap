namespace Student_Success_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_students = new System.Windows.Forms.ListView();
            this.columnH_StudentID = new System.Windows.Forms.ColumnHeader();
            this.columnH_student_name = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Major = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_year = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_GPA = new System.Windows.Forms.ColumnHeader();
            this.lbl_percentage = new System.Windows.Forms.Label();
            this.textBox_percentage = new System.Windows.Forms.TextBox();
            this.lbl_student_name = new System.Windows.Forms.Label();
            this.textBox_student_name = new System.Windows.Forms.TextBox();
            this.lbl_major = new System.Windows.Forms.Label();
            this.comboBox_major = new System.Windows.Forms.ComboBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.lbl_GPA = new System.Windows.Forms.Label();
            this.textBox_GPA = new System.Windows.Forms.TextBox();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_remove_record = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_students
            // 
            this.listView_students.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnH_StudentID,
            this.columnH_student_name,
            this.columnHeader_Major,
            this.columnHeader_year,
            this.columnHeader_GPA});
            this.listView_students.Location = new System.Drawing.Point(12, 227);
            this.listView_students.Name = "listView_students";
            this.listView_students.Size = new System.Drawing.Size(766, 280);
            this.listView_students.TabIndex = 0;
            this.listView_students.UseCompatibleStateImageBehavior = false;
            this.listView_students.View = System.Windows.Forms.View.Details;
            // 
            // columnH_StudentID
            // 
            this.columnH_StudentID.Text = "Student ID";
            this.columnH_StudentID.Width = 150;
            // 
            // columnH_student_name
            // 
            this.columnH_student_name.Text = "Student Name";
            this.columnH_student_name.Width = 200;
            // 
            // columnHeader_Major
            // 
            this.columnHeader_Major.Text = "Major";
            this.columnHeader_Major.Width = 150;
            // 
            // columnHeader_year
            // 
            this.columnHeader_year.Text = "Year";
            this.columnHeader_year.Width = 150;
            // 
            // columnHeader_GPA
            // 
            this.columnHeader_GPA.Text = "GPA";
            this.columnHeader_GPA.Width = 100;
            // 
            // lbl_percentage
            // 
            this.lbl_percentage.AutoSize = true;
            this.lbl_percentage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_percentage.Location = new System.Drawing.Point(416, 83);
            this.lbl_percentage.Name = "lbl_percentage";
            this.lbl_percentage.Size = new System.Drawing.Size(137, 17);
            this.lbl_percentage.TabIndex = 1;
            this.lbl_percentage.Text = "Enter Percentage";
            // 
            // textBox_percentage
            // 
            this.textBox_percentage.Location = new System.Drawing.Point(566, 78);
            this.textBox_percentage.Name = "textBox_percentage";
            this.textBox_percentage.Size = new System.Drawing.Size(125, 27);
            this.textBox_percentage.TabIndex = 2;
            // 
            // lbl_student_name
            // 
            this.lbl_student_name.AutoSize = true;
            this.lbl_student_name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_student_name.Location = new System.Drawing.Point(28, 24);
            this.lbl_student_name.Name = "lbl_student_name";
            this.lbl_student_name.Size = new System.Drawing.Size(110, 17);
            this.lbl_student_name.TabIndex = 3;
            this.lbl_student_name.Text = "Student Name";
            // 
            // textBox_student_name
            // 
            this.textBox_student_name.Location = new System.Drawing.Point(153, 19);
            this.textBox_student_name.Name = "textBox_student_name";
            this.textBox_student_name.Size = new System.Drawing.Size(125, 27);
            this.textBox_student_name.TabIndex = 4;
            // 
            // lbl_major
            // 
            this.lbl_major.AutoSize = true;
            this.lbl_major.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_major.Location = new System.Drawing.Point(28, 63);
            this.lbl_major.Name = "lbl_major";
            this.lbl_major.Size = new System.Drawing.Size(49, 17);
            this.lbl_major.TabIndex = 5;
            this.lbl_major.Text = "Major";
            // 
            // comboBox_major
            // 
            this.comboBox_major.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_major.FormattingEnabled = true;
            this.comboBox_major.Items.AddRange(new object[] {
            "",
            "Business",
            "Engineering",
            "Nursing",
            "Communication",
            "Economics"});
            this.comboBox_major.Location = new System.Drawing.Point(153, 58);
            this.comboBox_major.Name = "comboBox_major";
            this.comboBox_major.Size = new System.Drawing.Size(151, 28);
            this.comboBox_major.TabIndex = 6;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_year.Location = new System.Drawing.Point(27, 104);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(42, 17);
            this.lbl_year.TabIndex = 7;
            this.lbl_year.Text = "Year";
            // 
            // comboBox_year
            // 
            this.comboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Items.AddRange(new object[] {
            "",
            "Freshmen",
            "Sophomore",
            "Junior",
            "Senior",
            "Graduate"});
            this.comboBox_year.Location = new System.Drawing.Point(153, 99);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(151, 28);
            this.comboBox_year.TabIndex = 8;
            // 
            // lbl_GPA
            // 
            this.lbl_GPA.AutoSize = true;
            this.lbl_GPA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_GPA.Location = new System.Drawing.Point(27, 147);
            this.lbl_GPA.Name = "lbl_GPA";
            this.lbl_GPA.Size = new System.Drawing.Size(41, 17);
            this.lbl_GPA.TabIndex = 9;
            this.lbl_GPA.Text = "GPA";
            // 
            // textBox_GPA
            // 
            this.textBox_GPA.Location = new System.Drawing.Point(153, 142);
            this.textBox_GPA.Name = "textBox_GPA";
            this.textBox_GPA.Size = new System.Drawing.Size(125, 27);
            this.textBox_GPA.TabIndex = 10;
            // 
            // btn_add_student
            // 
            this.btn_add_student.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_student.Location = new System.Drawing.Point(27, 182);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(131, 29);
            this.btn_add_student.TabIndex = 11;
            this.btn_add_student.Text = "Add Student";
            this.btn_add_student.UseVisualStyleBackColor = true;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(173, 182);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(131, 29);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_remove_record
            // 
            this.btn_remove_record.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remove_record.Location = new System.Drawing.Point(416, 182);
            this.btn_remove_record.Name = "btn_remove_record";
            this.btn_remove_record.Size = new System.Drawing.Size(137, 29);
            this.btn_remove_record.TabIndex = 13;
            this.btn_remove_record.Text = "Remove Record";
            this.btn_remove_record.UseVisualStyleBackColor = true;
            this.btn_remove_record.Click += new System.EventHandler(this.btn_remove_record_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(566, 182);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(125, 29);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_remove_record);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_student);
            this.Controls.Add(this.textBox_GPA);
            this.Controls.Add(this.lbl_GPA);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.comboBox_major);
            this.Controls.Add(this.lbl_major);
            this.Controls.Add(this.textBox_student_name);
            this.Controls.Add(this.lbl_student_name);
            this.Controls.Add(this.textBox_percentage);
            this.Controls.Add(this.lbl_percentage);
            this.Controls.Add(this.listView_students);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView_students;
        private Label lbl_percentage;
        private TextBox textBox_percentage;
        private ColumnHeader columnH_StudentID;
        private ColumnHeader columnH_student_name;
        private ColumnHeader columnHeader_Major;
        private ColumnHeader columnHeader_year;
        private ColumnHeader columnHeader_GPA;
        private Label lbl_student_name;
        private TextBox textBox_student_name;
        private Label lbl_major;
        private ComboBox comboBox_major;
        private Label lbl_year;
        private ComboBox comboBox_year;
        private Label lbl_GPA;
        private TextBox textBox_GPA;
        private Button btn_add_student;
        private Button btn_clear;
        private Button btn_remove_record;
        private Button btn_close;
    }
}