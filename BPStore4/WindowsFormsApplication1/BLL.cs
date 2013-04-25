using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BLL
    {
        public static DataTable GetCustomers()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            dt.Rows.Add(1, "Rodney");
            dt.Rows.Add(2, "Charity");
            return dt;
        }

        public static DataTable GetRewards()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RewardId", typeof(int));
            dt.Columns.Add("Campaign", typeof(string));
            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            dt.Rows.Add(4, "Campaign1");
            dt.Rows.Add(5, "Campaign2");
            dt.Rows.Add(6, "Campaign3");
            return dt;
        }


    }
}
