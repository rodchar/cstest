using System;

namespace BPRewards2
{
    public partial class Form1
    {
        ucRewardDetails _tp1RewardDetailsUc;
        ucListView _tp1Lv;
        int _id;

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (tabPage1.Controls.Count == 0)
            {
                _tp1Lv = new ucListView();
                _tp1Lv.UserControlClicked += tp1Lv_UserControlClicked;
                tabPage1.Controls.Add(_tp1Lv);
            }
        }

        void tp1Lv_UserControlClicked(object sender, EventArgs e)
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
