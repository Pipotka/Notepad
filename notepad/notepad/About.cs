namespace notepad
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
