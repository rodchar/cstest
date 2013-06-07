using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string ActiveTab = "Customers";

        public Form1()
        {
            InitializeComponent();
            ucListView1.DataGridViewCellDoubleClickEvent += ucListView1_DataGridViewCellDoubleClickEvent;
            ucDetailView1.DetailClickEvent += ucDetailView1_DetailClickEvent;

            LoadCustomers();
        }

        void ucDetailView1_DetailClickEvent(object sender, System.EventArgs e)
        {
            MessageBox.Show("Detail: " + ActiveTab);
        }

        private void LoadDetailView()
        {
            //Todo: 
        }

        void ucListView1_DataGridViewCellDoubleClickEvent(object sender, System.EventArgs e)
        {
            MessageBox.Show("List View: " + ActiveTab);
            LoadDetailView();
        }

        private void LoadListView()
        {
            switch (ActiveTab)
            {
                case "Customers":
                    LoadCustomers();
                    break;
                case "Rewards":
                    LoadRewards();
                    break;
                default:
                    break;
            }
        }

        private void LoadCustomers()
        {
            ucListView1.dataGridView1.DataSource = BLL.GetCustomers();

        }

        private void LoadRewards()
        {
            ucListView1.dataGridView1.DataSource = BLL.GetRewards();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Text)
            {
                case "Customers":
                    LoadCustomers();
                    break;
                case "Rewards":
                    LoadRewards();
                    break;
                default:
                    break;
            }

            ActiveTab = e.TabPage.Text;
        }
    }
}
