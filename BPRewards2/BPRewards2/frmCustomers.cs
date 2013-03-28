using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPRewards2
{
    public partial class Form1
    {
        ucListView _tp2Lv;
        ucDetailView _tp2Dv;

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            //Late option
            //tabPage2.Controls.Clear();

            if (_tp2Dv == null)
            {
                _tp2Lv = new ucListView();
                _tp2Lv.Size = new System.Drawing.Size(600, 400);

                _tp2Lv.DataGridViewHelperClicked += ListViewClicked_tp2Lv;
                tabPage2.Controls.Add(_tp2Lv);

                _tp2Lv.DataSource = DAL.GetData();
                _tp2Lv.DataBind();
            }
        }

        void ListViewClicked_tp2Lv(object sender, EventArgs e)
        {
            //This event means a row was selected by double-click
            if (e.GetType().Name == "DataGridViewCellEventArgs")
            {
                _tp2Lv.Visible = false;
                _tp2Dv = new ucDetailView();
                _tp2Dv.DetailClicked += DetailClicked_tp2Dv;
                _tp2Dv.Dock = System.Windows.Forms.DockStyle.Fill;

                //Comment out DynamicStuff method in user control
                //to see Main design view, if needed.

                //Todo: Wire actual id to detail view
                //Use _tp2Lv.DataRowViewSelected to get selected row info
                DataPayload d = new DataPayload();
                d = DAL.GetRecord("Customers", "CustomerID", "ALFKI");
                _tp2Dv.DataPayload = d;
                tabPage2.Controls.Add(_tp2Dv);

            }
        }

        void DetailClicked_tp2Dv(object sender, EventArgs e)
        {
            String btnId = (sender as Button).Name;

            if (btnId == "btnCancel")
            {
                _tp2Dv.Visible = false;
                _tp2Lv.Visible = true;
            }
        }
    }
}
