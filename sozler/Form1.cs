namespace sozler
{
    public partial class Form1 : Form
    {
        private Note SelectedNote = null;
        public Form1()
        {
            InitializeComponent();
            Refresh();

        }
        public void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.Notes;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rchNote.Text))
            {
                var addedNote = new Note();
                addedNote.Description = rchNote.Text;
                var lastNote = DataStore.Notes[DataStore.Notes.Count - 1];
                addedNote.Id = lastNote.Id + 1;
                DataStore.Notes.Add(addedNote);
                Refresh();

                rchNote.Text = string.Empty;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                SelectedNote = (Note)listBox1.SelectedItem;
                rchNote.Text = SelectedNote.Description;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataStore.Notes.Remove(SelectedNote);
            SelectedNote = null;
            rchNote.Text = string.Empty;
            Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (rchNote.Text))
            {
                SelectedNote.Description = rchNote.Text;
                Refresh();
            }
        }
    }
}