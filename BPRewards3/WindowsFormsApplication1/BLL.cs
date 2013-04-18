using System.Data;

namespace WindowsFormsApplication1
{
    public class BLL
    {
        public static DataTable GetData2()
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
