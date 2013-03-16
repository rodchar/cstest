using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPRewards2
{
    public partial class Form1
    {
        ucListView tp2lv;

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            tp2lv = AddNewListView(sender);

            tp2lv.dataGridView1.DataSource = DAL.GetData().Tables[0];


        }
    }
}
