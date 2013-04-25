namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.tpRewards = new System.Windows.Forms.TabPage();
            this.ucListView1 = new WindowsFormsApplication1.ucListView();
            this.ucDetailView1 = new WindowsFormsApplication1.ucDetailView();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCustomers);
            this.tabControl1.Controls.Add(this.tpRewards);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpCustomers
            // 
            this.tpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tpCustomers.Name = "tpCustomers";
            this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomers.Size = new System.Drawing.Size(192, 74);
            this.tpCustomers.TabIndex = 0;
            this.tpCustomers.Text = "Customers";
            this.tpCustomers.UseVisualStyleBackColor = true;
            // 
            // tpRewards
            // 
            this.tpRewards.Location = new System.Drawing.Point(4, 22);
            this.tpRewards.Name = "tpRewards";
            this.tpRewards.Padding = new System.Windows.Forms.Padding(3);
            this.tpRewards.Size = new System.Drawing.Size(192, 74);
            this.tpRewards.TabIndex = 1;
            this.tpRewards.Text = "Rewards";
            this.tpRewards.UseVisualStyleBackColor = true;
            // 
            // ucListView1
            // 
            this.ucListView1.DataRowViewSelected = null;
            this.ucListView1.DataSource = null;
            this.ucListView1.Location = new System.Drawing.Point(74, 133);
            this.ucListView1.Name = "ucListView1";
            this.ucListView1.Size = new System.Drawing.Size(559, 322);
            this.ucListView1.TabIndex = 1;
            // 
            // ucDetailView1
            // 
            this.ucDetailView1.Location = new System.Drawing.Point(407, 22);
            this.ucDetailView1.Name = "ucDetailView1";
            this.ucDetailView1.Size = new System.Drawing.Size(150, 150);
            this.ucDetailView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 483);
            this.Controls.Add(this.ucDetailView1);
            this.Controls.Add(this.ucListView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCustomers;
        private System.Windows.Forms.TabPage tpRewards;
        private ucListView ucListView1;
        private ucDetailView ucDetailView1;
    }
}

