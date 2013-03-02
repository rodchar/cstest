using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPRewards2
{
    public partial class Form1
    {
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            int id = 1;
            if (tabPage1.Controls.Count == 0)
            {
                ucRewardDetails uc = new ucRewardDetails(id);
                tabPage1.Controls.Add(uc);
            }
        }
    }
}
