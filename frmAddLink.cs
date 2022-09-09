namespace SIDM
{
    public partial class frmAddLink : Form
    {
        public string Link = "";
        public frmAddLink()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            GC.Collect();
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            Link = txtDownloadLink.Text;
            DialogResult = DialogResult.OK;
            this.Close();
            GC.Collect();
        }

    }
}
