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
            btnCheck = new Button();
            dgvJobs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(927, 12);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(288, 73);
            btnCheck.TabIndex = 0;
            btnCheck.Text = "Verificar API";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // dgvJobs
            // 
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(55, 101);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersWidth = 62;
            dgvJobs.RowTemplate.Height = 33;
            dgvJobs.Size = new Size(1127, 309);
            dgvJobs.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 450);
            Controls.Add(dgvJobs);
            Controls.Add(btnCheck);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheck;
        private DataGridView dgvJobs;
    }
}