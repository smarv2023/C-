namespace AssignmentForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "New File";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Open ..";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "File Saved";
        }

        private void savToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Save As..";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "New File";
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Open ..";
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "File Saved";
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
