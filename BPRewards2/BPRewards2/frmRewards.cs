using System;

namespace BPRewards2
{
    public partial class Form1
    {
        ucRewardDetails uc;
        int _id;
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AddNewListView(sender);
        }

        void lv_UserControlClicked(object sender, EventArgs e)
        {
            lv.Visible = false;
            //Todo: remove this hard code
            _id = 1;
            uc = new ucRewardDetails(_id);
            uc.UserControlClicked += uc_UserControlClicked;
            tabPage1.Controls.Add(uc);
        }

        void uc_UserControlClicked(object sender, EventArgs e)
        {
            uc.Visible = false;
            lv.Visible = true;
            lv.lblTester.Text = "From Rewards";
        }
    }
}
