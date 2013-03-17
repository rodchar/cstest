using System;
using System.Data;
using System.Windows.Forms;

namespace BPRewards2
{
    public partial class ucRewardDetails : UserControl
    {
        public event EventHandler RewardDetailClicked;

        int _rewardId;

        public ucRewardDetails(int rewardId)
        {
            InitializeComponent();

            _rewardId = rewardId;

            LoadGridViews();
        }

        public void RewardDetailsClick(object sender, EventArgs e)
        {
            if (RewardDetailClicked != null) RewardDetailClicked(sender, e);

        }

        private void LoadGridViews()
        {
            ucDataGridViewHelper1.DataGridViewHelperClicked += DataGridViewHelperClicked;
            ucDataGridViewHelper2.DataGridViewHelperClicked += DataGridViewHelperClicked;
            ucDataGridViewHelper3.DataGridViewHelperClicked += DataGridViewHelperClicked;

            //Todo: Remove this from production
            DataTable dtp = DAL.GetProducts();
            DataTable dtc = DAL.GetCategories();
            DataTable dtb = DAL.GetProductRequirements();

            //end todo

            ucDataGridViewHelper1.dataGridView1.DataSource = dtp;
            ucDataGridViewHelper2.dataGridView1.DataSource = dtc;
            ucDataGridViewHelper3.dataGridView1.DataSource = dtb;

            ucDataGridViewHelper1.watermarkTextBox1.Text = "Product Search";
            ucDataGridViewHelper1.watermarkTextBox1.WatermarkText = "Product Search";
            ucDataGridViewHelper2.watermarkTextBox1.Text = "Category Search";
            ucDataGridViewHelper2.watermarkTextBox1.WatermarkText = "Category Search";
            ucDataGridViewHelper3.watermarkTextBox1.Text = "Requirements Search";
            ucDataGridViewHelper3.watermarkTextBox1.WatermarkText = "Requirements Search";

        }

        private void DataGridViewHelperClicked(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {

        }
    }
}
