using System;

namespace BPRewards2
{
    public partial class Form1
    {
        ucRewardDetails _tp1RewardDetailsUc;
        ucDataGridViewHelper _tp1Lv;
        int _id;

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (tabPage1.Controls.Count == 0)
            {
                _tp1Lv = new ucDataGridViewHelper();
                _tp1Lv.Size = new System.Drawing.Size(600, 400);

                _tp1Lv.DataGridViewHelperClicked += DataGridViewHelperClicked_tp1Lv;

                _tp1Lv.DataSource = DAL.GetData2();
                _tp1Lv.DataBind();

                tabPage1.Controls.Add(_tp1Lv);
            }
        }

        void DataGridViewHelperClicked_tp1Lv(object sender, EventArgs e)
        {
            _tp1Lv.Visible = false;
            //Todo: remove this hard code
            _id = 1;

            _tp1RewardDetailsUc = new ucRewardDetails(_id);
            _tp1RewardDetailsUc.RewardDetailClicked += uc_RewardDetailsClicked;
            tabPage1.Controls.Add(_tp1RewardDetailsUc);
        }

        void uc_RewardDetailsClicked(object sender, EventArgs e)
        {
            _tp1RewardDetailsUc.Visible = false;
            _tp1Lv.Visible = true;
        }
    }
}
