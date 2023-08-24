using Jobs.Api;
using System;
using Jobs.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jobs.Global;

namespace Jobs
{
    public partial class formAdd : Form
    {
        public formAdd()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            ApiJob api = new ApiJob();

            job.company = txtCompany.Text;
            job.function = txtFunction.Text;
            job.description = txtDesc.Text;
            job.hoursPerWeek = Convert.ToInt32(txtHours.Text);
            job.payment = Convert.ToInt32(txtPayment.Text);

            if (Config.edit == true)
            {
                job.id = Convert.ToInt32(txtId.Text);
                api.UpdateJob(job);
                Close();
            }
            else
            {
                api.AddJob(job);
                Close();
            }



        }

        private void formAdd_Load(object sender, EventArgs e)
        {
            if (Config.edit)
            {
                txtId.Text = Config.tempJob.id.ToString();
                txtCompany.Text = Config.tempJob.company;
                txtDesc.Text = Config.tempJob.description;
                txtFunction.Text = Config.tempJob.function;
                txtHours.Text = Config.tempJob.hoursPerWeek.ToString();
                txtPayment.Text = Config.tempJob.payment.ToString();
            }
        }

        private void formAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.tempJob = new Job();
            Config.edit = false;
        }
    }
}
