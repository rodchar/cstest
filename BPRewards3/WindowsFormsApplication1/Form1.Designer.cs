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
            this.tpRewards = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpSpinner = new System.Windows.Forms.TabPage();
            this.tbApiCalls = new System.Windows.Forms.TabPage();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tpRewards.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRewards);
            this.tabControl1.Controls.Add(this.tpCustomers);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRewards
            // 
            this.tpRewards.Controls.Add(this.tabControl2);
            this.tpRewards.Location = new System.Drawing.Point(4, 22);
            this.tpRewards.Name = "tpRewards";
            this.tpRewards.Padding = new System.Windows.Forms.Padding(3);
            this.tpRewards.Size = new System.Drawing.Size(654, 329);
            this.tpRewards.TabIndex = 0;
            this.tpRewards.Text = "Rewards";
            this.tpRewards.UseVisualStyleBackColor = true;
            this.tpRewards.Click += new System.EventHandler(this.tpRewards_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpSpinner);
            this.tabControl2.Controls.Add(this.tbApiCalls);
            this.tabControl2.Location = new System.Drawing.Point(60, 57);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(497, 253);
            this.tabControl2.TabIndex = 0;
            // 
            // tpSpinner
            // 
            this.tpSpinner.Location = new System.Drawing.Point(4, 22);
            this.tpSpinner.Name = "tpSpinner";
            this.tpSpinner.Padding = new System.Windows.Forms.Padding(3);
            this.tpSpinner.Size = new System.Drawing.Size(489, 227);
            this.tpSpinner.TabIndex = 0;
            this.tpSpinner.Text = "Spinner";
            this.tpSpinner.UseVisualStyleBackColor = true;
            this.tpSpinner.Click += new System.EventHandler(this.tpSpinner_Click);
            // 
            // tbApiCalls
            // 
            this.tbApiCalls.Location = new System.Drawing.Point(4, 22);
            this.tbApiCalls.Name = "tbApiCalls";
            this.tbApiCalls.Padding = new System.Windows.Forms.Padding(3);
            this.tbApiCalls.Size = new System.Drawing.Size(489, 227);
            this.tbApiCalls.TabIndex = 1;
            this.tbApiCalls.Text = "APIs";
            this.tbApiCalls.UseVisualStyleBackColor = true;
            this.tbApiCalls.Click += new System.EventHandler(this.tbApiCalls_Click);
            // 
            // tpCustomers
            // 
            this.tpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tpCustomers.Name = "tpCustomers";
            this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomers.Size = new System.Drawing.Size(654, 329);
            this.tpCustomers.TabIndex = 1;
            this.tpCustomers.Text = "Customers";
            this.tpCustomers.UseVisualStyleBackColor = true;
            this.tpCustomers.Click += new System.EventHandler(this.tpCustomers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpRewards.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRewards;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpSpinner;
        private System.Windows.Forms.TabPage tbApiCalls;
        private System.Windows.Forms.TabPage tpCustomers;
    }
}

