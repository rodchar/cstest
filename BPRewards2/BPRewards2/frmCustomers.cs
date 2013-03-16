using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPRewards2
{
    public partial class Form1
    {
        ucListView _tp2Lv;

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            _tp2Lv = new ucListView();
            _tp2Lv.UserControlClicked += tp2Lv_UserControlClicked;
            tabPage2.Controls.Add(_tp2Lv);

            _tp2Lv.dataGridView1.DataSource = DAL.GetData();
        }

        void tp2Lv_UserControlClicked(object sender, EventArgs e)
        {
            //This event means a row was selected by double-click
            if (e.GetType().Name == "DataGridViewCellEventArgs")
            {
                //Todo: Load detail user control here.
            }
        }
    }
}
