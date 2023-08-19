using Jobs.Api;
using Jobs.Global;
using Jobs.Models;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAdd frm = new formAdd();
            frm.Show();
        }

        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ApiJob api = new ApiJob();
                int id = Convert.ToInt32(dgvJobs.Rows[dgvJobs.CurrentRow.Index].Cells["id"].Value);

                if (e.ColumnIndex == dgvJobs.Columns["Editar"].Index)
                {
                    Config.edit = true;
                    Config.tempJob = api.GetJob(id);

                    formAdd edit = new formAdd();
                    edit.ShowDialog();

                }
                else if (e.ColumnIndex == dgvJobs.Columns["Deletar"].Index)
                {
                    DialogResult dialogResult = MessageBox.Show(
                    "Comfirma Exclusão", "Excluir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {

                        bool response = api.DeleteJob(id);

                        if (response)
                        {
                            LoadJobs();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao tentar excluir");
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }
    }
}