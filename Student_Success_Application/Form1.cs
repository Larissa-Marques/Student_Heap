using System.Windows.Forms.VisualStyles;

namespace Student_Success_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            // When this button is cliked, the data will be displayed in the listview.
            string[] row = { textBox_student_name.Text, comboBox_major.Text,
                    comboBox_year.Text, textBox_GPA.Text};
            ListViewItem listViewItem = new ListViewItem(row);
            listView_students.Items.Add(listViewItem);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // When this button is clicked, the info will be erased.
            textBox_student_name.Text = "";
            comboBox_major.Text = "";
            comboBox_year.Text = "";
            textBox_GPA.Text = "";
            }

        private void btn_remove_record_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will remove all the selected information.
            if (listView_students.SelectedItems.Count > 0)
            {
                listView_students.Items.Remove(listView_students.SelectedItems[0]);
            }
        }
    }
}