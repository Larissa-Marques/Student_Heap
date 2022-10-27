using GPA_Heap;

namespace Student_Success_Application
{
    public partial class Form1 : Form
    {
        Max_heap max_heap = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void insert_gpa_to_heap(decimal gpa) 
        { 
            if(max_heap == null)
            {
                Node root = new Node(gpa);
                max_heap = new Max_heap(root);
            }
            else max_heap.insert(new Node(gpa));
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            // When this button is cliked, the data will be displayed in the listview.
            int student_id = new Random().Next(10000000, 99999999);
            decimal gpa = Convert.ToDecimal(textBox_GPA.Text);

            // Adding to the heap
            insert_gpa_to_heap(gpa);

            string[] row = { student_id.ToString(), textBox_student_name.Text, comboBox_major.Text,
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will close the application.
            this.Close();
        }

        private void btn_max_gpa_Click(object sender, EventArgs e)
        {
            if (max_heap == null) MessageBox.Show("No Student Records Yet!");
            else MessageBox.Show(Convert.ToString(max_heap.root.data));
        }
    }
}