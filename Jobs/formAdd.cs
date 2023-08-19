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

            job.company = textBox2.Text;
            job.function = textBox3.Text;
            job.description = textBox6.Text;
            job.hoursPerWeek = Convert.ToInt32(textBox5.Text);
            job.payment = Convert.ToInt32(textBox4.Text);

            if (Config.edit = true)
            {
                job.id = Convert.ToInt32(textBox1.Text);
                api.UpdateJob(job);
            }
            else
            {
                api.AddJob(job);
            }



        }

        private void formAdd_Load(object sender, EventArgs e)
        {
            if (Config.edit)
            {
                textBox1.Text = Config.tempJob.ToString();
            }
        }

        private void formAdd_Leave(object sender, EventArgs e)
        {
            Config.tempJob = new Job();
            Config.edit = false;
        }
    }
}
