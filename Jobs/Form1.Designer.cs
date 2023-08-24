namespace Jobs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvJobs = new DataGridView();
            btnAdd = new Button();
            id = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            function = new DataGridViewTextBoxColumn();
            payment = new DataGridViewTextBoxColumn();
            Horas = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Deletar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // dgvJobs
            // 
            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.AllowUserToDeleteRows = false;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Columns.AddRange(new DataGridViewColumn[] { id, Company, function, payment, Horas, Descricao, Editar, Deletar });
            dgvJobs.Location = new Point(34, 82);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.ReadOnly = true;
            dgvJobs.RowHeadersWidth = 62;
            dgvJobs.RowTemplate.Height = 33;
            dgvJobs.Size = new Size(1121, 352);
            dgvJobs.TabIndex = 1;
            dgvJobs.CellClick += dgvJobs_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1043, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 150;
            // 
            // Company
            // 
            Company.DataPropertyName = "company";
            Company.HeaderText = "Company";
            Company.MinimumWidth = 8;
            Company.Name = "Company";
            Company.ReadOnly = true;
            Company.Width = 150;
            // 
            // function
            // 
            function.DataPropertyName = "function";
            function.HeaderText = "Function";
            function.MinimumWidth = 8;
            function.Name = "function";
            function.ReadOnly = true;
            function.Width = 150;
            // 
            // payment
            // 
            payment.DataPropertyName = "payment";
            payment.HeaderText = "Payment";
            payment.MinimumWidth = 8;
            payment.Name = "payment";
            payment.ReadOnly = true;
            payment.Width = 150;
            // 
            // Horas
            // 
            Horas.DataPropertyName = "hoursPerWeek";
            Horas.HeaderText = "HoursPerWeek";
            Horas.MinimumWidth = 8;
            Horas.Name = "Horas";
            Horas.ReadOnly = true;
            Horas.Width = 150;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "description";
            Descricao.HeaderText = "Description";
            Descricao.MinimumWidth = 8;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 150;
            // 
            // Deletar
            // 
            Deletar.HeaderText = "";
            Deletar.MinimumWidth = 8;
            Deletar.Name = "Deletar";
            Deletar.ReadOnly = true;
            Deletar.Text = "Deletar";
            Deletar.UseColumnTextForButtonValue = true;
            Deletar.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 469);
            Controls.Add(btnAdd);
            Controls.Add(dgvJobs);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvJobs;
        private Button btnAdd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn function;
        private DataGridViewTextBoxColumn payment;
        private DataGridViewTextBoxColumn Horas;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Deletar;
    }
}