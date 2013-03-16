using System;

namespace BPRewards2
{
    public partial class Form1
    {
        ucRewardDetails uc;
        ucListView tp1lv;
        int _id;
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (tabPage1.Controls.Count == 0)
            {
                tp1lv = AddNewListView(sender);
            }
        }

        void lv_UserControlClicked(object sender, EventArgs e)
        {
            tp1lv.Visible = false;
            //Todo: remove this hard code
            _id = 1;

            uc = new ucRewardDetails(_id);
            uc.UserControlClicked += uc_UserControlClicked;
            tabPage1.Controls.Add(uc);

        }

        void uc_UserControlClicked(object sender, EventArgs e)
        {
            uc.Visible = false;
            tp1lv.Visible = true;
            tp1lv.lblTester.Text = "From Rewards";
        }
    }
}
