using Jobs.Api;

namespace Jobs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ApiBase api = new ApiBase();

            bool result = api.Check();

            if (result)
            {
                MessageBox.Show("Conectividade ok");
            }
            else
            {
                MessageBox.Show("Erro");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadJobs();
        }

        private void LoadJobs()
        {
            ApiJob api = new ApiJob();
            dgvJobs.DataSource = api.GetAllJobs();
        }
    }
}