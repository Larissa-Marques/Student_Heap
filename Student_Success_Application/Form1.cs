using Student_Heap;

namespace Student_Success_Application
{
    public partial class Form1 : Form
    {
        Max_heap heap = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void insert_student_to_heap(int sid) { 
            if(heap == null)
            {
                Node root = new Node(sid);
                heap = new Max_heap(root);
            }
            else
            {
                heap.insert(new Node(sid));
                heap.bfs_traversal();
            }
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            // When this button is cliked, the data will be displayed in the listview.
            int student_id = new Random().Next(10000000, 99999999);
            int gpa = Convert.ToInt32(textBox_GPA.Text);

            // Adding to the heap
            insert_student_to_heap(gpa);

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

        private void btn_remove_record_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will remove all the selected information.
            if (listView_students.SelectedItems.Count > 0)
            {
                listView_students.Items.Remove(listView_students.SelectedItems[0]);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            // When this button is clicked, it will close the application.
            this.Close();
        }
    }
}