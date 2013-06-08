using System;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
            tabControl1.Click += delegate { HandleSelectedTab(tabControl1.SelectedTab.Text); };
            tabControl2.Click += delegate { HandleSelectedTab(tabControl2.SelectedTab.Text); };

            //Todo: Load default tab here.
        }

        public void HandleSelectedTab(string tabName)
        {
            //http://stackoverflow.com/a/540075
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(tabName);
            theMethod.Invoke(this, null);
        }

        public void Customers()
        {
            MessageBox.Show("Customers tab");
        }

        public void Rewards()
        {
            MessageBox.Show("Rewards tab");

            HandleSelectedTab(tabControl2.SelectedTab.Text);
        }

        public void Requirements()
        {
            MessageBox.Show("Reward Requirements tab");
        }

        public void Actions()
        {
            MessageBox.Show("Reward Actions tab");
        }
    }
}
