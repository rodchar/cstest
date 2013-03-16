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
            DataSet ds = DAL.GetData();
            DataTable dt = ds.Tables[0];
            //end todo

            ucDataGridViewHelper1.dataGridView1.DataSource = dt;
            ucDataGridViewHelper2.dataGridView1.DataSource = dt;
            ucDataGridViewHelper3.dataGridView1.DataSource = dt;
        }

        public void RewardDetailsClick(object sender, EventArgs e)
        {
            if (RewardDetailClicked != null) RewardDetailClicked(sender, e);

        }
    }
}
