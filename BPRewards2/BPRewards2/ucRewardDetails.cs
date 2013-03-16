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

            //Todo: Remove this from production
            DataTable dtp = DAL.GetProducts();
            DataTable dtc = DAL.GetCategories();
            DataTable dtb = DAL.GetProductRequirements();

            //end todo

            ucDataGridViewHelper1.dataGridView1.DataSource = dtp;
            ucDataGridViewHelper2.dataGridView1.DataSource = dtc;
            ucDataGridViewHelper3.dataGridView1.DataSource = dtb;

            

        }

        public void RewardDetailsClick(object sender, EventArgs e)
        {
            if (RewardDetailClicked != null) RewardDetailClicked(sender, e);

        }

        private void watermarkTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
